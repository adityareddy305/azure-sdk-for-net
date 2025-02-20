// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List VM scale set extension operation response. </summary>
    internal partial class VirtualMachineScaleSetExtensionListResult
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetExtensionListResult"/>. </summary>
        /// <param name="value"> The list of VM scale set extensions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VirtualMachineScaleSetExtensionListResult(IEnumerable<VirtualMachineScaleSetExtensionData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetExtensionListResult"/>. </summary>
        /// <param name="value"> The list of VM scale set extensions. </param>
        /// <param name="nextLink"> The uri to fetch the next page of VM scale set extensions. Call ListNext() with this to fetch the next page of VM scale set extensions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetExtensionListResult(IReadOnlyList<VirtualMachineScaleSetExtensionData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetExtensionListResult"/> for deserialization. </summary>
        internal VirtualMachineScaleSetExtensionListResult()
        {
        }

        /// <summary> The list of VM scale set extensions. </summary>
        public IReadOnlyList<VirtualMachineScaleSetExtensionData> Value { get; }
        /// <summary> The uri to fetch the next page of VM scale set extensions. Call ListNext() with this to fetch the next page of VM scale set extensions. </summary>
        public string NextLink { get; }
    }
}
