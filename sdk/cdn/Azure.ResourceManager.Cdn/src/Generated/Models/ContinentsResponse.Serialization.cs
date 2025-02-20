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
    public partial class ContinentsResponse : IUtf8JsonSerializable, IJsonModel<ContinentsResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContinentsResponse>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContinentsResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinentsResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContinentsResponse)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Continents))
            {
                writer.WritePropertyName("continents"u8);
                writer.WriteStartArray();
                foreach (var item in Continents)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CountryOrRegions))
            {
                writer.WritePropertyName("countryOrRegions"u8);
                writer.WriteStartArray();
                foreach (var item in CountryOrRegions)
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

        ContinentsResponse IJsonModel<ContinentsResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinentsResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContinentsResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContinentsResponse(document.RootElement, options);
        }

        internal static ContinentsResponse DeserializeContinentsResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ContinentsResponseContinentsItem> continents = default;
            IReadOnlyList<ContinentsResponseCountryOrRegionsItem> countryOrRegions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("continents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContinentsResponseContinentsItem> array = new List<ContinentsResponseContinentsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContinentsResponseContinentsItem.DeserializeContinentsResponseContinentsItem(item, options));
                    }
                    continents = array;
                    continue;
                }
                if (property.NameEquals("countryOrRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContinentsResponseCountryOrRegionsItem> array = new List<ContinentsResponseCountryOrRegionsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContinentsResponseCountryOrRegionsItem.DeserializeContinentsResponseCountryOrRegionsItem(item, options));
                    }
                    countryOrRegions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContinentsResponse(continents ?? new ChangeTrackingList<ContinentsResponseContinentsItem>(), countryOrRegions ?? new ChangeTrackingList<ContinentsResponseCountryOrRegionsItem>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContinentsResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinentsResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContinentsResponse)} does not support writing '{options.Format}' format.");
            }
        }

        ContinentsResponse IPersistableModel<ContinentsResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinentsResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContinentsResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContinentsResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContinentsResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
