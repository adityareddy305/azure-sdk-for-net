// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The connectivity check operation destination. </summary>
    public partial class ConnectivityCheckRequestDestination
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

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckRequestDestination"/>. </summary>
        /// <param name="address"> Destination address. Can either be an IP address or a FQDN. </param>
        /// <param name="port"> Destination port. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="address"/> is null. </exception>
        public ConnectivityCheckRequestDestination(string address, long port)
        {
            Argument.AssertNotNull(address, nameof(address));

            Address = address;
            Port = port;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckRequestDestination"/>. </summary>
        /// <param name="address"> Destination address. Can either be an IP address or a FQDN. </param>
        /// <param name="port"> Destination port. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectivityCheckRequestDestination(string address, long port, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Address = address;
            Port = port;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckRequestDestination"/> for deserialization. </summary>
        internal ConnectivityCheckRequestDestination()
        {
        }

        /// <summary> Destination address. Can either be an IP address or a FQDN. </summary>
        [WirePath("address")]
        public string Address { get; }
        /// <summary> Destination port. </summary>
        [WirePath("port")]
        public long Port { get; }
    }
}
