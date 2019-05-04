using System;

namespace SCOMAuthoringBook.Library.IDs
{
  public class SystemCenterId
  {
    #region Microsoft.SystemCenter.ManagementActionPoint
    /// <summary>
    ///  (Microsoft.SystemCenter.ManagementActionPoint)
    /// </summary>
    public static Guid ManagementActionPointClassId { get; } = new Guid("414bd649-ccf2-26a7-4171-e20694c802a4");
    #endregion

    #region Microsoft.SystemCenter.ManagementService
    /// <summary>
    ///  (Microsoft.SystemCenter.ManagementService)
    /// </summary>
    public static Guid ManagementServiceClassId { get; } = new Guid("d95d497c-25ec-9213-200c-50506912dad3");

    public static class ManagementServiceClassProperties
    {
      /// <summary>
      /// Microsoft.SystemCenter.ManagementService/HealthServiceId
      /// </summary>
      public static Guid HealthServiceIdPropertyId { get; } = new Guid("cac04922-bb71-8a38-2a97-d4f9f51d46c5");
    }
    #endregion

    #region Microsoft.SystemCenter.HealthService
    private static Guid _ab4c891f33593fb60704075fbfe36710 = new Guid("ab4c891f-3359-3fb6-0704-075fbfe36710");
    /// <summary>
    /// Health Service (Microsoft.SystemCenter.HealthService)
    /// </summary>
    public static Guid HealthServiceClassId { get { return _ab4c891f33593fb60704075fbfe36710; } }
    public static class HealthServiceClassProperties
    {
      private static Guid _b94cce785ad75056801999e6024fcb86 = new Guid("b94cce78-5ad7-5056-8019-99e6024fcb86");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/AuthenticationName
      /// </summary>
      public static Guid AuthenticationNamePropertyId { get { return _b94cce785ad75056801999e6024fcb86; } }
      private static Guid _c05be2de7d4b24e3cc1366ced5bec11d = new Guid("c05be2de-7d4b-24e3-cc13-66ced5bec11d");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/MaximumQueueSize
      /// </summary>
      public static Guid MaximumQueueSizePropertyId { get { return _c05be2de7d4b24e3cc1366ced5bec11d; } }
      private static Guid _fcf697889b67f7f1a2a117de6e3eed75 = new Guid("fcf69788-9b67-f7f1-a2a1-17de6e3eed75");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/MaximumSizeOfAllTransferredFiles
      /// </summary>
      public static Guid MaximumSizeOfAllTransferredFilesPropertyId { get { return _fcf697889b67f7f1a2a117de6e3eed75; } }
      private static Guid _f338297fdf7dad7bc666168643fdfba2 = new Guid("f338297f-df7d-ad7b-c666-168643fdfba2");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/RequestCompression
      /// </summary>
      public static Guid RequestCompressionPropertyId { get { return _f338297fdf7dad7bc666168643fdfba2; } }
      private static Guid _e50bfb1671a73d09cc652e3f83f7aa32 = new Guid("e50bfb16-71a7-3d09-cc65-2e3f83f7aa32");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/CreateListener
      /// </summary>
      public static Guid CreateListenerPropertyId { get { return _e50bfb1671a73d09cc652e3f83f7aa32; } }
      private static Guid _c51b7833da541653d8fd1a738ef8ded5 = new Guid("c51b7833-da54-1653-d8fd-1a738ef8ded5");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/Port
      /// </summary>
      public static Guid PortPropertyId { get { return _c51b7833da541653d8fd1a738ef8ded5; } }
      private static Guid _09be58d91a3db62bd68f2963589342bf = new Guid("09be58d9-1a3d-b62b-d68f-2963589342bf");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/IsRHS
      /// </summary>
      public static Guid IsRHSPropertyId { get { return _09be58d91a3db62bd68f2963589342bf; } }
      private static Guid _7cb1c2b79d400ded4af8f56d202c65d3 = new Guid("7cb1c2b7-9d40-0ded-4af8-f56d202c65d3");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/IsManagementServer
      /// </summary>
      public static Guid IsManagementServerPropertyId { get { return _7cb1c2b79d400ded4af8f56d202c65d3; } }
      private static Guid _38ca4e6a8c102da31ccb927b610ad4e3 = new Guid("38ca4e6a-8c10-2da3-1ccb-927b610ad4e3");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/IsAgent
      /// </summary>
      public static Guid IsAgentPropertyId { get { return _38ca4e6a8c102da31ccb927b610ad4e3; } }
      private static Guid _9f79275417bcf5961f63c59bd6c064ac = new Guid("9f792754-17bc-f596-1f63-c59bd6c064ac");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/IsGateway
      /// </summary>
      public static Guid IsGatewayPropertyId { get { return _9f79275417bcf5961f63c59bd6c064ac; } }
      private static Guid _dd9a0cc599c42ee6960280c4a441324f = new Guid("dd9a0cc5-99c4-2ee6-9602-80c4a441324f");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/IsManuallyInstalled
      /// </summary>
      public static Guid IsManuallyInstalledPropertyId { get { return _dd9a0cc599c42ee6960280c4a441324f; } }
      private static Guid _84c3b4b21c468de4e460ace739b9f479 = new Guid("84c3b4b2-1c46-8de4-e460-ace739b9f479");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/InstalledBy
      /// </summary>
      public static Guid InstalledByPropertyId { get { return _84c3b4b21c468de4e460ace739b9f479; } }
      private static Guid _f3b142c9c624763f1d2629e9ae91b850 = new Guid("f3b142c9-c624-763f-1d26-29e9ae91b850");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/InstallTime
      /// </summary>
      public static Guid InstallTimePropertyId { get { return _f3b142c9c624763f1d2629e9ae91b850; } }
      private static Guid _10dca198ca6de6cf5c8ba799b624173b = new Guid("10dca198-ca6d-e6cf-5c8b-a799b624173b");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/Version
      /// </summary>
      public static Guid VersionPropertyId { get { return _10dca198ca6de6cf5c8ba799b624173b; } }
      private static Guid _45eeedab8d7eefb221bfb1d0b3cd106c = new Guid("45eeedab-8d7e-efb2-21bf-b1d0b3cd106c");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/ActionAccountIdentity
      /// </summary>
      public static Guid ActionAccountIdentityPropertyId { get { return _45eeedab8d7eefb221bfb1d0b3cd106c; } }
      private static Guid _a70ea5998675ca64d8fa2b3a6f0b244e = new Guid("a70ea599-8675-ca64-d8fa-2b3a6f0b244e");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/HeartbeatEnabled
      /// </summary>
      public static Guid HeartbeatEnabledPropertyId { get { return _a70ea5998675ca64d8fa2b3a6f0b244e; } }
      private static Guid _c0a1371f82505215f43bbfd509cb9719 = new Guid("c0a1371f-8250-5215-f43b-bfd509cb9719");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/HeartbeatInterval
      /// </summary>
      public static Guid HeartbeatIntervalPropertyId { get { return _c0a1371f82505215f43bbfd509cb9719; } }
      private static Guid _7274017ad5efe6413c0ea4e150cabea0 = new Guid("7274017a-d5ef-e641-3c0e-a4e150cabea0");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/ActiveDirectoryManaged
      /// </summary>
      public static Guid ActiveDirectoryManagedPropertyId { get { return _7274017ad5efe6413c0ea4e150cabea0; } }
      private static Guid _2460b133b9b5e8341302bdea539b2f71 = new Guid("2460b133-b9b5-e834-1302-bdea539b2f71");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/ProxyingEnabled
      /// </summary>
      public static Guid ProxyingEnabledPropertyId { get { return _2460b133b9b5e8341302bdea539b2f71; } }
      private static Guid _189f0d482a0c699bf6f17a62cf991848 = new Guid("189f0d48-2a0c-699b-f6f1-7a62cf991848");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/PatchList
      /// </summary>
      public static Guid PatchListPropertyId { get { return _189f0d482a0c699bf6f17a62cf991848; } }
      private static Guid _e0d66bdd0e6aec6760bfe3932231d1c3 = new Guid("e0d66bdd-0e6a-ec67-60bf-e3932231d1c3");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/Protocol
      /// </summary>
      public static Guid ProtocolPropertyId { get { return _e0d66bdd0e6aec6760bfe3932231d1c3; } }
      private static Guid _314db88f7bcef0a40a524289e41cecbe = new Guid("314db88f-7bce-f0a4-0a52-4289e41cecbe");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/InitiatesConnectionToParent
      /// </summary>
      public static Guid InitiatesConnectionToParentPropertyId { get { return _314db88f7bcef0a40a524289e41cecbe; } }
      private static Guid _efc39f1f9a3b44a00ec91d16acd5bac3 = new Guid("efc39f1f-9a3b-44a0-0ec9-1d16acd5bac3");
      /// <summary>
      /// Microsoft.SystemCenter.HealthService/ThirdPartyAuthenticationUri
      /// </summary>
      public static Guid ThirdPartyAuthenticationUriPropertyId { get { return _efc39f1f9a3b44a00ec91d16acd5bac3; } }
    }
    #endregion

    #region Microsoft.SystemCenter.Agent
    private static Guid _118c0f187a705f573a9beeaf1705b3fc = new Guid("118c0f18-7a70-5f57-3a9b-eeaf1705b3fc");
    /// <summary>
    /// Agent (Microsoft.SystemCenter.Agent)
    /// </summary>
    public static Guid AgentClassId { get { return _118c0f187a705f573a9beeaf1705b3fc; } }
    #endregion

    #region Microsoft.SystemCenter.HealthServiceWatcher
    private static Guid _a4899740ef2f15416c1d51d34b739491 = new Guid("a4899740-ef2f-1541-6c1d-51d34b739491");
    /// <summary>
    /// Health Service Watcher (Microsoft.SystemCenter.HealthServiceWatcher)
    /// </summary>
    public static Guid HealthServiceWatcherClassId { get { return _a4899740ef2f15416c1d51d34b739491; } }
    public static class HealthServiceWatcherClassProperties
    {
      private static Guid _e356df805d09cd62f29de9106f730db6 = new Guid("e356df80-5d09-cd62-f29d-e9106f730db6");
      /// <summary>
      /// Microsoft.SystemCenter.HealthServiceWatcher/HealthServiceId
      /// </summary>
      public static Guid HealthServiceIdPropertyId { get { return _e356df805d09cd62f29de9106f730db6; } }
      private static Guid _50c2ad1bcd40d992baa5312c02dc5782 = new Guid("50c2ad1b-cd40-d992-baa5-312c02dc5782");
      /// <summary>
      /// Microsoft.SystemCenter.HealthServiceWatcher/HealthServiceName
      /// </summary>
      public static Guid HealthServiceNamePropertyId { get { return _50c2ad1bcd40d992baa5312c02dc5782; } }
    }
    #endregion

    #region Microsoft.SystemCenter.HealthServiceWatchersGroup
    /// <summary>
    /// Health Service Watcher Group (Microsoft.SystemCenter.HealthServiceWatchersGroup)
    /// </summary>
    public static Guid HealthServiceWatchersGroupClassId { get; } = new Guid("a4c8b023-4cfc-52cc-30b7-6c1b959c4723");
    public static class HealthServiceWatchersGroupClassProperties
    {
      /// <summary>
      /// Microsoft.SystemCenter.HealthServiceWatchersGroup/WatcherGroupName
      /// </summary>
      public static Guid WatcherGroupNamePropertyId { get; } = new Guid("87177203-9053-76a1-a322-1226f815507a");
      /// <summary>
      /// Microsoft.SystemCenter.HealthServiceWatchersGroup/RMSPrincipalName
      /// </summary>
      public static Guid RMSPrincipalNamePropertyId { get; } = new Guid("89ef0a95-2e5b-ee5f-96c2-71cce8490758");
    }
    #endregion

    #region Microsoft.SystemCenter.CollectionManagementServer
    private static Guid _7b11b1b93462c54f9f10943cabb9d26e = new Guid("7b11b1b9-3462-c54f-9f10-943cabb9d26e");
    /// <summary>
    /// Collection Server (Microsoft.SystemCenter.CollectionManagementServer)
    /// </summary>
    public static Guid CollectionManagementServerClassId { get { return _7b11b1b93462c54f9f10943cabb9d26e; } }
    #endregion

    #region Microsoft.SystemCenter.Connector
    private static Guid _2d63134b491fae0bd71b81ff238422bf = new Guid("2d63134b-491f-ae0b-d71b-81ff238422bf");
    /// <summary>
    /// Connector (Microsoft.SystemCenter.Connector)
    /// </summary>
    public static Guid ConnectorClassId { get { return _2d63134b491fae0bd71b81ff238422bf; } }
    public static class ConnectorClassProperties
    {
      private static Guid _29906075e9fc7bc4487bf964f91d6532 = new Guid("29906075-e9fc-7bc4-487b-f964f91d6532");
      /// <summary>
      /// Microsoft.SystemCenter.Connector/Id
      /// </summary>
      public static Guid IdPropertyId { get { return _29906075e9fc7bc4487bf964f91d6532; } }
      private static Guid _fd39fd0ea9df950933b9ba0f2d9bd215 = new Guid("fd39fd0e-a9df-9509-33b9-ba0f2d9bd215");
      /// <summary>
      /// Microsoft.SystemCenter.Connector/Name
      /// </summary>
      public static Guid NamePropertyId { get { return _fd39fd0ea9df950933b9ba0f2d9bd215; } }
      private static Guid _0a6e2ad0d84a964158e3abba4511bb79 = new Guid("0a6e2ad0-d84a-9641-58e3-abba4511bb79");
      /// <summary>
      /// Microsoft.SystemCenter.Connector/Description
      /// </summary>
      public static Guid DescriptionPropertyId { get { return _0a6e2ad0d84a964158e3abba4511bb79; } }
      private static Guid _89b6c2dd4f070f86a18d72401ea57f32 = new Guid("89b6c2dd-4f07-0f86-a18d-72401ea57f32");
      /// <summary>
      /// Microsoft.SystemCenter.Connector/DiscoveryDataIsManaged
      /// </summary>
      public static Guid DiscoveryDataIsManagedPropertyId { get { return _89b6c2dd4f070f86a18d72401ea57f32; } }
      private static Guid _802345ee2e7baf9e469f612945ce3b81 = new Guid("802345ee-2e7b-af9e-469f-612945ce3b81");
      /// <summary>
      /// Microsoft.SystemCenter.Connector/DiscoveryDataIsShared
      /// </summary>
      public static Guid DiscoveryDataIsSharedPropertyId { get { return _802345ee2e7baf9e469f612945ce3b81; } }
      private static Guid _d3e1b2583d8ab7f4a7a3d4499da44734 = new Guid("d3e1b258-3d8a-b7f4-a7a3-d4499da44734");
      /// <summary>
      /// Microsoft.SystemCenter.Connector/Incoming
      /// </summary>
      public static Guid IncomingPropertyId { get { return _d3e1b2583d8ab7f4a7a3d4499da44734; } }
      private static Guid _02e476787056068b244e126788f70b7b = new Guid("02e47678-7056-068b-244e-126788f70b7b");
      /// <summary>
      /// Microsoft.SystemCenter.Connector/Outgoing
      /// </summary>
      public static Guid OutgoingPropertyId { get { return _02e476787056068b244e126788f70b7b; } }
    }
    #endregion

    #region Microsoft.SystemCenter.GatewayManagementServer
    private static Guid _c1721bcc35f75a495d5f6880687c3d48 = new Guid("c1721bcc-35f7-5a49-5d5f-6880687c3d48");
    /// <summary>
    /// Gateway (Microsoft.SystemCenter.GatewayManagementServer)
    /// </summary>
    public static Guid GatewayManagementServerClassId { get { return _c1721bcc35f75a495d5f6880687c3d48; } }
    #endregion

    #region Microsoft.SystemCenter.ManagementGroup
    private static Guid _6b1d1be8ebb4b42508dc2385c5930b04 = new Guid("6b1d1be8-ebb4-b425-08dc-2385c5930b04");
    /// <summary>
    /// Operations Manager Management Group (Microsoft.SystemCenter.ManagementGroup)
    /// </summary>
    public static Guid ManagementGroupClassId { get { return _6b1d1be8ebb4b42508dc2385c5930b04; } }
    public static class ManagementGroupClassProperties
    {
      private static Guid _46b799969e04464d474d9a9fb8c2cd5d = new Guid("46b79996-9e04-464d-474d-9a9fb8c2cd5d");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/Name
      /// </summary>
      public static Guid NamePropertyId { get { return _46b799969e04464d474d9a9fb8c2cd5d; } }
      private static Guid _df0ca9f17ca7e177716a4bc404919411 = new Guid("df0ca9f1-7ca7-e177-716a-4bc404919411");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/Id
      /// </summary>
      public static Guid IdPropertyId { get { return _df0ca9f17ca7e177716a4bc404919411; } }
      private static Guid _9fcb7696eaaccf0d171433788290e437 = new Guid("9fcb7696-eaac-cf0d-1714-33788290e437");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/SDKServiceSCP
      /// </summary>
      public static Guid SDKServiceSCPPropertyId { get { return _9fcb7696eaaccf0d171433788290e437; } }
      private static Guid _2e75995223f93838b3b1639902c39469 = new Guid("2e759952-23f9-3838-b3b1-639902c39469");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/RootHealthServiceSCP
      /// </summary>
      public static Guid RootHealthServiceSCPPropertyId { get { return _2e75995223f93838b3b1639902c39469; } }
      private static Guid _b7222ae93490015adb7eaebb490aca03 = new Guid("b7222ae9-3490-015a-db7e-aebb490aca03");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/CEIPEnabled
      /// </summary>
      public static Guid CEIPEnabledPropertyId { get { return _b7222ae93490015adb7eaebb490aca03; } }
      private static Guid _a09f86058ead9dd35e6a7560ae7b41b1 = new Guid("a09f8605-8ead-9dd3-5e6a-7560ae7b41b1");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/CommunicationPort
      /// </summary>
      public static Guid CommunicationPortPropertyId { get { return _a09f86058ead9dd35e6a7560ae7b41b1; } }
      private static Guid _d5243a87901638ec02d71a39a3f792eb = new Guid("d5243a87-9016-38ec-02d7-1a39a3f792eb");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/ErrorReportingEnabled
      /// </summary>
      public static Guid ErrorReportingEnabledPropertyId { get { return _d5243a87901638ec02d71a39a3f792eb; } }
      private static Guid _4be130e0627397c943bd87e75eded95c = new Guid("4be130e0-6273-97c9-43bd-87e75eded95c");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/ErrorReportingQueuingEnabled
      /// </summary>
      public static Guid ErrorReportingQueuingEnabledPropertyId { get { return _4be130e0627397c943bd87e75eded95c; } }
      private static Guid _c7d5ca84abe2f8b3d6cb29ac7c3111fc = new Guid("c7d5ca84-abe2-f8b3-d6cb-29ac7c3111fc");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/OnlineProductKnowledgeUrl
      /// </summary>
      public static Guid OnlineProductKnowledgeUrlPropertyId { get { return _c7d5ca84abe2f8b3d6cb29ac7c3111fc; } }
      private static Guid _a3fcb97d3e4a752a311243f2eaf5c2a1 = new Guid("a3fcb97d-3e4a-752a-3112-43f2eaf5c2a1");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/SendOperationalDataReports
      /// </summary>
      public static Guid SendOperationalDataReportsPropertyId { get { return _a3fcb97d3e4a752a311243f2eaf5c2a1; } }
      private static Guid _94642b9ca7f1b192273b5c0f695e9f1e = new Guid("94642b9c-a7f1-b192-273b-5c0f695e9f1e");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/SDKServerName
      /// </summary>
      public static Guid SDKServerNamePropertyId { get { return _94642b9ca7f1b192273b5c0f695e9f1e; } }
      private static Guid _1e47d32ac6b51caf41e3c7c8cabcb60d = new Guid("1e47d32a-c6b5-1caf-41e3-c7c8cabcb60d");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/OperationalDatabaseName
      /// </summary>
      public static Guid OperationalDatabaseNamePropertyId { get { return _1e47d32ac6b51caf41e3c7c8cabcb60d; } }
      private static Guid _4f6bf68f122ac3fc1fec67dbf20b4747 = new Guid("4f6bf68f-122a-c3fc-1fec-67dbf20b4747");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/SQLServerName
      /// </summary>
      public static Guid SQLServerNamePropertyId { get { return _4f6bf68f122ac3fc1fec67dbf20b4747; } }
      private static Guid _6a98a95374ea7182a386e2ef4f9e7ce1 = new Guid("6a98a953-74ea-7182-a386-e2ef4f9e7ce1");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/AlertAutoResolvePeriod
      /// </summary>
      public static Guid AlertAutoResolvePeriodPropertyId { get { return _6a98a95374ea7182a386e2ef4f9e7ce1; } }
      private static Guid _28581f22e5638222ed64e3b9309c833b = new Guid("28581f22-e563-8222-ed64-e3b9309c833b");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/HealthyAlertAutoResolvePeriod
      /// </summary>
      public static Guid HealthyAlertAutoResolvePeriodPropertyId { get { return _28581f22e5638222ed64e3b9309c833b; } }
      private static Guid _23674d4417dd48bfb137dd00f76ef3d7 = new Guid("23674d44-17dd-48bf-b137-dd00f76ef3d7");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementGroup/TierTimeDifferenceThreshold
      /// </summary>
      public static Guid TierTimeDifferenceThresholdPropertyId { get { return _23674d4417dd48bfb137dd00f76ef3d7; } }
    }
    #endregion

    #region Microsoft.SystemCenter.ManagementServer
    private static Guid _9189a49eb2decab02e4f4925b68e335d = new Guid("9189a49e-b2de-cab0-2e4f-4925b68e335d");
    /// <summary>
    /// Management Server (Microsoft.SystemCenter.ManagementServer)
    /// </summary>
    public static Guid ManagementServerClassId { get { return _9189a49eb2decab02e4f4925b68e335d; } }
    public static class ManagementServerClassProperties
    {
      private static Guid _fabc7a501a47610bad632c1059e5b4f5 = new Guid("fabc7a50-1a47-610b-ad63-2c1059e5b4f5");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementServer/ManagementServerSCP
      /// </summary>
      public static Guid ManagementServerSCPPropertyId { get { return _fabc7a501a47610bad632c1059e5b4f5; } }
      private static Guid _49edf37d6dde01069d7dbf9d43bf85a9 = new Guid("49edf37d-6dde-0106-9d7d-bf9d43bf85a9");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementServer/AutoApproveManuallyInstalledAgents
      /// </summary>
      public static Guid AutoApproveManuallyInstalledAgentsPropertyId { get { return _49edf37d6dde01069d7dbf9d43bf85a9; } }
      private static Guid _954ee5f12a6ee2caff3c28059efaff32 = new Guid("954ee5f1-2a6e-e2ca-ff3c-28059efaff32");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementServer/NumberOfMissingHeartBeatsToMarkMachineDown
      /// </summary>
      public static Guid NumberOfMissingHeartBeatsToMarkMachineDownPropertyId { get { return _954ee5f12a6ee2caff3c28059efaff32; } }
      private static Guid _6faaee0b00506c154279c738915a91ad = new Guid("6faaee0b-0050-6c15-4279-c738915a91ad");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementServer/ProxyAddress
      /// </summary>
      public static Guid ProxyAddressPropertyId { get { return _6faaee0b00506c154279c738915a91ad; } }
      private static Guid _805a8adfeb8255cb9afb051661f94861 = new Guid("805a8adf-eb82-55cb-9afb-051661f94861");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementServer/ProxyPort
      /// </summary>
      public static Guid ProxyPortPropertyId { get { return _805a8adfeb8255cb9afb051661f94861; } }
      private static Guid _3b584cb1b84fe3ee784bb285d8094527 = new Guid("3b584cb1-b84f-e3ee-784b-b285d8094527");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementServer/RejectManuallyInstalledAgents
      /// </summary>
      public static Guid RejectManuallyInstalledAgentsPropertyId { get { return _3b584cb1b84fe3ee784bb285d8094527; } }
      private static Guid _4d22694e6dd613acbb7b0d0934f949ee = new Guid("4d22694e-6dd6-13ac-bb7b-0d0934f949ee");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementServer/UseProxyServer
      /// </summary>
      public static Guid UseProxyServerPropertyId { get { return _4d22694e6dd613acbb7b0d0934f949ee; } }
    }
    #endregion

    #region Microsoft.SystemCenter.AllManagementServersPool
    private static Guid _4932d8f0c8e22f4b288e3ed98a340b9f = new Guid("4932d8f0-c8e2-2f4b-288e-3ed98a340b9f");
    /// <summary>
    /// All Management Servers Resource Pool (Microsoft.SystemCenter.AllManagementServersPool)
    /// </summary>
    public static Guid AllManagementServersPoolClassId { get { return _4932d8f0c8e22f4b288e3ed98a340b9f; } }
    #endregion

    #region Microsoft.SystemCenter.DataWarehouse
    private static Guid _16781f33f72d033c1df465a2aff32ca3 = new Guid("16781f33-f72d-033c-1df4-65a2aff32ca3");
    /// <summary>
    /// Microsoft System Center Data Warehouse (Microsoft.SystemCenter.DataWarehouse)
    /// </summary>
    public static Guid DataWarehouseClassId { get { return _16781f33f72d033c1df465a2aff32ca3; } }
    public static class DataWarehouseClassProperties
    {
      private static Guid _8033f6cd5c048771bedaee46d3fa660c = new Guid("8033f6cd-5c04-8771-beda-ee46d3fa660c");
      /// <summary>
      /// Microsoft.SystemCenter.DataWarehouse/ReportingServerUrl
      /// </summary>
      public static Guid ReportingServerUrlPropertyId { get { return _8033f6cd5c048771bedaee46d3fa660c; } }
      private static Guid _6d266847f09aa3e3e7a49413d7967ad2 = new Guid("6d266847-f09a-a3e3-e7a4-9413d7967ad2");
      /// <summary>
      /// Microsoft.SystemCenter.DataWarehouse/ReportRootFolderName
      /// </summary>
      public static Guid ReportRootFolderNamePropertyId { get { return _6d266847f09aa3e3e7a49413d7967ad2; } }
      private static Guid _dabe508deba575f5872c9f151a1e1258 = new Guid("dabe508d-eba5-75f5-872c-9f151a1e1258");
      /// <summary>
      /// Microsoft.SystemCenter.DataWarehouse/MyReportsFolderName
      /// </summary>
      public static Guid MyReportsFolderNamePropertyId { get { return _dabe508deba575f5872c9f151a1e1258; } }
      private static Guid _ddf89d02f634eed5bb5d28d05d96b098 = new Guid("ddf89d02-f634-eed5-bb5d-28d05d96b098");
      /// <summary>
      /// Microsoft.SystemCenter.DataWarehouse/MainDatabaseServerName
      /// </summary>
      public static Guid MainDatabaseServerNamePropertyId { get { return _ddf89d02f634eed5bb5d28d05d96b098; } }
      private static Guid _dea1260e5e07656c33fece976ec9c8af = new Guid("dea1260e-5e07-656c-33fe-ce976ec9c8af");
      /// <summary>
      /// Microsoft.SystemCenter.DataWarehouse/MainDatabaseName
      /// </summary>
      public static Guid MainDatabaseNamePropertyId { get { return _dea1260e5e07656c33fece976ec9c8af; } }
    }
    #endregion

    #region Microsoft.SystemCenter.ManagementServicePool
    private static Guid _f5d4c6aff7ff57d6011f82713e64100d = new Guid("f5d4c6af-f7ff-57d6-011f-82713e64100d");
    /// <summary>
    /// Management Service Pool (Microsoft.SystemCenter.ManagementServicePool)
    /// </summary>
    public static Guid ManagementServicePoolClassId { get { return _f5d4c6aff7ff57d6011f82713e64100d; } }
    public static class ManagementServicePoolClassProperties
    {
      private static Guid _c73a06fe7c0e1991e600e849326e6e15 = new Guid("c73a06fe-7c0e-1991-e600-e849326e6e15");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementServicePool/IsDynamic
      /// </summary>
      public static Guid IsDynamicPropertyId { get { return _c73a06fe7c0e1991e600e849326e6e15; } }
      private static Guid _7d048a6afe81f26dce4cc174b0fe846a = new Guid("7d048a6a-fe81-f26d-ce4c-c174b0fe846a");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementServicePool/MembershipVersion
      /// </summary>
      public static Guid MembershipVersionPropertyId { get { return _7d048a6afe81f26dce4cc174b0fe846a; } }
      private static Guid _f0724ef30044b4a4ea69418a555fb207 = new Guid("f0724ef3-0044-b4a4-ea69-418a555fb207");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementServicePool/UseDefaultObserver
      /// </summary>
      public static Guid UseDefaultObserverPropertyId { get { return _f0724ef30044b4a4ea69418a555fb207; } }
      private static Guid _e2c4086b2480d4ebdb5c7a1aafadf33e = new Guid("e2c4086b-2480-d4eb-db5c-7a1aafadf33e");
      /// <summary>
      /// Microsoft.SystemCenter.ManagementServicePool/Description
      /// </summary>
      public static Guid DescriptionPropertyId { get { return _e2c4086b2480d4ebdb5c7a1aafadf33e; } }
    }
    #endregion

    // === Relationships

    #region Microsoft.SystemCenter.HealthServiceShouldManageEntity
    /// <summary>
    /// Health Service should manage Entity (Microsoft.SystemCenter.HealthServiceShouldManageEntity)
    /// </summary>
    public static Guid HealthServiceShouldManageEntityRelationshipId { get; } = new Guid("2f71c644-e092-b80a-040b-5c81ba1ec353");
    #endregion

    #region Microsoft.SystemCenter.ManagementActionPointShouldManageEntity
    /// <summary>
    ///  (Microsoft.SystemCenter.ManagementActionPointShouldManageEntity)
    /// </summary>
    public static Guid ManagementActionPointShouldManageEntityRelationshipId { get; } = new Guid("cdb09107-2411-d9e2-d718-e574983d304d");
    #endregion

    #region Microsoft.SystemCenter.ManagementActionPointManagesEntity
    /// <summary>
    ///  (Microsoft.SystemCenter.ManagementActionPointManagesEntity)
    /// </summary>
    public static Guid ManagementActionPointManagesEntityRelationshipId { get; } = new Guid("cb72a458-d56e-3be8-950b-955b16f2f6a2");
    #endregion

    #region Microsoft.SystemCenter.HealthServiceCommunication
    /// <summary>
    /// Health Service Communication (Microsoft.SystemCenter.HealthServiceCommunication)
    /// </summary>
    public static Guid HealthServiceCommunicationRelationshipId { get; } = new Guid("37848e16-37a2-b81b-daaf-60a5a626be93");

    public static class HealthServiceCommunicationClassProperties
    {
      /// <summary>
      /// Microsoft.SystemCenter.HealthServiceCommunication/CanEstablishConnectionTo
      /// </summary>
      public static Guid CanEstablishConnectionToPropertyId { get; } = new Guid("f3f1e4c9-e9be-3c82-e4d8-9d3b7b641034");
      /// <summary>
      /// Microsoft.SystemCenter.HealthServiceCommunication/HeartbeatType
      /// </summary>
      public static Guid HeartbeatTypePropertyId { get; } = new Guid("1d854446-c633-968e-a220-53dc4b0770f2");
      /// <summary>
      /// Microsoft.SystemCenter.HealthServiceCommunication/MaxBytesPerSecondToSend
      /// </summary>
      public static Guid MaxBytesPerSecondToSendPropertyId { get; } = new Guid("7b9b1d6d-cdd3-b742-fe1e-ef0971c40761");
      /// <summary>
      /// Microsoft.SystemCenter.HealthServiceCommunication/NetworkTimeout
      /// </summary>
      public static Guid NetworkTimeoutPropertyId { get; } = new Guid("869a3a95-f21c-6556-65f0-07b0fc9d3a74");
      /// <summary>
      /// Microsoft.SystemCenter.HealthServiceCommunication/OrderOfPreference
      /// </summary>
      public static Guid OrderOfPreferencePropertyId { get; } = new Guid("18a3814f-959f-75a7-e3ae-6dc579bfe8b6");
    }
    #endregion
  }
}