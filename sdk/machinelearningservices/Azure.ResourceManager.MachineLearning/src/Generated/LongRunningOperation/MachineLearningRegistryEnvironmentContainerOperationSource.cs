// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    internal class MachineLearningRegistryEnvironmentContainerOperationSource : IOperationSource<MachineLearningRegistryEnvironmentContainerResource>
    {
        private readonly ArmClient _client;

        internal MachineLearningRegistryEnvironmentContainerOperationSource(ArmClient client)
        {
            _client = client;
        }

        MachineLearningRegistryEnvironmentContainerResource IOperationSource<MachineLearningRegistryEnvironmentContainerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MachineLearningEnvironmentContainerData.DeserializeMachineLearningEnvironmentContainerData(document.RootElement);
            return new MachineLearningRegistryEnvironmentContainerResource(_client, data);
        }

        async ValueTask<MachineLearningRegistryEnvironmentContainerResource> IOperationSource<MachineLearningRegistryEnvironmentContainerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MachineLearningEnvironmentContainerData.DeserializeMachineLearningEnvironmentContainerData(document.RootElement);
            return new MachineLearningRegistryEnvironmentContainerResource(_client, data);
        }
    }
}
