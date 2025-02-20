// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Identify the status of the most severe insight generated by the detector. </summary>
    public partial class AppServiceStatusInfo
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

        /// <summary> Initializes a new instance of <see cref="AppServiceStatusInfo"/>. </summary>
        public AppServiceStatusInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceStatusInfo"/>. </summary>
        /// <param name="message"> Descriptive message. </param>
        /// <param name="statusId"> Level of the most severe insight generated by the detector. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceStatusInfo(string message, DetectorInsightStatus? statusId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Message = message;
            StatusId = statusId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Descriptive message. </summary>
        [WirePath("message")]
        public string Message { get; set; }
        /// <summary> Level of the most severe insight generated by the detector. </summary>
        [WirePath("statusId")]
        public DetectorInsightStatus? StatusId { get; set; }
    }
}
