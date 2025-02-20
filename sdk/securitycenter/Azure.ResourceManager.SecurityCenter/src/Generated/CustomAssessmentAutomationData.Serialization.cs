// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class CustomAssessmentAutomationData : IUtf8JsonSerializable, IJsonModel<CustomAssessmentAutomationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomAssessmentAutomationData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomAssessmentAutomationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomAssessmentAutomationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomAssessmentAutomationData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CompressedQuery))
            {
                writer.WritePropertyName("compressedQuery"u8);
                writer.WriteStringValue(CompressedQuery);
            }
            if (Optional.IsDefined(SupportedCloud))
            {
                writer.WritePropertyName("supportedCloud"u8);
                writer.WriteStringValue(SupportedCloud.Value.ToString());
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(RemediationDescription))
            {
                writer.WritePropertyName("remediationDescription"u8);
                writer.WriteStringValue(RemediationDescription);
            }
            if (Optional.IsDefined(AssessmentKey))
            {
                writer.WritePropertyName("assessmentKey"u8);
                writer.WriteStringValue(AssessmentKey);
            }
            writer.WriteEndObject();
        }

        CustomAssessmentAutomationData IJsonModel<CustomAssessmentAutomationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomAssessmentAutomationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomAssessmentAutomationData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomAssessmentAutomationData(document.RootElement, options);
        }

        internal static CustomAssessmentAutomationData DeserializeCustomAssessmentAutomationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string compressedQuery = default;
            CustomAssessmentAutomationSupportedCloud? supportedCloud = default;
            CustomAssessmentSeverity? severity = default;
            string displayName = default;
            string description = default;
            string remediationDescription = default;
            string assessmentKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("compressedQuery"u8))
                        {
                            compressedQuery = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("supportedCloud"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportedCloud = new CustomAssessmentAutomationSupportedCloud(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new CustomAssessmentSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("remediationDescription"u8))
                        {
                            remediationDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("assessmentKey"u8))
                        {
                            assessmentKey = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CustomAssessmentAutomationData(
                id,
                name,
                type,
                systemData,
                compressedQuery,
                supportedCloud,
                severity,
                displayName,
                description,
                remediationDescription,
                assessmentKey,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CustomAssessmentAutomationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomAssessmentAutomationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomAssessmentAutomationData)} does not support writing '{options.Format}' format.");
            }
        }

        CustomAssessmentAutomationData IPersistableModel<CustomAssessmentAutomationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomAssessmentAutomationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomAssessmentAutomationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomAssessmentAutomationData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomAssessmentAutomationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
