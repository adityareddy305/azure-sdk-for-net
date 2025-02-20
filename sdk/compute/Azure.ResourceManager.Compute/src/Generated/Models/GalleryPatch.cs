// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the Shared Image Gallery that you want to update. </summary>
    public partial class GalleryPatch : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GalleryPatch"/>. </summary>
        public GalleryPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="GalleryPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> The identity of the gallery, if configured. </param>
        /// <param name="description"> The description of this Shared Image Gallery resource. This property is updatable. </param>
        /// <param name="identifier"> Describes the gallery unique name. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="sharingProfile"> Profile for gallery sharing to subscription or tenant. </param>
        /// <param name="softDeletePolicy"> Contains information about the soft deletion policy of the gallery. </param>
        /// <param name="sharingStatus"> Sharing status of current gallery. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedServiceIdentity identity, string description, GalleryIdentifier identifier, GalleryProvisioningState? provisioningState, SharingProfile sharingProfile, SoftDeletePolicy softDeletePolicy, SharingStatus sharingStatus, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Identity = identity;
            Description = description;
            Identifier = identifier;
            ProvisioningState = provisioningState;
            SharingProfile = sharingProfile;
            SoftDeletePolicy = softDeletePolicy;
            SharingStatus = sharingStatus;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The identity of the gallery, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The description of this Shared Image Gallery resource. This property is updatable. </summary>
        public string Description { get; set; }
        /// <summary> Describes the gallery unique name. </summary>
        internal GalleryIdentifier Identifier { get; set; }
        /// <summary> The unique name of the Shared Image Gallery. This name is generated automatically by Azure. </summary>
        public string IdentifierUniqueName
        {
            get => Identifier is null ? default : Identifier.UniqueName;
        }

        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryProvisioningState? ProvisioningState { get; }
        /// <summary> Profile for gallery sharing to subscription or tenant. </summary>
        public SharingProfile SharingProfile { get; set; }
        /// <summary> Contains information about the soft deletion policy of the gallery. </summary>
        internal SoftDeletePolicy SoftDeletePolicy { get; set; }
        /// <summary> Enables soft-deletion for resources in this gallery, allowing them to be recovered within retention time. </summary>
        public bool? IsSoftDeleteEnabled
        {
            get => SoftDeletePolicy is null ? default : SoftDeletePolicy.IsSoftDeleteEnabled;
            set
            {
                if (SoftDeletePolicy is null)
                    SoftDeletePolicy = new SoftDeletePolicy();
                SoftDeletePolicy.IsSoftDeleteEnabled = value;
            }
        }

        /// <summary> Sharing status of current gallery. </summary>
        public SharingStatus SharingStatus { get; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
