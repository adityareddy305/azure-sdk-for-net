// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> The updatable properties of the OracleSubscription. </summary>
    public partial class OracleSubscriptionUpdateProperties
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

        /// <summary> Initializes a new instance of <see cref="OracleSubscriptionUpdateProperties"/>. </summary>
        public OracleSubscriptionUpdateProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OracleSubscriptionUpdateProperties"/>. </summary>
        /// <param name="productCode"> Product code for the term unit. </param>
        /// <param name="intent"> Intent for the update operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OracleSubscriptionUpdateProperties(string productCode, OracleSubscriptionUpdateIntent? intent, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProductCode = productCode;
            Intent = intent;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Product code for the term unit. </summary>
        public string ProductCode { get; set; }
        /// <summary> Intent for the update operation. </summary>
        public OracleSubscriptionUpdateIntent? Intent { get; set; }
    }
}
