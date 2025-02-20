// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the FunctionEnvelope data model.
    /// Function information.
    /// </summary>
    public partial class FunctionEnvelopeData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="FunctionEnvelopeData"/>. </summary>
        public FunctionEnvelopeData()
        {
            Files = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="FunctionEnvelopeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="functionAppId"> Function App ID. </param>
        /// <param name="scriptRootPathHref"> Script root path URI. </param>
        /// <param name="scriptHref"> Script URI. </param>
        /// <param name="configHref"> Config URI. </param>
        /// <param name="testDataHref"> Test data URI. </param>
        /// <param name="secretsFileHref"> Secrets file URI. </param>
        /// <param name="href"> Function URI. </param>
        /// <param name="config"> Config information. </param>
        /// <param name="files"> File list. </param>
        /// <param name="testData"> Test data used when testing via the Azure Portal. </param>
        /// <param name="invokeUrlTemplate"> The invocation URL. </param>
        /// <param name="language"> The function language. </param>
        /// <param name="isDisabled"> Gets or sets a value indicating whether the function is disabled. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FunctionEnvelopeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string functionAppId, string scriptRootPathHref, string scriptHref, string configHref, string testDataHref, string secretsFileHref, string href, BinaryData config, IDictionary<string, string> files, string testData, string invokeUrlTemplate, string language, bool? isDisabled, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            FunctionAppId = functionAppId;
            ScriptRootPathHref = scriptRootPathHref;
            ScriptHref = scriptHref;
            ConfigHref = configHref;
            TestDataHref = testDataHref;
            SecretsFileHref = secretsFileHref;
            Href = href;
            Config = config;
            Files = files;
            TestData = testData;
            InvokeUrlTemplate = invokeUrlTemplate;
            Language = language;
            IsDisabled = isDisabled;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Function App ID. </summary>
        [WirePath("properties.function_app_id")]
        public string FunctionAppId { get; set; }
        /// <summary> Script root path URI. </summary>
        [WirePath("properties.script_root_path_href")]
        public string ScriptRootPathHref { get; set; }
        /// <summary> Script URI. </summary>
        [WirePath("properties.script_href")]
        public string ScriptHref { get; set; }
        /// <summary> Config URI. </summary>
        [WirePath("properties.config_href")]
        public string ConfigHref { get; set; }
        /// <summary> Test data URI. </summary>
        [WirePath("properties.test_data_href")]
        public string TestDataHref { get; set; }
        /// <summary> Secrets file URI. </summary>
        [WirePath("properties.secrets_file_href")]
        public string SecretsFileHref { get; set; }
        /// <summary> Function URI. </summary>
        [WirePath("properties.href")]
        public string Href { get; set; }
        /// <summary>
        /// Config information.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("properties.config")]
        public BinaryData Config { get; set; }
        /// <summary> File list. </summary>
        [WirePath("properties.files")]
        public IDictionary<string, string> Files { get; }
        /// <summary> Test data used when testing via the Azure Portal. </summary>
        [WirePath("properties.test_data")]
        public string TestData { get; set; }
        /// <summary> The invocation URL. </summary>
        [WirePath("properties.invoke_url_template")]
        public string InvokeUrlTemplate { get; set; }
        /// <summary> The function language. </summary>
        [WirePath("properties.language")]
        public string Language { get; set; }
        /// <summary> Gets or sets a value indicating whether the function is disabled. </summary>
        [WirePath("properties.isDisabled")]
        public bool? IsDisabled { get; set; }
        /// <summary> Kind of resource. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
    }
}
