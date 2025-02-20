// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AppConfigurationKeyValueModifiedEventDataConverter))]
    public partial class AppConfigurationKeyValueModifiedEventData
    {
        internal static AppConfigurationKeyValueModifiedEventData DeserializeAppConfigurationKeyValueModifiedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            string label = default;
            string etag = default;
            string syncToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("syncToken"u8))
                {
                    syncToken = property.Value.GetString();
                    continue;
                }
            }
            return new AppConfigurationKeyValueModifiedEventData(key, label, etag, syncToken);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AppConfigurationKeyValueModifiedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAppConfigurationKeyValueModifiedEventData(document.RootElement);
        }

        internal partial class AppConfigurationKeyValueModifiedEventDataConverter : JsonConverter<AppConfigurationKeyValueModifiedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AppConfigurationKeyValueModifiedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override AppConfigurationKeyValueModifiedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAppConfigurationKeyValueModifiedEventData(document.RootElement);
            }
        }
    }
}
