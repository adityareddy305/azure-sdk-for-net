// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    internal class MySqlFlexibleServerAadAdministratorOperationSource : IOperationSource<MySqlFlexibleServerAadAdministratorResource>
    {
        private readonly ArmClient _client;

        internal MySqlFlexibleServerAadAdministratorOperationSource(ArmClient client)
        {
            _client = client;
        }

        MySqlFlexibleServerAadAdministratorResource IOperationSource<MySqlFlexibleServerAadAdministratorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MySqlFlexibleServerAadAdministratorData.DeserializeMySqlFlexibleServerAadAdministratorData(document.RootElement);
            return new MySqlFlexibleServerAadAdministratorResource(_client, data);
        }

        async ValueTask<MySqlFlexibleServerAadAdministratorResource> IOperationSource<MySqlFlexibleServerAadAdministratorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MySqlFlexibleServerAadAdministratorData.DeserializeMySqlFlexibleServerAadAdministratorData(document.RootElement);
            return new MySqlFlexibleServerAadAdministratorResource(_client, data);
        }
    }
}
