// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class MetricSeriesData
    {
        internal static MetricSeriesData DeserializeMetricSeriesData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MetricSeriesDefinition id = default;
            IReadOnlyList<DateTimeOffset> timestampList = default;
            IReadOnlyList<double> valueList = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = MetricSeriesDefinition.DeserializeMetricSeriesDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("timestampList"u8))
                {
                    List<DateTimeOffset> array = new List<DateTimeOffset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDateTimeOffset("O"));
                    }
                    timestampList = array;
                    continue;
                }
                if (property.NameEquals("valueList"u8))
                {
                    List<double> array = new List<double>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDouble());
                    }
                    valueList = array;
                    continue;
                }
            }
            return new MetricSeriesData(id, timestampList, valueList);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MetricSeriesData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMetricSeriesData(document.RootElement);
        }
    }
}
