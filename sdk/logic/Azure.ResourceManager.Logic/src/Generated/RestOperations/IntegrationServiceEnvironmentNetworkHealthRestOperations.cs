// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Logic.Models;

namespace Azure.ResourceManager.Logic
{
    internal partial class IntegrationServiceEnvironmentNetworkHealthRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentNetworkHealthRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public IntegrationServiceEnvironmentNetworkHealthRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroup, true);
            uri.AppendPath("/providers/Microsoft.Logic/integrationServiceEnvironments/", false);
            uri.AppendPath(integrationServiceEnvironmentName, true);
            uri.AppendPath("/health/network", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroup, true);
            uri.AppendPath("/providers/Microsoft.Logic/integrationServiceEnvironments/", false);
            uri.AppendPath(integrationServiceEnvironmentName, true);
            uri.AppendPath("/health/network", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the integration service environment network health. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/> or <paramref name="integrationServiceEnvironmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/> or <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IReadOnlyDictionary<string, IntegrationServiceEnvironmentSubnetNetworkHealth>>> GetAsync(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroup, nameof(resourceGroup));
            Argument.AssertNotNullOrEmpty(integrationServiceEnvironmentName, nameof(integrationServiceEnvironmentName));

            using var message = CreateGetRequest(subscriptionId, resourceGroup, integrationServiceEnvironmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyDictionary<string, IntegrationServiceEnvironmentSubnetNetworkHealth> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        Dictionary<string, IntegrationServiceEnvironmentSubnetNetworkHealth> dictionary = new Dictionary<string, IntegrationServiceEnvironmentSubnetNetworkHealth>();
                        foreach (var property in document.RootElement.EnumerateObject())
                        {
                            dictionary.Add(property.Name, IntegrationServiceEnvironmentSubnetNetworkHealth.DeserializeIntegrationServiceEnvironmentSubnetNetworkHealth(property.Value));
                        }
                        value = dictionary;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the integration service environment network health. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroup"> The resource group. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/> or <paramref name="integrationServiceEnvironmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroup"/> or <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IReadOnlyDictionary<string, IntegrationServiceEnvironmentSubnetNetworkHealth>> Get(string subscriptionId, string resourceGroup, string integrationServiceEnvironmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroup, nameof(resourceGroup));
            Argument.AssertNotNullOrEmpty(integrationServiceEnvironmentName, nameof(integrationServiceEnvironmentName));

            using var message = CreateGetRequest(subscriptionId, resourceGroup, integrationServiceEnvironmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyDictionary<string, IntegrationServiceEnvironmentSubnetNetworkHealth> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        Dictionary<string, IntegrationServiceEnvironmentSubnetNetworkHealth> dictionary = new Dictionary<string, IntegrationServiceEnvironmentSubnetNetworkHealth>();
                        foreach (var property in document.RootElement.EnumerateObject())
                        {
                            dictionary.Add(property.Name, IntegrationServiceEnvironmentSubnetNetworkHealth.DeserializeIntegrationServiceEnvironmentSubnetNetworkHealth(property.Value));
                        }
                        value = dictionary;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
