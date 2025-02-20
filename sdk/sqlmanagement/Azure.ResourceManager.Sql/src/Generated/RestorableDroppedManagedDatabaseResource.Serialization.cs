// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class RestorableDroppedManagedDatabaseResource : IJsonModel<RestorableDroppedManagedDatabaseData>
    {
        void IJsonModel<RestorableDroppedManagedDatabaseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RestorableDroppedManagedDatabaseData>)Data).Write(writer, options);

        RestorableDroppedManagedDatabaseData IJsonModel<RestorableDroppedManagedDatabaseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RestorableDroppedManagedDatabaseData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<RestorableDroppedManagedDatabaseData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        RestorableDroppedManagedDatabaseData IPersistableModel<RestorableDroppedManagedDatabaseData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RestorableDroppedManagedDatabaseData>(data, options);

        string IPersistableModel<RestorableDroppedManagedDatabaseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RestorableDroppedManagedDatabaseData>)Data).GetFormatFromOptions(options);
    }
}
