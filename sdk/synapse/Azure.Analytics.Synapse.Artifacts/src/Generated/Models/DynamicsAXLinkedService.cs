// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Dynamics AX linked service. </summary>
    public partial class DynamicsAXLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="DynamicsAXLinkedService"/>. </summary>
        /// <param name="url"> The Dynamics AX (or Dynamics 365 Finance and Operations) instance OData endpoint. </param>
        /// <param name="servicePrincipalId"> Specify the application's client ID. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey">
        /// Specify the application's key. Mark this field as a SecureString to store it securely in Data Factory, or reference a secret stored in Azure Key Vault. Type: string (or Expression with resultType string).
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="tenant"> Specify the tenant information (domain name or tenant ID) under which your application resides. Retrieve it by hovering the mouse in the top-right corner of the Azure portal. Type: string (or Expression with resultType string). </param>
        /// <param name="aadResourceId"> Specify the resource you are requesting authorization. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/>, <paramref name="servicePrincipalId"/>, <paramref name="servicePrincipalKey"/>, <paramref name="tenant"/> or <paramref name="aadResourceId"/> is null. </exception>
        public DynamicsAXLinkedService(object url, object servicePrincipalId, SecretBase servicePrincipalKey, object tenant, object aadResourceId)
        {
            Argument.AssertNotNull(url, nameof(url));
            Argument.AssertNotNull(servicePrincipalId, nameof(servicePrincipalId));
            Argument.AssertNotNull(servicePrincipalKey, nameof(servicePrincipalKey));
            Argument.AssertNotNull(tenant, nameof(tenant));
            Argument.AssertNotNull(aadResourceId, nameof(aadResourceId));

            Url = url;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            AadResourceId = aadResourceId;
            Type = "DynamicsAX";
        }

        /// <summary> Initializes a new instance of <see cref="DynamicsAXLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="version"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="url"> The Dynamics AX (or Dynamics 365 Finance and Operations) instance OData endpoint. </param>
        /// <param name="servicePrincipalId"> Specify the application's client ID. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey">
        /// Specify the application's key. Mark this field as a SecureString to store it securely in Data Factory, or reference a secret stored in Azure Key Vault. Type: string (or Expression with resultType string).
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="tenant"> Specify the tenant information (domain name or tenant ID) under which your application resides. Retrieve it by hovering the mouse in the top-right corner of the Azure portal. Type: string (or Expression with resultType string). </param>
        /// <param name="aadResourceId"> Specify the resource you are requesting authorization. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal DynamicsAXLinkedService(string type, string version, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object url, object servicePrincipalId, SecretBase servicePrincipalKey, object tenant, object aadResourceId, object encryptedCredential) : base(type, version, connectVia, description, parameters, annotations, additionalProperties)
        {
            Url = url;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            AadResourceId = aadResourceId;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "DynamicsAX";
        }

        /// <summary> The Dynamics AX (or Dynamics 365 Finance and Operations) instance OData endpoint. </summary>
        public object Url { get; set; }
        /// <summary> Specify the application's client ID. Type: string (or Expression with resultType string). </summary>
        public object ServicePrincipalId { get; set; }
        /// <summary>
        /// Specify the application's key. Mark this field as a SecureString to store it securely in Data Factory, or reference a secret stored in Azure Key Vault. Type: string (or Expression with resultType string).
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase ServicePrincipalKey { get; set; }
        /// <summary> Specify the tenant information (domain name or tenant ID) under which your application resides. Retrieve it by hovering the mouse in the top-right corner of the Azure portal. Type: string (or Expression with resultType string). </summary>
        public object Tenant { get; set; }
        /// <summary> Specify the resource you are requesting authorization. Type: string (or Expression with resultType string). </summary>
        public object AadResourceId { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
