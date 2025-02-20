// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ScVmm
{
    internal class ScVmmVirtualMachineInstanceOperationSource : IOperationSource<ScVmmVirtualMachineInstanceResource>
    {
        private readonly ArmClient _client;

        internal ScVmmVirtualMachineInstanceOperationSource(ArmClient client)
        {
            _client = client;
        }

        ScVmmVirtualMachineInstanceResource IOperationSource<ScVmmVirtualMachineInstanceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ScVmmVirtualMachineInstanceData.DeserializeScVmmVirtualMachineInstanceData(document.RootElement);
            return new ScVmmVirtualMachineInstanceResource(_client, data);
        }

        async ValueTask<ScVmmVirtualMachineInstanceResource> IOperationSource<ScVmmVirtualMachineInstanceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ScVmmVirtualMachineInstanceData.DeserializeScVmmVirtualMachineInstanceData(document.RootElement);
            return new ScVmmVirtualMachineInstanceResource(_client, data);
        }
    }
}
