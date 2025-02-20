// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    internal partial class InternalOpenAIPageableListOfThreadRun : IUtf8JsonSerializable, IJsonModel<InternalOpenAIPageableListOfThreadRun>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InternalOpenAIPageableListOfThreadRun>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InternalOpenAIPageableListOfThreadRun>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalOpenAIPageableListOfThreadRun>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalOpenAIPageableListOfThreadRun)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(Object.ToString());
            writer.WritePropertyName("data"u8);
            writer.WriteStartArray();
            foreach (var item in Data)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("first_id"u8);
            writer.WriteStringValue(FirstId);
            writer.WritePropertyName("last_id"u8);
            writer.WriteStringValue(LastId);
            writer.WritePropertyName("has_more"u8);
            writer.WriteBooleanValue(HasMore);
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

        InternalOpenAIPageableListOfThreadRun IJsonModel<InternalOpenAIPageableListOfThreadRun>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalOpenAIPageableListOfThreadRun>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalOpenAIPageableListOfThreadRun)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalOpenAIPageableListOfThreadRun(document.RootElement, options);
        }

        internal static InternalOpenAIPageableListOfThreadRun DeserializeInternalOpenAIPageableListOfThreadRun(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OpenAIPageableListOfThreadRunObject @object = default;
            IReadOnlyList<ThreadRun> data = default;
            string firstId = default;
            string lastId = default;
            bool hasMore = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("object"u8))
                {
                    @object = new OpenAIPageableListOfThreadRunObject(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    List<ThreadRun> array = new List<ThreadRun>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThreadRun.DeserializeThreadRun(item, options));
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("first_id"u8))
                {
                    firstId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("last_id"u8))
                {
                    lastId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("has_more"u8))
                {
                    hasMore = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalOpenAIPageableListOfThreadRun(
                @object,
                data,
                firstId,
                lastId,
                hasMore,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalOpenAIPageableListOfThreadRun>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalOpenAIPageableListOfThreadRun>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalOpenAIPageableListOfThreadRun)} does not support writing '{options.Format}' format.");
            }
        }

        InternalOpenAIPageableListOfThreadRun IPersistableModel<InternalOpenAIPageableListOfThreadRun>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalOpenAIPageableListOfThreadRun>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalOpenAIPageableListOfThreadRun(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalOpenAIPageableListOfThreadRun)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalOpenAIPageableListOfThreadRun>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static InternalOpenAIPageableListOfThreadRun FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalOpenAIPageableListOfThreadRun(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
