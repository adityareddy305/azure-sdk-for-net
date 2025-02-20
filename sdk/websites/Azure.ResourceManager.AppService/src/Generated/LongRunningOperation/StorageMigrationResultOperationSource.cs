// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    internal class StorageMigrationResultOperationSource : IOperationSource<StorageMigrationResult>
    {
        StorageMigrationResult IOperationSource<StorageMigrationResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return StorageMigrationResult.DeserializeStorageMigrationResult(document.RootElement);
        }

        async ValueTask<StorageMigrationResult> IOperationSource<StorageMigrationResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return StorageMigrationResult.DeserializeStorageMigrationResult(document.RootElement);
        }
    }
}
