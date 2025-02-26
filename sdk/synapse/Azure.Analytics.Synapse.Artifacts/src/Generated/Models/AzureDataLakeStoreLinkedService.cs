// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Data Lake Store linked service. </summary>
    public partial class AzureDataLakeStoreLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="AzureDataLakeStoreLinkedService"/>. </summary>
        /// <param name="dataLakeStoreUri"> Data Lake Store service URI. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataLakeStoreUri"/> is null. </exception>
        public AzureDataLakeStoreLinkedService(object dataLakeStoreUri)
        {
            Argument.AssertNotNull(dataLakeStoreUri, nameof(dataLakeStoreUri));

            DataLakeStoreUri = dataLakeStoreUri;
            Type = "AzureDataLakeStore";
        }

        /// <summary> Initializes a new instance of <see cref="AzureDataLakeStoreLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="version"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="dataLakeStoreUri"> Data Lake Store service URI. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The ID of the application used to authenticate against the Azure Data Lake Store account. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey">
        /// The Key of the application used to authenticate against the Azure Data Lake Store account.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="tenant"> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="azureCloudType"> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </param>
        /// <param name="accountName"> Data Lake Store account name. Type: string (or Expression with resultType string). </param>
        /// <param name="subscriptionId"> Data Lake Store account subscription ID (if different from Data Factory account). Type: string (or Expression with resultType string). </param>
        /// <param name="resourceGroupName"> Data Lake Store account resource group name (if different from Data Factory account). Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal AzureDataLakeStoreLinkedService(string type, string version, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object dataLakeStoreUri, object servicePrincipalId, SecretBase servicePrincipalKey, object tenant, object azureCloudType, object accountName, object subscriptionId, object resourceGroupName, object encryptedCredential, CredentialReference credential) : base(type, version, connectVia, description, parameters, annotations, additionalProperties)
        {
            DataLakeStoreUri = dataLakeStoreUri;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            AzureCloudType = azureCloudType;
            AccountName = accountName;
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            Type = type ?? "AzureDataLakeStore";
        }

        /// <summary> Data Lake Store service URI. Type: string (or Expression with resultType string). </summary>
        public object DataLakeStoreUri { get; set; }
        /// <summary> The ID of the application used to authenticate against the Azure Data Lake Store account. Type: string (or Expression with resultType string). </summary>
        public object ServicePrincipalId { get; set; }
        /// <summary>
        /// The Key of the application used to authenticate against the Azure Data Lake Store account.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase ServicePrincipalKey { get; set; }
        /// <summary> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </summary>
        public object Tenant { get; set; }
        /// <summary> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </summary>
        public object AzureCloudType { get; set; }
        /// <summary> Data Lake Store account name. Type: string (or Expression with resultType string). </summary>
        public object AccountName { get; set; }
        /// <summary> Data Lake Store account subscription ID (if different from Data Factory account). Type: string (or Expression with resultType string). </summary>
        public object SubscriptionId { get; set; }
        /// <summary> Data Lake Store account resource group name (if different from Data Factory account). Type: string (or Expression with resultType string). </summary>
        public object ResourceGroupName { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public CredentialReference Credential { get; set; }
    }
}
