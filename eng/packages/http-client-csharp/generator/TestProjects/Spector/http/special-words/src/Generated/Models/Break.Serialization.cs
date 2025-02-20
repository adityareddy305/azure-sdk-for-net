// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace SpecialWords._Models
{
    public partial class Break : IJsonModel<Break>
    {
        void IJsonModel<Break>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        Break IJsonModel<Break>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual Break JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<Break>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        Break IPersistableModel<Break>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual Break PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<Break>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="break"> The <see cref="Break"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(Break @break) => throw null;

        public static explicit operator Break(Response result) => throw null;
    }
}
