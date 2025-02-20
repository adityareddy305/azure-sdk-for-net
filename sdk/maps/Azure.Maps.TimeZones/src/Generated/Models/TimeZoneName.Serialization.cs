// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Maps.TimeZones
{
    public partial class TimeZoneName
    {
        internal static TimeZoneName DeserializeTimeZoneName(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string isO6391LanguageCode = default;
            string generic = default;
            string standard = default;
            string daylight = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ISO6391LanguageCode"u8))
                {
                    isO6391LanguageCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Generic"u8))
                {
                    generic = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Standard"u8))
                {
                    standard = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Daylight"u8))
                {
                    daylight = property.Value.GetString();
                    continue;
                }
            }
            return new TimeZoneName(isO6391LanguageCode, generic, standard, daylight);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TimeZoneName FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTimeZoneName(document.RootElement);
        }
    }
}
