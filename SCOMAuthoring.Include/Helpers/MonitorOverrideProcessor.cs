using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EnterpriseManagement.Configuration;
using Microsoft.EnterpriseManagement.Common;
using System.Xml;
using System.Xml.XPath;

namespace SCOMAuthoringBook.Library.Helpers
{
  public class MonitorOverrideProcessor
  {
    private Dictionary<ManagementPackOverrideableParameter, string> defaultValues;
    private ManagementPackMonitorResultantOverrideSet _results = null;

    internal MonitorOverrideProcessor(ManagementPackUnitMonitor monitor, bool watchMPImport = false)
    {
      Monitor = monitor;
      IList<ManagementPackOverrideableParameter> allParams = Monitor.GetOverrideableParameters();
      defaultValues = new Dictionary<ManagementPackOverrideableParameter, string>(allParams.Count);
      XmlDocument monitorConfiguration = new XmlDocument();
      monitorConfiguration.LoadXml("<Config>" + Monitor.Configuration + "</Config>");
      XPathNavigator xpathNavigator = monitorConfiguration.CreateNavigator();
      // Create a dictionary of parameters and their default values
      foreach (ManagementPackOverrideableParameter param in allParams)
      {
        foreach (XPathNavigator selectors in xpathNavigator.Select(param.Selector.Trim(new char[] { '$' })))
        {
          defaultValues.Add(param, selectors.IsEmptyElement ? null : selectors.Value);
          break; // virtual .First()
        }
      }
      if (watchMPImport)
      {
        Monitor.ManagementGroup.ManagementPacks.OnManagementPackCacheRefresh += ManagementPacks_OnManagementPackCacheRefresh;
      }
    }

    ~MonitorOverrideProcessor()
    {
      Monitor.ManagementGroup.ManagementPacks.OnManagementPackCacheRefresh -= ManagementPacks_OnManagementPackCacheRefresh;
    }

    private void ManagementPacks_OnManagementPackCacheRefresh(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    public ManagementPackUnitMonitor Monitor { get; private set; } = null;

    public Dictionary<ManagementPackOverrideableParameter, string>.KeyCollection OverrideableParameters { get { return defaultValues.Keys; } }

    public ManagementPackOverrideableParameter GetOverrideableParameter(string parameterName)
    {
      return defaultValues.Keys.Where(x => x.Name == parameterName).FirstOrDefault();
    }

    public void Apply(EnterpriseManagementObject monitoringInstance)
    {
      _results = monitoringInstance.ManagementGroup.Overrides.GetResultantOverrides(monitoringInstance, Monitor);
    }

    public string this[ManagementPackOverrideableParameter parameter]
    {
      get
      {
        if (_results == null)
          throw new InvalidOperationException("Call Apply method first.");
        return _results.ResultantConfigurationOverrides.ContainsKey(parameter) ? _results.ResultantConfigurationOverrides[parameter].EffectiveValue : defaultValues[parameter];
      }
    }
  }
}
