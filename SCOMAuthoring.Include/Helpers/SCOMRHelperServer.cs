using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EnterpriseManagement.Configuration;
using Microsoft.EnterpriseManagement.Monitoring;
using Microsoft.EnterpriseManagement;
using Microsoft.EnterpriseManagement.ConnectorFramework;
using Microsoft.EnterpriseManagement.Common;
using SCOMAuthoringBook.Library.IDs;

namespace SCOMAuthoringBook.Library.Helpers
{
  public static partial class SCOMRHelper
  {
    public static object GetSCOMClassInstancePropertyValue(MonitoringObject classInstance, string properyName)
    {
      var allClasses = classInstance.GetClasses();
      ManagementPackProperty myProperty = null;
      foreach (var objectClass in allClasses)
      {
        if (objectClass.TryGetProperty(properyName, out myProperty))
          break;
      }
      if (myProperty == null)
        throw new KeyNotFoundException("Cannot find class property.");
      return classInstance[myProperty].Value;
    }

    public static bool ClassExists(this IEntityTypeManagement entityTypes, string className)
    {
      IList<ManagementPackClass> classesCollection = entityTypes.GetClasses(new ManagementPackClassCriteria("Name='" + className + "'"));
      if (classesCollection.Count == 0)
        return false;
      else
        return true;
    }

    public static bool ClassExists(this IEntityTypeManagement entityTypes, Guid classId)
    {
      try
      {
        var classDefinition = entityTypes.GetClass(classId);
        if (classDefinition != null)
          return true;
        else
          return false;
      }
      catch (ObjectNotFoundException)
      {
        return false;
      }
    }

    public static bool MonitorExists(ManagementPack mp, string unitMonitorName)
    {
      try
      {
        var x = mp.GetMonitor(unitMonitorName);
        if (x == null)
          return false;
        return true;
      }
      catch (ObjectNotFoundException)
      {
        return false;
      }
    }

    public static MonitoringConnector GetSCOMAuthoringConnector(this IConnectorFrameworkManagement connectorFramework)
    {
      MonitoringConnector myConnnector;
      Guid connectorID = new Guid("C96B099A-1525-4F8B-88F8-0592F6F1E811");
      try
      {
        myConnnector = connectorFramework.GetConnector(connectorID);
        if (!myConnnector.Initialized)
          myConnnector.Initialize();
      }
      catch (ObjectNotFoundException)
      {
        myConnnector = connectorFramework.Setup(new ConnectorInfo()
        {
          Name = "SCOM Authoring Book Connector",
          DisplayName = "SCOM Authoring Book Generic Connector",
          Description = "Connector for SCOM Authoring Book Management Packs",
          DiscoveryDataIsManaged = true
        }, connectorID);
        if (!myConnnector.Initialized)
          myConnnector.Initialize();
      }
      return myConnnector;
    }

    public static ManagementPack GetManagementPack(this IManagementPackManagement mgmp, string name)
    {
      var MPList = mgmp.GetManagementPacks(new ManagementPackCriteria("Name='" + name + "'"));
      if (MPList.Count == 0)
        throw new ObjectNotFoundException("Cannot find any version of MP: " + name);
      return MPList.First();
    }

    public static MonitorOverrideProcessor PrepareOverrideProcessor(this ManagementPackUnitMonitor monitor)
    {
      return new MonitorOverrideProcessor(monitor);
    }

    public static string GetDataWarehouseConnectionString(this ManagementGroup mg, bool integratedSecurity = true, string extraOptions = null)
    {
      ManagementPackClass DWClass = mg.EntityTypes.GetClass(SystemCenterId.DataWarehouseClassId); // GetClass(mg, "Microsoft.SystemCenter.DataWarehouse");
      EnterpriseManagementObject DWInstance = mg.EntityObjects.GetObjectReader<EnterpriseManagementObject>(DWClass, ObjectQueryOptions.Default).FirstOrDefault();
      if (DWInstance != null)
      {
        string DWSQLServerName = DWInstance[SystemCenterId.DataWarehouseClassProperties.MainDatabaseServerNamePropertyId].Value.ToString();
        string DWDataBaseName = DWInstance[SystemCenterId.DataWarehouseClassProperties.MainDatabaseNamePropertyId].Value.ToString();
        string result = "Server=" + DWSQLServerName + ";Database=" + DWDataBaseName;
        if (integratedSecurity)
          result += ";Integrated Security=True";
        else
          result += ";Integrated Security=False";
        if (!string.IsNullOrEmpty(extraOptions))
        {
          if (extraOptions[0] != ';')
            extraOptions = ";" + extraOptions;
          result += extraOptions;
        }
        return result;
      }
      else
        throw new ObjectNotFoundException("Cannot find Data Warehouse instance. Entire SCOM must be broken.");
    }

    public static string GetDataWarehouseConnectionString(this ManagementGroup mg, string SQLUserName, string SQLPassword, string extraOptions = null)
    {
      return mg.GetDataWarehouseConnectionString(integratedSecurity: false, extraOptions: extraOptions) + 
        string.Format(";User Id={0};Password={1}", SQLUserName, SQLPassword);
    }
  }
}