// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Kubernetes cluster configuration. </summary>
    public partial class EdgeKubernetesClusterInfo
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

        /// <summary> Initializes a new instance of <see cref="EdgeKubernetesClusterInfo"/>. </summary>
        /// <param name="version"> Kubernetes cluster version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public EdgeKubernetesClusterInfo(string version)
        {
            Argument.AssertNotNull(version, nameof(version));

            Nodes = new ChangeTrackingList<EdgeKubernetesNodeInfo>();
            Version = version;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeKubernetesClusterInfo"/>. </summary>
        /// <param name="etcdInfo"> Etcd configuration. </param>
        /// <param name="nodes"> Kubernetes cluster nodes. </param>
        /// <param name="version"> Kubernetes cluster version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeKubernetesClusterInfo(DataBoxEdgeEtcdInfo etcdInfo, IReadOnlyList<EdgeKubernetesNodeInfo> nodes, string version, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EtcdInfo = etcdInfo;
            Nodes = nodes;
            Version = version;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeKubernetesClusterInfo"/> for deserialization. </summary>
        internal EdgeKubernetesClusterInfo()
        {
        }

        /// <summary> Etcd configuration. </summary>
        public DataBoxEdgeEtcdInfo EtcdInfo { get; }
        /// <summary> Kubernetes cluster nodes. </summary>
        public IReadOnlyList<EdgeKubernetesNodeInfo> Nodes { get; }
        /// <summary> Kubernetes cluster version. </summary>
        public string Version { get; set; }
    }
}
