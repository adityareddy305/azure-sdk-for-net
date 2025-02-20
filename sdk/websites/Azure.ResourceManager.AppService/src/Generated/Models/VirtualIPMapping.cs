// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Virtual IP mapping. </summary>
    public partial class VirtualIPMapping
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

        /// <summary> Initializes a new instance of <see cref="VirtualIPMapping"/>. </summary>
        public VirtualIPMapping()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualIPMapping"/>. </summary>
        /// <param name="virtualIP"> Virtual IP address. </param>
        /// <param name="internalHttpPort"> Internal HTTP port. </param>
        /// <param name="internalHttpsPort"> Internal HTTPS port. </param>
        /// <param name="isInUse"> Is virtual IP mapping in use. </param>
        /// <param name="serviceName"> name of the service that virtual IP is assigned to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualIPMapping(string virtualIP, int? internalHttpPort, int? internalHttpsPort, bool? isInUse, string serviceName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VirtualIP = virtualIP;
            InternalHttpPort = internalHttpPort;
            InternalHttpsPort = internalHttpsPort;
            IsInUse = isInUse;
            ServiceName = serviceName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Virtual IP address. </summary>
        [WirePath("virtualIP")]
        public string VirtualIP { get; set; }
        /// <summary> Internal HTTP port. </summary>
        [WirePath("internalHttpPort")]
        public int? InternalHttpPort { get; set; }
        /// <summary> Internal HTTPS port. </summary>
        [WirePath("internalHttpsPort")]
        public int? InternalHttpsPort { get; set; }
        /// <summary> Is virtual IP mapping in use. </summary>
        [WirePath("inUse")]
        public bool? IsInUse { get; set; }
        /// <summary> name of the service that virtual IP is assigned to. </summary>
        [WirePath("serviceName")]
        public string ServiceName { get; set; }
    }
}
