// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableStoragePoolArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableStoragePoolArmClient"/> class for mocking. </summary>
        protected MockableStoragePoolArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableStoragePoolArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableStoragePoolArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableStoragePoolArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="DiskPoolResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DiskPoolResource.CreateResourceIdentifier" /> to create a <see cref="DiskPoolResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskPoolResource"/> object. </returns>
        public virtual DiskPoolResource GetDiskPoolResource(ResourceIdentifier id)
        {
            DiskPoolResource.ValidateResourceId(id);
            return new DiskPoolResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DiskPoolIscsiTargetResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DiskPoolIscsiTargetResource.CreateResourceIdentifier" /> to create a <see cref="DiskPoolIscsiTargetResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskPoolIscsiTargetResource"/> object. </returns>
        public virtual DiskPoolIscsiTargetResource GetDiskPoolIscsiTargetResource(ResourceIdentifier id)
        {
            DiskPoolIscsiTargetResource.ValidateResourceId(id);
            return new DiskPoolIscsiTargetResource(Client, id);
        }
    }
}
