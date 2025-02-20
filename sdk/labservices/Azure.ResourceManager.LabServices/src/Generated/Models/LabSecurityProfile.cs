// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The lab security profile. </summary>
    public partial class LabSecurityProfile
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

        /// <summary> Initializes a new instance of <see cref="LabSecurityProfile"/>. </summary>
        public LabSecurityProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LabSecurityProfile"/>. </summary>
        /// <param name="registrationCode"> The registration code for the lab. </param>
        /// <param name="openAccess"> Whether any user or only specified users can register to a lab. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LabSecurityProfile(string registrationCode, LabServicesEnableState? openAccess, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RegistrationCode = registrationCode;
            OpenAccess = openAccess;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The registration code for the lab. </summary>
        public string RegistrationCode { get; }
        /// <summary> Whether any user or only specified users can register to a lab. </summary>
        public LabServicesEnableState? OpenAccess { get; set; }
    }
}
