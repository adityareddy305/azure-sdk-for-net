// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class RankingsResponseTablesItem : IUtf8JsonSerializable, IJsonModel<RankingsResponseTablesItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RankingsResponseTablesItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RankingsResponseTablesItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RankingsResponseTablesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RankingsResponseTablesItem)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Ranking))
            {
                writer.WritePropertyName("ranking"u8);
                writer.WriteStringValue(Ranking);
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        RankingsResponseTablesItem IJsonModel<RankingsResponseTablesItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RankingsResponseTablesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RankingsResponseTablesItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRankingsResponseTablesItem(document.RootElement, options);
        }

        internal static RankingsResponseTablesItem DeserializeRankingsResponseTablesItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ranking = default;
            IReadOnlyList<RankingsResponseTablesPropertiesItemsItem> data = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ranking"u8))
                {
                    ranking = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RankingsResponseTablesPropertiesItemsItem> array = new List<RankingsResponseTablesPropertiesItemsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RankingsResponseTablesPropertiesItemsItem.DeserializeRankingsResponseTablesPropertiesItemsItem(item, options));
                    }
                    data = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RankingsResponseTablesItem(ranking, data ?? new ChangeTrackingList<RankingsResponseTablesPropertiesItemsItem>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RankingsResponseTablesItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RankingsResponseTablesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RankingsResponseTablesItem)} does not support writing '{options.Format}' format.");
            }
        }

        RankingsResponseTablesItem IPersistableModel<RankingsResponseTablesItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RankingsResponseTablesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRankingsResponseTablesItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RankingsResponseTablesItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RankingsResponseTablesItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
