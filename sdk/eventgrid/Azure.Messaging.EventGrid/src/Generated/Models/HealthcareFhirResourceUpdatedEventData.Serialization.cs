// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(HealthcareFhirResourceUpdatedEventDataConverter))]
    public partial class HealthcareFhirResourceUpdatedEventData
    {
        internal static HealthcareFhirResourceUpdatedEventData DeserializeHealthcareFhirResourceUpdatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HealthcareFhirResourceType? resourceType = default;
            string resourceFhirAccount = default;
            string resourceFhirId = default;
            long? resourceVersionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = new HealthcareFhirResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceFhirAccount"u8))
                {
                    resourceFhirAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceFhirId"u8))
                {
                    resourceFhirId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceVersionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceVersionId = property.Value.GetInt64();
                    continue;
                }
            }
            return new HealthcareFhirResourceUpdatedEventData(resourceType, resourceFhirAccount, resourceFhirId, resourceVersionId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static HealthcareFhirResourceUpdatedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeHealthcareFhirResourceUpdatedEventData(document.RootElement);
        }

        internal partial class HealthcareFhirResourceUpdatedEventDataConverter : JsonConverter<HealthcareFhirResourceUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, HealthcareFhirResourceUpdatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override HealthcareFhirResourceUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHealthcareFhirResourceUpdatedEventData(document.RootElement);
            }
        }
    }
}
