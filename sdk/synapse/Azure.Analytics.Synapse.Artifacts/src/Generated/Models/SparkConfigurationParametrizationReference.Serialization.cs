// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SparkConfigurationParametrizationReferenceConverter))]
    public partial class SparkConfigurationParametrizationReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("referenceName"u8);
            writer.WriteObjectValue<object>(ReferenceName);
            writer.WriteEndObject();
        }

        internal static SparkConfigurationParametrizationReference DeserializeSparkConfigurationParametrizationReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SparkConfigurationReferenceType type = default;
            object referenceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new SparkConfigurationReferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("referenceName"u8))
                {
                    referenceName = property.Value.GetObject();
                    continue;
                }
            }
            return new SparkConfigurationParametrizationReference(type, referenceName);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SparkConfigurationParametrizationReference FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSparkConfigurationParametrizationReference(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class SparkConfigurationParametrizationReferenceConverter : JsonConverter<SparkConfigurationParametrizationReference>
        {
            public override void Write(Utf8JsonWriter writer, SparkConfigurationParametrizationReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override SparkConfigurationParametrizationReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSparkConfigurationParametrizationReference(document.RootElement);
            }
        }
    }
}
