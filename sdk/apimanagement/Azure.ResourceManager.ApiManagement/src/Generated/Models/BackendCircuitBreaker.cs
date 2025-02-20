// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The configuration of the backend circuit breaker. </summary>
    internal partial class BackendCircuitBreaker
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

        /// <summary> Initializes a new instance of <see cref="BackendCircuitBreaker"/>. </summary>
        public BackendCircuitBreaker()
        {
            Rules = new ChangeTrackingList<CircuitBreakerRule>();
        }

        /// <summary> Initializes a new instance of <see cref="BackendCircuitBreaker"/>. </summary>
        /// <param name="rules"> The rules for tripping the backend. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackendCircuitBreaker(IList<CircuitBreakerRule> rules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Rules = rules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The rules for tripping the backend. </summary>
        [WirePath("rules")]
        public IList<CircuitBreakerRule> Rules { get; }
    }
}
