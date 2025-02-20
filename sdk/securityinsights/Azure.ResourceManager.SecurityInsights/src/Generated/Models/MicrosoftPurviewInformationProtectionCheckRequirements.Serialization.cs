// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class MicrosoftPurviewInformationProtectionCheckRequirements : IUtf8JsonSerializable, IJsonModel<MicrosoftPurviewInformationProtectionCheckRequirements>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MicrosoftPurviewInformationProtectionCheckRequirements>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MicrosoftPurviewInformationProtectionCheckRequirements>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftPurviewInformationProtectionCheckRequirements>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MicrosoftPurviewInformationProtectionCheckRequirements)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            writer.WriteEndObject();
        }

        MicrosoftPurviewInformationProtectionCheckRequirements IJsonModel<MicrosoftPurviewInformationProtectionCheckRequirements>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftPurviewInformationProtectionCheckRequirements>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MicrosoftPurviewInformationProtectionCheckRequirements)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMicrosoftPurviewInformationProtectionCheckRequirements(document.RootElement, options);
        }

        internal static MicrosoftPurviewInformationProtectionCheckRequirements DeserializeMicrosoftPurviewInformationProtectionCheckRequirements(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataConnectorKind kind = default;
            Guid? tenantId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new DataConnectorKind(property.Value.GetString());
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
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
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
            return new MicrosoftPurviewInformationProtectionCheckRequirements(kind, serializedAdditionalRawData, tenantId);
        }

        BinaryData IPersistableModel<MicrosoftPurviewInformationProtectionCheckRequirements>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftPurviewInformationProtectionCheckRequirements>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MicrosoftPurviewInformationProtectionCheckRequirements)} does not support writing '{options.Format}' format.");
            }
        }

        MicrosoftPurviewInformationProtectionCheckRequirements IPersistableModel<MicrosoftPurviewInformationProtectionCheckRequirements>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftPurviewInformationProtectionCheckRequirements>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMicrosoftPurviewInformationProtectionCheckRequirements(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MicrosoftPurviewInformationProtectionCheckRequirements)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MicrosoftPurviewInformationProtectionCheckRequirements>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
