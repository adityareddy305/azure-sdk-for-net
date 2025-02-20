// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DeviceProvisioningServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceProvisioningServices
{
    /// <summary>
    /// A class representing the DeviceProvisioningService data model.
    /// The description of the provisioning service.
    /// </summary>
    public partial class DeviceProvisioningServiceData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServiceData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Service specific properties for a provisioning service. </param>
        /// <param name="sku"> Sku info for a provisioning Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> or <paramref name="sku"/> is null. </exception>
        public DeviceProvisioningServiceData(AzureLocation location, DeviceProvisioningServiceProperties properties, DeviceProvisioningServicesSkuInfo sku) : base(location)
        {
            Argument.AssertNotNull(properties, nameof(properties));
            Argument.AssertNotNull(sku, nameof(sku));

            Properties = properties;
            Sku = sku;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention. </param>
        /// <param name="properties"> Service specific properties for a provisioning service. </param>
        /// <param name="sku"> Sku info for a provisioning Service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceProvisioningServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, DeviceProvisioningServiceProperties properties, DeviceProvisioningServicesSkuInfo sku, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            Properties = properties;
            Sku = sku;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServiceData"/> for deserialization. </summary>
        internal DeviceProvisioningServiceData()
        {
        }

        /// <summary> The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Service specific properties for a provisioning service. </summary>
        public DeviceProvisioningServiceProperties Properties { get; set; }
        /// <summary> Sku info for a provisioning Service. </summary>
        public DeviceProvisioningServicesSkuInfo Sku { get; set; }
    }
}
