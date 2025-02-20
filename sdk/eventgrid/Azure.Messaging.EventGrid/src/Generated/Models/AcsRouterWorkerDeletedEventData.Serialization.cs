// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsRouterWorkerDeletedEventDataConverter))]
    public partial class AcsRouterWorkerDeletedEventData
    {
        internal static AcsRouterWorkerDeletedEventData DeserializeAcsRouterWorkerDeletedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string workerId = default;
            string jobId = default;
            string channelReference = default;
            string channelId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workerId"u8))
                {
                    workerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelReference"u8))
                {
                    channelReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsRouterWorkerDeletedEventData(jobId, channelReference, channelId, workerId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AcsRouterWorkerDeletedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAcsRouterWorkerDeletedEventData(document.RootElement);
        }

        internal partial class AcsRouterWorkerDeletedEventDataConverter : JsonConverter<AcsRouterWorkerDeletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsRouterWorkerDeletedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override AcsRouterWorkerDeletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsRouterWorkerDeletedEventData(document.RootElement);
            }
        }
    }
}
