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
    [JsonConverter(typeof(SsisExecutionParameterConverter))]
    public partial class SsisExecutionParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteObjectValue<object>(Value);
            writer.WriteEndObject();
        }

        internal static SsisExecutionParameter DeserializeSsisExecutionParameter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetObject();
                    continue;
                }
            }
            return new SsisExecutionParameter(value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SsisExecutionParameter FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSsisExecutionParameter(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class SsisExecutionParameterConverter : JsonConverter<SsisExecutionParameter>
        {
            public override void Write(Utf8JsonWriter writer, SsisExecutionParameter model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override SsisExecutionParameter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSsisExecutionParameter(document.RootElement);
            }
        }
    }
}
