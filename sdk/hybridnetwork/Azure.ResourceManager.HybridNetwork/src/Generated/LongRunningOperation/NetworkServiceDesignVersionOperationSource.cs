// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork
{
    internal class NetworkServiceDesignVersionOperationSource : IOperationSource<NetworkServiceDesignVersionResource>
    {
        private readonly ArmClient _client;

        internal NetworkServiceDesignVersionOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkServiceDesignVersionResource IOperationSource<NetworkServiceDesignVersionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkServiceDesignVersionData.DeserializeNetworkServiceDesignVersionData(document.RootElement);
            return new NetworkServiceDesignVersionResource(_client, data);
        }

        async ValueTask<NetworkServiceDesignVersionResource> IOperationSource<NetworkServiceDesignVersionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkServiceDesignVersionData.DeserializeNetworkServiceDesignVersionData(document.RootElement);
            return new NetworkServiceDesignVersionResource(_client, data);
        }
    }
}
