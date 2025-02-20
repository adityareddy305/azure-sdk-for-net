// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ServiceWorkspaceApiReleaseResource : IJsonModel<ApiReleaseData>
    {
        void IJsonModel<ApiReleaseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ApiReleaseData>)Data).Write(writer, options);

        ApiReleaseData IJsonModel<ApiReleaseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ApiReleaseData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ApiReleaseData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ApiReleaseData IPersistableModel<ApiReleaseData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ApiReleaseData>(data, options);

        string IPersistableModel<ApiReleaseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ApiReleaseData>)Data).GetFormatFromOptions(options);
    }
}
