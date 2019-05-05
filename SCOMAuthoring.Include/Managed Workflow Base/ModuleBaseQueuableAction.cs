// .Net Framework
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Xml;

// SCOM SDK
using Microsoft.EnterpriseManagement.HealthService;

namespace SCOMAuthoringBook.Library
{
  /// <summary>
  /// Base class for SCOM workflow accessing a shared resources. All requests are queued and executed sequentially.
  /// </summary>
  /// <typeparam name="TOutputDataType"></typeparam>
  internal abstract class ModuleBaseQueuableAction<TOutputDataType> : ModuleBaseCoreWorkflow<TOutputDataType> where TOutputDataType : DataItemBase
  {
    protected SemaphoreSlim enqueuedSemaphore;

    // save data between input and callback
    protected bool _logicallyGrouped;
    protected DataItemAcknowledgementCallback _acknowledgeCallback;
    protected object _acknowledgedState;
    protected DataItemProcessingCompleteCallback _completionCallback;
    protected object _completionState;

    public ModuleBaseQueuableAction(ModuleHost<TOutputDataType> moduleHost, XmlReader configuration, byte[] previousState) : base(moduleHost, configuration, previousState)
    {
      enqueuedSemaphore = new SemaphoreSlim(1, 1);
    }

    protected abstract TOutputDataType[] GetOutputData();

    [InputStream(0)]
    public void OnNewDataItems(DataItemBase[] dataItems, bool logicallyGrouped,
      DataItemAcknowledgementCallback acknowledgeCallback, object acknowledgedState,
      DataItemProcessingCompleteCallback completionCallback, object completionState)
    {
      if ((acknowledgeCallback == null && completionCallback != null) ||
        (acknowledgeCallback != null && completionCallback == null))
        throw new ArgumentOutOfRangeException("acknowledgeCallback, completionCallback");
      _acknowledgeCallback = acknowledgeCallback;
      _acknowledgedState = acknowledgedState;
      _completionCallback = completionCallback;
      _completionState = completionState;
      _logicallyGrouped = logicallyGrouped;
      lock (shutdownLock)
      {
        if (shutdown)
          return;
        if (enqueuedSemaphore.CurrentCount == 0)
        {
          Global.logWriteWarning("{0} data action is already queued or running. Current action request will be skipped.", this, GetType().FullName);
          return;
        }
        try
        {
          if (enqueuedSemaphore.Wait(60))
          {
            QueueManager.Enqueue(QueueCallback);
          }
          else
          {
            Global.logWriteWarning("Action has been already enqueued, skipping.", this);
          }
        }
        catch
        {
          Global.logWriteError("Cannot enqueue the current action, skipping.", this);
          if (enqueuedSemaphore.CurrentCount == 0)
            enqueuedSemaphore.Release();
        }
      }
    }

    public void QueueCallback()
    {
      // this method can access shared static resource, because QueueManager ensures, that other queued actions called sequentially.
      try
      {
        bool NeedAcknowledge = (_acknowledgeCallback != null);
        lock (shutdownLock)
        {
          if (shutdown)
            return;
          TOutputDataType[] ReturningResults;
          try
          {
            ReturningResults = GetOutputData();
          }
          catch (Exception e)
          {
            try
            {
              if (NeedAcknowledge)
              {
                _acknowledgeCallback(_acknowledgedState);
                _completionCallback(_completionState);
              }
            }
            catch (Exception ae)
            {
              Global.logWriteException("Failed to acknowledge action completion.", ae, this);
            }
            ModuleHost.RequestNextDataItem();
            throw new ModuleException(e.Message, e);
          }
          if (ReturningResults == null || ReturningResults.Length == 0)
          {
            if (NeedAcknowledge)
            {
              _acknowledgeCallback(_acknowledgedState);
              _completionCallback(_completionState);
            }
            ModuleHost.RequestNextDataItem();
          }
          else if (NeedAcknowledge)
          {
            void AcknowledgeBypass(object ackState)
            {
              lock (shutdownLock)
              {
                if (shutdown)
                  return;
                _acknowledgeCallback(_acknowledgedState);
                _completionCallback(_completionState);
                ModuleHost.RequestNextDataItem();
              }
            }
            if (ReturningResults.Length == 1)
              ModuleHost.PostOutputDataItem(ReturningResults[0], AcknowledgeBypass, null);
            else
              ModuleHost.PostOutputDataItems(ReturningResults, _logicallyGrouped, AcknowledgeBypass, null);
          }
          else
          {
            if (ReturningResults.Length == 1)
              ModuleHost.PostOutputDataItem(ReturningResults[0]);
            else
              ModuleHost.PostOutputDataItems(ReturningResults, _logicallyGrouped);
            ModuleHost.RequestNextDataItem();
          }
        }
      }
      finally
      {
        enqueuedSemaphore.Release();
      }
    }

    public override void Shutdown()
    {
      lock (shutdownLock)
      {
        shutdown = true;
        OnShutdownInvoke();
      }
    }

    public override void Start()
    {
      lock (shutdownLock)
      {
        if (shutdown)
          return;
        ModuleHost.RequestNextDataItem();
        OnStartInvoke();
      }
    }
  }

  public delegate void QueueItemCallback();

  public static class QueueManager
  {
    private static ConcurrentQueue<QueueItemCallback> concurrentQueue = new ConcurrentQueue<QueueItemCallback>();
    private static SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);

    public static void Enqueue(QueueItemCallback item)
    {
      concurrentQueue.Enqueue(item);
      if (semaphore.CurrentCount > 0)
      {
        if (semaphore.Wait(60))
        {
          Global.logWriteVerbose("Starting offload thread.", "QueueManager", "Enqueue", 0);
          Thread thread = new Thread(QueueOffloadTask);
          thread.Start();
        }
        else
        {
          Global.logWriteVerbose("Another instance of offloading thread is already running.", "QueueManager", "Enqueue", 0);
        }
      }
    }

    private static void QueueOffloadTask()
    {
      try
      {
        QueueItemCallback currentItem = null;
        int queueItemsCount = 0;
        while (concurrentQueue.TryDequeue(out currentItem))
          try
          {
            currentItem?.Invoke();
            queueItemsCount++;
          }
          catch (Exception e)
          {
            if (currentItem != null)
              Global.logWriteException("Failed to invoke queued callback for {0}, skipping.", e, null, currentItem.Target.GetType().FullName);
            else
              Global.logWriteException("Failed to invoke queued callback for NULL, skipping.", e, null);
          }
        // Global.logWriteInformation("Finishing offload thread. Total {0} invocation made.", null, queueItemsCount);
      }
      finally
      {
        semaphore.Release();
      }
    }
  }
}