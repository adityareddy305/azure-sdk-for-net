// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Support
{
    public partial class SupportTicketNoSubChatTranscriptResource : IJsonModel<ChatTranscriptDetailData>
    {
        void IJsonModel<ChatTranscriptDetailData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ChatTranscriptDetailData>)Data).Write(writer, options);

        ChatTranscriptDetailData IJsonModel<ChatTranscriptDetailData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ChatTranscriptDetailData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ChatTranscriptDetailData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ChatTranscriptDetailData IPersistableModel<ChatTranscriptDetailData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ChatTranscriptDetailData>(data, options);

        string IPersistableModel<ChatTranscriptDetailData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ChatTranscriptDetailData>)Data).GetFormatFromOptions(options);
    }
}
