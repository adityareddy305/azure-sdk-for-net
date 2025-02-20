// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The response from the List namespace operation. </summary>
    public partial class EventHubsNetworkRuleSetIPRules
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

        /// <summary> Initializes a new instance of <see cref="EventHubsNetworkRuleSetIPRules"/>. </summary>
        public EventHubsNetworkRuleSetIPRules()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsNetworkRuleSetIPRules"/>. </summary>
        /// <param name="ipMask"> IP Mask. </param>
        /// <param name="action"> The IP Filter Action. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsNetworkRuleSetIPRules(string ipMask, EventHubsNetworkRuleIPAction? action, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPMask = ipMask;
            Action = action;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> IP Mask. </summary>
        [WirePath("ipMask")]
        public string IPMask { get; set; }
        /// <summary> The IP Filter Action. </summary>
        [WirePath("action")]
        public EventHubsNetworkRuleIPAction? Action { get; set; }
    }
}
