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
    [JsonConverter(typeof(SsisAccessCredentialConverter))]
    public partial class SsisAccessCredential : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("domain"u8);
            writer.WriteObjectValue<object>(Domain);
            writer.WritePropertyName("userName"u8);
            writer.WriteObjectValue<object>(UserName);
            writer.WritePropertyName("password"u8);
            writer.WriteObjectValue(Password);
            writer.WriteEndObject();
        }

        internal static SsisAccessCredential DeserializeSsisAccessCredential(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object domain = default;
            object userName = default;
            SecretBase password = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domain"u8))
                {
                    domain = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("userName"u8))
                {
                    userName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = SecretBase.DeserializeSecretBase(property.Value);
                    continue;
                }
            }
            return new SsisAccessCredential(domain, userName, password);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SsisAccessCredential FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSsisAccessCredential(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class SsisAccessCredentialConverter : JsonConverter<SsisAccessCredential>
        {
            public override void Write(Utf8JsonWriter writer, SsisAccessCredential model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override SsisAccessCredential Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSsisAccessCredential(document.RootElement);
            }
        }
    }
}
