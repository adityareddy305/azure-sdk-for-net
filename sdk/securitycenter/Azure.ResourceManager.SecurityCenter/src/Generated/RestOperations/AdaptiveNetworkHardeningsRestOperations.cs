// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    internal partial class AdaptiveNetworkHardeningsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AdaptiveNetworkHardeningsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AdaptiveNetworkHardeningsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-01-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListByExtendedResourceRequestUri(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/", false);
            uri.AppendPath(resourceNamespace, true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceType, true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/providers/Microsoft.Security/adaptiveNetworkHardenings", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByExtendedResourceRequest(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/", false);
            uri.AppendPath(resourceNamespace, true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceType, true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/providers/Microsoft.Security/adaptiveNetworkHardenings", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of Adaptive Network Hardenings resources in scope of an extended resource. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="resourceNamespace"> The Namespace of the resource. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="resourceName"> Name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AdaptiveNetworkHardeningsList>> ListByExtendedResourceAsync(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceNamespace, nameof(resourceNamespace));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListByExtendedResourceRequest(subscriptionId, resourceGroupName, resourceNamespace, resourceType, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AdaptiveNetworkHardeningsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AdaptiveNetworkHardeningsList.DeserializeAdaptiveNetworkHardeningsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of Adaptive Network Hardenings resources in scope of an extended resource. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="resourceNamespace"> The Namespace of the resource. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="resourceName"> Name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AdaptiveNetworkHardeningsList> ListByExtendedResource(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceNamespace, nameof(resourceNamespace));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListByExtendedResourceRequest(subscriptionId, resourceGroupName, resourceNamespace, resourceType, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AdaptiveNetworkHardeningsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AdaptiveNetworkHardeningsList.DeserializeAdaptiveNetworkHardeningsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, string adaptiveNetworkHardeningResourceName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/", false);
            uri.AppendPath(resourceNamespace, true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceType, true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/providers/Microsoft.Security/adaptiveNetworkHardenings/", false);
            uri.AppendPath(adaptiveNetworkHardeningResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, string adaptiveNetworkHardeningResourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/", false);
            uri.AppendPath(resourceNamespace, true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceType, true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/providers/Microsoft.Security/adaptiveNetworkHardenings/", false);
            uri.AppendPath(adaptiveNetworkHardeningResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a single Adaptive Network Hardening resource. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="resourceNamespace"> The Namespace of the resource. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="resourceName"> Name of the resource. </param>
        /// <param name="adaptiveNetworkHardeningResourceName"> The name of the Adaptive Network Hardening resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="adaptiveNetworkHardeningResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="adaptiveNetworkHardeningResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AdaptiveNetworkHardeningData>> GetAsync(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, string adaptiveNetworkHardeningResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceNamespace, nameof(resourceNamespace));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(adaptiveNetworkHardeningResourceName, nameof(adaptiveNetworkHardeningResourceName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceNamespace, resourceType, resourceName, adaptiveNetworkHardeningResourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AdaptiveNetworkHardeningData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AdaptiveNetworkHardeningData.DeserializeAdaptiveNetworkHardeningData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AdaptiveNetworkHardeningData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a single Adaptive Network Hardening resource. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="resourceNamespace"> The Namespace of the resource. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="resourceName"> Name of the resource. </param>
        /// <param name="adaptiveNetworkHardeningResourceName"> The name of the Adaptive Network Hardening resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="adaptiveNetworkHardeningResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="adaptiveNetworkHardeningResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AdaptiveNetworkHardeningData> Get(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, string adaptiveNetworkHardeningResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceNamespace, nameof(resourceNamespace));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(adaptiveNetworkHardeningResourceName, nameof(adaptiveNetworkHardeningResourceName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceNamespace, resourceType, resourceName, adaptiveNetworkHardeningResourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AdaptiveNetworkHardeningData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AdaptiveNetworkHardeningData.DeserializeAdaptiveNetworkHardeningData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AdaptiveNetworkHardeningData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateEnforceRequestUri(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, string adaptiveNetworkHardeningResourceName, AdaptiveNetworkHardeningEnforceContent content)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/", false);
            uri.AppendPath(resourceNamespace, true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceType, true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/providers/Microsoft.Security/adaptiveNetworkHardenings/", false);
            uri.AppendPath(adaptiveNetworkHardeningResourceName, true);
            uri.AppendPath("/", false);
            uri.AppendPath("enforce", true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateEnforceRequest(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, string adaptiveNetworkHardeningResourceName, AdaptiveNetworkHardeningEnforceContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/", false);
            uri.AppendPath(resourceNamespace, true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceType, true);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/providers/Microsoft.Security/adaptiveNetworkHardenings/", false);
            uri.AppendPath(adaptiveNetworkHardeningResourceName, true);
            uri.AppendPath("/", false);
            uri.AppendPath("enforce", true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content, ModelSerializationExtensions.WireOptions);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Enforces the given rules on the NSG(s) listed in the request. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="resourceNamespace"> The Namespace of the resource. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="resourceName"> Name of the resource. </param>
        /// <param name="adaptiveNetworkHardeningResourceName"> The name of the Adaptive Network Hardening resource. </param>
        /// <param name="content"> The <see cref="AdaptiveNetworkHardeningEnforceContent"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/>, <paramref name="adaptiveNetworkHardeningResourceName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="adaptiveNetworkHardeningResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> EnforceAsync(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, string adaptiveNetworkHardeningResourceName, AdaptiveNetworkHardeningEnforceContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceNamespace, nameof(resourceNamespace));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(adaptiveNetworkHardeningResourceName, nameof(adaptiveNetworkHardeningResourceName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateEnforceRequest(subscriptionId, resourceGroupName, resourceNamespace, resourceType, resourceName, adaptiveNetworkHardeningResourceName, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Enforces the given rules on the NSG(s) listed in the request. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="resourceNamespace"> The Namespace of the resource. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="resourceName"> Name of the resource. </param>
        /// <param name="adaptiveNetworkHardeningResourceName"> The name of the Adaptive Network Hardening resource. </param>
        /// <param name="content"> The <see cref="AdaptiveNetworkHardeningEnforceContent"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/>, <paramref name="adaptiveNetworkHardeningResourceName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/>, <paramref name="resourceName"/> or <paramref name="adaptiveNetworkHardeningResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Enforce(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, string adaptiveNetworkHardeningResourceName, AdaptiveNetworkHardeningEnforceContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceNamespace, nameof(resourceNamespace));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(adaptiveNetworkHardeningResourceName, nameof(adaptiveNetworkHardeningResourceName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateEnforceRequest(subscriptionId, resourceGroupName, resourceNamespace, resourceType, resourceName, adaptiveNetworkHardeningResourceName, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByExtendedResourceNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByExtendedResourceNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of Adaptive Network Hardenings resources in scope of an extended resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="resourceNamespace"> The Namespace of the resource. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="resourceName"> Name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AdaptiveNetworkHardeningsList>> ListByExtendedResourceNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceNamespace, nameof(resourceNamespace));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListByExtendedResourceNextPageRequest(nextLink, subscriptionId, resourceGroupName, resourceNamespace, resourceType, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AdaptiveNetworkHardeningsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AdaptiveNetworkHardeningsList.DeserializeAdaptiveNetworkHardeningsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of Adaptive Network Hardenings resources in scope of an extended resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the user's subscription. The name is case insensitive. </param>
        /// <param name="resourceNamespace"> The Namespace of the resource. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="resourceName"> Name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceNamespace"/>, <paramref name="resourceType"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AdaptiveNetworkHardeningsList> ListByExtendedResourceNextPage(string nextLink, string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceNamespace, nameof(resourceNamespace));
            Argument.AssertNotNullOrEmpty(resourceType, nameof(resourceType));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListByExtendedResourceNextPageRequest(nextLink, subscriptionId, resourceGroupName, resourceNamespace, resourceType, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AdaptiveNetworkHardeningsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AdaptiveNetworkHardeningsList.DeserializeAdaptiveNetworkHardeningsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
