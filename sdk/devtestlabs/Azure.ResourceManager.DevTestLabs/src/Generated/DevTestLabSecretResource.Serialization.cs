// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabSecretResource : IJsonModel<DevTestLabSecretData>
    {
        void IJsonModel<DevTestLabSecretData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DevTestLabSecretData>)Data).Write(writer, options);

        DevTestLabSecretData IJsonModel<DevTestLabSecretData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DevTestLabSecretData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DevTestLabSecretData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DevTestLabSecretData IPersistableModel<DevTestLabSecretData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DevTestLabSecretData>(data, options);

        string IPersistableModel<DevTestLabSecretData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DevTestLabSecretData>)Data).GetFormatFromOptions(options);
    }
}
