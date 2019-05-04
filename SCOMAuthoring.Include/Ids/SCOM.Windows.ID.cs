using System;

namespace SCOMAuthoringBook.Library.IDs
{
  public class WindowsId
  {
    // === Classes ===

    #region Microsoft.Windows.Computer
    private static Guid _ea99500d8d52fc52b5a510dcd1e9d2bd = new Guid("ea99500d-8d52-fc52-b5a5-10dcd1e9d2bd");
    /// <summary>
    /// Windows Computer (Microsoft.Windows.Computer)
    /// </summary>
    public static Guid ComputerClassId { get { return _ea99500d8d52fc52b5a510dcd1e9d2bd; } }
    public static class ComputerClassProperties
    {
      private static Guid _5c324096d92876dbe9e7e629dcc261b1 = new Guid("5c324096-d928-76db-e9e7-e629dcc261b1");
      /// <summary>
      /// Microsoft.Windows.Computer/PrincipalName
      /// </summary>
      public static Guid PrincipalNamePropertyId { get { return _5c324096d92876dbe9e7e629dcc261b1; } }
      private static Guid _d3b003ee7bb764562d45c2e764df37a6 = new Guid("d3b003ee-7bb7-6456-2d45-c2e764df37a6");
      /// <summary>
      /// Microsoft.Windows.Computer/DNSName
      /// </summary>
      public static Guid DNSNamePropertyId { get { return _d3b003ee7bb764562d45c2e764df37a6; } }
      private static Guid _879a4dee444f186bcc6f2e9cb89d87c3 = new Guid("879a4dee-444f-186b-cc6f-2e9cb89d87c3");
      /// <summary>
      /// Microsoft.Windows.Computer/NetbiosComputerName
      /// </summary>
      public static Guid NetbiosComputerNamePropertyId { get { return _879a4dee444f186bcc6f2e9cb89d87c3; } }
      private static Guid _756493d6f2a24f358970953d7c828cd0 = new Guid("756493d6-f2a2-4f35-8970-953d7c828cd0");
      /// <summary>
      /// Microsoft.Windows.Computer/NetbiosDomainName
      /// </summary>
      public static Guid NetbiosDomainNamePropertyId { get { return _756493d6f2a24f358970953d7c828cd0; } }
      private static Guid _f97e7c31f713e2a60450239a62363651 = new Guid("f97e7c31-f713-e2a6-0450-239a62363651");
      /// <summary>
      /// Microsoft.Windows.Computer/IPAddress
      /// </summary>
      public static Guid IPAddressPropertyId { get { return _f97e7c31f713e2a60450239a62363651; } }
      private static Guid _8f538d6386dac1493c841f1aace2f930 = new Guid("8f538d63-86da-c149-3c84-1f1aace2f930");
      /// <summary>
      /// Microsoft.Windows.Computer/NetworkName
      /// </summary>
      public static Guid NetworkNamePropertyId { get { return _8f538d6386dac1493c841f1aace2f930; } }
      private static Guid _488183e9d2bb2dd8b87218a20a1c9fa6 = new Guid("488183e9-d2bb-2dd8-b872-18a20a1c9fa6");
      /// <summary>
      /// Microsoft.Windows.Computer/ActiveDirectoryObjectSid
      /// </summary>
      public static Guid ActiveDirectoryObjectSidPropertyId { get { return _488183e9d2bb2dd8b87218a20a1c9fa6; } }
      private static Guid _6832a546b39daff894e1660bbd336687 = new Guid("6832a546-b39d-aff8-94e1-660bbd336687");
      /// <summary>
      /// Microsoft.Windows.Computer/IsVirtualMachine
      /// </summary>
      public static Guid IsVirtualMachinePropertyId { get { return _6832a546b39daff894e1660bbd336687; } }
      private static Guid _9f2cafc87a181c76b709d51b01d3b3d3 = new Guid("9f2cafc8-7a18-1c76-b709-d51b01d3b3d3");
      /// <summary>
      /// Microsoft.Windows.Computer/DomainDnsName
      /// </summary>
      public static Guid DomainDnsNamePropertyId { get { return _9f2cafc87a181c76b709d51b01d3b3d3; } }
      private static Guid _bfdf9a0d3393a720f24a17ea701eb77a = new Guid("bfdf9a0d-3393-a720-f24a-17ea701eb77a");
      /// <summary>
      /// Microsoft.Windows.Computer/OrganizationalUnit
      /// </summary>
      public static Guid OrganizationalUnitPropertyId { get { return _bfdf9a0d3393a720f24a17ea701eb77a; } }
      private static Guid _1704a09d8063021a9b802c47622ecf0f = new Guid("1704a09d-8063-021a-9b80-2c47622ecf0f");
      /// <summary>
      /// Microsoft.Windows.Computer/ForestDnsName
      /// </summary>
      public static Guid ForestDnsNamePropertyId { get { return _1704a09d8063021a9b802c47622ecf0f; } }
      private static Guid _4a1e1c69c659af91e7a8d886008032f3 = new Guid("4a1e1c69-c659-af91-e7a8-d886008032f3");
      /// <summary>
      /// Microsoft.Windows.Computer/ActiveDirectorySite
      /// </summary>
      public static Guid ActiveDirectorySitePropertyId { get { return _4a1e1c69c659af91e7a8d886008032f3; } }
      private static Guid _025639656649f495aeb7bd8a6eab33a7 = new Guid("02563965-6649-f495-aeb7-bd8a6eab33a7");
      /// <summary>
      /// Microsoft.Windows.Computer/LogicalProcessors
      /// </summary>
      public static Guid LogicalProcessorsPropertyId { get { return _025639656649f495aeb7bd8a6eab33a7; } }
      private static Guid _acf577c17adab105ca801a6347a2ccb7 = new Guid("acf577c1-7ada-b105-ca80-1a6347a2ccb7");
      /// <summary>
      /// Microsoft.Windows.Computer/PhysicalProcessors
      /// </summary>
      public static Guid PhysicalProcessorsPropertyId { get { return _acf577c17adab105ca801a6347a2ccb7; } }
      private static Guid _8613d41399caef86763646ac10db6478 = new Guid("8613d413-99ca-ef86-7636-46ac10db6478");
      /// <summary>
      /// Microsoft.Windows.Computer/HostServerName
      /// </summary>
      public static Guid HostServerNamePropertyId { get { return _8613d41399caef86763646ac10db6478; } }
      private static Guid _6664d8ac53c84e5c72a9349051837330 = new Guid("6664d8ac-53c8-4e5c-72a9-349051837330");
      /// <summary>
      /// Microsoft.Windows.Computer/VirtualMachineName
      /// </summary>
      public static Guid VirtualMachineNamePropertyId { get { return _6664d8ac53c84e5c72a9349051837330; } }
      private static Guid _68f597b6aada7baab544fe67c737be32 = new Guid("68f597b6-aada-7baa-b544-fe67c737be32");
      /// <summary>
      /// Microsoft.Windows.Computer/OffsetInMinuteFromGreenwichTime
      /// </summary>
      public static Guid OffsetInMinuteFromGreenwichTimePropertyId { get { return _68f597b6aada7baab544fe67c737be32; } }
      private static Guid _6223ef7250deb1fbd666397cefd264ea = new Guid("6223ef72-50de-b1fb-d666-397cefd264ea");
      /// <summary>
      /// Microsoft.Windows.Computer/LastInventoryDate
      /// </summary>
      public static Guid LastInventoryDatePropertyId { get { return _6223ef7250deb1fbd666397cefd264ea; } }
    }
    #endregion

    #region Microsoft.Windows.Server.Computer
    private static Guid _e817d03402e8294c350901ca25481689 = new Guid("e817d034-02e8-294c-3509-01ca25481689");
    /// <summary>
    /// Windows Server (Microsoft.Windows.Server.Computer)
    /// </summary>
    public static Guid ServerComputerClassId { get { return _e817d03402e8294c350901ca25481689; } }
    public static class ServerComputerClassProperties
    {
      private static Guid _d1d39d5ce9347d7f4f3858d5ef4ae1e2 = new Guid("d1d39d5c-e934-7d7f-4f38-58d5ef4ae1e2");
      /// <summary>
      /// Microsoft.Windows.Server.Computer/IsVirtualNode
      /// </summary>
      public static Guid IsVirtualNodePropertyId { get { return _d1d39d5ce9347d7f4f3858d5ef4ae1e2; } }
    }
    #endregion

    #region Microsoft.Windows.Client.Computer
    private static Guid _5918e1982dbe5f7d135e6e43a94ccb5b = new Guid("5918e198-2dbe-5f7d-135e-6e43a94ccb5b");
    /// <summary>
    /// Windows Client (Microsoft.Windows.Client.Computer)
    /// </summary>
    public static Guid ClientComputerClassId { get { return _5918e1982dbe5f7d135e6e43a94ccb5b; } }
    #endregion

    #region Microsoft.Windows.LogicalDevice
    private static Guid _3361982a7dfd288df48ce04e85149750 = new Guid("3361982a-7dfd-288d-f48c-e04e85149750");
    /// <summary>
    /// Windows Logical Hardware Component (Microsoft.Windows.LogicalDevice)
    /// </summary>
    public static Guid LogicalDeviceClassId { get { return _3361982a7dfd288df48ce04e85149750; } }
    public static class LogicalDeviceClassProperties
    {
      private static Guid _af13c36e919795f7393c84aa6638fec9 = new Guid("af13c36e-9197-95f7-393c-84aa6638fec9");
      /// <summary>
      /// Microsoft.Windows.LogicalDevice/DeviceID
      /// </summary>
      public static Guid DeviceIDPropertyId { get { return _af13c36e919795f7393c84aa6638fec9; } }
      private static Guid _e0b1c8bec004f8923528d9321d185910 = new Guid("e0b1c8be-c004-f892-3528-d9321d185910");
      /// <summary>
      /// Microsoft.Windows.LogicalDevice/Name
      /// </summary>
      public static Guid NamePropertyId { get { return _e0b1c8bec004f8923528d9321d185910; } }
      private static Guid _5d0624b028998948924d3e4cb24c21f5 = new Guid("5d0624b0-2899-8948-924d-3e4cb24c21f5");
      /// <summary>
      /// Microsoft.Windows.LogicalDevice/Description
      /// </summary>
      public static Guid DescriptionPropertyId { get { return _5d0624b028998948924d3e4cb24c21f5; } }
    }
    #endregion

    #region Microsoft.Windows.LogicalDisk
    private static Guid _d0718456aa7e7b928a466a2d762d32a7 = new Guid("d0718456-aa7e-7b92-8a46-6a2d762d32a7");
    /// <summary>
    /// Logical Disk (abstract) (Microsoft.Windows.LogicalDisk)
    /// </summary>
    public static Guid LogicalDiskClassId { get { return _d0718456aa7e7b928a466a2d762d32a7; } }
    public static class LogicalDiskClassProperties
    {
      private static Guid _654302a38566e4e9e856f8cae47741b2 = new Guid("654302a3-8566-e4e9-e856-f8cae47741b2");
      /// <summary>
      /// Microsoft.Windows.LogicalDisk/VolumeName
      /// </summary>
      public static Guid VolumeNamePropertyId { get { return _654302a38566e4e9e856f8cae47741b2; } }
    }
    #endregion

    #region Microsoft.Windows.PhysicalDisk
    private static Guid _26d62cffbd8fbc5a74dfcbf19e0367d3 = new Guid("26d62cff-bd8f-bc5a-74df-cbf19e0367d3");
    /// <summary>
    /// Physical Disk (abstract) (Microsoft.Windows.PhysicalDisk)
    /// </summary>
    public static Guid PhysicalDiskClassId { get { return _26d62cffbd8fbc5a74dfcbf19e0367d3; } }
    public static class PhysicalDiskClassProperties
    {
      private static Guid _9147b06ee3c312f80c8bef1f2c04cd15 = new Guid("9147b06e-e3c3-12f8-0c8b-ef1f2c04cd15");
      /// <summary>
      /// Microsoft.Windows.PhysicalDisk/MediaType
      /// </summary>
      public static Guid MediaTypePropertyId { get { return _9147b06ee3c312f80c8bef1f2c04cd15; } }
      private static Guid _b25559f916e9551cebc7efd0b8c2446f = new Guid("b25559f9-16e9-551c-ebc7-efd0b8c2446f");
      /// <summary>
      /// Microsoft.Windows.PhysicalDisk/PNPDeviceId
      /// </summary>
      public static Guid PNPDeviceIdPropertyId { get { return _b25559f916e9551cebc7efd0b8c2446f; } }
    }
    #endregion

    #region Microsoft.Windows.DiskPartition
    private static Guid _83a0ee32c6cd3dafebc8958ea15fd764 = new Guid("83a0ee32-c6cd-3daf-ebc8-958ea15fd764");
    /// <summary>
    /// Disk Partition (Microsoft.Windows.DiskPartition)
    /// </summary>
    public static Guid DiskPartitionClassId { get { return _83a0ee32c6cd3dafebc8958ea15fd764; } }
    public static class DiskPartitionClassProperties
    {
      private static Guid _69fabfcdd5792be1e786c80b219c4be5 = new Guid("69fabfcd-d579-2be1-e786-c80b219c4be5");
      /// <summary>
      /// Microsoft.Windows.DiskPartition/Type
      /// </summary>
      public static Guid TypePropertyId { get { return _69fabfcdd5792be1e786c80b219c4be5; } }
    }
    #endregion

    #region Microsoft.Windows.LocalApplication
    private static Guid _0d02676886be77f5b58e7f07d3178cf8 = new Guid("0d026768-86be-77f5-b58e-7f07d3178cf8");
    /// <summary>
    /// Windows Local Application (Microsoft.Windows.LocalApplication)
    /// </summary>
    public static Guid LocalApplicationClassId { get { return _0d02676886be77f5b58e7f07d3178cf8; } }
    #endregion

    #region Microsoft.Windows.ApplicationComponent
    private static Guid _fb00bb78d29c55085707bf8bafb2127b = new Guid("fb00bb78-d29c-5508-5707-bf8bafb2127b");
    /// <summary>
    /// Windows Application Component (Microsoft.Windows.ApplicationComponent)
    /// </summary>
    public static Guid ApplicationComponentClassId { get { return _fb00bb78d29c55085707bf8bafb2127b; } }
    #endregion

    #region Microsoft.Windows.OperatingSystem
    private static Guid _66dd9b433dc1383195d41b03b0a6ea13 = new Guid("66dd9b43-3dc1-3831-95d4-1b03b0a6ea13");
    /// <summary>
    /// Windows Operating System (Microsoft.Windows.OperatingSystem)
    /// </summary>
    public static Guid OperatingSystemClassId { get { return _66dd9b433dc1383195d41b03b0a6ea13; } }
    public static class OperatingSystemClassProperties
    {
      private static Guid _a90b398332ea70d8d41c0f5a3957639a = new Guid("a90b3983-32ea-70d8-d41c-0f5a3957639a");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/OSVersion
      /// </summary>
      public static Guid OSVersionPropertyId { get { return _a90b398332ea70d8d41c0f5a3957639a; } }
      private static Guid _0d53d0cbb62a7177e9ef3543f94784fd = new Guid("0d53d0cb-b62a-7177-e9ef-3543f94784fd");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/OSVersionDisplayName
      /// </summary>
      public static Guid OSVersionDisplayNamePropertyId { get { return _0d53d0cbb62a7177e9ef3543f94784fd; } }
      private static Guid _cbba965a3e956c6e6f40bdea5d061df9 = new Guid("cbba965a-3e95-6c6e-6f40-bdea5d061df9");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/ProductType
      /// </summary>
      public static Guid ProductTypePropertyId { get { return _cbba965a3e956c6e6f40bdea5d061df9; } }
      private static Guid _1919c45dce1e2f56da19c1f19fd70f19 = new Guid("1919c45d-ce1e-2f56-da19-c1f19fd70f19");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/BuildNumber
      /// </summary>
      public static Guid BuildNumberPropertyId { get { return _1919c45dce1e2f56da19c1f19fd70f19; } }
      private static Guid _bf125622640e901c7c53a32391fba2a5 = new Guid("bf125622-640e-901c-7c53-a32391fba2a5");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/CSDVersion
      /// </summary>
      public static Guid CSDVersionPropertyId { get { return _bf125622640e901c7c53a32391fba2a5; } }
      private static Guid _38242aed43b81ae28aec7dbb5a6ebab0 = new Guid("38242aed-43b8-1ae2-8aec-7dbb5a6ebab0");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/ServicePackVersion
      /// </summary>
      public static Guid ServicePackVersionPropertyId { get { return _38242aed43b81ae28aec7dbb5a6ebab0; } }
      private static Guid _b67a574250a805d8cc3d260dcac27988 = new Guid("b67a5742-50a8-05d8-cc3d-260dcac27988");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/SerialNumber
      /// </summary>
      public static Guid SerialNumberPropertyId { get { return _b67a574250a805d8cc3d260dcac27988; } }
      private static Guid _4b8f45d0bffcc96a18116071aacfedee = new Guid("4b8f45d0-bffc-c96a-1811-6071aacfedee");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/InstallDate
      /// </summary>
      public static Guid InstallDatePropertyId { get { return _4b8f45d0bffcc96a18116071aacfedee; } }
      private static Guid _ee4b8224d7d5dc1e2413415181a26822 = new Guid("ee4b8224-d7d5-dc1e-2413-415181a26822");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/SystemDrive
      /// </summary>
      public static Guid SystemDrivePropertyId { get { return _ee4b8224d7d5dc1e2413415181a26822; } }
      private static Guid _58cb8748e8ef44d773557b3da7fd686b = new Guid("58cb8748-e8ef-44d7-7355-7b3da7fd686b");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/WindowsDirectory
      /// </summary>
      public static Guid WindowsDirectoryPropertyId { get { return _58cb8748e8ef44d773557b3da7fd686b; } }
      private static Guid _d20125476eefffcfef83316aeff4f079 = new Guid("d2012547-6eef-ffcf-ef83-316aeff4f079");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/PhysicalMemory
      /// </summary>
      public static Guid PhysicalMemoryPropertyId { get { return _d20125476eefffcfef83316aeff4f079; } }
      private static Guid _6521ce39faec1489b49c3d7cc441b717 = new Guid("6521ce39-faec-1489-b49c-3d7cc441b717");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/LogicalProcessors
      /// </summary>
      public static Guid LogicalProcessorsPropertyId { get { return _6521ce39faec1489b49c3d7cc441b717; } }
      private static Guid _a690ee4453b579693e18a5dd6a582d8b = new Guid("a690ee44-53b5-7969-3e18-a5dd6a582d8b");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/CountryCode
      /// </summary>
      public static Guid CountryCodePropertyId { get { return _a690ee4453b579693e18a5dd6a582d8b; } }
      private static Guid _79226c29d54fbfb3779fdbdf6aaf7a0c = new Guid("79226c29-d54f-bfb3-779f-dbdf6aaf7a0c");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/Locale
      /// </summary>
      public static Guid LocalePropertyId { get { return _79226c29d54fbfb3779fdbdf6aaf7a0c; } }
      private static Guid _c6ec39a6fa969679ece5f5323a7c0810 = new Guid("c6ec39a6-fa96-9679-ece5-f5323a7c0810");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/Description
      /// </summary>
      public static Guid DescriptionPropertyId { get { return _c6ec39a6fa969679ece5f5323a7c0810; } }
      private static Guid _d13263fb404a45ade4708fd7d05155bd = new Guid("d13263fb-404a-45ad-e470-8fd7d05155bd");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/Manufacturer
      /// </summary>
      public static Guid ManufacturerPropertyId { get { return _d13263fb404a45ade4708fd7d05155bd; } }
      private static Guid _eac39b2ce610d1343764d052857bc8f3 = new Guid("eac39b2c-e610-d134-3764-d052857bc8f3");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/OSLanguage
      /// </summary>
      public static Guid OSLanguagePropertyId { get { return _eac39b2ce610d1343764d052857bc8f3; } }
      private static Guid _a8148d6fcdd69b69377adb35f76c82b3 = new Guid("a8148d6f-cdd6-9b69-377a-db35f76c82b3");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/MinorVersion
      /// </summary>
      public static Guid MinorVersionPropertyId { get { return _a8148d6fcdd69b69377adb35f76c82b3; } }
      private static Guid _764da59e134bb1d43d9872ac5763c1fc = new Guid("764da59e-134b-b1d4-3d98-72ac5763c1fc");
      /// <summary>
      /// Microsoft.Windows.OperatingSystem/MajorVersion
      /// </summary>
      public static Guid MajorVersionPropertyId { get { return _764da59e134bb1d43d9872ac5763c1fc; } }
    }
    #endregion

    #region Microsoft.Windows.Server.OperatingSystem
    private static Guid _ab468fc4467d841e0f5d61c41fa54735 = new Guid("ab468fc4-467d-841e-0f5d-61c41fa54735");
    /// <summary>
    /// Windows Server Operating System (Microsoft.Windows.Server.OperatingSystem)
    /// </summary>
    public static Guid ServerOperatingSystemClassId { get { return _ab468fc4467d841e0f5d61c41fa54735; } }
    #endregion

    #region Microsoft.Windows.Client.OperatingSystem
    private static Guid _e9377b27f64bb2a3b01d5de35b1304ac = new Guid("e9377b27-f64b-b2a3-b01d-5de35b1304ac");
    /// <summary>
    /// Windows Client Operating System (Microsoft.Windows.Client.OperatingSystem)
    /// </summary>
    public static Guid ClientOperatingSystemClassId { get { return _e9377b27f64bb2a3b01d5de35b1304ac; } }
    #endregion

    #region Microsoft.Windows.ComputerRole
    private static Guid _273c8793d1c3aaf0cbcb4962f532fbe5 = new Guid("273c8793-d1c3-aaf0-cbcb-4962f532fbe5");
    /// <summary>
    /// Windows Computer Role (Microsoft.Windows.ComputerRole)
    /// </summary>
    public static Guid ComputerRoleClassId { get { return _273c8793d1c3aaf0cbcb4962f532fbe5; } }
    #endregion

    // === Relationships ===

  }
}