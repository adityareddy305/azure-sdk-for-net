// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Routing.Models
{
    public partial class RouteDirectionsBatchItemResponse
    {
        internal static RouteDirectionsBatchItemResponse DeserializeRouteDirectionsBatchItemResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ErrorDetail error = default;
            string formatVersion = default;
            IReadOnlyList<RouteData> routes = default;
            IReadOnlyList<RouteOptimizedWaypoint> optimizedWaypoints = default;
            RouteReport report = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = Models.ErrorDetail.DeserializeErrorDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("formatVersion"u8))
                {
                    formatVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteData> array = new List<RouteData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteData.DeserializeRouteData(item));
                    }
                    routes = array;
                    continue;
                }
                if (property.NameEquals("optimizedWaypoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteOptimizedWaypoint> array = new List<RouteOptimizedWaypoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteOptimizedWaypoint.DeserializeRouteOptimizedWaypoint(item));
                    }
                    optimizedWaypoints = array;
                    continue;
                }
                if (property.NameEquals("report"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    report = RouteReport.DeserializeRouteReport(property.Value);
                    continue;
                }
            }
            return new RouteDirectionsBatchItemResponse(formatVersion, routes ?? new ChangeTrackingList<RouteData>(), optimizedWaypoints ?? new ChangeTrackingList<RouteOptimizedWaypoint>(), report, error);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new RouteDirectionsBatchItemResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRouteDirectionsBatchItemResponse(document.RootElement);
        }
    }
}
