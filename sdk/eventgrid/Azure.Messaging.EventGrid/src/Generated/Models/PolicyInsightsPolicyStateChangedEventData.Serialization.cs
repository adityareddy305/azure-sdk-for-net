// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(PolicyInsightsPolicyStateChangedEventDataConverter))]
    public partial class PolicyInsightsPolicyStateChangedEventData
    {
        internal static PolicyInsightsPolicyStateChangedEventData DeserializePolicyInsightsPolicyStateChangedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? timestamp = default;
            string policyAssignmentId = default;
            string policyDefinitionId = default;
            string policyDefinitionReferenceId = default;
            string complianceState = default;
            string subscriptionId = default;
            string complianceReasonCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("policyAssignmentId"u8))
                {
                    policyAssignmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionId"u8))
                {
                    policyDefinitionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionReferenceId"u8))
                {
                    policyDefinitionReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceState"u8))
                {
                    complianceState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceReasonCode"u8))
                {
                    complianceReasonCode = property.Value.GetString();
                    continue;
                }
            }
            return new PolicyInsightsPolicyStateChangedEventData(
                timestamp,
                policyAssignmentId,
                policyDefinitionId,
                policyDefinitionReferenceId,
                complianceState,
                subscriptionId,
                complianceReasonCode);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PolicyInsightsPolicyStateChangedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePolicyInsightsPolicyStateChangedEventData(document.RootElement);
        }

        internal partial class PolicyInsightsPolicyStateChangedEventDataConverter : JsonConverter<PolicyInsightsPolicyStateChangedEventData>
        {
            public override void Write(Utf8JsonWriter writer, PolicyInsightsPolicyStateChangedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override PolicyInsightsPolicyStateChangedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializePolicyInsightsPolicyStateChangedEventData(document.RootElement);
            }
        }
    }
}
