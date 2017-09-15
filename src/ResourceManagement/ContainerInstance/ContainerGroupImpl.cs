// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.ContainerInstance.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.ContainerInstance.Fluent.Models;
    using Microsoft.Azure.Management.ContainerInstance.Fluent.ContainerGroup.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Azure.Management.Storage.Fluent;
    using System.Collections.Generic;
    using Microsoft.WindowsAzure.Storage.File;
    using System;

    ///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LmNvbnRhaW5lcmluc3RhbmNlLmltcGxlbWVudGF0aW9uLkNvbnRhaW5lckdyb3VwSW1wbC5UcmlwbGU=
    public partial class Triple<L,M,R> 
    {
        private L leftValue;
        private M middleValue;
        private R rightValue;
        ///GENMHASH:BFE981420F9A1E48AB7C20DC7410EB26:5BBAEC1690FBD54FDC2C20C626EAB540
        internal  Triple(L left, M middle, R right)
        {
            //$ this.leftValue = left;
            //$ this.middleValue = middle;
            //$ this.rightValue = right;
            //$ }

        }

        ///GENMHASH:5D577CD480D73E5B9FF839352AA1D935:39FFDE7860FB43A747CAA93FCBA8596A
        public R GetRight()
        {
            //$ return this.rightValue;
            //$ }

            return default(R);
        }

        ///GENMHASH:FEE9DD5E71B862F41CFA9A4C11BC6F84:5198E0F45948B6BC69A77D7C6ACC3456
        public M GetMiddle()
        {
            //$ return this.middleValue;
            //$ }

            return default(M);
        }

        ///GENMHASH:C6F1DC0D6BD0B807F5C530C67E38E3E8:C156B2CF5195AEB25A0FE2A939DB62FF
        public L GetLeft()
        {
            //$ return this.leftValue;
            //$ }

            return default(L);
        }
    }

    /// <summary>
    /// Implementation for ContainerGroup and its create interfaces.
    /// </summary>
///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LmNvbnRhaW5lcmluc3RhbmNlLmltcGxlbWVudGF0aW9uLkNvbnRhaW5lckdyb3VwSW1wbA==
    internal partial class ContainerGroupImpl  :
        GroupableResource<
            Microsoft.Azure.Management.ContainerInstance.Fluent.IContainerGroup,
            Models.ContainerGroupInner,
            Microsoft.Azure.Management.ContainerInstance.Fluent.ContainerGroupImpl,
            Microsoft.Azure.Management.ContainerInstance.Fluent.IContainerInstanceManager,
            IWithGroup,
            IWithOsType,
            IWithCreate,
            IWithCreate>,
        IContainerGroup
    {
        private IStorageManager storageManager;
        private string creatableStorageAccountKey;
        private Dictionary<string,string> newFileShares;
        private Dictionary<string,Models.Container> containers;
        private Dictionary<string,Models.Volume> volumes;
        private IList<string> imageRegistryServers;
        private int externalTcpPorts;
        private int externalUdpPorts;

        IReadOnlyCollection<string> IContainerGroup.ImageRegistryServers => throw new NotImplementedException();

        IReadOnlyCollection<Port> IContainerGroup.ExternalPorts => throw new NotImplementedException();

        IReadOnlyDictionary<string, Volume> IContainerGroup.Volumes => throw new NotImplementedException();

        string IContainerGroup.IPAddress => throw new NotImplementedException();

        int IContainerGroup.ExternalUdpPorts => throw new NotImplementedException();

        string IContainerGroup.ProvisioningState => throw new NotImplementedException();

        int IContainerGroup.ExternalTcpPorts => throw new NotImplementedException();

        bool IContainerGroup.isAlwaysRestart => throw new NotImplementedException();

        bool IContainerGroup.IsIPAddressPublic => throw new NotImplementedException();

        IReadOnlyDictionary<string, Container> IContainerGroup.Containers => throw new NotImplementedException();

        string IContainerGroup.State => throw new NotImplementedException();

        OSTypeName IContainerGroup.OSType => throw new NotImplementedException();

        ///GENMHASH:9C262E34A24F538EA2B9CCF05B5DDC31:B1054C7ABC568976F407B3F83CBEF497
        public int ExternalTcpPorts()
        {
            //$ return this.externalTcpPorts;

            return 0;
        }

        ///GENMHASH:EE87A5D4CD5A141684404A7DCC098A5E:69C48C874380FD258ED24236ECFF7545
        public bool IsIPAddressPublic()
        {
            //$ return this.Inner.IpAddress() != null && this.Inner.IpAddress().Type().ToLowerCase().Equals("public");

            return false;
        }

        ///GENMHASH:AEE17FD09F624712647F5EBCEC141EA5:99ECDF2C7D842BA7D2742AC2953EDA92
        public string State()
        {
            //$ if (this.Inner.State() != null) {
            //$ return this.Inner.State();
            //$ } else {
            //$ return null;
            //$ }

            return null;
        }

        ///GENMHASH:59B08BD03F2496BDEFB0CB87748CB717:75DE4FE44AED6C1A4FA25A3E81685E01
        public IReadOnlyCollection<string> ImageRegistryServers()
        {
            //$ return Collections.UnmodifiableCollection(this.imageRegistryServers);

            return null;
        }

        ///GENMHASH:48C59AE949E12C01A6C61142D3D2B6C5:213253B61921C0106B8B07DBB056405B
        public IReadOnlyCollection<Models.Port> ExternalPorts()
        {
            //$ if (this.Inner.IpAddress() != null && this.Inner.IpAddress().Ports() != null) {
            //$ return Collections.UnmodifiableCollection(this.Inner.IpAddress().Ports());
            //$ } else {
            //$ return null;
            //$ }

            return null;
        }

        ///GENMHASH:AB09C46CE8F9CA6FA0F625131031E74D:1631EAB8864F459FF3F0235822E771D5
        public IReadOnlyDictionary<string, Models.Volume> Volumes()
        {
            //$ return Collections.UnmodifiableMap(this.volumes);

            return null;
        }

        ///GENMHASH:568B36CDA0227A7F3A32B87E92E09B4D:C12E94C76D9C55968CE90919BD8CF60E
        public IReadOnlyDictionary<string, Models.Container> Containers()
        {
            //$ return Collections.UnmodifiableMap(this.containers);

            return null;
        }

        ///GENMHASH:EB9638E8F65D17F5F594E27D773A247D:9A9A38EC01C4A2143FD55250B964F335
        public string IPAddress()
        {
            //$ if (this.Inner.IpAddress() != null) {
            //$ return this.Inner.IpAddress().Ip();
            //$ } else {
            //$ return null;
            //$ }

            return null;
        }

        ///GENMHASH:B7B94C51823E8E9590CFB5D3B4497C02:0FB59B85F29ED94C51DB36094BBDE1A8
        public int ExternalUdpPorts()
        {
            //$ return this.externalUdpPorts;

            return 0;
        }

        ///GENMHASH:99D5BF64EA8AA0E287C9B6F77AAD6FC4:023E92B4527E4CFAE96195535BADEFE2
        public string ProvisioningState()
        {
            //$ if (this.Inner.ProvisioningState() != null) {
            //$ return this.Inner.ProvisioningState();
            //$ } else {
            //$ return null;
            //$ }

            return null;
        }

        ///GENMHASH:72D8F838766D2FA789A06DBB8ACE4C8C:6688B3D6EDBA6430DBE60C201714B737
        //        public ContainerRestartPolicy RestartPolicy()
        //        {
        ////            return this.RestartPolicy();

        //            return null;
        //        }


        ///GENMHASH:C4B69D63304D818F517794AA4D07AAC6:C2773B13EB9D03F0091114E1241E51EB
        protected ContainerGroupImpl(string name, ContainerGroupInner innerObject, IContainerInstanceManager manager, IStorageManager storageManager)
            : base(name, innerObject, manager)
        {
            this.storageManager = storageManager;
        }

        ///GENMHASH:359B78C1848B4A526D723F29D8C8C558:57298D21D3C56E8C5DD3E2C79149DE00
        protected async Task<Models.ContainerGroupInner> CreateInnerAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            //$ ContainerGroupImpl self = this;
            //$ 
            //$ if (!isInCreateMode()) {
            //$ throw new UnsupportedOperationException("Update on an existing container group resource is not supported");
            //$ } else if (newFileShares == null || creatableStorageAccountKey == null) {
            //$ return this.Manager().Inner.ContainerGroups().CreateOrUpdateAsync(this.ResourceGroupName(), this.Name(), this.Inner);
            //$ } else {
            //$ StorageAccount storageAccount = (StorageAccount) this.CreatedResource(this.creatableStorageAccountKey);
            //$ return createFileShareAsync(storageAccount)
            //$ .Collect(new Func0<List<Triple<String, String, String>>>() {
            //$ @Override
            //$ public List<Triple<String, String, String>> call() {
            //$ return new ArrayList<>();
            //$ }
            //$ }, new Action2<List<Triple<String, String, String>>, Triple<String, String, String>>() {
            //$ @Override
            //$ public void call(List<Triple<String, String, String>> cloudFileShares, Triple<String, String, String> fileShare) {
            //$ cloudFileShares.Add(fileShare);
            //$ }
            //$ })
            //$ .FlatMap(new Func1<List<Triple<String, String, String>>, Observable<? extends ContainerGroupInner>>() {
            //$ @Override
            //$ public Observable<? extends ContainerGroupInner> call(List<Triple<String, String, String>> fileShares) {
            //$ for (Triple<String, String, String> fileShareEntry : fileShares) {
            //$ self.DefineVolume(fileShareEntry.GetLeft())
            //$ .WithExistingReadWriteAzureFileShare(fileShareEntry.GetMiddle())
            //$ .WithStorageAccountName(storageAccount.Name())
            //$ .WithStorageAccountKey(fileShareEntry.GetRight())
            //$ .Attach();
            //$ }
            //$ return self.Manager().Inner.ContainerGroups().CreateOrUpdateAsync(self.ResourceGroupName(), self.Name(), self.Inner);
            //$ }
            //$ });
            //$ }

            return null;
        }

        ///GENMHASH:AC21A10EE2E745A89E94E447800452C1:27E486AB74A10242FF421C0798DDC450
        protected void BeforeCreating()
        {
            //$ 

        }

    
        ///GENMHASH:5A2D79502EDA81E37A36694062AEDC65:30511FD503549EDC455B6D09D542DB93
        public async Task<Microsoft.Azure.Management.ContainerInstance.Fluent.IContainerGroup> RefreshAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            //$ return super.RefreshAsync().Map(new Func1<ContainerGroup, ContainerGroup>() {
            //$ @Override
            //$ public ContainerGroup call(ContainerGroup containerGroup) {
            //$ ContainerGroupImpl impl = (ContainerGroupImpl) containerGroup;
            //$ impl.InitializeChildrenFromInner();
            //$ return impl;
            //$ }
            //$ });

            return null;
        }

        public override Task<IContainerGroup> CreateResourceAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected override Task<ContainerGroupInner> GetInnerAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        ///GENMHASH:F91F57741BB7E185BF012523964DEED0:B855D73B977281A4DC1F154F5A7D4DC5
        protected void AfterCreating()
        {
            //$ initializeChildrenFromInner();

        }

        ///GENMHASH:6D9F740D6D73C56877B02D9F1C96F6E7:40DC8096FB53D9EA447C99B67637E40C
        protected void InitializeChildrenFromInner()
        {
            //$ // Getting the container instances
            //$ this.containers = new HashMap<>();
            //$ if (this.Inner.Containers() != null && this.Inner.Containers().Size() > 0) {
            //$ foreach(var containerInstance in this.Inner.Containers()) {
            //$ this.containers.Put(containerInstance.Name(), containerInstance);
            //$ }
            //$ }
            //$ 
            //$ // Getting the volumes
            //$ this.volumes = new HashMap<>();
            //$ if (this.Inner.Volumes() != null && this.Inner.Volumes().Size() > 0) {
            //$ foreach(var volume in this.Inner.Volumes()) {
            //$ this.volumes.Put(volume.Name(), volume);
            //$ }
            //$ }
            //$ 
            //$ // Getting the private image registry servers
            //$ this.imageRegistryServers = new ArrayList<>();
            //$ if (this.Inner.ImageRegistryCredentials() != null && this.Inner.ImageRegistryCredentials().Size() > 0) {
            //$ foreach(var imageRegistry in this.Inner.ImageRegistryCredentials()) {
            //$ this.imageRegistryServers.Add(imageRegistry.Server());
            //$ }
            //$ }
            //$ 
            //$ // Splitting ports between TCP and UDP ports
            //$ if (this.Inner.IpAddress() != null && this.Inner.IpAddress().Ports() != null) {
            //$ List<Port> tcpPorts = new ArrayList<>();
            //$ List<Port> udpPorts = new ArrayList<>();
            //$ foreach(var port in this.Inner.IpAddress().Ports()) {
            //$ if (port.Protocol().Equals(ContainerGroupNetworkProtocol.TCP)) {
            //$ tcpPorts.Add(port);
            //$ } else if (port.Protocol().Equals(ContainerGroupNetworkProtocol.UDP)) {
            //$ udpPorts.Add(port);
            //$ }
            //$ }
            //$ this.externalTcpPorts = new int[tcpPorts.Size()];
            //$ for (int i = 0; i < this.externalTcpPorts.Length; i++) {
            //$ this.externalTcpPorts[i] = tcpPorts.Get(i).Port();
            //$ }
            //$ this.externalUdpPorts = new int[udpPorts.Size()];
            //$ for (int i = 0; i < this.externalTcpPorts.Length; i++) {
            //$ this.externalTcpPorts[i] = tcpPorts.Get(i).Port();
            //$ }
            //$ } else {
            //$ this.externalTcpPorts = new int[0];
            //$ this.externalUdpPorts = new int[0];
            //$ }

        }


        ///GENMHASH:002B9FED6878745A10FBEF2FDB77458A:4C268D270623A9FCE0E849411F7DACB8
        public ContainerGroupImpl WithLinux()
        {
            //$ this.Inner.WithOsType(OperatingSystemTypes.LINUX);
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:21843F6A42DA7655078B0AAA573930DC:1BB4AF60868C4D62F669F7DFFC20EE87
        public ContainerGroupImpl WithWindows()
        {
            //$ this.Inner.WithOsType(OperatingSystemTypes.WINDOWS);
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:81CB563AFF6AD26FDBD5ADDFA8E9807A:29FFF0E66BE4B91F688014D063FC58D9
        public ContainerGroupImpl WithPrivateImageRegistry(string server, string username, string password)
        {
            //$ if (this.Inner.ImageRegistryCredentials() == null) {
            //$ this.Inner.WithImageRegistryCredentials(new ArrayList<ImageRegistryCredential>());
            //$ }
            //$ this.Inner.ImageRegistryCredentials().Add(new ImageRegistryCredential()
            //$ .WithServer(server)
            //$ .WithUsername(username)
            //$ .WithPassword(password));
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:2CB4C248C39610BBCDFA3C7C13950F51:345DD81D2BBDE0DAE630775246270473
        public ContainerGroupImpl WithPublicImageRegistryOnly()
        {
            //$ this.Inner.WithImageRegistryCredentials(null);
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:C518B06C0BBC9766A09F6FD2432A9CD4:FDC33FB248B626868B54320954852A00
        public VolumeImpl DefineVolume(string name)
        {
            //$ return new VolumeImpl(this, name);

            return null;
        }

        ///GENMHASH:DFC2593B74D1E01275625E2EE80CC9AD:D22668247339DCCC31D9166C946C6AA8
        public ContainerGroupImpl WithNewAzureFileShareVolume(string volumeName, string shareName)
        {
            //$ if (this.newFileShares == null || this.creatableStorageAccountKey == null) {
            //$ StorageAccount.DefinitionStages.WithGroup definitionWithGroup = this.storageManager
            //$ .StorageAccounts()
            //$ .Define(SdkContext.RandomResourceName("fs", 24))
            //$ .WithRegion(this.RegionName());
            //$ Creatable<StorageAccount> creatable;
            //$ if (this.CreatableGroup != null) {
            //$ creatable = definitionWithGroup.WithNewResourceGroup(this.CreatableGroup);
            //$ } else {
            //$ creatable = definitionWithGroup.WithExistingResourceGroup(this.ResourceGroupName());
            //$ }
            //$ this.creatableStorageAccountKey = creatable.Key();
            //$ this.AddCreatableDependency(creatable);
            //$ 
            //$ this.newFileShares = new HashMap<>();
            //$ }
            //$ this.newFileShares.Put(volumeName, shareName);
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:F0C4F6A7F84296DE6B5B22E9CD83088B:3AA393F2B1A370FDC3C77E87951AD500
        public ContainerGroupImpl WithoutVolume()
        {
            //$ this.Inner.WithVolumes(null);
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:7094AF382C96EC7FD1063D04C15909E0:176B8A1880E543242F8EA2343BF2B436
        public ContainerImpl DefineContainerInstance(string name)
        {
            //$ return new ContainerImpl(this, name);

            return null;
        }

        ///GENMHASH:A56B900EF7111F72F47E8873EAB80EC5:D0617CA076D9D9042A7EB6FB9E67995F
        public ContainerGroupImpl WithContainerInstance(string imageName)
        {
            //$ return this.DefineContainerInstance(this.Name())
            //$ .WithImage(imageName)
            //$ .WithoutPorts()
            //$ .WithCpuCoreCount(1)
            //$ .WithMemorySizeInGB(1.5)
            //$ .Attach();

            return this;
        }

        ///GENMHASH:95D94B5131D92BA7AF72C28CE506404B:B731C6B2B19E78D26B13FB71FBD36ECF
        public ContainerGroupImpl WithContainerInstance(string imageName, int port)
        {
            //$ return this.DefineContainerInstance(this.Name())
            //$ .WithImage(imageName)
            //$ .WithExternalTcpPort(port)
            //$ .WithCpuCoreCount(1)
            //$ .WithMemorySizeInGB(1.5)
            //$ .Attach();

            return this;
        }

        ///GENMHASH:A635F03FFAADE336D939009842628798:E4F21E5AA474849623AE0FF3F5A6EBBC
        private async Task<Microsoft.Azure.Management.ContainerInstance.Fluent.Triple<string,string,string>> CreateSingleFileShareAsync(CloudFileClient client, string volumeName, string fileShareName, string storageAccountKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            //$ return Observable.FromCallable(new Callable<Triple<String, String, String>>() {
            //$ @Override
            //$ public Triple<String, String, String> call() throws Exception {
            //$ CloudFileShare cloudFileShare = client.GetShareReference(fileShareName);
            //$ cloudFileShare.CreateIfNotExists();
            //$ 
            //$ return new Triple<>(volumeName, fileShareName, storageAccountKey);
            //$ }
            //$ });
            //$ }

            return null;
        }

        ///GENMHASH:5539452FF37A2039D171B77EAB519674:F662BD68539B03381406F317464C0B00
        public string GetLogContent(string containerName)
        {
            return this.Manager.Inner.ContainerLogs.List(this.ResourceGroupName, containerName, this.Name).Content;
        }

        ///GENMHASH:E56134B3DD31D67F07D4B5EDC1D24FD7:137080B7ED8C37E287C17CC77224DECA
        public string GetLogContent(string containerName, int tailLineCount)
        {
            return this.Manager.Inner.ContainerLogs.List(this.ResourceGroupName, containerName, this.Name, tailLineCount).Content;
        }

        ///GENMHASH:68FA359B278647E097B20441389A58FC:3119C16FFA0F521767097C339920EE47
        public async Task<string> GetLogContentAsync(string containerName, CancellationToken cancellationToken = default(CancellationToken))
        {
            var log = await this.Manager.Inner.ContainerLogs.ListAsync(this.ResourceGroupName, containerName, this.Name, cancellationToken : cancellationToken);
            return log.Content;
        }

        ///GENMHASH:FF17FE4F8B9A7B52DB8052C65778E9B1:62A00FD4D8AED790BA6A5B89296698FF
        public async Task<string> GetLogContentAsync(string containerName, int tailLineCount, CancellationToken cancellationToken = default(CancellationToken))
        {
            var log = await this.Manager.Inner.ContainerLogs.ListAsync(this.ResourceGroupName, containerName, this.Name, tailLineCount, cancellationToken);
            return log.Content;
        }

        ///GENMHASH:53CA8D40ECB27A5C5EB44F72E8E14045:D07194F262EB31D2A263802100EE423F
        private async Task<Microsoft.Azure.Management.ContainerInstance.Fluent.Triple<string, string, string>> CreateFileShareAsync(IStorageAccount storageAccount, CancellationToken cancellationToken = default(CancellationToken))
        {
            //$ return storageAccount.GetKeysAsync()
            //$ .Map(new Func1<List<StorageAccountKey>, String>() {
            //$ @Override
            //$ public String call(List<StorageAccountKey> storageAccountKeys) {
            //$ return storageAccountKeys.Get(0).Value();
            //$ }
            //$ })
            //$ .FlatMap(new Func1<String, Observable<Triple<String, String, String>>>() {
            //$ CloudFileClient cloudFileClient;
            //$ @Override
            //$ public Observable<Triple<String, String, String>> call( String storageAccountKey) {
            //$ try {
            //$ cloudFileClient = CloudStorageAccount.Parse(String.Format("DefaultEndpointsProtocol=https;AccountName=%s;AccountKey=%s;EndpointSuffix=core.Windows.Net",
            //$ storageAccount.Name(),
            //$ storageAccountKey))
            //$ .CreateCloudFileClient();
            //$ } catch (URISyntaxException syntaxException) {
            //$ throw Exceptions.Propagate(syntaxException);
            //$ } catch (InvalidKeyException keyException) {
            //$ throw Exceptions.Propagate(keyException);
            //$ }
            //$ return Observable.From(newFileShares.EntrySet())
            //$ .FlatMap(new Func1<Map.Entry<String, String>, Observable<Triple<String, String, String>>>() {
            //$ @Override
            //$ public Observable<Triple<String, String, String>> call(Map.Entry<String, String> fileShareEntry) {
            //$ return createSingleFileShareAsync(cloudFileClient, fileShareEntry.GetKey(), fileShareEntry.GetValue(), storageAccountKey);
            //$ }
            //$ });
            //$ }
            //$ });
            //$ }

            return null;
        }
    }
}