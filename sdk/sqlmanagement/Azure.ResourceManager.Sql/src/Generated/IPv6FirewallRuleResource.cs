// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing an IPv6FirewallRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="IPv6FirewallRuleResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetIPv6FirewallRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerResource"/> using the GetIPv6FirewallRule method.
    /// </summary>
    public partial class IPv6FirewallRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="IPv6FirewallRuleResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        /// <param name="firewallRuleName"> The firewallRuleName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string firewallRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/ipv6FirewallRules/{firewallRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _iPv6FirewallRuleClientDiagnostics;
        private readonly IPv6FirewallRulesRestOperations _iPv6FirewallRuleRestClient;
        private readonly IPv6FirewallRuleData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/ipv6FirewallRules";

        /// <summary> Initializes a new instance of the <see cref="IPv6FirewallRuleResource"/> class for mocking. </summary>
        protected IPv6FirewallRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IPv6FirewallRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal IPv6FirewallRuleResource(ArmClient client, IPv6FirewallRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="IPv6FirewallRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal IPv6FirewallRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iPv6FirewallRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string iPv6FirewallRuleApiVersion);
            _iPv6FirewallRuleRestClient = new IPv6FirewallRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iPv6FirewallRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual IPv6FirewallRuleData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets an IPv6 firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/ipv6FirewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IPv6FirewallRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IPv6FirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IPv6FirewallRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _iPv6FirewallRuleClientDiagnostics.CreateScope("IPv6FirewallRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _iPv6FirewallRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IPv6FirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an IPv6 firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/ipv6FirewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IPv6FirewallRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IPv6FirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IPv6FirewallRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _iPv6FirewallRuleClientDiagnostics.CreateScope("IPv6FirewallRuleResource.Get");
            scope.Start();
            try
            {
                var response = _iPv6FirewallRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IPv6FirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an IPv6 firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/ipv6FirewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IPv6FirewallRules_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IPv6FirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _iPv6FirewallRuleClientDiagnostics.CreateScope("IPv6FirewallRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _iPv6FirewallRuleRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _iPv6FirewallRuleRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SqlArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an IPv6 firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/ipv6FirewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IPv6FirewallRules_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IPv6FirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _iPv6FirewallRuleClientDiagnostics.CreateScope("IPv6FirewallRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _iPv6FirewallRuleRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var uri = _iPv6FirewallRuleRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SqlArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an IPv6 firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/ipv6FirewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IPv6FirewallRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IPv6FirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required parameters for creating or updating an IPv6 firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IPv6FirewallRuleResource>> UpdateAsync(WaitUntil waitUntil, IPv6FirewallRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iPv6FirewallRuleClientDiagnostics.CreateScope("IPv6FirewallRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _iPv6FirewallRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _iPv6FirewallRuleRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SqlArmOperation<IPv6FirewallRuleResource>(Response.FromValue(new IPv6FirewallRuleResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an IPv6 firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/ipv6FirewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IPv6FirewallRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IPv6FirewallRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required parameters for creating or updating an IPv6 firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IPv6FirewallRuleResource> Update(WaitUntil waitUntil, IPv6FirewallRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iPv6FirewallRuleClientDiagnostics.CreateScope("IPv6FirewallRuleResource.Update");
            scope.Start();
            try
            {
                var response = _iPv6FirewallRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var uri = _iPv6FirewallRuleRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SqlArmOperation<IPv6FirewallRuleResource>(Response.FromValue(new IPv6FirewallRuleResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
