// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ManagedNetwork
{
    public partial class ManagedNetworkPeeringPolicyResource : IJsonModel<ManagedNetworkPeeringPolicyData>
    {
        void IJsonModel<ManagedNetworkPeeringPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ManagedNetworkPeeringPolicyData>)Data).Write(writer, options);

        ManagedNetworkPeeringPolicyData IJsonModel<ManagedNetworkPeeringPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ManagedNetworkPeeringPolicyData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ManagedNetworkPeeringPolicyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ManagedNetworkPeeringPolicyData IPersistableModel<ManagedNetworkPeeringPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ManagedNetworkPeeringPolicyData>(data, options);

        string IPersistableModel<ManagedNetworkPeeringPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ManagedNetworkPeeringPolicyData>)Data).GetFormatFromOptions(options);
    }
}
