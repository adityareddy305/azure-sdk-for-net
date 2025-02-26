// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing a collection of <see cref="NetAppBackupPolicyResource"/> and their operations.
    /// Each <see cref="NetAppBackupPolicyResource"/> in the collection will belong to the same instance of <see cref="NetAppAccountResource"/>.
    /// To get a <see cref="NetAppBackupPolicyCollection"/> instance call the GetNetAppBackupPolicies method from an instance of <see cref="NetAppAccountResource"/>.
    /// </summary>
    public partial class NetAppBackupPolicyCollection : ArmCollection, IEnumerable<NetAppBackupPolicyResource>, IAsyncEnumerable<NetAppBackupPolicyResource>
    {
        private readonly ClientDiagnostics _netAppBackupPolicyBackupPoliciesClientDiagnostics;
        private readonly BackupPoliciesRestOperations _netAppBackupPolicyBackupPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetAppBackupPolicyCollection"/> class for mocking. </summary>
        protected NetAppBackupPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetAppBackupPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetAppBackupPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _netAppBackupPolicyBackupPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", NetAppBackupPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetAppBackupPolicyResource.ResourceType, out string netAppBackupPolicyBackupPoliciesApiVersion);
            _netAppBackupPolicyBackupPoliciesRestClient = new BackupPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, netAppBackupPolicyBackupPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetAppAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetAppAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a backup policy for Netapp Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupPolicies/{backupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backupPolicyName"> Backup policy Name which uniquely identify backup policy. </param>
        /// <param name="data"> Backup policy object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetAppBackupPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string backupPolicyName, NetAppBackupPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupPolicyName, nameof(backupPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _netAppBackupPolicyBackupPoliciesClientDiagnostics.CreateScope("NetAppBackupPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _netAppBackupPolicyBackupPoliciesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<NetAppBackupPolicyResource>(new NetAppBackupPolicyOperationSource(Client), _netAppBackupPolicyBackupPoliciesClientDiagnostics, Pipeline, _netAppBackupPolicyBackupPoliciesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a backup policy for Netapp Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupPolicies/{backupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backupPolicyName"> Backup policy Name which uniquely identify backup policy. </param>
        /// <param name="data"> Backup policy object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetAppBackupPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string backupPolicyName, NetAppBackupPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupPolicyName, nameof(backupPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _netAppBackupPolicyBackupPoliciesClientDiagnostics.CreateScope("NetAppBackupPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _netAppBackupPolicyBackupPoliciesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, data, cancellationToken);
                var operation = new NetAppArmOperation<NetAppBackupPolicyResource>(new NetAppBackupPolicyOperationSource(Client), _netAppBackupPolicyBackupPoliciesClientDiagnostics, Pipeline, _netAppBackupPolicyBackupPoliciesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Get a particular backup Policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupPolicies/{backupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupPolicyName"> Backup policy Name which uniquely identify backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupPolicyName"/> is null. </exception>
        public virtual async Task<Response<NetAppBackupPolicyResource>> GetAsync(string backupPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupPolicyName, nameof(backupPolicyName));

            using var scope = _netAppBackupPolicyBackupPoliciesClientDiagnostics.CreateScope("NetAppBackupPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _netAppBackupPolicyBackupPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppBackupPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a particular backup Policy
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupPolicies/{backupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupPolicyName"> Backup policy Name which uniquely identify backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupPolicyName"/> is null. </exception>
        public virtual Response<NetAppBackupPolicyResource> Get(string backupPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupPolicyName, nameof(backupPolicyName));

            using var scope = _netAppBackupPolicyBackupPoliciesClientDiagnostics.CreateScope("NetAppBackupPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _netAppBackupPolicyBackupPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppBackupPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List backup policies for Netapp Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppBackupPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetAppBackupPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _netAppBackupPolicyBackupPoliciesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new NetAppBackupPolicyResource(Client, NetAppBackupPolicyData.DeserializeNetAppBackupPolicyData(e)), _netAppBackupPolicyBackupPoliciesClientDiagnostics, Pipeline, "NetAppBackupPolicyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List backup policies for Netapp Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppBackupPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetAppBackupPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _netAppBackupPolicyBackupPoliciesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new NetAppBackupPolicyResource(Client, NetAppBackupPolicyData.DeserializeNetAppBackupPolicyData(e)), _netAppBackupPolicyBackupPoliciesClientDiagnostics, Pipeline, "NetAppBackupPolicyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupPolicies/{backupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupPolicyName"> Backup policy Name which uniquely identify backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backupPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupPolicyName, nameof(backupPolicyName));

            using var scope = _netAppBackupPolicyBackupPoliciesClientDiagnostics.CreateScope("NetAppBackupPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _netAppBackupPolicyBackupPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupPolicies/{backupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupPolicyName"> Backup policy Name which uniquely identify backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupPolicyName, nameof(backupPolicyName));

            using var scope = _netAppBackupPolicyBackupPoliciesClientDiagnostics.CreateScope("NetAppBackupPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _netAppBackupPolicyBackupPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupPolicies/{backupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupPolicyName"> Backup policy Name which uniquely identify backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupPolicyName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetAppBackupPolicyResource>> GetIfExistsAsync(string backupPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupPolicyName, nameof(backupPolicyName));

            using var scope = _netAppBackupPolicyBackupPoliciesClientDiagnostics.CreateScope("NetAppBackupPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _netAppBackupPolicyBackupPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetAppBackupPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new NetAppBackupPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/backupPolicies/{backupPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppBackupPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="backupPolicyName"> Backup policy Name which uniquely identify backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupPolicyName"/> is null. </exception>
        public virtual NullableResponse<NetAppBackupPolicyResource> GetIfExists(string backupPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupPolicyName, nameof(backupPolicyName));

            using var scope = _netAppBackupPolicyBackupPoliciesClientDiagnostics.CreateScope("NetAppBackupPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _netAppBackupPolicyBackupPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetAppBackupPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new NetAppBackupPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetAppBackupPolicyResource> IEnumerable<NetAppBackupPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetAppBackupPolicyResource> IAsyncEnumerable<NetAppBackupPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
