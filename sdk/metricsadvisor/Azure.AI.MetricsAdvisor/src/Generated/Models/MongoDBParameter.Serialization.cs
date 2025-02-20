// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class MongoDBParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionString))
            {
                if (ConnectionString != null)
                {
                    writer.WritePropertyName("connectionString"u8);
                    writer.WriteStringValue(ConnectionString);
                }
                else
                {
                    writer.WriteNull("connectionString");
                }
            }
            if (Optional.IsDefined(Database))
            {
                if (Database != null)
                {
                    writer.WritePropertyName("database"u8);
                    writer.WriteStringValue(Database);
                }
                else
                {
                    writer.WriteNull("database");
                }
            }
            if (Command != null)
            {
                writer.WritePropertyName("command"u8);
                writer.WriteStringValue(Command);
            }
            else
            {
                writer.WriteNull("command");
            }
            writer.WriteEndObject();
        }

        internal static MongoDBParameter DeserializeMongoDBParameter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string connectionString = default;
            string database = default;
            string command = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        connectionString = null;
                        continue;
                    }
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("database"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        database = null;
                        continue;
                    }
                    database = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("command"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        command = null;
                        continue;
                    }
                    command = property.Value.GetString();
                    continue;
                }
            }
            return new MongoDBParameter(connectionString, database, command);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MongoDBParameter FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMongoDBParameter(document.RootElement);
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
