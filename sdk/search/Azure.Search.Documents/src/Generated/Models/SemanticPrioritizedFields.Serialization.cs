// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SemanticPrioritizedFields : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TitleField))
            {
                writer.WritePropertyName("titleField"u8);
                writer.WriteObjectValue(TitleField);
            }
            if (Optional.IsCollectionDefined(ContentFields))
            {
                writer.WritePropertyName("prioritizedContentFields"u8);
                writer.WriteStartArray();
                foreach (var item in ContentFields)
                {
                    writer.WriteObjectValue<SemanticField>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(KeywordsFields))
            {
                writer.WritePropertyName("prioritizedKeywordsFields"u8);
                writer.WriteStartArray();
                foreach (var item in KeywordsFields)
                {
                    writer.WriteObjectValue<SemanticField>(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SemanticPrioritizedFields DeserializeSemanticPrioritizedFields(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SemanticField titleField = default;
            IList<SemanticField> prioritizedContentFields = default;
            IList<SemanticField> prioritizedKeywordsFields = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("titleField"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    titleField = SemanticField.DeserializeSemanticField(property.Value);
                    continue;
                }
                if (property.NameEquals("prioritizedContentFields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SemanticField> array = new List<SemanticField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SemanticField.DeserializeSemanticField(item));
                    }
                    prioritizedContentFields = array;
                    continue;
                }
                if (property.NameEquals("prioritizedKeywordsFields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SemanticField> array = new List<SemanticField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SemanticField.DeserializeSemanticField(item));
                    }
                    prioritizedKeywordsFields = array;
                    continue;
                }
            }
            return new SemanticPrioritizedFields(titleField, prioritizedContentFields ?? new ChangeTrackingList<SemanticField>(), prioritizedKeywordsFields ?? new ChangeTrackingList<SemanticField>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SemanticPrioritizedFields FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSemanticPrioritizedFields(document.RootElement);
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
