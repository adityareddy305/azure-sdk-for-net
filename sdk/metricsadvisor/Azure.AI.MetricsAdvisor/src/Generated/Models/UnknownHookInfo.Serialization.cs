// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.MetricsAdvisor.Administration;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class UnknownHookInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("hookType"u8);
            writer.WriteStringValue(HookKind.ToString());
            writer.WritePropertyName("hookName"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(InternalExternalLink))
            {
                writer.WritePropertyName("externalLink"u8);
                writer.WriteStringValue(InternalExternalLink);
            }
            if (Optional.IsCollectionDefined(Administrators))
            {
                writer.WritePropertyName("admins"u8);
                writer.WriteStartArray();
                foreach (var item in Administrators)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static UnknownHookInfo DeserializeUnknownHookInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NotificationHookKind hookType = "Unknown";
            string hookId = default;
            string hookName = default;
            string description = default;
            string externalLink = default;
            IList<string> admins = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hookType"u8))
                {
                    hookType = new NotificationHookKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hookId"u8))
                {
                    hookId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hookName"u8))
                {
                    hookName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("externalLink"u8))
                {
                    externalLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("admins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    admins = array;
                    continue;
                }
            }
            return new UnknownHookInfo(
                hookType,
                hookId,
                hookName,
                description,
                externalLink,
                admins ?? new ChangeTrackingList<string>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new UnknownHookInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnknownHookInfo(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<NotificationHook>(this);
            return content;
        }
    }
}
