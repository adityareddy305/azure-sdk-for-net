// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Communication
{
    internal class CommunicationDomainResourceOperationSource : IOperationSource<CommunicationDomainResource>
    {
        private readonly ArmClient _client;

        internal CommunicationDomainResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        CommunicationDomainResource IOperationSource<CommunicationDomainResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CommunicationDomainResourceData.DeserializeCommunicationDomainResourceData(document.RootElement);
            return new CommunicationDomainResource(_client, data);
        }

        async ValueTask<CommunicationDomainResource> IOperationSource<CommunicationDomainResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CommunicationDomainResourceData.DeserializeCommunicationDomainResourceData(document.RootElement);
            return new CommunicationDomainResource(_client, data);
        }
    }
}
