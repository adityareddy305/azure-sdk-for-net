// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SubscriptionSecurityTaskResource : IJsonModel<SecurityTaskData>
    {
        void IJsonModel<SecurityTaskData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SecurityTaskData>)Data).Write(writer, options);

        SecurityTaskData IJsonModel<SecurityTaskData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SecurityTaskData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SecurityTaskData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SecurityTaskData IPersistableModel<SecurityTaskData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SecurityTaskData>(data, options);

        string IPersistableModel<SecurityTaskData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SecurityTaskData>)Data).GetFormatFromOptions(options);
    }
}
