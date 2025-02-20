// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabArtifactSourceResource : IJsonModel<DevTestLabArtifactSourceData>
    {
        void IJsonModel<DevTestLabArtifactSourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DevTestLabArtifactSourceData>)Data).Write(writer, options);

        DevTestLabArtifactSourceData IJsonModel<DevTestLabArtifactSourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DevTestLabArtifactSourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DevTestLabArtifactSourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DevTestLabArtifactSourceData IPersistableModel<DevTestLabArtifactSourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DevTestLabArtifactSourceData>(data, options);

        string IPersistableModel<DevTestLabArtifactSourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DevTestLabArtifactSourceData>)Data).GetFormatFromOptions(options);
    }
}
