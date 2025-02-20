// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxConfigurationProtectedFileContent. </summary>
    public partial class NginxConfigurationProtectedFileContent
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

        /// <summary> Initializes a new instance of <see cref="NginxConfigurationProtectedFileContent"/>. </summary>
        public NginxConfigurationProtectedFileContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NginxConfigurationProtectedFileContent"/>. </summary>
        /// <param name="content"> The content of the protected file. This value is a PUT only value. If you perform a GET request on this value, it will be empty because it is a protected file. </param>
        /// <param name="virtualPath"> The virtual path of the protected file. </param>
        /// <param name="contentHash"> The hash of the content of the file. This value is used to determine if the file has changed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NginxConfigurationProtectedFileContent(string content, string virtualPath, string contentHash, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            VirtualPath = virtualPath;
            ContentHash = contentHash;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The content of the protected file. This value is a PUT only value. If you perform a GET request on this value, it will be empty because it is a protected file. </summary>
        public string Content { get; set; }
        /// <summary> The virtual path of the protected file. </summary>
        public string VirtualPath { get; set; }
        /// <summary> The hash of the content of the file. This value is used to determine if the file has changed. </summary>
        public string ContentHash { get; set; }
    }
}
