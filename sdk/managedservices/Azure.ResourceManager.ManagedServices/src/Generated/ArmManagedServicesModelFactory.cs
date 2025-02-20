// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedServices.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmManagedServicesModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ManagedServices.ManagedServicesRegistrationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties of a registration definition. </param>
        /// <param name="plan"> The details for the Managed Services offer’s plan in Azure Marketplace. </param>
        /// <returns> A new <see cref="ManagedServices.ManagedServicesRegistrationData"/> instance for mocking. </returns>
        public static ManagedServicesRegistrationData ManagedServicesRegistrationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ManagedServicesRegistrationProperties properties = null, ManagedServicesPlan plan = null)
        {
            return new ManagedServicesRegistrationData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                plan,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedServicesRegistrationProperties"/>. </summary>
        /// <param name="description"> The description of the registration definition. </param>
        /// <param name="authorizations"> The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="eligibleAuthorizations"> The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="registrationDefinitionName"> The name of the registration definition. </param>
        /// <param name="managedByTenantId"> The identifier of the managedBy tenant. </param>
        /// <param name="provisioningState"> The current provisioning state of the registration definition. </param>
        /// <param name="manageeTenantId"> The identifier of the managed tenant. </param>
        /// <param name="manageeTenantName"> The name of the managed tenant. </param>
        /// <param name="managedByTenantName"> The name of the managedBy tenant. </param>
        /// <returns> A new <see cref="Models.ManagedServicesRegistrationProperties"/> instance for mocking. </returns>
        public static ManagedServicesRegistrationProperties ManagedServicesRegistrationProperties(string description = null, IEnumerable<ManagedServicesAuthorization> authorizations = null, IEnumerable<ManagedServicesEligibleAuthorization> eligibleAuthorizations = null, string registrationDefinitionName = null, Guid managedByTenantId = default, ManagedServicesProvisioningState? provisioningState = null, Guid? manageeTenantId = null, string manageeTenantName = null, string managedByTenantName = null)
        {
            authorizations ??= new List<ManagedServicesAuthorization>();
            eligibleAuthorizations ??= new List<ManagedServicesEligibleAuthorization>();

            return new ManagedServicesRegistrationProperties(
                description,
                authorizations?.ToList(),
                eligibleAuthorizations?.ToList(),
                registrationDefinitionName,
                managedByTenantId,
                provisioningState,
                manageeTenantId,
                manageeTenantName,
                managedByTenantName,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServices.ManagedServicesRegistrationAssignmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties of a registration assignment. </param>
        /// <returns> A new <see cref="ManagedServices.ManagedServicesRegistrationAssignmentData"/> instance for mocking. </returns>
        public static ManagedServicesRegistrationAssignmentData ManagedServicesRegistrationAssignmentData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ManagedServicesRegistrationAssignmentProperties properties = null)
        {
            return new ManagedServicesRegistrationAssignmentData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedServicesRegistrationAssignmentProperties"/>. </summary>
        /// <param name="registrationId"> The fully qualified path of the registration definition. </param>
        /// <param name="provisioningState"> The current provisioning state of the registration assignment. </param>
        /// <param name="registrationDefinition"> The registration definition associated with the registration assignment. </param>
        /// <returns> A new <see cref="Models.ManagedServicesRegistrationAssignmentProperties"/> instance for mocking. </returns>
        public static ManagedServicesRegistrationAssignmentProperties ManagedServicesRegistrationAssignmentProperties(ResourceIdentifier registrationId = null, ManagedServicesProvisioningState? provisioningState = null, ManagedServicesRegistrationAssignmentRegistrationData registrationDefinition = null)
        {
            return new ManagedServicesRegistrationAssignmentProperties(registrationId, provisioningState, registrationDefinition, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedServicesRegistrationAssignmentRegistrationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties of the registration definition associated with the registration assignment. </param>
        /// <param name="plan"> The details for the Managed Services offer’s plan in Azure Marketplace. </param>
        /// <returns> A new <see cref="Models.ManagedServicesRegistrationAssignmentRegistrationData"/> instance for mocking. </returns>
        public static ManagedServicesRegistrationAssignmentRegistrationData ManagedServicesRegistrationAssignmentRegistrationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ManagedServicesRegistrationAssignmentRegistrationProperties properties = null, ManagedServicesPlan plan = null)
        {
            return new ManagedServicesRegistrationAssignmentRegistrationData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                plan,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedServicesRegistrationAssignmentRegistrationProperties"/>. </summary>
        /// <param name="description"> The description of the registration definition. </param>
        /// <param name="authorizations"> The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="eligibleAuthorizations"> The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="registrationDefinitionName"> The name of the registration definition. </param>
        /// <param name="provisioningState"> The current provisioning state of the registration definition. </param>
        /// <param name="manageeTenantId"> The identifier of the managed tenant. </param>
        /// <param name="manageeTenantName"> The name of the managed tenant. </param>
        /// <param name="managedByTenantId"> The identifier of the managedBy tenant. </param>
        /// <param name="managedByTenantName"> The name of the managedBy tenant. </param>
        /// <returns> A new <see cref="Models.ManagedServicesRegistrationAssignmentRegistrationProperties"/> instance for mocking. </returns>
        public static ManagedServicesRegistrationAssignmentRegistrationProperties ManagedServicesRegistrationAssignmentRegistrationProperties(string description = null, IEnumerable<ManagedServicesAuthorization> authorizations = null, IEnumerable<ManagedServicesEligibleAuthorization> eligibleAuthorizations = null, string registrationDefinitionName = null, ManagedServicesProvisioningState? provisioningState = null, Guid? manageeTenantId = null, string manageeTenantName = null, Guid? managedByTenantId = null, string managedByTenantName = null)
        {
            authorizations ??= new List<ManagedServicesAuthorization>();
            eligibleAuthorizations ??= new List<ManagedServicesEligibleAuthorization>();

            return new ManagedServicesRegistrationAssignmentRegistrationProperties(
                description,
                authorizations?.ToList(),
                eligibleAuthorizations?.ToList(),
                registrationDefinitionName,
                provisioningState,
                manageeTenantId,
                manageeTenantName,
                managedByTenantId,
                managedByTenantName,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServices.ManagedServicesMarketplaceRegistrationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties of the marketplace registration definition. </param>
        /// <param name="plan"> The details for the Managed Services offer’s plan in Azure Marketplace. </param>
        /// <returns> A new <see cref="ManagedServices.ManagedServicesMarketplaceRegistrationData"/> instance for mocking. </returns>
        public static ManagedServicesMarketplaceRegistrationData ManagedServicesMarketplaceRegistrationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ManagedServicesMarketplaceRegistrationProperties properties = null, ManagedServicesPlan plan = null)
        {
            return new ManagedServicesMarketplaceRegistrationData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                plan,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedServicesMarketplaceRegistrationProperties"/>. </summary>
        /// <param name="managedByTenantId"> The identifier of the managedBy tenant. </param>
        /// <param name="authorizations"> The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="eligibleAuthorizations"> The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant. </param>
        /// <param name="offerDisplayName"> The marketplace offer display name. </param>
        /// <param name="publisherDisplayName"> The marketplace publisher display name. </param>
        /// <param name="planDisplayName"> The marketplace plan display name. </param>
        /// <returns> A new <see cref="Models.ManagedServicesMarketplaceRegistrationProperties"/> instance for mocking. </returns>
        public static ManagedServicesMarketplaceRegistrationProperties ManagedServicesMarketplaceRegistrationProperties(Guid managedByTenantId = default, IEnumerable<ManagedServicesAuthorization> authorizations = null, IEnumerable<ManagedServicesEligibleAuthorization> eligibleAuthorizations = null, string offerDisplayName = null, string publisherDisplayName = null, string planDisplayName = null)
        {
            authorizations ??= new List<ManagedServicesAuthorization>();
            eligibleAuthorizations ??= new List<ManagedServicesEligibleAuthorization>();

            return new ManagedServicesMarketplaceRegistrationProperties(
                managedByTenantId,
                authorizations?.ToList(),
                eligibleAuthorizations?.ToList(),
                offerDisplayName,
                publisherDisplayName,
                planDisplayName,
                serializedAdditionalRawData: null);
        }
    }
}
