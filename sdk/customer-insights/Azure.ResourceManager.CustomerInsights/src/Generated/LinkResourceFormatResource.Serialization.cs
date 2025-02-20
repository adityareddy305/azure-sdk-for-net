// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class LinkResourceFormatResource : IJsonModel<LinkResourceFormatData>
    {
        void IJsonModel<LinkResourceFormatData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<LinkResourceFormatData>)Data).Write(writer, options);

        LinkResourceFormatData IJsonModel<LinkResourceFormatData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<LinkResourceFormatData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<LinkResourceFormatData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        LinkResourceFormatData IPersistableModel<LinkResourceFormatData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<LinkResourceFormatData>(data, options);

        string IPersistableModel<LinkResourceFormatData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<LinkResourceFormatData>)Data).GetFormatFromOptions(options);
    }
}
