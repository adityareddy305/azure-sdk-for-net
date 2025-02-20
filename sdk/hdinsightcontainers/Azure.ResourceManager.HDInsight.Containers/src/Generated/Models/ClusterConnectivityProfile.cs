// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster connectivity profile. </summary>
    public partial class ClusterConnectivityProfile
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

        /// <summary> Initializes a new instance of <see cref="ClusterConnectivityProfile"/>. </summary>
        /// <param name="web"> Web connectivity endpoint details. </param>
        internal ClusterConnectivityProfile(WebConnectivityEndpoint web)
        {
            Web = web;
            Ssh = new ChangeTrackingList<SshConnectivityEndpoint>();
        }

        /// <summary> Initializes a new instance of <see cref="ClusterConnectivityProfile"/>. </summary>
        /// <param name="web"> Web connectivity endpoint details. </param>
        /// <param name="ssh"> List of SSH connectivity endpoints. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterConnectivityProfile(WebConnectivityEndpoint web, IReadOnlyList<SshConnectivityEndpoint> ssh, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Web = web;
            Ssh = ssh;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterConnectivityProfile"/> for deserialization. </summary>
        internal ClusterConnectivityProfile()
        {
        }

        /// <summary> Web connectivity endpoint details. </summary>
        [WirePath("web")]
        public WebConnectivityEndpoint Web { get; }
        /// <summary> List of SSH connectivity endpoints. </summary>
        [WirePath("ssh")]
        public IReadOnlyList<SshConnectivityEndpoint> Ssh { get; }
    }
}
