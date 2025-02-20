// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Parameters supplied to the Create Group operation. </summary>
    public partial class ApiManagementGroupCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="ApiManagementGroupCreateOrUpdateContent"/>. </summary>
        public ApiManagementGroupCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementGroupCreateOrUpdateContent"/>. </summary>
        /// <param name="displayName"> Group name. </param>
        /// <param name="description"> Group description. </param>
        /// <param name="apiManagementGroupType"> Group type. </param>
        /// <param name="externalId"> Identifier of the external groups, this property contains the id of the group from the external identity provider, e.g. for Azure Active Directory `aad://&lt;tenant&gt;.onmicrosoft.com/groups/&lt;group object id&gt;`; otherwise the value is null. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementGroupCreateOrUpdateContent(string displayName, string description, ApiManagementGroupType? apiManagementGroupType, string externalId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayName = displayName;
            Description = description;
            ApiManagementGroupType = apiManagementGroupType;
            ExternalId = externalId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Group name. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> Group description. </summary>
        [WirePath("properties.description")]
        public string Description { get; set; }
        /// <summary> Group type. </summary>
        [WirePath("properties.type")]
        public ApiManagementGroupType? ApiManagementGroupType { get; set; }
        /// <summary> Identifier of the external groups, this property contains the id of the group from the external identity provider, e.g. for Azure Active Directory `aad://&lt;tenant&gt;.onmicrosoft.com/groups/&lt;group object id&gt;`; otherwise the value is null. </summary>
        [WirePath("properties.externalId")]
        public string ExternalId { get; set; }
    }
}
