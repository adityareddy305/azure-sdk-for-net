// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Xml.Linq;

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class StorageError
    {
        internal static StorageError DeserializeStorageError(XElement element)
        {
            StorageErrorError error = default;
            if (element.Element("error") is XElement errorElement)
            {
                error = StorageErrorError.DeserializeStorageErrorError(errorElement);
            }
            return new StorageError(error);
        }

        internal static StorageError DeserializeStorageError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StorageErrorError error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = StorageErrorError.DeserializeStorageErrorError(property.Value);
                    continue;
                }
            }
            return new StorageError(error);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static StorageError FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeStorageError(document.RootElement);
        }
    }
}
