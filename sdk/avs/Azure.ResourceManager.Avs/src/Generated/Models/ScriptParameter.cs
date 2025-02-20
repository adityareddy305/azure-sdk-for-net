// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> An parameter that the script will accept. </summary>
    public partial class ScriptParameter
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

        /// <summary> Initializes a new instance of <see cref="ScriptParameter"/>. </summary>
        internal ScriptParameter()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScriptParameter"/>. </summary>
        /// <param name="parameterType">
        /// The type of parameter the script is expecting. psCredential is a
        /// PSCredentialObject
        /// </param>
        /// <param name="name"> The parameter name that the script will expect a parameter value for. </param>
        /// <param name="description"> User friendly description of the parameter. </param>
        /// <param name="visibility">
        /// Should this parameter be visible to arm and passed in the parameters argument
        /// when executing
        /// </param>
        /// <param name="optional"> Is this parameter required or optional. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScriptParameter(ScriptParameterType? parameterType, string name, string description, ParameterVisibilityStatus? visibility, ParameterOptionalityStatus? optional, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ParameterType = parameterType;
            Name = name;
            Description = description;
            Visibility = visibility;
            Optional = optional;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The type of parameter the script is expecting. psCredential is a
        /// PSCredentialObject
        /// </summary>
        public ScriptParameterType? ParameterType { get; }
        /// <summary> The parameter name that the script will expect a parameter value for. </summary>
        public string Name { get; }
        /// <summary> User friendly description of the parameter. </summary>
        public string Description { get; }
        /// <summary>
        /// Should this parameter be visible to arm and passed in the parameters argument
        /// when executing
        /// </summary>
        public ParameterVisibilityStatus? Visibility { get; }
        /// <summary> Is this parameter required or optional. </summary>
        public ParameterOptionalityStatus? Optional { get; }
    }
}
