// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry
{
    internal class ContainerRegistryArchiveVersionOperationSource : IOperationSource<ContainerRegistryArchiveVersionResource>
    {
        private readonly ArmClient _client;

        internal ContainerRegistryArchiveVersionOperationSource(ArmClient client)
        {
            _client = client;
        }

        ContainerRegistryArchiveVersionResource IOperationSource<ContainerRegistryArchiveVersionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ContainerRegistryArchiveVersionData.DeserializeContainerRegistryArchiveVersionData(document.RootElement);
            return new ContainerRegistryArchiveVersionResource(_client, data);
        }

        async ValueTask<ContainerRegistryArchiveVersionResource> IOperationSource<ContainerRegistryArchiveVersionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ContainerRegistryArchiveVersionData.DeserializeContainerRegistryArchiveVersionData(document.RootElement);
            return new ContainerRegistryArchiveVersionResource(_client, data);
        }
    }
}
