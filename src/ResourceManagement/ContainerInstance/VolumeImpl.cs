// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.ContainerInstance.Fluent
{
    using Microsoft.Azure.Management.ContainerInstance.Fluent.Models;
    using Microsoft.Azure.Management.ContainerInstance.Fluent.ContainerGroup.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Definition;

    /// <summary>
    /// Implementation for container group's volume definition stages interface.
    /// </summary>
///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LmNvbnRhaW5lcmluc3RhbmNlLmltcGxlbWVudGF0aW9uLlZvbHVtZUltcGw=
    internal partial class VolumeImpl  :
        IVolumeDefinition<ContainerGroup.Definition.IWithVolume>
    {
        private Volume innerVolume;
        private ContainerGroupImpl parent;
        ///GENMHASH:806528B4E8306F96D8D8B59FBEEC50D9:92DE3D44A00B96B446737E32FB695D1A
        private AzureFileVolume EnsureAzureFileVolume()
        {
            //$ if (innerVolume.AzureFile() == null) {
            //$ innerVolume.WithAzureFile(new AzureFileVolume());
            //$ }
            //$ 
            //$ return innerVolume.AzureFile();
            //$ }

            return null;
        }

        ///GENMHASH:58AD2109DE49A21089D219327AB34729:A24F436CF7F24D91E89F7155872C668C
        internal  VolumeImpl(ContainerGroupImpl parent, string volumeName)
        {
            //$ this.parent = parent;
            //$ this.innerVolume = new Volume().WithName(volumeName);
            //$ }

        }

        ///GENMHASH:1D5A37DFB991B90DE83B301E1FCB379E:025288B52D0EDDFBEC55734236D78DEC
        public VolumeImpl WithStorageAccountName(string storageAccountName)
        {
            //$ ensureAzureFileVolume().WithStorageAccountName(storageAccountName);
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:9467EFF6B0BC2CE3447C4AAC840262AE:8FDCDE287ED3A18DF7EE774EC05B2634
        public VolumeImpl WithExistingReadWriteAzureFileShare(string shareName)
        {
            //$ ensureAzureFileVolume()
            //$ .WithReadOnly(false)
            //$ .WithShareName(shareName);
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:C3BEE33E51121CBAF2861DB3C9FE8E00:FD1669E86C4F7C3C91337F9EBBB7A285
        public VolumeImpl WithStorageAccountKey(string storageAccountKey)
        {
            //$ ensureAzureFileVolume().WithStorageAccountKey(storageAccountKey);
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:F75F8EB1FB5E69A3305EC890FAE92837:21284A740F71497AF7DB2358141743F9
        public VolumeImpl WithExistingReadOnlyAzureFileShare(string shareName)
        {
            //$ ensureAzureFileVolume()
            //$ .WithReadOnly(true)
            //$ .WithShareName(shareName);
            //$ 
            //$ return this;

            return this;
        }

        ///GENMHASH:077EB7776EFFBFAA141C1696E75EF7B3:9F82274A47A307BCD4EFC0D2AFD33F1B
        public ContainerGroupImpl Attach()
        {
            //$ if (parent.Inner.Volumes() == null) {
            //$ parent.Inner.WithVolumes(new ArrayList<Volume>());
            //$ }
            //$ parent.Inner.Volumes().Add(innerVolume);
            //$ 
            //$ return parent;

            return null;
        }
    }
}