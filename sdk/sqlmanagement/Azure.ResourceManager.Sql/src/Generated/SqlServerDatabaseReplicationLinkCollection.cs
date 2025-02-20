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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerDatabaseReplicationLinkResource"/> and their operations.
    /// Each <see cref="SqlServerDatabaseReplicationLinkResource"/> in the collection will belong to the same instance of <see cref="SqlDatabaseResource"/>.
    /// To get a <see cref="SqlServerDatabaseReplicationLinkCollection"/> instance call the GetSqlServerDatabaseReplicationLinks method from an instance of <see cref="SqlDatabaseResource"/>.
    /// </summary>
    public partial class SqlServerDatabaseReplicationLinkCollection : ArmCollection, IEnumerable<SqlServerDatabaseReplicationLinkResource>, IAsyncEnumerable<SqlServerDatabaseReplicationLinkResource>
    {
        private readonly ClientDiagnostics _sqlServerDatabaseReplicationLinkReplicationLinksClientDiagnostics;
        private readonly ReplicationLinksRestOperations _sqlServerDatabaseReplicationLinkReplicationLinksRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerDatabaseReplicationLinkCollection"/> class for mocking. </summary>
        protected SqlServerDatabaseReplicationLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerDatabaseReplicationLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerDatabaseReplicationLinkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerDatabaseReplicationLinkReplicationLinksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerDatabaseReplicationLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerDatabaseReplicationLinkResource.ResourceType, out string sqlServerDatabaseReplicationLinkReplicationLinksApiVersion);
            _sqlServerDatabaseReplicationLinkReplicationLinksRestClient = new ReplicationLinksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerDatabaseReplicationLinkReplicationLinksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates the replication link type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationLinks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseReplicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="linkId"> The <see cref="string"/> to use. </param>
        /// <param name="data"> The <see cref="SqlServerDatabaseReplicationLinkData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerDatabaseReplicationLinkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string linkId, SqlServerDatabaseReplicationLinkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkId, nameof(linkId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerDatabaseReplicationLinkReplicationLinksClientDiagnostics.CreateScope("SqlServerDatabaseReplicationLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerDatabaseReplicationLinkReplicationLinksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkId, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerDatabaseReplicationLinkResource>(new SqlServerDatabaseReplicationLinkOperationSource(Client), _sqlServerDatabaseReplicationLinkReplicationLinksClientDiagnostics, Pipeline, _sqlServerDatabaseReplicationLinkReplicationLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates the replication link type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationLinks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseReplicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="linkId"> The <see cref="string"/> to use. </param>
        /// <param name="data"> The <see cref="SqlServerDatabaseReplicationLinkData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerDatabaseReplicationLinkResource> CreateOrUpdate(WaitUntil waitUntil, string linkId, SqlServerDatabaseReplicationLinkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkId, nameof(linkId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerDatabaseReplicationLinkReplicationLinksClientDiagnostics.CreateScope("SqlServerDatabaseReplicationLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerDatabaseReplicationLinkReplicationLinksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkId, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerDatabaseReplicationLinkResource>(new SqlServerDatabaseReplicationLinkOperationSource(Client), _sqlServerDatabaseReplicationLinkReplicationLinksClientDiagnostics, Pipeline, _sqlServerDatabaseReplicationLinkReplicationLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a replication link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseReplicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkId"> The name of the replication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public virtual async Task<Response<SqlServerDatabaseReplicationLinkResource>> GetAsync(string linkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkId, nameof(linkId));

            using var scope = _sqlServerDatabaseReplicationLinkReplicationLinksClientDiagnostics.CreateScope("SqlServerDatabaseReplicationLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerDatabaseReplicationLinkReplicationLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerDatabaseReplicationLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a replication link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseReplicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkId"> The name of the replication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public virtual Response<SqlServerDatabaseReplicationLinkResource> Get(string linkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkId, nameof(linkId));

            using var scope = _sqlServerDatabaseReplicationLinkReplicationLinksClientDiagnostics.CreateScope("SqlServerDatabaseReplicationLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerDatabaseReplicationLinkReplicationLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerDatabaseReplicationLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of replication links on database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationLinks_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseReplicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerDatabaseReplicationLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerDatabaseReplicationLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerDatabaseReplicationLinkReplicationLinksRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerDatabaseReplicationLinkReplicationLinksRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlServerDatabaseReplicationLinkResource(Client, SqlServerDatabaseReplicationLinkData.DeserializeSqlServerDatabaseReplicationLinkData(e)), _sqlServerDatabaseReplicationLinkReplicationLinksClientDiagnostics, Pipeline, "SqlServerDatabaseReplicationLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of replication links on database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationLinks_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseReplicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerDatabaseReplicationLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerDatabaseReplicationLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerDatabaseReplicationLinkReplicationLinksRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerDatabaseReplicationLinkReplicationLinksRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlServerDatabaseReplicationLinkResource(Client, SqlServerDatabaseReplicationLinkData.DeserializeSqlServerDatabaseReplicationLinkData(e)), _sqlServerDatabaseReplicationLinkReplicationLinksClientDiagnostics, Pipeline, "SqlServerDatabaseReplicationLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseReplicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkId"> The name of the replication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string linkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkId, nameof(linkId));

            using var scope = _sqlServerDatabaseReplicationLinkReplicationLinksClientDiagnostics.CreateScope("SqlServerDatabaseReplicationLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerDatabaseReplicationLinkReplicationLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseReplicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkId"> The name of the replication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public virtual Response<bool> Exists(string linkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkId, nameof(linkId));

            using var scope = _sqlServerDatabaseReplicationLinkReplicationLinksClientDiagnostics.CreateScope("SqlServerDatabaseReplicationLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerDatabaseReplicationLinkReplicationLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseReplicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkId"> The name of the replication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlServerDatabaseReplicationLinkResource>> GetIfExistsAsync(string linkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkId, nameof(linkId));

            using var scope = _sqlServerDatabaseReplicationLinkReplicationLinksClientDiagnostics.CreateScope("SqlServerDatabaseReplicationLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerDatabaseReplicationLinkReplicationLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerDatabaseReplicationLinkResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerDatabaseReplicationLinkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/replicationLinks/{linkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseReplicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkId"> The name of the replication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public virtual NullableResponse<SqlServerDatabaseReplicationLinkResource> GetIfExists(string linkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkId, nameof(linkId));

            using var scope = _sqlServerDatabaseReplicationLinkReplicationLinksClientDiagnostics.CreateScope("SqlServerDatabaseReplicationLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerDatabaseReplicationLinkReplicationLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerDatabaseReplicationLinkResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerDatabaseReplicationLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerDatabaseReplicationLinkResource> IEnumerable<SqlServerDatabaseReplicationLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerDatabaseReplicationLinkResource> IAsyncEnumerable<SqlServerDatabaseReplicationLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
