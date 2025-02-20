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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a RestorableDroppedManagedDatabase along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="RestorableDroppedManagedDatabaseResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetRestorableDroppedManagedDatabaseResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagedInstanceResource"/> using the GetRestorableDroppedManagedDatabase method.
    /// </summary>
    public partial class RestorableDroppedManagedDatabaseResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RestorableDroppedManagedDatabaseResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="managedInstanceName"> The managedInstanceName. </param>
        /// <param name="restorableDroppedDatabaseId"> The restorableDroppedDatabaseId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _restorableDroppedManagedDatabaseClientDiagnostics;
        private readonly RestorableDroppedManagedDatabasesRestOperations _restorableDroppedManagedDatabaseRestClient;
        private readonly RestorableDroppedManagedDatabaseData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/restorableDroppedDatabases";

        /// <summary> Initializes a new instance of the <see cref="RestorableDroppedManagedDatabaseResource"/> class for mocking. </summary>
        protected RestorableDroppedManagedDatabaseResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RestorableDroppedManagedDatabaseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RestorableDroppedManagedDatabaseResource(ArmClient client, RestorableDroppedManagedDatabaseData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RestorableDroppedManagedDatabaseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RestorableDroppedManagedDatabaseResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorableDroppedManagedDatabaseClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string restorableDroppedManagedDatabaseApiVersion);
            _restorableDroppedManagedDatabaseRestClient = new RestorableDroppedManagedDatabasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, restorableDroppedManagedDatabaseApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RestorableDroppedManagedDatabaseData Data
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

        /// <summary> Gets a collection of ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResources in the RestorableDroppedManagedDatabase. </summary>
        /// <returns> An object representing collection of ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResources and their operations over a ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource. </returns>
        public virtual ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection GetManagedRestorableDroppedDbBackupShortTermRetentionPolicies()
        {
            return GetCachedClient(client => new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection(client, Id));
        }

        /// <summary>
        /// Gets a dropped database's short term retention policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>> GetManagedRestorableDroppedDbBackupShortTermRetentionPolicyAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            return await GetManagedRestorableDroppedDbBackupShortTermRetentionPolicies().GetAsync(policyName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a dropped database's short term retention policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> GetManagedRestorableDroppedDbBackupShortTermRetentionPolicy(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            return GetManagedRestorableDroppedDbBackupShortTermRetentionPolicies().Get(policyName, cancellationToken);
        }

        /// <summary>
        /// Gets a restorable dropped managed database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedManagedDatabases_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorableDroppedManagedDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RestorableDroppedManagedDatabaseResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseResource.Get");
            scope.Start();
            try
            {
                var response = await _restorableDroppedManagedDatabaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedManagedDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a restorable dropped managed database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDroppedManagedDatabases_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorableDroppedManagedDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RestorableDroppedManagedDatabaseResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _restorableDroppedManagedDatabaseClientDiagnostics.CreateScope("RestorableDroppedManagedDatabaseResource.Get");
            scope.Start();
            try
            {
                var response = _restorableDroppedManagedDatabaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDroppedManagedDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
