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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a SecurityAlertsSuppressionRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SecurityAlertsSuppressionRuleResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSecurityAlertsSuppressionRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetSecurityAlertsSuppressionRule method.
    /// </summary>
    public partial class SecurityAlertsSuppressionRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SecurityAlertsSuppressionRuleResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="alertsSuppressionRuleName"> The alertsSuppressionRuleName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string alertsSuppressionRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics;
        private readonly AlertsSuppressionRulesRestOperations _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient;
        private readonly SecurityAlertsSuppressionRuleData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/alertsSuppressionRules";

        /// <summary> Initializes a new instance of the <see cref="SecurityAlertsSuppressionRuleResource"/> class for mocking. </summary>
        protected SecurityAlertsSuppressionRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityAlertsSuppressionRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SecurityAlertsSuppressionRuleResource(ArmClient client, SecurityAlertsSuppressionRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityAlertsSuppressionRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SecurityAlertsSuppressionRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string securityAlertsSuppressionRuleAlertsSuppressionRulesApiVersion);
            _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient = new AlertsSuppressionRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityAlertsSuppressionRuleAlertsSuppressionRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityAlertsSuppressionRuleData Data
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
        /// Get dismiss rule, with name: {alertsSuppressionRuleName}, for the given subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertsSuppressionRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityAlertsSuppressionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecurityAlertsSuppressionRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics.CreateScope("SecurityAlertsSuppressionRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityAlertsSuppressionRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get dismiss rule, with name: {alertsSuppressionRuleName}, for the given subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertsSuppressionRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityAlertsSuppressionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecurityAlertsSuppressionRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics.CreateScope("SecurityAlertsSuppressionRuleResource.Get");
            scope.Start();
            try
            {
                var response = _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityAlertsSuppressionRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete dismiss alert rule for this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertsSuppressionRules_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityAlertsSuppressionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics.CreateScope("SecurityAlertsSuppressionRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.DeleteAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityCenterArmOperation(response, rehydrationToken);
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
        /// Delete dismiss alert rule for this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertsSuppressionRules_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityAlertsSuppressionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics.CreateScope("SecurityAlertsSuppressionRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.Delete(Id.SubscriptionId, Id.Name, cancellationToken);
                var uri = _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityCenterArmOperation(response, rehydrationToken);
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
        /// Update existing rule or create new rule if it doesn't exist
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertsSuppressionRules_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityAlertsSuppressionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Suppression rule object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityAlertsSuppressionRuleResource>> UpdateAsync(WaitUntil waitUntil, SecurityAlertsSuppressionRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics.CreateScope("SecurityAlertsSuppressionRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.UpdateAsync(Id.SubscriptionId, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.CreateUpdateRequestUri(Id.SubscriptionId, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityCenterArmOperation<SecurityAlertsSuppressionRuleResource>(Response.FromValue(new SecurityAlertsSuppressionRuleResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Update existing rule or create new rule if it doesn't exist
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/alertsSuppressionRules/{alertsSuppressionRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertsSuppressionRules_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityAlertsSuppressionRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Suppression rule object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityAlertsSuppressionRuleResource> Update(WaitUntil waitUntil, SecurityAlertsSuppressionRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityAlertsSuppressionRuleAlertsSuppressionRulesClientDiagnostics.CreateScope("SecurityAlertsSuppressionRuleResource.Update");
            scope.Start();
            try
            {
                var response = _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.Update(Id.SubscriptionId, Id.Name, data, cancellationToken);
                var uri = _securityAlertsSuppressionRuleAlertsSuppressionRulesRestClient.CreateUpdateRequestUri(Id.SubscriptionId, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityCenterArmOperation<SecurityAlertsSuppressionRuleResource>(Response.FromValue(new SecurityAlertsSuppressionRuleResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
