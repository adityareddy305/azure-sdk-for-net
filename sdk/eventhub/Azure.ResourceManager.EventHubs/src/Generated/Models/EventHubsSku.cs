// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> SKU parameters supplied to the create namespace operation. </summary>
    public partial class EventHubsSku
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

        /// <summary> Initializes a new instance of <see cref="EventHubsSku"/>. </summary>
        /// <param name="name"> Name of this SKU. </param>
        public EventHubsSku(EventHubsSkuName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsSku"/>. </summary>
        /// <param name="name"> Name of this SKU. </param>
        /// <param name="tier"> The billing tier of this particular SKU. </param>
        /// <param name="capacity"> The Event Hubs throughput units for Basic or Standard tiers, where value should be 0 to 20 throughput units. The Event Hubs premium units for Premium tier, where value should be 0 to 10 premium units. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsSku(EventHubsSkuName name, EventHubsSkuTier? tier, int? capacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsSku"/> for deserialization. </summary>
        internal EventHubsSku()
        {
        }

        /// <summary> Name of this SKU. </summary>
        [WirePath("name")]
        public EventHubsSkuName Name { get; set; }
        /// <summary> The billing tier of this particular SKU. </summary>
        [WirePath("tier")]
        public EventHubsSkuTier? Tier { get; set; }
        /// <summary> The Event Hubs throughput units for Basic or Standard tiers, where value should be 0 to 20 throughput units. The Event Hubs premium units for Premium tier, where value should be 0 to 10 premium units. </summary>
        [WirePath("capacity")]
        public int? Capacity { get; set; }
    }
}
