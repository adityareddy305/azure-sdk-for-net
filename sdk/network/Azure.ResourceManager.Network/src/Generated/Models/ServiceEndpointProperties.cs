// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The service endpoint properties. </summary>
    public partial class ServiceEndpointProperties
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

        /// <summary> Initializes a new instance of <see cref="ServiceEndpointProperties"/>. </summary>
        public ServiceEndpointProperties()
        {
            Locations = new ChangeTrackingList<AzureLocation>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceEndpointProperties"/>. </summary>
        /// <param name="service"> The type of the endpoint service. </param>
        /// <param name="networkIdentifier"> SubResource as network identifier. </param>
        /// <param name="locations"> A list of locations. </param>
        /// <param name="provisioningState"> The provisioning state of the service endpoint resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceEndpointProperties(string service, WritableSubResource networkIdentifier, IList<AzureLocation> locations, NetworkProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Service = service;
            NetworkIdentifier = networkIdentifier;
            Locations = locations;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of the endpoint service. </summary>
        public string Service { get; set; }
        /// <summary> SubResource as network identifier. </summary>
        internal WritableSubResource NetworkIdentifier { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier NetworkIdentifierId
        {
            get => NetworkIdentifier is null ? default : NetworkIdentifier.Id;
            set
            {
                if (NetworkIdentifier is null)
                    NetworkIdentifier = new WritableSubResource();
                NetworkIdentifier.Id = value;
            }
        }

        /// <summary> A list of locations. </summary>
        public IList<AzureLocation> Locations { get; }
        /// <summary> The provisioning state of the service endpoint resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
