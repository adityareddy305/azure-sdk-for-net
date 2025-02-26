// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service for Windows Azure Search Service. </summary>
    public partial class AzureSearchLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="AzureSearchLinkedService"/>. </summary>
        /// <param name="url"> URL for Azure Search service. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        public AzureSearchLinkedService(object url)
        {
            Argument.AssertNotNull(url, nameof(url));

            Url = url;
            Type = "AzureSearch";
        }

        /// <summary> Initializes a new instance of <see cref="AzureSearchLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="version"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="url"> URL for Azure Search service. Type: string (or Expression with resultType string). </param>
        /// <param name="key">
        /// Admin Key for Azure Search service
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal AzureSearchLinkedService(string type, string version, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object url, SecretBase key, object encryptedCredential) : base(type, version, connectVia, description, parameters, annotations, additionalProperties)
        {
            Url = url;
            Key = key;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "AzureSearch";
        }

        /// <summary> URL for Azure Search service. Type: string (or Expression with resultType string). </summary>
        public object Url { get; set; }
        /// <summary>
        /// Admin Key for Azure Search service
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Key { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
