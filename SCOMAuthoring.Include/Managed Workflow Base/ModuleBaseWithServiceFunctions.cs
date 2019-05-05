// .Net Framework
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;

// SCOM SDK
using Microsoft.EnterpriseManagement.HealthService;
using Microsoft.EnterpriseManagement.Modules.DataItems.Discovery;
using Microsoft.EnterpriseManagement.Mom.Modules.DataItems;

namespace SCOMAuthoringBook.Library
{
  /// <summary>
  /// Extend base SCOM managed module base class with static service functions.
  /// </summary>
  /// <typeparam name="TOutputDataType">Output data type for the an action. <typeparamref name="PropertyBagDataItem"/> is the most
  /// common output type for a monitoring probe action. Use <typeparamref name="DiscoveryDataItem"/> for a discovery
  /// probe action.</typeparam>
  public abstract class ModuleBaseWithServiceFunctions<TOutputDataType> : ModuleBase<TOutputDataType> where TOutputDataType : DataItemBase
  {
    // cached values
    private Version internal_ModuleVersion;
    private string internal_ModuleName;

    public ModuleBaseWithServiceFunctions(ModuleHost<TOutputDataType> moduleHost) : base(moduleHost)
    {
    }

    public static void LoadConfigurationElement(XmlDocument cfgDoc, string paramName, out Guid paramValue, string defaultValue = "{00000000-0000-0000-0000-000000000000}", bool Compulsory = true)
    {
      string varOut;
      LoadConfigurationElement(cfgDoc, paramName, out varOut, defaultValue, Compulsory);
      //if (string.IsNullOrWhiteSpace(varOut))
      //varOut = defaultValue;
      paramValue = new Guid(varOut);
    }

    public static void LoadConfigurationElement(XmlDocument cfgDoc, string paramName, out string paramValue, string defaultValue = "", bool Compulsory = true)
    {
      XmlNodeList nodes = null;
      nodes = cfgDoc.GetElementsByTagName(paramName);
      if (nodes != null)
      {
        if (nodes.Count == 1)
        {
          paramValue = nodes[0].InnerText;
          return;
        }
        if (nodes.Count >= 2)
          throw new InvalidOperationException("Ambiguous configuration element name: " + paramName + ". Number of elements: " + nodes.Count.ToString() + ".");
        if (nodes.Count == 0)
        {
          if (Compulsory)
            throw new Exception("Missing compulsory configuration element: " + paramName + ".");
          else
          {
            paramValue = defaultValue;
            return;
          }
        }
      }
      // we shall never get here, but to remove warning
      paramValue = defaultValue;
    }

    public static void LoadConfigurationElement(XmlDocument cfgDoc, string paramName, out bool paramValue, bool defaultValue = false, bool Compulsory = true)
    {
      XmlNodeList nodes = null;
      nodes = cfgDoc.GetElementsByTagName(paramName);
      if (nodes != null)
      {
        if (nodes.Count == 1)
        {
          if (!string.IsNullOrEmpty(nodes[0].InnerText))
            paramValue = ConvertSCOMBoolean(nodes[0].InnerText);
          else
            paramValue = defaultValue;
          return;
        }
        if (nodes.Count >= 2)
          throw new InvalidOperationException("Ambiguous configuration element name: " + paramName + ". Number of elements: " + nodes.Count.ToString() + ".");
        if (nodes.Count == 0)
        {
          if (Compulsory)
            throw new Exception("Missing compulsory configuration element: " + paramName + ".");
          else
          {
            paramValue = defaultValue;
            return;
          }
        }
      }
      // we shall never get here, but to remove warning
      paramValue = defaultValue;
    }

    public static void LoadConfigurationElement(XmlDocument cfgDoc, string paramName, out int paramValue, int defaultValue = 0, bool Compulsory = true)
    {
      XmlNodeList nodes = null;
      nodes = cfgDoc.GetElementsByTagName(paramName);
      if (nodes != null)
      {
        if (nodes.Count == 1)
        {
          if (!string.IsNullOrEmpty(nodes[0].InnerText))
            paramValue = Convert.ToInt32(nodes[0].InnerText);
          else
            paramValue = defaultValue;
          return;
        }
        if (nodes.Count >= 2)
          throw new InvalidOperationException("Ambiguous configuration element name: " + paramName + ". Number of elements: " + nodes.Count.ToString() + ".");
        if (nodes.Count == 0)
        {
          if (Compulsory)
            throw new Exception("Missing compulsory configuration element: " + paramName + ".");
          else
          {
            paramValue = defaultValue;
            return;
          }
        }
      }
      // we shall never get here, but to remove warning
      paramValue = defaultValue;
    }

    public static void LoadConfigurationElement(XmlDocument cfgDoc, string paramName, out double paramValue, double defaultValue = 0, bool Compulsory = true)
    {
      XmlNodeList nodes = null;
      nodes = cfgDoc.GetElementsByTagName(paramName);
      if (nodes != null)
      {
        if (nodes.Count == 1)
        {
          if (!string.IsNullOrEmpty(nodes[0].InnerText))
            paramValue = Convert.ToDouble(nodes[0].InnerText);
          else
            paramValue = defaultValue;
          return;
        }
        if (nodes.Count >= 2)
          throw new InvalidOperationException("Ambiguous configuration element name: " + paramName + ". Number of elements: " + nodes.Count.ToString() + ".");
        if (nodes.Count == 0)
        {
          if (Compulsory)
            throw new Exception("Missing compulsory configuration element: " + paramName + ".");
          else
          {
            paramValue = defaultValue;
            return;
          }
        }
      }
      // we shall never get here, but to remove warning
      paramValue = defaultValue;
    }

    public static bool ConvertSCOMBoolean(string BoolString)
    {
      bool _Result;
      _Result = false;
      if (!string.IsNullOrEmpty(BoolString))
      { _Result = string.Equals(BoolString, "true", StringComparison.OrdinalIgnoreCase) | string.Equals(BoolString, "1", StringComparison.OrdinalIgnoreCase); }
      return _Result;
    }

    public static string ConvertToSCOMBoolean(bool BoolInput)
    {
      return BoolInput.ToString().ToLowerInvariant();
    }

    public static Property NewProperty(string name, string value) => new Property(name, value);
    public static Property NewProperty(Guid id, string value) => new Property(id.ToString("B"), value);

    public static PropertyBagDataItem CreatePropertyBag(Dictionary<string, object> bagItem)
    {
      Dictionary<string, Dictionary<string, object>> dictionary = new Dictionary<string, Dictionary<string, object>>
      {
        { "", bagItem }
      };
      return new PropertyBagDataItem(null, dictionary);
    }

    public Version ModuleVersion
    {
      get
      {
        if (internal_ModuleVersion != null)
          return internal_ModuleVersion;
        try
        {
          internal_ModuleVersion = Assembly.GetAssembly(GetType()).GetName().Version;
          return internal_ModuleVersion;
        }
        catch
        {
          return new Version(0, 0, 0, 0);
        }
      }
    }

    public string ModuleName
    {
      get
      {
        if (!string.IsNullOrEmpty(internal_ModuleName))
          return internal_ModuleName;
        try
        {
          internal_ModuleName = GetType().FullName;
          return internal_ModuleName;
        }
        catch
        {
          return "ModuleBaseWithServiceFunctions";
        }
      }
    }
  }
}
