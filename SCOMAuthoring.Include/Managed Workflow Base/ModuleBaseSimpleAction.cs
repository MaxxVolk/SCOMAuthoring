// .Net Framework
using System;
using System.Xml;

// SCOM SDK
using Microsoft.EnterpriseManagement.HealthService;

namespace SCOMAuthoringBook.Library
{
  /// <summary>
  /// Base class for any simple SCOM managed code workflow. Can implement ProbeAction and WriteAction. 
  /// Limited usage for ConditionDetection. Not to be used to implement DataSource.
  /// </summary>
  /// <typeparam name="TOutputDataType">Output data type for the an action. <typeparamref name="PropertyBagDataItem"/> is the most
  /// common output type for a monitoring probe action. Use <typeparamref name="DiscoveryDataItem"/> for a discovery
  /// probe action.</typeparam>
  public abstract class ModuleBaseSimpleAction<TOutputDataType> : ModuleBaseCoreWorkflow<TOutputDataType> where TOutputDataType : DataItemBase
  {
    public ModuleBaseSimpleAction(ModuleHost<TOutputDataType> moduleHost, XmlReader configuration, byte[] previousState) : base(moduleHost, configuration, previousState)
    {
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

    protected abstract TOutputDataType[] GetOutputData(DataItemBase[] inputDataItems);

    [InputStream(0)]
    public void OnNewDataItems(DataItemBase[] dataItems, bool logicallyGrouped,
      DataItemAcknowledgementCallback acknowledgeCallback, object acknowledgedState,
      DataItemProcessingCompleteCallback completionCallback, object completionState)
    {
      if ((acknowledgeCallback == null && completionCallback != null) ||
        (acknowledgeCallback != null && completionCallback == null))
        throw new ArgumentOutOfRangeException("acknowledgeCallback, completionCallback");
      bool NeedAcknowledge = (acknowledgeCallback != null);
      lock (shutdownLock)
      {
        if (shutdown)
          return;
        TOutputDataType[] ReturningResults;
        try
        {
          ReturningResults = GetOutputData(dataItems);
        }
        catch (Exception e)
        {
          if (NeedAcknowledge)
          {
            acknowledgeCallback(acknowledgedState);
            completionCallback(completionState);
          }
          ModuleHost.RequestNextDataItem();
          throw new ModuleException(e.Message, e);
        }
        if (ReturningResults == null || ReturningResults.Length == 0)
        {
          if (NeedAcknowledge)
          {
            acknowledgeCallback(acknowledgedState);
            completionCallback(completionState);
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
              acknowledgeCallback(acknowledgedState);
              completionCallback(completionState);
              ModuleHost.RequestNextDataItem();
            }
          }
          if (ReturningResults.Length == 1)
            ModuleHost.PostOutputDataItem(ReturningResults[0], AcknowledgeBypass, null);
          else
            ModuleHost.PostOutputDataItems(ReturningResults, logicallyGrouped, AcknowledgeBypass, null);
        }
        else
        {
          if (ReturningResults.Length == 1)
            ModuleHost.PostOutputDataItem(ReturningResults[0]);
          else
            ModuleHost.PostOutputDataItems(ReturningResults, logicallyGrouped);
          ModuleHost.RequestNextDataItem();
        }
      }
    }
  }
}
