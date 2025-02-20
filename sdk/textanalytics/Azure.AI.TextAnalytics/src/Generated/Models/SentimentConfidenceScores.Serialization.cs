// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    public partial class SentimentConfidenceScores : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("positive"u8);
            writer.WriteNumberValue(Positive);
            writer.WritePropertyName("neutral"u8);
            writer.WriteNumberValue(Neutral);
            writer.WritePropertyName("negative"u8);
            writer.WriteNumberValue(Negative);
            writer.WriteEndObject();
        }

        internal static SentimentConfidenceScores DeserializeSentimentConfidenceScores(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double positive = default;
            double neutral = default;
            double negative = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("positive"u8))
                {
                    positive = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("neutral"u8))
                {
                    neutral = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("negative"u8))
                {
                    negative = property.Value.GetDouble();
                    continue;
                }
            }
            return new SentimentConfidenceScores(positive, neutral, negative);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SentimentConfidenceScores FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSentimentConfidenceScores(document.RootElement);
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
