// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Read-write endpoint of the failover group instance. </summary>
    public partial class FailoverGroupReadWriteEndpoint
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

        /// <summary> Initializes a new instance of <see cref="FailoverGroupReadWriteEndpoint"/>. </summary>
        /// <param name="failoverPolicy"> Failover policy of the read-write endpoint for the failover group. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </param>
        public FailoverGroupReadWriteEndpoint(ReadWriteEndpointFailoverPolicy failoverPolicy)
        {
            FailoverPolicy = failoverPolicy;
        }

        /// <summary> Initializes a new instance of <see cref="FailoverGroupReadWriteEndpoint"/>. </summary>
        /// <param name="failoverPolicy"> Failover policy of the read-write endpoint for the failover group. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </param>
        /// <param name="failoverWithDataLossGracePeriodMinutes"> Grace period before failover with data loss is attempted for the read-write endpoint. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FailoverGroupReadWriteEndpoint(ReadWriteEndpointFailoverPolicy failoverPolicy, int? failoverWithDataLossGracePeriodMinutes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FailoverPolicy = failoverPolicy;
            FailoverWithDataLossGracePeriodMinutes = failoverWithDataLossGracePeriodMinutes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FailoverGroupReadWriteEndpoint"/> for deserialization. </summary>
        internal FailoverGroupReadWriteEndpoint()
        {
        }

        /// <summary> Failover policy of the read-write endpoint for the failover group. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </summary>
        [WirePath("failoverPolicy")]
        public ReadWriteEndpointFailoverPolicy FailoverPolicy { get; set; }
        /// <summary> Grace period before failover with data loss is attempted for the read-write endpoint. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required. </summary>
        [WirePath("failoverWithDataLossGracePeriodMinutes")]
        public int? FailoverWithDataLossGracePeriodMinutes { get; set; }
    }
}
