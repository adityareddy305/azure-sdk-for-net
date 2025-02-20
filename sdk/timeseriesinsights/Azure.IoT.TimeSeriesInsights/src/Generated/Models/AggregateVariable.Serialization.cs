// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class AggregateVariable : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("aggregation"u8);
            writer.WriteObjectValue(Aggregation);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter);
            }
            writer.WriteEndObject();
        }

        internal static AggregateVariable DeserializeAggregateVariable(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSeriesExpression aggregation = default;
            string kind = default;
            TimeSeriesExpression filter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aggregation"u8))
                {
                    aggregation = TimeSeriesExpression.DeserializeTimeSeriesExpression(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = TimeSeriesExpression.DeserializeTimeSeriesExpression(property.Value);
                    continue;
                }
            }
            return new AggregateVariable(kind, filter, aggregation);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AggregateVariable FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAggregateVariable(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
