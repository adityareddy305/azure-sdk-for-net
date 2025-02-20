// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Input for testing route. </summary>
    public partial class IotHubTestRouteContent
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

        /// <summary> Initializes a new instance of <see cref="IotHubTestRouteContent"/>. </summary>
        /// <param name="route"> Route properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="route"/> is null. </exception>
        public IotHubTestRouteContent(RoutingRuleProperties route)
        {
            Argument.AssertNotNull(route, nameof(route));

            Route = route;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubTestRouteContent"/>. </summary>
        /// <param name="message"> Routing message. </param>
        /// <param name="route"> Route properties. </param>
        /// <param name="twin"> Routing Twin Reference. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubTestRouteContent(RoutingMessage message, RoutingRuleProperties route, RoutingTwin twin, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Message = message;
            Route = route;
            Twin = twin;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubTestRouteContent"/> for deserialization. </summary>
        internal IotHubTestRouteContent()
        {
        }

        /// <summary> Routing message. </summary>
        public RoutingMessage Message { get; set; }
        /// <summary> Route properties. </summary>
        public RoutingRuleProperties Route { get; }
        /// <summary> Routing Twin Reference. </summary>
        public RoutingTwin Twin { get; set; }
    }
}
