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
using Azure.ResourceManager.Logic.Models;

namespace Azure.ResourceManager.Logic
{
    internal partial class WorkflowRunActionRepetitionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of WorkflowRunActionRepetitionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public WorkflowRunActionRepetitionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Logic/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/repetitions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName)
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
            uri.AppendPath("/providers/Microsoft.Logic/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/repetitions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get all of a workflow run action repetitions. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LogicWorkflowRunActionRepetitionDefinitionList>> ListAsync(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workflowName, runName, actionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowRunActionRepetitionDefinitionList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogicWorkflowRunActionRepetitionDefinitionList.DeserializeLogicWorkflowRunActionRepetitionDefinitionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all of a workflow run action repetitions. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LogicWorkflowRunActionRepetitionDefinitionList> List(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workflowName, runName, actionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowRunActionRepetitionDefinitionList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogicWorkflowRunActionRepetitionDefinitionList.DeserializeLogicWorkflowRunActionRepetitionDefinitionList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, string repetitionName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Logic/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/repetitions/", false);
            uri.AppendPath(repetitionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, string repetitionName)
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
            uri.AppendPath("/providers/Microsoft.Logic/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/repetitions/", false);
            uri.AppendPath(repetitionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a workflow run action repetition. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LogicWorkflowRunActionRepetitionDefinitionData>> GetAsync(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workflowName, runName, actionName, repetitionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowRunActionRepetitionDefinitionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogicWorkflowRunActionRepetitionDefinitionData.DeserializeLogicWorkflowRunActionRepetitionDefinitionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((LogicWorkflowRunActionRepetitionDefinitionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a workflow run action repetition. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LogicWorkflowRunActionRepetitionDefinitionData> Get(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workflowName, runName, actionName, repetitionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowRunActionRepetitionDefinitionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogicWorkflowRunActionRepetitionDefinitionData.DeserializeLogicWorkflowRunActionRepetitionDefinitionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((LogicWorkflowRunActionRepetitionDefinitionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListExpressionTracesRequestUri(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, string repetitionName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Logic/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/repetitions/", false);
            uri.AppendPath(repetitionName, true);
            uri.AppendPath("/listExpressionTraces", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListExpressionTracesRequest(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, string repetitionName)
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
            uri.AppendPath("/providers/Microsoft.Logic/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/repetitions/", false);
            uri.AppendPath(repetitionName, true);
            uri.AppendPath("/listExpressionTraces", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists a workflow run expression trace. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ExpressionTraces>> ListExpressionTracesAsync(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var message = CreateListExpressionTracesRequest(subscriptionId, resourceGroupName, workflowName, runName, actionName, repetitionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpressionTraces value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExpressionTraces.DeserializeExpressionTraces(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists a workflow run expression trace. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ExpressionTraces> ListExpressionTraces(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var message = CreateListExpressionTracesRequest(subscriptionId, resourceGroupName, workflowName, runName, actionName, repetitionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpressionTraces value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExpressionTraces.DeserializeExpressionTraces(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
