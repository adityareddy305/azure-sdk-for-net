// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class ProtectedItemDynamicMemoryConfig : IUtf8JsonSerializable, IJsonModel<ProtectedItemDynamicMemoryConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProtectedItemDynamicMemoryConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ProtectedItemDynamicMemoryConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectedItemDynamicMemoryConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProtectedItemDynamicMemoryConfig)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("maximumMemoryInMegaBytes"u8);
            writer.WriteNumberValue(MaximumMemoryInMegaBytes);
            writer.WritePropertyName("minimumMemoryInMegaBytes"u8);
            writer.WriteNumberValue(MinimumMemoryInMegaBytes);
            writer.WritePropertyName("targetMemoryBufferPercentage"u8);
            writer.WriteNumberValue(TargetMemoryBufferPercentage);
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

        ProtectedItemDynamicMemoryConfig IJsonModel<ProtectedItemDynamicMemoryConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectedItemDynamicMemoryConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProtectedItemDynamicMemoryConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProtectedItemDynamicMemoryConfig(document.RootElement, options);
        }

        internal static ProtectedItemDynamicMemoryConfig DeserializeProtectedItemDynamicMemoryConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long maximumMemoryInMegaBytes = default;
            long minimumMemoryInMegaBytes = default;
            int targetMemoryBufferPercentage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maximumMemoryInMegaBytes"u8))
                {
                    maximumMemoryInMegaBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minimumMemoryInMegaBytes"u8))
                {
                    minimumMemoryInMegaBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("targetMemoryBufferPercentage"u8))
                {
                    targetMemoryBufferPercentage = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ProtectedItemDynamicMemoryConfig(maximumMemoryInMegaBytes, minimumMemoryInMegaBytes, targetMemoryBufferPercentage, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProtectedItemDynamicMemoryConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectedItemDynamicMemoryConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProtectedItemDynamicMemoryConfig)} does not support writing '{options.Format}' format.");
            }
        }

        ProtectedItemDynamicMemoryConfig IPersistableModel<ProtectedItemDynamicMemoryConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectedItemDynamicMemoryConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProtectedItemDynamicMemoryConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProtectedItemDynamicMemoryConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProtectedItemDynamicMemoryConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
