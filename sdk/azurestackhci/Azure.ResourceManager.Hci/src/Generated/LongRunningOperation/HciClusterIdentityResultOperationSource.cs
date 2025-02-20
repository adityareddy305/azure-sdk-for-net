// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;

namespace Azure.ResourceManager.Hci
{
    internal class HciClusterIdentityResultOperationSource : IOperationSource<HciClusterIdentityResult>
    {
        HciClusterIdentityResult IOperationSource<HciClusterIdentityResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return HciClusterIdentityResult.DeserializeHciClusterIdentityResult(document.RootElement);
        }

        async ValueTask<HciClusterIdentityResult> IOperationSource<HciClusterIdentityResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return HciClusterIdentityResult.DeserializeHciClusterIdentityResult(document.RootElement);
        }
    }
}
