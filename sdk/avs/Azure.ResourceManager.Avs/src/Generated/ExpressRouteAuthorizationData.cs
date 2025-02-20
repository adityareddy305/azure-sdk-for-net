// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the ExpressRouteAuthorization data model.
    /// ExpressRoute Circuit Authorization
    /// </summary>
    public partial class ExpressRouteAuthorizationData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ExpressRouteAuthorizationData"/>. </summary>
        public ExpressRouteAuthorizationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteAuthorizationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The state of the ExpressRoute Circuit Authorization provisioning. </param>
        /// <param name="expressRouteAuthorizationId"> The ID of the ExpressRoute Circuit Authorization. </param>
        /// <param name="expressRouteAuthorizationKey"> The key of the ExpressRoute Circuit Authorization. </param>
        /// <param name="expressRouteId"> The ID of the ExpressRoute Circuit. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpressRouteAuthorizationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ExpressRouteAuthorizationProvisioningState? provisioningState, ResourceIdentifier expressRouteAuthorizationId, string expressRouteAuthorizationKey, ResourceIdentifier expressRouteId, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            ExpressRouteAuthorizationId = expressRouteAuthorizationId;
            ExpressRouteAuthorizationKey = expressRouteAuthorizationKey;
            ExpressRouteId = expressRouteId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The state of the ExpressRoute Circuit Authorization provisioning. </summary>
        public ExpressRouteAuthorizationProvisioningState? ProvisioningState { get; }
        /// <summary> The ID of the ExpressRoute Circuit Authorization. </summary>
        public ResourceIdentifier ExpressRouteAuthorizationId { get; }
        /// <summary> The key of the ExpressRoute Circuit Authorization. </summary>
        public string ExpressRouteAuthorizationKey { get; }
        /// <summary> The ID of the ExpressRoute Circuit. </summary>
        public ResourceIdentifier ExpressRouteId { get; set; }
    }
}
