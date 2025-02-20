// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class P2SVpnGatewayOperationSource : IOperationSource<P2SVpnGatewayResource>
    {
        private readonly ArmClient _client;

        internal P2SVpnGatewayOperationSource(ArmClient client)
        {
            _client = client;
        }

        P2SVpnGatewayResource IOperationSource<P2SVpnGatewayResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = P2SVpnGatewayData.DeserializeP2SVpnGatewayData(document.RootElement);
            return new P2SVpnGatewayResource(_client, data);
        }

        async ValueTask<P2SVpnGatewayResource> IOperationSource<P2SVpnGatewayResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = P2SVpnGatewayData.DeserializeP2SVpnGatewayData(document.RootElement);
            return new P2SVpnGatewayResource(_client, data);
        }
    }
}
