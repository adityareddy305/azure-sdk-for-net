// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class PatientRecord : IUtf8JsonSerializable, IJsonModel<PatientRecord>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PatientRecord>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PatientRecord>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PatientRecord)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteObjectValue(Details, options);
            }
            if (Optional.IsCollectionDefined(Encounters))
            {
                writer.WritePropertyName("encounters"u8);
                writer.WriteStartArray();
                foreach (var item in Encounters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PatientDocuments))
            {
                writer.WritePropertyName("patientDocuments"u8);
                writer.WriteStartArray();
                foreach (var item in PatientDocuments)
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

        PatientRecord IJsonModel<PatientRecord>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PatientRecord)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePatientRecord(document.RootElement, options);
        }

        internal static PatientRecord DeserializePatientRecord(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            PatientDetails details = default;
            IList<PatientEncounter> encounters = default;
            IList<PatientDocument> patientDocuments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    details = PatientDetails.DeserializePatientDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("encounters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PatientEncounter> array = new List<PatientEncounter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PatientEncounter.DeserializePatientEncounter(item, options));
                    }
                    encounters = array;
                    continue;
                }
                if (property.NameEquals("patientDocuments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PatientDocument> array = new List<PatientDocument>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PatientDocument.DeserializePatientDocument(item, options));
                    }
                    patientDocuments = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PatientRecord(id, details, encounters ?? new ChangeTrackingList<PatientEncounter>(), patientDocuments ?? new ChangeTrackingList<PatientDocument>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PatientRecord>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PatientRecord)} does not support writing '{options.Format}' format.");
            }
        }

        PatientRecord IPersistableModel<PatientRecord>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePatientRecord(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PatientRecord)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PatientRecord>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PatientRecord FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePatientRecord(document.RootElement);
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
