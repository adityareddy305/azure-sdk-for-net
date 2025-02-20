// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster pool compute profile. </summary>
    public partial class ClusterPoolComputeProfile
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

        /// <summary> Initializes a new instance of <see cref="ClusterPoolComputeProfile"/>. </summary>
        /// <param name="vmSize"> The virtual machine SKU. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmSize"/> is null. </exception>
        public ClusterPoolComputeProfile(string vmSize)
        {
            Argument.AssertNotNull(vmSize, nameof(vmSize));

            VmSize = vmSize;
            AvailabilityZones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ClusterPoolComputeProfile"/>. </summary>
        /// <param name="vmSize"> The virtual machine SKU. </param>
        /// <param name="count"> The number of virtual machines. </param>
        /// <param name="availabilityZones"> The list of Availability zones to use for AKS VMSS nodes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterPoolComputeProfile(string vmSize, int? count, IList<string> availabilityZones, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VmSize = vmSize;
            Count = count;
            AvailabilityZones = availabilityZones;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterPoolComputeProfile"/> for deserialization. </summary>
        internal ClusterPoolComputeProfile()
        {
        }

        /// <summary> The virtual machine SKU. </summary>
        [WirePath("vmSize")]
        public string VmSize { get; set; }
        /// <summary> The number of virtual machines. </summary>
        [WirePath("count")]
        public int? Count { get; }
        /// <summary> The list of Availability zones to use for AKS VMSS nodes. </summary>
        [WirePath("availabilityZones")]
        public IList<string> AvailabilityZones { get; }
    }
}
