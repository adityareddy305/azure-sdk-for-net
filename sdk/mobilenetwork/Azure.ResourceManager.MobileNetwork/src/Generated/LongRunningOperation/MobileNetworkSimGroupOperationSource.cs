// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork
{
    internal class MobileNetworkSimGroupOperationSource : IOperationSource<MobileNetworkSimGroupResource>
    {
        private readonly ArmClient _client;

        internal MobileNetworkSimGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        MobileNetworkSimGroupResource IOperationSource<MobileNetworkSimGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MobileNetworkSimGroupData.DeserializeMobileNetworkSimGroupData(document.RootElement);
            return new MobileNetworkSimGroupResource(_client, data);
        }

        async ValueTask<MobileNetworkSimGroupResource> IOperationSource<MobileNetworkSimGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MobileNetworkSimGroupData.DeserializeMobileNetworkSimGroupData(document.RootElement);
            return new MobileNetworkSimGroupResource(_client, data);
        }
    }
}
