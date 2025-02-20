// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> Parameters for terminating an Azure Batch Job. </summary>
    public partial class BatchJobTerminateContent
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

        /// <summary> Initializes a new instance of <see cref="BatchJobTerminateContent"/>. </summary>
        public BatchJobTerminateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchJobTerminateContent"/>. </summary>
        /// <param name="terminationReason"> The text you want to appear as the Job's TerminationReason. The default is 'UserTerminate'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchJobTerminateContent(string terminationReason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TerminationReason = terminationReason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The text you want to appear as the Job's TerminationReason. The default is 'UserTerminate'. </summary>
        public string TerminationReason { get; set; }
    }
}
