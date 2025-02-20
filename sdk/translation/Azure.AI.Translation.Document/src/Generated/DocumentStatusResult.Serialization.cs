// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Document
{
    public partial class DocumentStatusResult : IUtf8JsonSerializable, IJsonModel<DocumentStatusResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentStatusResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DocumentStatusResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentStatusResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentStatusResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(TranslatedDocumentUri))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(TranslatedDocumentUri.AbsoluteUri);
            }
            writer.WritePropertyName("sourcePath"u8);
            writer.WriteStringValue(SourceDocumentUri.AbsoluteUri);
            writer.WritePropertyName("createdDateTimeUtc"u8);
            writer.WriteStringValue(CreatedOn, "O");
            writer.WritePropertyName("lastActionDateTimeUtc"u8);
            writer.WriteStringValue(LastModified, "O");
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            writer.WritePropertyName("to"u8);
            writer.WriteStringValue(TranslatedToLanguageCode);
            if (Optional.IsDefined(_error))
            {
                writer.WritePropertyName("error"u8);
                _error.WriteTo(writer);
            }
            writer.WritePropertyName("progress"u8);
            writer.WriteNumberValue(Progress);
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("characterCharged"u8);
            writer.WriteNumberValue(CharactersCharged);
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

        DocumentStatusResult IJsonModel<DocumentStatusResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentStatusResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentStatusResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentStatusResult(document.RootElement, options);
        }

        internal static DocumentStatusResult DeserializeDocumentStatusResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri path = default;
            Uri sourcePath = default;
            DateTimeOffset createdDateTimeUtc = default;
            DateTimeOffset lastActionDateTimeUtc = default;
            DocumentTranslationStatus status = default;
            string to = default;
            JsonElement error = default;
            float progress = default;
            string id = default;
            long characterCharged = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    path = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourcePath"u8))
                {
                    sourcePath = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdDateTimeUtc"u8))
                {
                    createdDateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastActionDateTimeUtc"u8))
                {
                    lastActionDateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new DocumentTranslationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("to"u8))
                {
                    to = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("progress"u8))
                {
                    progress = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("characterCharged"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    characterCharged = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DocumentStatusResult(
                path,
                sourcePath,
                createdDateTimeUtc,
                lastActionDateTimeUtc,
                status,
                to,
                error,
                progress,
                id,
                characterCharged,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentStatusResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentStatusResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DocumentStatusResult)} does not support writing '{options.Format}' format.");
            }
        }

        DocumentStatusResult IPersistableModel<DocumentStatusResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentStatusResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDocumentStatusResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentStatusResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentStatusResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentStatusResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDocumentStatusResult(document.RootElement);
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
