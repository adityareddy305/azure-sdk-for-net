// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Marketplace
{
    public partial class MarketplaceAdminApprovalRequestResource : IJsonModel<MarketplaceAdminApprovalRequestData>
    {
        void IJsonModel<MarketplaceAdminApprovalRequestData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MarketplaceAdminApprovalRequestData>)Data).Write(writer, options);

        MarketplaceAdminApprovalRequestData IJsonModel<MarketplaceAdminApprovalRequestData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MarketplaceAdminApprovalRequestData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MarketplaceAdminApprovalRequestData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        MarketplaceAdminApprovalRequestData IPersistableModel<MarketplaceAdminApprovalRequestData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MarketplaceAdminApprovalRequestData>(data, options);

        string IPersistableModel<MarketplaceAdminApprovalRequestData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MarketplaceAdminApprovalRequestData>)Data).GetFormatFromOptions(options);
    }
}
