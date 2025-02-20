// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Cognitive Services account ModelDeprecationInfo. </summary>
    public partial class ServiceAccountModelDeprecationInfo
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

        /// <summary> Initializes a new instance of <see cref="ServiceAccountModelDeprecationInfo"/>. </summary>
        public ServiceAccountModelDeprecationInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceAccountModelDeprecationInfo"/>. </summary>
        /// <param name="fineTuneOn"> The datetime of deprecation of the fineTune Model. </param>
        /// <param name="inferenceOn"> The datetime of deprecation of the inference Model. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceAccountModelDeprecationInfo(DateTimeOffset? fineTuneOn, DateTimeOffset? inferenceOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FineTuneOn = fineTuneOn;
            InferenceOn = inferenceOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The datetime of deprecation of the fineTune Model. </summary>
        [WirePath("fineTune")]
        public DateTimeOffset? FineTuneOn { get; set; }
        /// <summary> The datetime of deprecation of the inference Model. </summary>
        [WirePath("inference")]
        public DateTimeOffset? InferenceOn { get; set; }
    }
}
