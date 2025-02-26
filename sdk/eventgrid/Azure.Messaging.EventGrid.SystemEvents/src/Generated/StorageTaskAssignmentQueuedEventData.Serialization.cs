// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class StorageTaskAssignmentQueuedEventData : IUtf8JsonSerializable, IJsonModel<StorageTaskAssignmentQueuedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageTaskAssignmentQueuedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageTaskAssignmentQueuedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskAssignmentQueuedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageTaskAssignmentQueuedEventData)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(QueuedOn))
            {
                writer.WritePropertyName("queuedDateTime"u8);
                writer.WriteStringValue(QueuedOn.Value, "O");
            }
            if (Optional.IsDefined(TaskExecutionId))
            {
                writer.WritePropertyName("taskExecutionId"u8);
                writer.WriteStringValue(TaskExecutionId);
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

        StorageTaskAssignmentQueuedEventData IJsonModel<StorageTaskAssignmentQueuedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskAssignmentQueuedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageTaskAssignmentQueuedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageTaskAssignmentQueuedEventData(document.RootElement, options);
        }

        internal static StorageTaskAssignmentQueuedEventData DeserializeStorageTaskAssignmentQueuedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? queuedDateTime = default;
            string taskExecutionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queuedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queuedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("taskExecutionId"u8))
                {
                    taskExecutionId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageTaskAssignmentQueuedEventData(queuedDateTime, taskExecutionId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageTaskAssignmentQueuedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskAssignmentQueuedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageTaskAssignmentQueuedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        StorageTaskAssignmentQueuedEventData IPersistableModel<StorageTaskAssignmentQueuedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskAssignmentQueuedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageTaskAssignmentQueuedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageTaskAssignmentQueuedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageTaskAssignmentQueuedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static StorageTaskAssignmentQueuedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeStorageTaskAssignmentQueuedEventData(document.RootElement);
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
