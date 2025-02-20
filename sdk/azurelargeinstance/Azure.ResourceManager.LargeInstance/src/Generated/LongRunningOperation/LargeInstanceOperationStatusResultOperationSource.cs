// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.LargeInstance.Models;

namespace Azure.ResourceManager.LargeInstance
{
    internal class LargeInstanceOperationStatusResultOperationSource : IOperationSource<LargeInstanceOperationStatusResult>
    {
        LargeInstanceOperationStatusResult IOperationSource<LargeInstanceOperationStatusResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return LargeInstanceOperationStatusResult.DeserializeLargeInstanceOperationStatusResult(document.RootElement);
        }

        async ValueTask<LargeInstanceOperationStatusResult> IOperationSource<LargeInstanceOperationStatusResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return LargeInstanceOperationStatusResult.DeserializeLargeInstanceOperationStatusResult(document.RootElement);
        }
    }
}
