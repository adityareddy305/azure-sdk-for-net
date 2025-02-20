// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Cdn
{
    public partial class FrontDoorSecretResource : IJsonModel<FrontDoorSecretData>
    {
        void IJsonModel<FrontDoorSecretData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FrontDoorSecretData>)Data).Write(writer, options);

        FrontDoorSecretData IJsonModel<FrontDoorSecretData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FrontDoorSecretData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<FrontDoorSecretData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        FrontDoorSecretData IPersistableModel<FrontDoorSecretData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FrontDoorSecretData>(data, options);

        string IPersistableModel<FrontDoorSecretData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FrontDoorSecretData>)Data).GetFormatFromOptions(options);
    }
}
