// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The storage task assignment report. </summary>
    public partial class StorageTaskAssignmentReport
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

        /// <summary> Initializes a new instance of <see cref="StorageTaskAssignmentReport"/>. </summary>
        /// <param name="prefix"> The container prefix for the location of storage task assignment report. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="prefix"/> is null. </exception>
        public StorageTaskAssignmentReport(string prefix)
        {
            Argument.AssertNotNull(prefix, nameof(prefix));

            Prefix = prefix;
        }

        /// <summary> Initializes a new instance of <see cref="StorageTaskAssignmentReport"/>. </summary>
        /// <param name="prefix"> The container prefix for the location of storage task assignment report. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageTaskAssignmentReport(string prefix, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Prefix = prefix;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageTaskAssignmentReport"/> for deserialization. </summary>
        internal StorageTaskAssignmentReport()
        {
        }

        /// <summary> The container prefix for the location of storage task assignment report. </summary>
        [WirePath("prefix")]
        public string Prefix { get; set; }
    }
}
