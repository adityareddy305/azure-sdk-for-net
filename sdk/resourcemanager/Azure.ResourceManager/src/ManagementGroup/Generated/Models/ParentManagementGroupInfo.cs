// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    /// <summary> (Optional) The ID of the parent management group. </summary>
    public partial class ParentManagementGroupInfo
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

        /// <summary> Initializes a new instance of <see cref="ParentManagementGroupInfo"/>. </summary>
        internal ParentManagementGroupInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ParentManagementGroupInfo"/>. </summary>
        /// <param name="id"> The fully qualified ID for the parent management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </param>
        /// <param name="name"> The name of the parent management group. </param>
        /// <param name="displayName"> The friendly name of the parent management group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ParentManagementGroupInfo(string id, string name, string displayName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            DisplayName = displayName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The fully qualified ID for the parent management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </summary>
        [WirePath("id")]
        public string Id { get; }
        /// <summary> The name of the parent management group. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> The friendly name of the parent management group. </summary>
        [WirePath("displayName")]
        public string DisplayName { get; }
    }
}
