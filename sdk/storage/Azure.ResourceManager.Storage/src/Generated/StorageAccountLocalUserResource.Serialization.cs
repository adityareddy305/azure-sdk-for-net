// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Storage
{
    public partial class StorageAccountLocalUserResource : IJsonModel<StorageAccountLocalUserData>
    {
        void IJsonModel<StorageAccountLocalUserData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<StorageAccountLocalUserData>)Data).Write(writer, options);

        StorageAccountLocalUserData IJsonModel<StorageAccountLocalUserData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<StorageAccountLocalUserData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<StorageAccountLocalUserData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        StorageAccountLocalUserData IPersistableModel<StorageAccountLocalUserData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<StorageAccountLocalUserData>(data, options);

        string IPersistableModel<StorageAccountLocalUserData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<StorageAccountLocalUserData>)Data).GetFormatFromOptions(options);
    }
}
