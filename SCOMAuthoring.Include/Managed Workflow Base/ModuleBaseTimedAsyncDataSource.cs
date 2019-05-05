// .Net Framework
using System;
using System.Threading;
using System.Xml;

// SCOM SDK
using Microsoft.EnterpriseManagement.HealthService;

namespace SCOMAuthoringBook.Library
{
  public abstract class ModuleBaseTimedAsyncDataSource<TOutputDataType> : ModuleBaseDataSource<TOutputDataType> where TOutputDataType : DataItemBase
  {
    private Timer _timer = null;
    private object callbackActive = new object();
    protected Thread managedThread;

    protected Timer DSTimer { get { return _timer; } }
    protected abstract long IntervalSeconds { get; }


    public ModuleBaseTimedAsyncDataSource(ModuleHost<TOutputDataType> moduleHost, XmlReader configuration, byte[] previousState) : base(moduleHost, configuration, previousState)
    {

      OnStart += ModuleBaseTimedDataSource_OnStart;
      OnShutdown += ModuleBaseTimedDataSource_OnShutdown;
    }

    private void ModuleBaseTimedDataSource_OnShutdown(object sender, EventArgs e)
    {
      if (_timer != null)
        _timer.Dispose();
      _timer = null;
    }

    private void ModuleBaseTimedDataSource_OnStart(object sender, EventArgs e)
    {
      _timer = new Timer(TimerCallback, this, 0, IntervalSeconds * 1000);
    }

    private void TimerCallback(object state)
    {
      if (Monitor.IsEntered(callbackActive))
      {
        Global.logWriteWarning("{0} cannot start GetOutputData thread instance, because the previous instance is still running.", this, GetType().FullName);
        return;
      }
      managedThread = new Thread(GetOutputDataAsync);
      managedThread.Start();
    }

    private void GetOutputDataAsync()
    {
      Monitor.Enter(callbackActive);
      try
      {
        TOutputDataType[] result = GetOutputData();
        if (result == null || shutdown)
          return;
        PostOutputData(result, null, false);
      }
      catch (ThreadAbortException)
      {
        // ????
        throw;
      }
      finally
      {
        if (Monitor.IsEntered(callbackActive))
          Monitor.Exit(callbackActive);
      }
    }

    protected abstract TOutputDataType[] GetOutputData();
  }
}
