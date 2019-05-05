// .Net Framework
using System;
using System.Threading;
using System.Xml;

// SCOM SDK
using Microsoft.EnterpriseManagement.HealthService;

namespace SCOMAuthoringBook.Library
{
  /// <summary>
  /// Base Data Source class. Implements basic logic and methods to use in Data Source.
  /// </summary>
  /// <typeparam name="TOutputDataType"></typeparam>
  public abstract class ModuleBaseTimedDataSource<TOutputDataType> : ModuleBaseDataSource<TOutputDataType> where TOutputDataType : DataItemBase
  {
    private Timer _timer = null;
    private bool callbackActive = false;

    protected Timer DSTimer { get { return _timer; } }
    protected abstract long IntervalSeconds { get; }


    public ModuleBaseTimedDataSource(ModuleHost<TOutputDataType> moduleHost, XmlReader configuration, byte[] previousState) : base(moduleHost, configuration, previousState)
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
      if (shutdown)
        return;
      if (callbackActive)
      {
        Global.logWriteWarning("{0} cannot start GetOutputData callback, because the previous one is still running.", this, GetType().FullName);
        return;
      }
      callbackActive = true;
      try
      {
        TOutputDataType[] result = GetOutputData();
        if (result == null || shutdown)
          return;
        PostOutputData(result, null, false);
      }
      catch (Exception e)
      {
        Global.logWriteException("Exception in GetOutputData.", e, this, GetType().FullName);
      }
      finally
      {
        callbackActive = false;
      }
    }

    protected abstract TOutputDataType[] GetOutputData();
  }
}
