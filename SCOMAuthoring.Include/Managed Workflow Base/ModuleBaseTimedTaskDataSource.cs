// .Net Framework
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

// SCOM SDK
using Microsoft.EnterpriseManagement.HealthService;

namespace SCOMAuthoringBook.Library
{
  public abstract class ModuleBaseTimedTaskDataSource<TOutputDataType> : ModuleBaseDataSource<TOutputDataType> where TOutputDataType : DataItemBase
  {
    private Timer _timer = null;
    private bool callbackActive;

    protected Timer DSTimer { get { return _timer; } }
    protected abstract long IntervalSeconds { get; }


    public ModuleBaseTimedTaskDataSource(ModuleHost<TOutputDataType> moduleHost, XmlReader configuration, byte[] previousState) : base(moduleHost, configuration, previousState)
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
      if (callbackActive)
        return;
      Task.Run(async () =>
      {
        callbackActive = true;
        try
        {
          TOutputDataType[] result = await GetOutputDataAsync();
          if (result == null || shutdown)
            return;
          PostOutputData(result, null, false);
        }
        catch (Exception e)
        {
          Global.logWriteException(e, this);
        }
        finally
        {
          callbackActive = false;
        }
      }
      );
    }

    private Task<TOutputDataType[]> GetOutputDataAsync()
    {
      Global.logWriteInformation("ModuleBaseTimedAsyncDataSource starts new Task from thread #{0}.", this, Thread.CurrentThread.ManagedThreadId);
      return Task.Run(() => GetOutputData());
    }

    protected abstract TOutputDataType[] GetOutputData();
  }
}
