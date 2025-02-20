// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class DataPointAnomaly
    {
        internal static DataPointAnomaly DeserializeDataPointAnomaly(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dataFeedId = default;
            string metricId = default;
            string anomalyDetectionConfigurationId = default;
            DateTimeOffset timestamp = default;
            DateTimeOffset? createdTime = default;
            DateTimeOffset? modifiedTime = default;
            IReadOnlyDictionary<string, string> dimension = default;
            AnomalyProperty property = default;
            foreach (var property0 in element.EnumerateObject())
            {
                if (property0.NameEquals("dataFeedId"u8))
                {
                    dataFeedId = property0.Value.GetString();
                    continue;
                }
                if (property0.NameEquals("metricId"u8))
                {
                    metricId = property0.Value.GetString();
                    continue;
                }
                if (property0.NameEquals("anomalyDetectionConfigurationId"u8))
                {
                    anomalyDetectionConfigurationId = property0.Value.GetString();
                    continue;
                }
                if (property0.NameEquals("timestamp"u8))
                {
                    timestamp = property0.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property0.NameEquals("createdTime"u8))
                {
                    if (property0.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property0.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property0.NameEquals("modifiedTime"u8))
                {
                    if (property0.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedTime = property0.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property0.NameEquals("dimension"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property1 in property0.Value.EnumerateObject())
                    {
                        dictionary.Add(property1.Name, property1.Value.GetString());
                    }
                    dimension = dictionary;
                    continue;
                }
                if (property0.NameEquals("property"u8))
                {
                    property = AnomalyProperty.DeserializeAnomalyProperty(property0.Value);
                    continue;
                }
            }
            return new DataPointAnomaly(
                dataFeedId,
                metricId,
                anomalyDetectionConfigurationId,
                timestamp,
                createdTime,
                modifiedTime,
                dimension,
                property);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DataPointAnomaly FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDataPointAnomaly(document.RootElement);
        }
    }
}
