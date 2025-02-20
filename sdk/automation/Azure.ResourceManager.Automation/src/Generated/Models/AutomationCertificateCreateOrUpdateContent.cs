// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update or replace certificate operation. </summary>
    public partial class AutomationCertificateCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="AutomationCertificateCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the certificate. </param>
        /// <param name="base64Value"> Gets or sets the base64 encoded value of the certificate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="base64Value"/> is null. </exception>
        public AutomationCertificateCreateOrUpdateContent(string name, string base64Value)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(base64Value, nameof(base64Value));

            Name = name;
            Base64Value = base64Value;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationCertificateCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets the name of the certificate. </param>
        /// <param name="base64Value"> Gets or sets the base64 encoded value of the certificate. </param>
        /// <param name="description"> Gets or sets the description of the certificate. </param>
        /// <param name="thumbprintString"> Gets or sets the thumbprint of the certificate. </param>
        /// <param name="isExportable"> Gets or sets the is exportable flag of the certificate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationCertificateCreateOrUpdateContent(string name, string base64Value, string description, string thumbprintString, bool? isExportable, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Base64Value = base64Value;
            Description = description;
            ThumbprintString = thumbprintString;
            IsExportable = isExportable;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationCertificateCreateOrUpdateContent"/> for deserialization. </summary>
        internal AutomationCertificateCreateOrUpdateContent()
        {
        }

        /// <summary> Gets or sets the name of the certificate. </summary>
        public string Name { get; }
        /// <summary> Gets or sets the base64 encoded value of the certificate. </summary>
        public string Base64Value { get; }
        /// <summary> Gets or sets the description of the certificate. </summary>
        public string Description { get; set; }
        /// <summary> Gets or sets the thumbprint of the certificate. </summary>
        public string ThumbprintString { get; set; }
        /// <summary> Gets or sets the is exportable flag of the certificate. </summary>
        public bool? IsExportable { get; set; }
    }
}
