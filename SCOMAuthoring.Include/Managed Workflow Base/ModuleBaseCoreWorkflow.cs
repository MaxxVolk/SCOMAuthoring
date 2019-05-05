// .Net Framework
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;

// SCOM SDK
using Microsoft.EnterpriseManagement.HealthService;

namespace SCOMAuthoringBook.Library
{
  /// <summary>
  /// Adds core workflow and abstract initialization procedures. No data handling defined. 
  /// </summary>
  /// <typeparam name="TOutputDataType"></typeparam>
  public abstract class ModuleBaseCoreWorkflow<TOutputDataType> : ModuleBaseWithServiceFunctions<TOutputDataType> where TOutputDataType : DataItemBase
  {
    protected readonly object shutdownLock;
    protected bool shutdown;
    private bool? internal_IsStateless = null;

    public ModuleBaseCoreWorkflow(ModuleHost<TOutputDataType> moduleHost, XmlReader configuration, byte[] previousState)
      : base(moduleHost)
    {
      if (moduleHost == null)
        throw new ArgumentNullException("moduleHost");
      if (configuration == null)
        throw new ArgumentNullException("configuration");
      shutdownLock = new object();
      PreInitialize(moduleHost, configuration, previousState);
      LoadConfiguration(configuration);
      LoadPreviousState(previousState);
    }

    protected bool IsStateless
    {
      get
      {
        if (internal_IsStateless != null)
          return internal_IsStateless == true;
        StatelessModuleAttribute attribute = (StatelessModuleAttribute)Attribute.GetCustomAttribute(GetType(), typeof(StatelessModuleAttribute));
        if (attribute == null)
          internal_IsStateless = true; // module is stateless by default if no attribute is defined
        else
          internal_IsStateless = attribute.IsStateless; // else use attribute value
        return internal_IsStateless == true;
      }
    }

    protected object ModuleState { get; set; }

    protected virtual void LoadPreviousState(byte[] previousState)
    {
      if (previousState != null)
      {
        using (MemoryStream memoryStream = new MemoryStream(previousState))
        {
          BinaryFormatter binaryFormatter = new BinaryFormatter();
          try
          {
            ModuleState = binaryFormatter.Deserialize(memoryStream);
          }
          catch (Exception e)
          {
            Global.logWriteException(e, this);
            ModuleState = null;
          }
        }
      }
    }

    /// <summary>
    /// Tries to serialize the state object and save it using SCOM Agent API.
    /// </summary>
    /// <param name="state">Module state object to save.</param>
    /// <returns>Returns true if success, false otherwise.</returns>
    protected bool SavePreviousState()
    {
      if (ModuleState == null)
        return false;
      lock (shutdownLock)
      {
        using (MemoryStream memoryStream = new MemoryStream())
        {
          BinaryFormatter binaryFormatter = new BinaryFormatter();
          try
          {
            binaryFormatter.Serialize(memoryStream, ModuleState);
            ModuleHost.SaveState(memoryStream.GetBuffer(), (int)memoryStream.Length);
            return true;
          }
          catch (Exception e)
          {
            Global.logWriteException(e, this);
            return false;
          }
        }
      }
    }

    protected abstract void LoadConfiguration(XmlReader configuration);

    protected event EventHandler OnStart;

    protected event EventHandler OnShutdown;

    protected virtual void OnStartInvoke()
    {
      OnStart?.Invoke(this, null);
    }
    protected virtual void OnShutdownInvoke()
    {
      OnShutdown?.Invoke(this, null);
    }

    /// <summary>
    /// Inherited classes may override this method to make an earlier, before the most base constructor, initialization. 
    /// For example, to setup logging parameters.
    /// </summary>
    /// <param name="moduleHost"></param>
    /// <param name="configuration"></param>
    /// <param name="previousState"></param>
    protected virtual void PreInitialize(ModuleHost<TOutputDataType> moduleHost, XmlReader configuration, byte[] previousState)
    {
    }
  }
}
