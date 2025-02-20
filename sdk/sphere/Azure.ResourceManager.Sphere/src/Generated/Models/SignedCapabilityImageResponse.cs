// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary> Signed device capability image response. </summary>
    public partial class SignedCapabilityImageResponse
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

        /// <summary> Initializes a new instance of <see cref="SignedCapabilityImageResponse"/>. </summary>
        internal SignedCapabilityImageResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignedCapabilityImageResponse"/>. </summary>
        /// <param name="image"> The signed device capability image as a UTF-8 encoded base 64 string. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignedCapabilityImageResponse(string image, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Image = image;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The signed device capability image as a UTF-8 encoded base 64 string. </summary>
        public string Image { get; }
    }
}
