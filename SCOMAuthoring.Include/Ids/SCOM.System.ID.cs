using System;

namespace SCOMAuthoringBook.Library.IDs
{
  public class SystemId
  {
    // === Classes ===

    #region System.Entity
    private static Guid _55270a70ac47c853c617236b0cff9b4c = new Guid("55270a70-ac47-c853-c617-236b0cff9b4c");
    /// <summary>
    /// Object (System.Entity)
    /// </summary>
    public static Guid EntityClassId { get { return _55270a70ac47c853c617236b0cff9b4c; } }
    public static class EntityClassProperties
    {
      private static Guid _afb4f9e6bf48173776adc9b3ec325b97 = new Guid("afb4f9e6-bf48-1737-76ad-c9b3ec325b97");
      /// <summary>
      /// System.Entity/DisplayName
      /// </summary>
      public static Guid DisplayNamePropertyId { get { return _afb4f9e6bf48173776adc9b3ec325b97; } }
    }
    #endregion

    #region System.ConfigItem
    private static Guid _62f0be9feceae73cf00d3dd78a7422fc = new Guid("62f0be9f-ecea-e73c-f00d-3dd78a7422fc");
    /// <summary>
    /// Configuration Item (System.ConfigItem)
    /// </summary>
    public static Guid ConfigItemClassId { get { return _62f0be9feceae73cf00d3dd78a7422fc; } }
    public static class ConfigItemClassProperties
    {
      private static Guid _119270696957dfcfa27708a784221325 = new Guid("11927069-6957-dfcf-a277-08a784221325");
      /// <summary>
      /// System.ConfigItem/ObjectStatus
      /// </summary>
      public static Guid ObjectStatusPropertyId { get { return _119270696957dfcfa27708a784221325; } }
      private static Guid _a6b7ea8d94238529cb2187ac1a21fdcb = new Guid("a6b7ea8d-9423-8529-cb21-87ac1a21fdcb");
      /// <summary>
      /// System.ConfigItem/AssetStatus
      /// </summary>
      public static Guid AssetStatusPropertyId { get { return _a6b7ea8d94238529cb2187ac1a21fdcb; } }
      private static Guid _55124dce750dbd544b92d1fddf99adec = new Guid("55124dce-750d-bd54-4b92-d1fddf99adec");
      /// <summary>
      /// System.ConfigItem/Notes
      /// </summary>
      public static Guid NotesPropertyId { get { return _55124dce750dbd544b92d1fddf99adec; } }
    }
    #endregion

    #region System.Collections
    private static Guid _6833e0ae75b00e28746698cefe548585 = new Guid("6833e0ae-75b0-0e28-7466-98cefe548585");
    /// <summary>
    /// Collection (System.Collections)
    /// </summary>
    public static Guid CollectionsClassId { get { return _6833e0ae75b00e28746698cefe548585; } }
    #endregion

    #region System.LogicalEntity
    private static Guid _885bc562ed36c548b93844ce5ba7ba2b = new Guid("885bc562-ed36-c548-b938-44ce5ba7ba2b");
    /// <summary>
    /// Logical Entity (System.LogicalEntity)
    /// </summary>
    public static Guid LogicalEntityClassId { get { return _885bc562ed36c548b93844ce5ba7ba2b; } }
    #endregion

    #region System.Database
    private static Guid _36866ed84de132b83f01030fd6005839 = new Guid("36866ed8-4de1-32b8-3f01-030fd6005839");
    /// <summary>
    /// Database (System.Database)
    /// </summary>
    public static Guid DatabaseClassId { get { return _36866ed84de132b83f01030fd6005839; } }
    #endregion

    #region System.PhysicalEntity
    private static Guid _4f931f46b47afd34cdd68aa9dbd819b4 = new Guid("4f931f46-b47a-fd34-cdd6-8aa9dbd819b4");
    /// <summary>
    /// Physical Entity (System.PhysicalEntity)
    /// </summary>
    public static Guid PhysicalEntityClassId { get { return _4f931f46b47afd34cdd68aa9dbd819b4; } }
    #endregion

    #region System.LogicalHardware
    private static Guid _d7c7821848b61ed9c7d2b6b832ef1652 = new Guid("d7c78218-48b6-1ed9-c7d2-b6b832ef1652");
    /// <summary>
    /// Logical Hardware Component (System.LogicalHardware)
    /// </summary>
    public static Guid LogicalHardwareClassId { get { return _d7c7821848b61ed9c7d2b6b832ef1652; } }
    #endregion

    #region System.Device
    private static Guid _7ad221e0e4bb39a8651433b60bba46f5 = new Guid("7ad221e0-e4bb-39a8-6514-33b60bba46f5");
    /// <summary>
    /// Device (System.Device)
    /// </summary>
    public static Guid DeviceClassId { get { return _7ad221e0e4bb39a8651433b60bba46f5; } }
    #endregion

    #region System.Computer
    private static Guid _b4a14ffd52c8064fc93667616c245b35 = new Guid("b4a14ffd-52c8-064f-c936-67616c245b35");
    /// <summary>
    /// Computer (System.Computer)
    /// </summary>
    public static Guid ComputerClassId { get { return _b4a14ffd52c8064fc93667616c245b35; } }
    #endregion

    #region System.MobileDevice
    private static Guid _149aef0fc094c06a38246e0732c7a04a = new Guid("149aef0f-c094-c06a-3824-6e0732c7a04a");
    /// <summary>
    /// Mobile device (System.MobileDevice)
    /// </summary>
    public static Guid MobileDeviceClassId { get { return _149aef0fc094c06a38246e0732c7a04a; } }
    public static class MobileDeviceClassProperties
    {
      private static Guid _8e22d1b5f99fe3d1d332a0c220346302 = new Guid("8e22d1b5-f99f-e3d1-d332-a0c220346302");
      /// <summary>
      /// System.MobileDevice/Id
      /// </summary>
      public static Guid IdPropertyId { get { return _8e22d1b5f99fe3d1d332a0c220346302; } }
      private static Guid _ffe59943d4f2d2450b66d7ba22a71593 = new Guid("ffe59943-d4f2-d245-0b66-d7ba22a71593");
      /// <summary>
      /// System.MobileDevice/DeviceImei
      /// </summary>
      public static Guid DeviceImeiPropertyId { get { return _ffe59943d4f2d2450b66d7ba22a71593; } }
      private static Guid _b2e701f03939202fcaccea5502c47a7d = new Guid("b2e701f0-3939-202f-cacc-ea5502c47a7d");
      /// <summary>
      /// System.MobileDevice/DeviceOS
      /// </summary>
      public static Guid DeviceOSPropertyId { get { return _b2e701f03939202fcaccea5502c47a7d; } }
      private static Guid _79956129c115e4dde056ffc0084d248c = new Guid("79956129-c115-e4dd-e056-ffc0084d248c");
      /// <summary>
      /// System.MobileDevice/DevicePhoneNumber
      /// </summary>
      public static Guid DevicePhoneNumberPropertyId { get { return _79956129c115e4dde056ffc0084d248c; } }
      private static Guid _29e02638ab607920aac5677e3b434169 = new Guid("29e02638-ab60-7920-aac5-677e3b434169");
      /// <summary>
      /// System.MobileDevice/DeviceMobileOperator
      /// </summary>
      public static Guid DeviceMobileOperatorPropertyId { get { return _29e02638ab607920aac5677e3b434169; } }
      private static Guid _1559c5cc04dfdcdf9b070a2112673c2c = new Guid("1559c5cc-04df-dcdf-9b07-0a2112673c2c");
      /// <summary>
      /// System.MobileDevice/DeviceModel
      /// </summary>
      public static Guid DeviceModelPropertyId { get { return _1559c5cc04dfdcdf9b070a2112673c2c; } }
      private static Guid _56c62eca54fbcc8789adb256941e6b29 = new Guid("56c62eca-54fb-cc87-89ad-b256941e6b29");
      /// <summary>
      /// System.MobileDevice/ExchangeServer
      /// </summary>
      public static Guid ExchangeServerPropertyId { get { return _56c62eca54fbcc8789adb256941e6b29; } }
      private static Guid _08fe3348c7db478d6bcc6a9842fae742 = new Guid("08fe3348-c7db-478d-6bcc-6a9842fae742");
      /// <summary>
      /// System.MobileDevice/DeviceManufacturer
      /// </summary>
      public static Guid DeviceManufacturerPropertyId { get { return _08fe3348c7db478d6bcc6a9842fae742; } }
      private static Guid _079e6f7593e34f25ca394df46c1fc8fe = new Guid("079e6f75-93e3-4f25-ca39-4df46c1fc8fe");
      /// <summary>
      /// System.MobileDevice/FirmwareVersion
      /// </summary>
      public static Guid FirmwareVersionPropertyId { get { return _079e6f7593e34f25ca394df46c1fc8fe; } }
      private static Guid _193a08aa854f0c6d4c747ebfd6e5fb88 = new Guid("193a08aa-854f-0c6d-4c74-7ebfd6e5fb88");
      /// <summary>
      /// System.MobileDevice/HardwareVersion
      /// </summary>
      public static Guid HardwareVersionPropertyId { get { return _193a08aa854f0c6d4c747ebfd6e5fb88; } }
      private static Guid _35c574c32a04f99c4d7d7daf82665f4d = new Guid("35c574c3-2a04-f99c-4d7d-7daf82665f4d");
      /// <summary>
      /// System.MobileDevice/OEM
      /// </summary>
      public static Guid OEMPropertyId { get { return _35c574c32a04f99c4d7d7daf82665f4d; } }
      private static Guid _e6472620ee26b980bedd8ed709e56b3a = new Guid("e6472620-ee26-b980-bedd-8ed709e56b3a");
      /// <summary>
      /// System.MobileDevice/ProcessorType
      /// </summary>
      public static Guid ProcessorTypePropertyId { get { return _e6472620ee26b980bedd8ed709e56b3a; } }
      private static Guid _56d78143d770ea42a24e94943c528fa7 = new Guid("56d78143-d770-ea42-a24e-94943c528fa7");
      /// <summary>
      /// System.MobileDevice/HorizontalResolution
      /// </summary>
      public static Guid HorizontalResolutionPropertyId { get { return _56d78143d770ea42a24e94943c528fa7; } }
      private static Guid _a6522909981e81549e8c70cd992262a4 = new Guid("a6522909-981e-8154-9e8c-70cd992262a4");
      /// <summary>
      /// System.MobileDevice/VerticalResolution
      /// </summary>
      public static Guid VerticalResolutionPropertyId { get { return _a6522909981e81549e8c70cd992262a4; } }
    }
    #endregion

    #region System.NetworkDevice
    private static Guid _4fbfee21293bd82f8af1da003bebabfc = new Guid("4fbfee21-293b-d82f-8af1-da003bebabfc");
    /// <summary>
    /// Network Device (System.NetworkDevice)
    /// </summary>
    public static Guid NetworkDeviceClassId { get { return _4fbfee21293bd82f8af1da003bebabfc; } }
    #endregion

    #region System.Group
    private static Guid _d0b3273653442fcc74b3f72dc64ef572 = new Guid("d0b32736-5344-2fcc-74b3-f72dc64ef572");
    /// <summary>
    /// Group (System.Group)
    /// </summary>
    public static Guid GroupClassId { get { return _d0b3273653442fcc74b3f72dc64ef572; } }
    #endregion

    #region System.User
    private static Guid _943d298fd79a7a29a3358833e582d252 = new Guid("943d298f-d79a-7a29-a335-8833e582d252");
    /// <summary>
    /// User (System.User)
    /// </summary>
    public static Guid UserClassId { get { return _943d298fd79a7a29a3358833e582d252; } }
    public static class UserClassProperties
    {
      private static Guid _a1dd0787f6b951313f43f356ca2bb163 = new Guid("a1dd0787-f6b9-5131-3f43-f356ca2bb163");
      /// <summary>
      /// System.User/FirstName
      /// </summary>
      public static Guid FirstNamePropertyId { get { return _a1dd0787f6b951313f43f356ca2bb163; } }
      private static Guid _7b32dd73f649f288f8a113b16481eca6 = new Guid("7b32dd73-f649-f288-f8a1-13b16481eca6");
      /// <summary>
      /// System.User/Initials
      /// </summary>
      public static Guid InitialsPropertyId { get { return _7b32dd73f649f288f8a113b16481eca6; } }
      private static Guid _2cde06de0ad2ea7a50b0627d0a2337df = new Guid("2cde06de-0ad2-ea7a-50b0-627d0a2337df");
      /// <summary>
      /// System.User/LastName
      /// </summary>
      public static Guid LastNamePropertyId { get { return _2cde06de0ad2ea7a50b0627d0a2337df; } }
      private static Guid _7b3a602cc9e3766e840da2099f5a51ad = new Guid("7b3a602c-c9e3-766e-840d-a2099f5a51ad");
      /// <summary>
      /// System.User/Company
      /// </summary>
      public static Guid CompanyPropertyId { get { return _7b3a602cc9e3766e840da2099f5a51ad; } }
      private static Guid _224058122d6de429110c2d2d8f9518df = new Guid("22405812-2d6d-e429-110c-2d2d8f9518df");
      /// <summary>
      /// System.User/Department
      /// </summary>
      public static Guid DepartmentPropertyId { get { return _224058122d6de429110c2d2d8f9518df; } }
      private static Guid _6021c77723ddc73a3465b97e00d7a1ba = new Guid("6021c777-23dd-c73a-3465-b97e00d7a1ba");
      /// <summary>
      /// System.User/Office
      /// </summary>
      public static Guid OfficePropertyId { get { return _6021c77723ddc73a3465b97e00d7a1ba; } }
      private static Guid _9010dfd38bceeac96657d19130e07bfa = new Guid("9010dfd3-8bce-eac9-6657-d19130e07bfa");
      /// <summary>
      /// System.User/Title
      /// </summary>
      public static Guid TitlePropertyId { get { return _9010dfd38bceeac96657d19130e07bfa; } }
      private static Guid _d56f368d2e48e4bef4ebf82744879663 = new Guid("d56f368d-2e48-e4be-f4eb-f82744879663");
      /// <summary>
      /// System.User/EmployeeId
      /// </summary>
      public static Guid EmployeeIdPropertyId { get { return _d56f368d2e48e4bef4ebf82744879663; } }
      private static Guid _3c923ab81f93bd5207a9df59fd78bd1f = new Guid("3c923ab8-1f93-bd52-07a9-df59fd78bd1f");
      /// <summary>
      /// System.User/StreetAddress
      /// </summary>
      public static Guid StreetAddressPropertyId { get { return _3c923ab81f93bd5207a9df59fd78bd1f; } }
      private static Guid _42b2a2147cccb734f5a7ee7b0bb8b371 = new Guid("42b2a214-7ccc-b734-f5a7-ee7b0bb8b371");
      /// <summary>
      /// System.User/City
      /// </summary>
      public static Guid CityPropertyId { get { return _42b2a2147cccb734f5a7ee7b0bb8b371; } }
      private static Guid _ed79d5a619ff6c7272041b7b26677f17 = new Guid("ed79d5a6-19ff-6c72-7204-1b7b26677f17");
      /// <summary>
      /// System.User/State
      /// </summary>
      public static Guid StatePropertyId { get { return _ed79d5a619ff6c7272041b7b26677f17; } }
      private static Guid _584266bfa344f323a15b4a761aecd867 = new Guid("584266bf-a344-f323-a15b-4a761aecd867");
      /// <summary>
      /// System.User/Zip
      /// </summary>
      public static Guid ZipPropertyId { get { return _584266bfa344f323a15b4a761aecd867; } }
      private static Guid _9c5cfe858752d66ec08b419776f9c0f0 = new Guid("9c5cfe85-8752-d66e-c08b-419776f9c0f0");
      /// <summary>
      /// System.User/Country
      /// </summary>
      public static Guid CountryPropertyId { get { return _9c5cfe858752d66ec08b419776f9c0f0; } }
      private static Guid _d1aded933cd935e2d4f48b4d0d37409c = new Guid("d1aded93-3cd9-35e2-d4f4-8b4d0d37409c");
      /// <summary>
      /// System.User/BusinessPhone
      /// </summary>
      public static Guid BusinessPhonePropertyId { get { return _d1aded933cd935e2d4f48b4d0d37409c; } }
      private static Guid _51d9d5601c1a058e43074e5302132612 = new Guid("51d9d560-1c1a-058e-4307-4e5302132612");
      /// <summary>
      /// System.User/BusinessPhone2
      /// </summary>
      public static Guid BusinessPhone2PropertyId { get { return _51d9d5601c1a058e43074e5302132612; } }
      private static Guid _b22c0740cdcc4e9d9ad2d97b096f8330 = new Guid("b22c0740-cdcc-4e9d-9ad2-d97b096f8330");
      /// <summary>
      /// System.User/HomePhone
      /// </summary>
      public static Guid HomePhonePropertyId { get { return _b22c0740cdcc4e9d9ad2d97b096f8330; } }
      private static Guid _1e319ed084e598d1b4cbe62b524d81b1 = new Guid("1e319ed0-84e5-98d1-b4cb-e62b524d81b1");
      /// <summary>
      /// System.User/HomePhone2
      /// </summary>
      public static Guid HomePhone2PropertyId { get { return _1e319ed084e598d1b4cbe62b524d81b1; } }
      private static Guid _d962f04f1429a910fa7bac8444645aee = new Guid("d962f04f-1429-a910-fa7b-ac8444645aee");
      /// <summary>
      /// System.User/Fax
      /// </summary>
      public static Guid FaxPropertyId { get { return _d962f04f1429a910fa7bac8444645aee; } }
      private static Guid _79a97a95f92deb97e9e9d4b9c51e0ab5 = new Guid("79a97a95-f92d-eb97-e9e9-d4b9c51e0ab5");
      /// <summary>
      /// System.User/Mobile
      /// </summary>
      public static Guid MobilePropertyId { get { return _79a97a95f92deb97e9e9d4b9c51e0ab5; } }
      private static Guid _d72232bd85e43e3d1f336bebf3b7606a = new Guid("d72232bd-85e4-3e3d-1f33-6bebf3b7606a");
      /// <summary>
      /// System.User/Pager
      /// </summary>
      public static Guid PagerPropertyId { get { return _d72232bd85e43e3d1f336bebf3b7606a; } }
    }
    #endregion

    #region System.Printer
    private static Guid _319e665c8db5c06bfd4b93991942e429 = new Guid("319e665c-8db5-c06b-fd4b-93991942e429");
    /// <summary>
    /// Printer (System.Printer)
    /// </summary>
    public static Guid PrinterClassId { get { return _319e665c8db5c06bfd4b93991942e429; } }
    #endregion

    #region System.Perspective
    private static Guid _176ced557556a619717cb59ae14e756f = new Guid("176ced55-7556-a619-717c-b59ae14e756f");
    /// <summary>
    /// Perspective (System.Perspective)
    /// </summary>
    public static Guid PerspectiveClassId { get { return _176ced557556a619717cb59ae14e756f; } }
    #endregion

    #region System.OperatingSystem
    private static Guid _a82191f5fe0dcf40846439e75f95db57 = new Guid("a82191f5-fe0d-cf40-8464-39e75f95db57");
    /// <summary>
    /// Operating System (System.OperatingSystem)
    /// </summary>
    public static Guid OperatingSystemClassId { get { return _a82191f5fe0dcf40846439e75f95db57; } }
    #endregion

    #region System.ComputerRole
    private static Guid _fb979319fa0cea0e3ac5d514c7bdd043 = new Guid("fb979319-fa0c-ea0e-3ac5-d514c7bdd043");
    /// <summary>
    /// Computer Role (System.ComputerRole)
    /// </summary>
    public static Guid ComputerRoleClassId { get { return _fb979319fa0cea0e3ac5d514c7bdd043; } }
    #endregion

    #region System.LocalApplication
    private static Guid _1f06bba958a9fd0bd98008d5af2e67d3 = new Guid("1f06bba9-58a9-fd0b-d980-08d5af2e67d3");
    /// <summary>
    /// Local Application (System.LocalApplication)
    /// </summary>
    public static Guid LocalApplicationClassId { get { return _1f06bba958a9fd0bd98008d5af2e67d3; } }
    #endregion

    #region System.Service
    private static Guid _1d870aa6edb47d133950d3c73755d6bf = new Guid("1d870aa6-edb4-7d13-3950-d3c73755d6bf");
    /// <summary>
    /// Service (System.Service)
    /// </summary>
    public static Guid ServiceClassId { get { return _1d870aa6edb47d133950d3c73755d6bf; } }
    public static class ServiceClassProperties
    {
      private static Guid _f75caf82ba43cad3c16588f709fc3fbe = new Guid("f75caf82-ba43-cad3-c165-88f709fc3fbe");
      /// <summary>
      /// System.Service/ServiceDescription
      /// </summary>
      public static Guid ServiceDescriptionPropertyId { get { return _f75caf82ba43cad3c16588f709fc3fbe; } }
      private static Guid _0269f25a1f9f04234d7ab286220d05d0 = new Guid("0269f25a-1f9f-0423-4d7a-b286220d05d0");
      /// <summary>
      /// System.Service/BusinessDetailedDescription
      /// </summary>
      public static Guid BusinessDetailedDescriptionPropertyId { get { return _0269f25a1f9f04234d7ab286220d05d0; } }
      private static Guid _7879f2b132387221e42777785556d78a = new Guid("7879f2b1-3238-7221-e427-77785556d78a");
      /// <summary>
      /// System.Service/IsBusinessService
      /// </summary>
      public static Guid IsBusinessServicePropertyId { get { return _7879f2b132387221e42777785556d78a; } }
      private static Guid _112beb7ca1c594b99954a4d8cd0e0363 = new Guid("112beb7c-a1c5-94b9-9954-a4d8cd0e0363");
      /// <summary>
      /// System.Service/OwnedByOrganization
      /// </summary>
      public static Guid OwnedByOrganizationPropertyId { get { return _112beb7ca1c594b99954a4d8cd0e0363; } }
      private static Guid _a4b16882470946e697e75cf34b69ad28 = new Guid("a4b16882-4709-46e6-97e7-5cf34b69ad28");
      /// <summary>
      /// System.Service/Priority
      /// </summary>
      public static Guid PriorityPropertyId { get { return _a4b16882470946e697e75cf34b69ad28; } }
      private static Guid _9d19da0ee22b98351ba7fddb36832789 = new Guid("9d19da0e-e22b-9835-1ba7-fddb36832789");
      /// <summary>
      /// System.Service/Status
      /// </summary>
      public static Guid StatusPropertyId { get { return _9d19da0ee22b98351ba7fddb36832789; } }
      private static Guid _330dcee38fa0875bc8f0fe5f77d12fff = new Guid("330dcee3-8fa0-875b-c8f0-fe5f77d12fff");
      /// <summary>
      /// System.Service/Classification
      /// </summary>
      public static Guid ClassificationPropertyId { get { return _330dcee38fa0875bc8f0fe5f77d12fff; } }
      private static Guid _c8b4567b842fae1b0f391f446d1c7919 = new Guid("c8b4567b-842f-ae1b-0f39-1f446d1c7919");
      /// <summary>
      /// System.Service/AvailabilitySchedule
      /// </summary>
      public static Guid AvailabilitySchedulePropertyId { get { return _c8b4567b842fae1b0f391f446d1c7919; } }
    }
    #endregion

    #region System.ApplicationComponent
    private static Guid _15c8d57872b5756d8e119a644a44ad67 = new Guid("15c8d578-72b5-756d-8e11-9a644a44ad67");
    /// <summary>
    /// Application Component (System.ApplicationComponent)
    /// </summary>
    public static Guid ApplicationComponentClassId { get { return _15c8d57872b5756d8e119a644a44ad67; } }
    #endregion

    #region System.Environment
    private static Guid _62d48404535d17cce01bd4f45a7998cd = new Guid("62d48404-535d-17cc-e01b-d4f45a7998cd");
    /// <summary>
    /// Environment (System.Environment)
    /// </summary>
    public static Guid EnvironmentClassId { get { return _62d48404535d17cce01bd4f45a7998cd; } }
    public static class EnvironmentClassProperties
    {
      private static Guid _f59aed76ea575339433027149b398c3f = new Guid("f59aed76-ea57-5339-4330-27149b398c3f");
      /// <summary>
      /// System.Environment/Title
      /// </summary>
      public static Guid TitlePropertyId { get { return _f59aed76ea575339433027149b398c3f; } }
      private static Guid _edc0c5541ad997e1c9798a8d58bf35ff = new Guid("edc0c554-1ad9-97e1-c979-8a8d58bf35ff");
      /// <summary>
      /// System.Environment/Description
      /// </summary>
      public static Guid DescriptionPropertyId { get { return _edc0c5541ad997e1c9798a8d58bf35ff; } }
      private static Guid _dbabac529202419f4993f0ddb6cfc06c = new Guid("dbabac52-9202-419f-4993-f0ddb6cfc06c");
      /// <summary>
      /// System.Environment/Notes
      /// </summary>
      public static Guid NotesPropertyId { get { return _dbabac529202419f4993f0ddb6cfc06c; } }
      private static Guid _76342a38a140aa2b35e07c33919d2852 = new Guid("76342a38-a140-aa2b-35e0-7c33919d2852");
      /// <summary>
      /// System.Environment/Category
      /// </summary>
      public static Guid CategoryPropertyId { get { return _76342a38a140aa2b35e07c33919d2852; } }
    }
    #endregion

    #region System.GeoLocation
    private static Guid _a7f774ed534c08af2fbf54cbe1745388 = new Guid("a7f774ed-534c-08af-2fbf-54cbe1745388");
    /// <summary>
    /// Geo Location (System.GeoLocation)
    /// </summary>
    public static Guid GeoLocationClassId { get { return _a7f774ed534c08af2fbf54cbe1745388; } }
    public static class GeoLocationClassProperties
    {
      private static Guid _010edd9de536b62a8aae577e21f26e52 = new Guid("010edd9d-e536-b62a-8aae-577e21f26e52");
      /// <summary>
      /// System.GeoLocation/Id
      /// </summary>
      public static Guid IdPropertyId { get { return _010edd9de536b62a8aae577e21f26e52; } }
      private static Guid _a0a917df779775e97bc0c65bd8a36c3b = new Guid("a0a917df-7797-75e9-7bc0-c65bd8a36c3b");
      /// <summary>
      /// System.GeoLocation/Latitude
      /// </summary>
      public static Guid LatitudePropertyId { get { return _a0a917df779775e97bc0c65bd8a36c3b; } }
      private static Guid _a7074e3d44d556b2215350adb6b821e4 = new Guid("a7074e3d-44d5-56b2-2153-50adb6b821e4");
      /// <summary>
      /// System.GeoLocation/Longitude
      /// </summary>
      public static Guid LongitudePropertyId { get { return _a7074e3d44d556b2215350adb6b821e4; } }
    }
    #endregion

    // === Relationships ===

    #region System.Reference
    private static Guid _5996b2762d7f7ca568e709186d9462d5 = new Guid("5996b276-2d7f-7ca5-68e7-09186d9462d5");
    /// <summary>
    /// Reference (System.Reference)
    /// </summary>
    public static Guid ReferenceRelationshipId { get { return _5996b2762d7f7ca568e709186d9462d5; } }
    #endregion

    #region System.Containment
    private static Guid _189f45007a70db539566feea4695da29 = new Guid("189f4500-7a70-db53-9566-feea4695da29");
    /// <summary>
    /// Membership (System.Containment)
    /// </summary>
    public static Guid ContainmentRelationshipId { get { return _189f45007a70db539566feea4695da29; } }
    #endregion

    #region System.Membership
    private static Guid _c89ea3f4bcc3a4ab89c0c58c2cd88c84 = new Guid("c89ea3f4-bcc3-a4ab-89c0-c58c2cd88c84");
    /// <summary>
    /// Membership (System.Membership)
    /// </summary>
    public static Guid MembershipRelationshipId { get { return _c89ea3f4bcc3a4ab89c0c58c2cd88c84; } }
    #endregion

    #region System.Hosting
    private static Guid _ae80f88344099e3503da90ecc19a8b2c = new Guid("ae80f883-4409-9e35-03da-90ecc19a8b2c");
    /// <summary>
    /// Hosting (System.Hosting)
    /// </summary>
    public static Guid HostingRelationshipId { get { return _ae80f88344099e3503da90ecc19a8b2c; } }
    #endregion

    #region System.WatchedBy
    private static Guid _26ae25af43075414b07feda2bf845f9b = new Guid("26ae25af-4307-5414-b07f-eda2bf845f9b");
    /// <summary>
    /// Entity Watched By Perspective (System.WatchedBy)
    /// </summary>
    public static Guid WatchedByRelationshipId { get { return _26ae25af43075414b07feda2bf845f9b; } }
    #endregion

  }
}