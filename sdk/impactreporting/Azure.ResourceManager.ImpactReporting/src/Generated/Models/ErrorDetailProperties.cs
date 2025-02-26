// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ImpactReporting.Models
{
    /// <summary> ARM error code and error message associated with the impact. </summary>
    public partial class ErrorDetailProperties
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

        /// <summary> Initializes a new instance of <see cref="ErrorDetailProperties"/>. </summary>
        public ErrorDetailProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ErrorDetailProperties"/>. </summary>
        /// <param name="errorCode"> ARM Error code associated with the impact. </param>
        /// <param name="errorMessage"> ARM Error Message associated with the impact. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ErrorDetailProperties(string errorCode, string errorMessage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ARM Error code associated with the impact. </summary>
        public string ErrorCode { get; set; }
        /// <summary> ARM Error Message associated with the impact. </summary>
        public string ErrorMessage { get; set; }
    }
}
