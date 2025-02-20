// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing a collection of <see cref="RoleEligibilityScheduleResource"/> and their operations.
    /// Each <see cref="RoleEligibilityScheduleResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="RoleEligibilityScheduleCollection"/> instance call the GetRoleEligibilitySchedules method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class RoleEligibilityScheduleCollection : ArmCollection, IEnumerable<RoleEligibilityScheduleResource>, IAsyncEnumerable<RoleEligibilityScheduleResource>
    {
        private readonly ClientDiagnostics _roleEligibilityScheduleClientDiagnostics;
        private readonly RoleEligibilitySchedulesRestOperations _roleEligibilityScheduleRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoleEligibilityScheduleCollection"/> class for mocking. </summary>
        protected RoleEligibilityScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleEligibilityScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RoleEligibilityScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleEligibilityScheduleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", RoleEligibilityScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RoleEligibilityScheduleResource.ResourceType, out string roleEligibilityScheduleApiVersion);
            _roleEligibilityScheduleRestClient = new RoleEligibilitySchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleEligibilityScheduleApiVersion);
        }

        /// <summary>
        /// Get the specified role eligibility schedule for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilitySchedules/{roleEligibilityScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilitySchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleName"> The name (guid) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleName"/> is null. </exception>
        public virtual async Task<Response<RoleEligibilityScheduleResource>> GetAsync(string roleEligibilityScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleName, nameof(roleEligibilityScheduleName));

            using var scope = _roleEligibilityScheduleClientDiagnostics.CreateScope("RoleEligibilityScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleRestClient.GetAsync(Id, roleEligibilityScheduleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role eligibility schedule for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilitySchedules/{roleEligibilityScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilitySchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleName"> The name (guid) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleName"/> is null. </exception>
        public virtual Response<RoleEligibilityScheduleResource> Get(string roleEligibilityScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleName, nameof(roleEligibilityScheduleName));

            using var scope = _roleEligibilityScheduleClientDiagnostics.CreateScope("RoleEligibilityScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleRestClient.Get(Id, roleEligibilityScheduleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets role eligibility schedules for a resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilitySchedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilitySchedules_ListForScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role eligibility schedules at or above the scope. Use $filter=principalId eq {id} to return all role eligibility schedules at, above or below the scope for the specified principal. Use $filter=assignedTo('{userId}') to return all role eligibility schedules for the user. Use $filter=asTarget() to return all role eligibility schedules created for the current user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleEligibilityScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleEligibilityScheduleResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleEligibilityScheduleRestClient.CreateListForScopeRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleEligibilityScheduleRestClient.CreateListForScopeNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RoleEligibilityScheduleResource(Client, RoleEligibilityScheduleData.DeserializeRoleEligibilityScheduleData(e)), _roleEligibilityScheduleClientDiagnostics, Pipeline, "RoleEligibilityScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets role eligibility schedules for a resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilitySchedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilitySchedules_ListForScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role eligibility schedules at or above the scope. Use $filter=principalId eq {id} to return all role eligibility schedules at, above or below the scope for the specified principal. Use $filter=assignedTo('{userId}') to return all role eligibility schedules for the user. Use $filter=asTarget() to return all role eligibility schedules created for the current user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleEligibilityScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleEligibilityScheduleResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleEligibilityScheduleRestClient.CreateListForScopeRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleEligibilityScheduleRestClient.CreateListForScopeNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RoleEligibilityScheduleResource(Client, RoleEligibilityScheduleData.DeserializeRoleEligibilityScheduleData(e)), _roleEligibilityScheduleClientDiagnostics, Pipeline, "RoleEligibilityScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilitySchedules/{roleEligibilityScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilitySchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleName"> The name (guid) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleEligibilityScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleName, nameof(roleEligibilityScheduleName));

            using var scope = _roleEligibilityScheduleClientDiagnostics.CreateScope("RoleEligibilityScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleRestClient.GetAsync(Id, roleEligibilityScheduleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilitySchedules/{roleEligibilityScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilitySchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleName"> The name (guid) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleEligibilityScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleName, nameof(roleEligibilityScheduleName));

            using var scope = _roleEligibilityScheduleClientDiagnostics.CreateScope("RoleEligibilityScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleRestClient.Get(Id, roleEligibilityScheduleName, cancellationToken: cancellationToken);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilitySchedules/{roleEligibilityScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilitySchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleName"> The name (guid) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleName"/> is null. </exception>
        public virtual async Task<NullableResponse<RoleEligibilityScheduleResource>> GetIfExistsAsync(string roleEligibilityScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleName, nameof(roleEligibilityScheduleName));

            using var scope = _roleEligibilityScheduleClientDiagnostics.CreateScope("RoleEligibilityScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleRestClient.GetAsync(Id, roleEligibilityScheduleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RoleEligibilityScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilitySchedules/{roleEligibilityScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilitySchedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoleEligibilityScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleName"> The name (guid) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleName"/> is null. </exception>
        public virtual NullableResponse<RoleEligibilityScheduleResource> GetIfExists(string roleEligibilityScheduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleName, nameof(roleEligibilityScheduleName));

            using var scope = _roleEligibilityScheduleClientDiagnostics.CreateScope("RoleEligibilityScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleRestClient.Get(Id, roleEligibilityScheduleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RoleEligibilityScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RoleEligibilityScheduleResource> IEnumerable<RoleEligibilityScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoleEligibilityScheduleResource> IAsyncEnumerable<RoleEligibilityScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
