// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    internal class ResourceGroupLongTermRetentionBackupOperationSource : IOperationSource<ResourceGroupLongTermRetentionBackupResource>
    {
        private readonly ArmClient _client;

        internal ResourceGroupLongTermRetentionBackupOperationSource(ArmClient client)
        {
            _client = client;
        }

        ResourceGroupLongTermRetentionBackupResource IOperationSource<ResourceGroupLongTermRetentionBackupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LongTermRetentionBackupData.DeserializeLongTermRetentionBackupData(document.RootElement);
            return new ResourceGroupLongTermRetentionBackupResource(_client, data);
        }

        async ValueTask<ResourceGroupLongTermRetentionBackupResource> IOperationSource<ResourceGroupLongTermRetentionBackupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LongTermRetentionBackupData.DeserializeLongTermRetentionBackupData(document.RootElement);
            return new ResourceGroupLongTermRetentionBackupResource(_client, data);
        }
    }
}
