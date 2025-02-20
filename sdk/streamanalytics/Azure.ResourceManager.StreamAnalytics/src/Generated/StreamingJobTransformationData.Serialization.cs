// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics
{
    public partial class StreamingJobTransformationData : IUtf8JsonSerializable, IJsonModel<StreamingJobTransformationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingJobTransformationData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StreamingJobTransformationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobTransformationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobTransformationData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StreamingUnits))
            {
                writer.WritePropertyName("streamingUnits"u8);
                writer.WriteNumberValue(StreamingUnits.Value);
            }
            if (Optional.IsCollectionDefined(ValidStreamingUnits))
            {
                writer.WritePropertyName("validStreamingUnits"u8);
                writer.WriteStartArray();
                foreach (var item in ValidStreamingUnits)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WriteEndObject();
        }

        StreamingJobTransformationData IJsonModel<StreamingJobTransformationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobTransformationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobTransformationData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingJobTransformationData(document.RootElement, options);
        }

        internal static StreamingJobTransformationData DeserializeStreamingJobTransformationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            int? streamingUnits = default;
            IList<int> validStreamingUnits = default;
            string query = default;
            ETag? etag = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("streamingUnits"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            streamingUnits = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("validStreamingUnits"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<int> array = new List<int>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetInt32());
                            }
                            validStreamingUnits = array;
                            continue;
                        }
                        if (property0.NameEquals("query"u8))
                        {
                            query = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("etag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            etag = new ETag(property0.Value.GetString());
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
            return new StreamingJobTransformationData(
                id,
                name,
                type,
                serializedAdditionalRawData,
                streamingUnits,
                validStreamingUnits ?? new ChangeTrackingList<int>(),
                query,
                etag);
        }

        BinaryData IPersistableModel<StreamingJobTransformationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobTransformationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingJobTransformationData)} does not support writing '{options.Format}' format.");
            }
        }

        StreamingJobTransformationData IPersistableModel<StreamingJobTransformationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobTransformationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamingJobTransformationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingJobTransformationData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingJobTransformationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
