// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    internal class PreRulestackRuleOperationSource : IOperationSource<PreRulestackRuleResource>
    {
        private readonly ArmClient _client;

        internal PreRulestackRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        PreRulestackRuleResource IOperationSource<PreRulestackRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PreRulestackRuleData.DeserializePreRulestackRuleData(document.RootElement);
            return new PreRulestackRuleResource(_client, data);
        }

        async ValueTask<PreRulestackRuleResource> IOperationSource<PreRulestackRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PreRulestackRuleData.DeserializePreRulestackRuleData(document.RootElement);
            return new PreRulestackRuleResource(_client, data);
        }
    }
}
