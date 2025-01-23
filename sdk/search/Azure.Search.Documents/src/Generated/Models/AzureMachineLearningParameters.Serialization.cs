// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class AzureMachineLearningParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ScoringUri != null)
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(ScoringUri.AbsoluteUri);
            }
            else
            {
                writer.WriteNull("uri");
            }
            if (Optional.IsDefined(AuthenticationKey))
            {
                if (AuthenticationKey != null)
                {
                    writer.WritePropertyName("key"u8);
                    writer.WriteStringValue(AuthenticationKey);
                }
                else
                {
                    writer.WriteNull("key");
                }
            }
            if (Optional.IsDefined(ResourceId))
            {
                if (ResourceId != null)
                {
                    writer.WritePropertyName("resourceId"u8);
                    writer.WriteStringValue(ResourceId);
                }
                else
                {
                    writer.WriteNull("resourceId");
                }
            }
            if (Optional.IsDefined(Timeout))
            {
                if (Timeout != null)
                {
                    writer.WritePropertyName("timeout"u8);
                    writer.WriteStringValue(Timeout.Value, "P");
                }
                else
                {
                    writer.WriteNull("timeout");
                }
            }
            if (Optional.IsDefined(Region))
            {
                if (Region != null)
                {
                    writer.WritePropertyName("region"u8);
                    writer.WriteStringValue(Region);
                }
                else
                {
                    writer.WriteNull("region");
                }
            }
            if (Optional.IsDefined(ModelName))
            {
                writer.WritePropertyName("modelName"u8);
                writer.WriteStringValue(ModelName.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AzureMachineLearningParameters DeserializeAzureMachineLearningParameters(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri uri = default;
            string key = default;
            string resourceId = default;
            TimeSpan? timeout = default;
            string region = default;
            AIFoundryModelCatalogName? modelName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        uri = null;
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        key = null;
                        continue;
                    }
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceId = null;
                        continue;
                    }
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeout = null;
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        region = null;
                        continue;
                    }
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modelName = new AIFoundryModelCatalogName(property.Value.GetString());
                    continue;
                }
            }
            return new AzureMachineLearningParameters(
                uri,
                key,
                resourceId,
                timeout,
                region,
                modelName);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AzureMachineLearningParameters FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureMachineLearningParameters(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
