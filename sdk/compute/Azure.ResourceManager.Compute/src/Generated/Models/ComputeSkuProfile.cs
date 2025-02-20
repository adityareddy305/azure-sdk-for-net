// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the sku profile for the virtual machine scale set. With this property the customer is able to specify a list of VM sizes and an allocation strategy. </summary>
    public partial class ComputeSkuProfile
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

        /// <summary> Initializes a new instance of <see cref="ComputeSkuProfile"/>. </summary>
        public ComputeSkuProfile()
        {
            VmSizes = new ChangeTrackingList<ComputeSkuProfileVmSize>();
        }

        /// <summary> Initializes a new instance of <see cref="ComputeSkuProfile"/>. </summary>
        /// <param name="vmSizes"> Specifies the VM sizes for the virtual machine scale set. </param>
        /// <param name="allocationStrategy"> Specifies the allocation strategy for the virtual machine scale set based on which the VMs will be allocated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeSkuProfile(IList<ComputeSkuProfileVmSize> vmSizes, ComputeAllocationStrategy? allocationStrategy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VmSizes = vmSizes;
            AllocationStrategy = allocationStrategy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the VM sizes for the virtual machine scale set. </summary>
        public IList<ComputeSkuProfileVmSize> VmSizes { get; }
        /// <summary> Specifies the allocation strategy for the virtual machine scale set based on which the VMs will be allocated. </summary>
        public ComputeAllocationStrategy? AllocationStrategy { get; set; }
    }
}
