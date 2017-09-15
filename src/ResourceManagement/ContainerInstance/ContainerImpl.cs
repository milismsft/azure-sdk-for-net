// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.ContainerInstance.Fluent
{
    using Microsoft.Azure.Management.ContainerInstance.Fluent.Models;
    using Microsoft.Azure.Management.ContainerInstance.Fluent.ContainerGroup.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Definition;
    using System.Collections.Generic;

    /// <summary>
    /// Implementation for container group's container instance definition stages interface.
    /// </summary>
///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LmNvbnRhaW5lcmluc3RhbmNlLmltcGxlbWVudGF0aW9uLkNvbnRhaW5lckltcGw=
    internal partial class ContainerImpl  :
        IContainerInstanceDefinition<ContainerGroup.Definition.IWithNextContainerInstance>
    {
        private Container innerContainer;
        private ContainerGroupImpl parent;
        ///GENMHASH:66555EBBCC30DB300A281ACB6763E593:EF245C15D3BC1329A06611AC25E2D70E
        public ContainerImpl WithMemorySizeInGB(double memorySize)
        {
            //$ innerContainer.Resources().Requests().WithMemoryInGB(memorySize);
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:5C76B193E83BD7C58CB6E3753DA88310:6C24A584F86F20A464F4F419490DEED5
        public ContainerImpl WithExternalTcpPort(int port)
        {
            //$ ensureParentIpAddress().Ports().Add(new Port()
            //$ .WithPort(port)
            //$ .WithProtocol(ContainerGroupNetworkProtocol.TCP));
            //$ this.WithInternalPort(port);
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:446B156BB626194DD2A3F46642818AF8:7E9223FA05AAC7124FF7DD1B2ECE1797
        public ContainerImpl WithEnvironmentVariable(string envName, string envValue)
        {
            //$ if (innerContainer.EnvironmentVariables() == null) {
            //$ innerContainer.WithEnvironmentVariables(new ArrayList<EnvironmentVariable>());
            //$ }
            //$ 
            //$ innerContainer.EnvironmentVariables().Add(new EnvironmentVariable()
            //$ .WithName(envName)
            //$ .WithValue(envValue));
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:0872885322A92A458CDD1D6B2ACC4C4F:AC06F5B158CD4065B62D1154DB162932
        public ContainerImpl WithInternalPort(int port)
        {
            //$ if (innerContainer.Ports() == null) {
            //$ innerContainer.WithPorts(new ArrayList<ContainerPort>());
            //$ }
            //$ innerContainer.Ports().Add(new ContainerPort().WithPort(port));
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:046712950623ACD1BE6F242ECEA8CA2B:398852805A9A50C5F3D83D0DCCC0142C
        public ContainerImpl WithVolumeMountSetting(string volumeName, string mountPath)
        {
            //$ if (innerContainer.VolumeMounts() == null) {
            //$ innerContainer.WithVolumeMounts(new ArrayList<VolumeMount>());
            //$ }
            //$ innerContainer.VolumeMounts().Add(new VolumeMount()
            //$ .WithName(volumeName)
            //$ .WithMountPath(mountPath)
            //$ .WithReadOnly(false));
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:8ABB3E5D5803F586B91B990EA36AE378:D515D10749D44D79BD96BB55771F1497
        public ContainerImpl WithVolumeMountSetting(IDictionary<string,string> volumeMountSetting)
        {
            //$ for (Map.Entry<String, String> entry : volumeMountSetting.EntrySet()) {
            //$ this.WithVolumeMountSetting(entry.GetKey(), entry.GetValue());
            //$ }
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:91ACBA4EF9239B3539C75B731EE1A8F0:BCAEDD042F54F396515C9FB79928D6D2
        public ContainerImpl WithExternalTcpPorts(params int[] ports)
        {
            //$ foreach(var port in ports) {
            //$ this.WithExternalTcpPort(port);
            //$ }
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:48D52F8A8C40347416FAC933CA8B4D2C:30647CF2486187FF144A4DA12361D549
        public ContainerImpl WithStartingCommandLine(string commandLine)
        {
            //$ if (innerContainer.Command() == null) {
            //$ innerContainer.WithCommand(new ArrayList<String>());
            //$ }
            //$ innerContainer.Command().Add(commandLine);
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:2D9601410B12651FBB952BA561EE10EC:B1EA24166F4859A8E0303EC071E7F22D
        public ContainerImpl WithEnvironmentVariables(IDictionary<string,string> environmentVariables)
        {
            //$ for (Map.Entry<String, String> entry : environmentVariables.EntrySet()) {
            //$ this.WithEnvironmentVariable(entry.GetKey(), entry.GetValue());
            //$ }
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:6428E7659CEA7CB8569742940D144B5C:C64852F349A25A3E24359DF90B113729
        public ContainerImpl WithStartingCommandLines(params string[] commandLines)
        {
            //$ foreach(var command in commandLines) {
            //$ this.WithStartingCommandLine(command);
            //$ }
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:16A81C8C13231E12EF7D9BF49401DF38:5AA37F80972D4D18478D0DDA9FC24A42
        public ContainerImpl WithReadOnlyVolumeMountSetting(string volumeName, string mountPath)
        {
            //$ if (innerContainer.VolumeMounts() == null) {
            //$ innerContainer.WithVolumeMounts(new ArrayList<VolumeMount>());
            //$ }
            //$ innerContainer.VolumeMounts().Add(new VolumeMount()
            //$ .WithName(volumeName)
            //$ .WithMountPath(mountPath)
            //$ .WithReadOnly(true));
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:A9873093FBB421FA3185083488FA7694:F7F3BA844B4500E1397BCD435F887C08
        public ContainerImpl WithReadOnlyVolumeMountSetting(IDictionary<string,string> volumeMountSetting)
        {
            //$ for (Map.Entry<String, String> entry : volumeMountSetting.EntrySet()) {
            //$ this.WithReadOnlyVolumeMountSetting(entry.GetKey(), entry.GetValue());
            //$ }
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:86A8DD73E8E5FB035D1594F42AE63086:E2A08C9A4C8D1AADB006C21DDA7D4669
        private IpAddress EnsureParentIpAddress()
        {
            //$ if (parent.Inner.IpAddress() == null) {
            //$ parent.Inner.WithIpAddress(new IpAddress()
            //$ .WithType("Public")
            //$ .WithPorts(new ArrayList<Port>()));
            //$ }
            //$ 
            //$ return parent.Inner.IpAddress();
            //$ }

            return null;
        }

        ///GENMHASH:F663DDC5E764903CF07E3C769F5B7219:E61F400F3796C466695A0745EFC7BBF6
        public ContainerImpl WithoutPorts()
        {
            //$ innerContainer.WithPorts(null);
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:75C9253FF3F9500CD3DBE3B10C7B770E:5E9ACDDAC6AA38C75542D99D3000D173
        public ContainerImpl WithInternalPorts(params int[] ports)
        {
            //$ foreach(var port in ports) {
            //$ this.WithInternalPort(port);
            //$ }
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:C933388CFB7191BAD7DAA84EAED418CE:909C9049FD102EC104827552A0DCB4C7
        internal  ContainerImpl(ContainerGroupImpl parent, string containerName)
        {
            //$ this.parent = parent;
            //$ this.innerContainer = new Container()
            //$ .WithName(containerName)
            //$ .WithResources(new ResourceRequirements()
            //$ .WithRequests(new ResourceRequests()
            //$ .WithCpu(1)
            //$ .WithMemoryInGB(1.5)));
            //$ }

        }

        ///GENMHASH:978BA481A95BA4EC59306DDACC86F9BA:5176CC4FDCE41FA746260903484F5362
        public ContainerImpl WithExternalUdpPorts(params int[] ports)
        {
            //$ foreach(var port in ports) {
            //$ this.WithExternalUdpPort(port);
            //$ }
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:9FBAE3BDB53ED1FCA497427C24464DAD:F26FBB613297995A238509A393A0891F
        public ContainerImpl WithImage(string imageName)
        {
            //$ innerContainer.WithImage(imageName);
            //$ return this;

            return this;
        }

        ///GENMHASH:077EB7776EFFBFAA141C1696E75EF7B3:3096C005BF39DD1EA35957AEE106323D
        public ContainerGroupImpl Attach()
        {
            //$ if (parent.Inner.Containers() == null) {
            //$ parent.Inner.WithContainers(new ArrayList<Container>());
            //$ }
            //$ parent.Inner.Containers().Add(innerContainer);
            //$ 
            //$ return parent;

            return null;
        }

        ///GENMHASH:6B6898D7A5AE8278A914F38202CF0BDE:3B16DF64D0E82B78899E309718ACE475
        public ContainerImpl WithExternalUdpPort(int port)
        {
            //$ ensureParentIpAddress().Ports().Add(new Port()
            //$ .WithPort(port)
            //$ .WithProtocol(ContainerGroupNetworkProtocol.UDP));
            //$ this.WithInternalPort(port);
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:9DAFEBCA163A39F7BCF392B037E68577:C89E448B1FAF974B467890B30223E23C
        public ContainerImpl WithCpuCoreCount(double cpuCoreCount)
        {
            //$ innerContainer.Resources().Requests().WithCpu(cpuCoreCount);
            //$ 
            //$ return this;

            return this;
        }
    }
}