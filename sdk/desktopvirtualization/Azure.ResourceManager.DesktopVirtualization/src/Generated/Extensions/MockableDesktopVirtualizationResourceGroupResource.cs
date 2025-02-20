// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableDesktopVirtualizationResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableDesktopVirtualizationResourceGroupResource"/> class for mocking. </summary>
        protected MockableDesktopVirtualizationResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDesktopVirtualizationResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDesktopVirtualizationResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of VirtualWorkspaceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of VirtualWorkspaceResources and their operations over a VirtualWorkspaceResource. </returns>
        public virtual VirtualWorkspaceCollection GetVirtualWorkspaces()
        {
            return GetCachedClient(client => new VirtualWorkspaceCollection(client, Id));
        }

        /// <summary>
        /// Get a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<VirtualWorkspaceResource>> GetVirtualWorkspaceAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            return await GetVirtualWorkspaces().GetAsync(workspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<VirtualWorkspaceResource> GetVirtualWorkspace(string workspaceName, CancellationToken cancellationToken = default)
        {
            return GetVirtualWorkspaces().Get(workspaceName, cancellationToken);
        }

        /// <summary> Gets a collection of ScalingPlanResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScalingPlanResources and their operations over a ScalingPlanResource. </returns>
        public virtual ScalingPlanCollection GetScalingPlans()
        {
            return GetCachedClient(client => new ScalingPlanCollection(client, Id));
        }

        /// <summary>
        /// Get a scaling plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScalingPlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanName"> The name of the scaling plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ScalingPlanResource>> GetScalingPlanAsync(string scalingPlanName, CancellationToken cancellationToken = default)
        {
            return await GetScalingPlans().GetAsync(scalingPlanName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a scaling plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/scalingPlans/{scalingPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScalingPlans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScalingPlanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scalingPlanName"> The name of the scaling plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scalingPlanName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scalingPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ScalingPlanResource> GetScalingPlan(string scalingPlanName, CancellationToken cancellationToken = default)
        {
            return GetScalingPlans().Get(scalingPlanName, cancellationToken);
        }

        /// <summary> Gets a collection of VirtualApplicationGroupResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of VirtualApplicationGroupResources and their operations over a VirtualApplicationGroupResource. </returns>
        public virtual VirtualApplicationGroupCollection GetVirtualApplicationGroups()
        {
            return GetCachedClient(client => new VirtualApplicationGroupCollection(client, Id));
        }

        /// <summary>
        /// Get an application group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualApplicationGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="applicationGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<VirtualApplicationGroupResource>> GetVirtualApplicationGroupAsync(string applicationGroupName, CancellationToken cancellationToken = default)
        {
            return await GetVirtualApplicationGroups().GetAsync(applicationGroupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an application group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualApplicationGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationGroupName"> The name of the application group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="applicationGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<VirtualApplicationGroupResource> GetVirtualApplicationGroup(string applicationGroupName, CancellationToken cancellationToken = default)
        {
            return GetVirtualApplicationGroups().Get(applicationGroupName, cancellationToken);
        }

        /// <summary> Gets a collection of HostPoolResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of HostPoolResources and their operations over a HostPoolResource. </returns>
        public virtual HostPoolCollection GetHostPools()
        {
            return GetCachedClient(client => new HostPoolCollection(client, Id));
        }

        /// <summary>
        /// Get a host pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<HostPoolResource>> GetHostPoolAsync(string hostPoolName, CancellationToken cancellationToken = default)
        {
            return await GetHostPools().GetAsync(hostPoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a host pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HostPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<HostPoolResource> GetHostPool(string hostPoolName, CancellationToken cancellationToken = default)
        {
            return GetHostPools().Get(hostPoolName, cancellationToken);
        }

        /// <summary> Gets a collection of AppAttachPackageResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AppAttachPackageResources and their operations over a AppAttachPackageResource. </returns>
        public virtual AppAttachPackageCollection GetAppAttachPackages()
        {
            return GetCachedClient(client => new AppAttachPackageCollection(client, Id));
        }

        /// <summary>
        /// Get an app attach package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/appAttachPackages/{appAttachPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppAttachPackage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppAttachPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appAttachPackageName"> The name of the App Attach package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appAttachPackageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="appAttachPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppAttachPackageResource>> GetAppAttachPackageAsync(string appAttachPackageName, CancellationToken cancellationToken = default)
        {
            return await GetAppAttachPackages().GetAsync(appAttachPackageName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an app attach package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/appAttachPackages/{appAttachPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppAttachPackage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-03</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppAttachPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appAttachPackageName"> The name of the App Attach package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appAttachPackageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="appAttachPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppAttachPackageResource> GetAppAttachPackage(string appAttachPackageName, CancellationToken cancellationToken = default)
        {
            return GetAppAttachPackages().Get(appAttachPackageName, cancellationToken);
        }
    }
}
