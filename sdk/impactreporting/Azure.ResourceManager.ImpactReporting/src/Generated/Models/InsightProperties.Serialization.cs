// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ImpactReporting.Models
{
    public partial class InsightProperties : IUtf8JsonSerializable, IJsonModel<InsightProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InsightProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InsightProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InsightProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InsightProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WritePropertyName("category"u8);
            writer.WriteStringValue(Category);
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(EventId))
            {
                writer.WritePropertyName("eventId"u8);
                writer.WriteStringValue(EventId);
            }
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            writer.WritePropertyName("content"u8);
            writer.WriteObjectValue(Content, options);
            if (Optional.IsDefined(EventOn))
            {
                writer.WritePropertyName("eventTime"u8);
                writer.WriteStringValue(EventOn.Value, "O");
            }
            writer.WritePropertyName("insightUniqueId"u8);
            writer.WriteStringValue(InsightUniqueId);
            writer.WritePropertyName("impact"u8);
            writer.WriteObjectValue(Impact, options);
            if (Optional.IsDefined(AdditionalDetails))
            {
                writer.WritePropertyName("additionalDetails"u8);
                writer.WriteObjectValue(AdditionalDetails, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        InsightProperties IJsonModel<InsightProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InsightProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InsightProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInsightProperties(document.RootElement, options);
        }

        internal static InsightProperties DeserializeInsightProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProvisioningState? provisioningState = default;
            string category = default;
            string status = default;
            string eventId = default;
            string groupId = default;
            Content content = default;
            DateTimeOffset? eventTime = default;
            string insightUniqueId = default;
            ImpactDetails impact = default;
            InsightPropertiesAdditionalDetails additionalDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventId"u8))
                {
                    eventId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    content = Content.DeserializeContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("eventTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("insightUniqueId"u8))
                {
                    insightUniqueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("impact"u8))
                {
                    impact = ImpactDetails.DeserializeImpactDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("additionalDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalDetails = InsightPropertiesAdditionalDetails.DeserializeInsightPropertiesAdditionalDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InsightProperties(
                provisioningState,
                category,
                status,
                eventId,
                groupId,
                content,
                eventTime,
                insightUniqueId,
                impact,
                additionalDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InsightProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InsightProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InsightProperties)} does not support writing '{options.Format}' format.");
            }
        }

        InsightProperties IPersistableModel<InsightProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InsightProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInsightProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InsightProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InsightProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
