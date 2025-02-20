// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AppServicePlanEventTypeDetail
    {
        internal static AppServicePlanEventTypeDetail DeserializeAppServicePlanEventTypeDetail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StampKind? stampKind = default;
            AppServicePlanAction? action = default;
            AsyncStatus? status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stampKind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stampKind = new StampKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new AppServicePlanAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new AsyncStatus(property.Value.GetString());
                    continue;
                }
            }
            return new AppServicePlanEventTypeDetail(stampKind, action, status);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AppServicePlanEventTypeDetail FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAppServicePlanEventTypeDetail(document.RootElement);
        }
    }
}
