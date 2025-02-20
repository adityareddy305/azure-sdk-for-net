// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridContainerService
{
    /// <summary>
    /// A class representing the HybridIdentityMetadata data model.
    /// Defines the hybridIdentityMetadata.
    /// </summary>
    public partial class HybridIdentityMetadataData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="HybridIdentityMetadataData"/>. </summary>
        public HybridIdentityMetadataData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HybridIdentityMetadataData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="resourceUid"> Unique id of the parent provisioned cluster resource. </param>
        /// <param name="publicKey"> Onboarding public key for provisioning the Managed identity for the connected cluster. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HybridIdentityMetadataData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string resourceUid, string publicKey, HybridContainerServiceResourceProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ResourceUid = resourceUid;
            PublicKey = publicKey;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Unique id of the parent provisioned cluster resource. </summary>
        public string ResourceUid { get; set; }
        /// <summary> Onboarding public key for provisioning the Managed identity for the connected cluster. </summary>
        public string PublicKey { get; set; }
        /// <summary> Provisioning state of the resource. </summary>
        public HybridContainerServiceResourceProvisioningState? ProvisioningState { get; }
    }
}
