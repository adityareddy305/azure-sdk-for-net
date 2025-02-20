// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Synapse
{
    internal class SynapseRestorePointOperationSource : IOperationSource<SynapseRestorePointResource>
    {
        private readonly ArmClient _client;

        internal SynapseRestorePointOperationSource(ArmClient client)
        {
            _client = client;
        }

        SynapseRestorePointResource IOperationSource<SynapseRestorePointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SynapseRestorePointData.DeserializeSynapseRestorePointData(document.RootElement);
            return new SynapseRestorePointResource(_client, data);
        }

        async ValueTask<SynapseRestorePointResource> IOperationSource<SynapseRestorePointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SynapseRestorePointData.DeserializeSynapseRestorePointData(document.RootElement);
            return new SynapseRestorePointResource(_client, data);
        }
    }
}
