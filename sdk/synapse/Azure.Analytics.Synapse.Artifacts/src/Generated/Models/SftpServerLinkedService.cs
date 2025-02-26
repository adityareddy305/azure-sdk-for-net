// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A linked service for an SSH File Transfer Protocol (SFTP) server. </summary>
    public partial class SftpServerLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="SftpServerLinkedService"/>. </summary>
        /// <param name="host"> The SFTP server host name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public SftpServerLinkedService(object host)
        {
            Argument.AssertNotNull(host, nameof(host));

            Host = host;
            Type = "Sftp";
        }

        /// <summary> Initializes a new instance of <see cref="SftpServerLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="version"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> The SFTP server host name. Type: string (or Expression with resultType string). </param>
        /// <param name="port"> The TCP port number that the SFTP server uses to listen for client connections. Default value is 22. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="authenticationType"> The authentication type to be used to connect to the FTP server. </param>
        /// <param name="userName"> The username used to log on to the SFTP server. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// Password to logon the SFTP server for Basic authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        /// <param name="privateKeyPath"> The SSH private key file path for SshPublicKey authentication. Only valid for on-premises copy. For on-premises copy with SshPublicKey authentication, either PrivateKeyPath or PrivateKeyContent should be specified. SSH private key should be OpenSSH format. Type: string (or Expression with resultType string). </param>
        /// <param name="privateKeyContent">
        /// Base64 encoded SSH private key content for SshPublicKey authentication. For on-premises copy with SshPublicKey authentication, either PrivateKeyPath or PrivateKeyContent should be specified. SSH private key should be OpenSSH format.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="passPhrase">
        /// The password to decrypt the SSH private key if the SSH private key is encrypted.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="skipHostKeyValidation"> If true, skip the SSH host key validation. Default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="hostKeyFingerprint"> The host key finger-print of the SFTP server. When SkipHostKeyValidation is false, HostKeyFingerprint should be specified. Type: string (or Expression with resultType string). </param>
        internal SftpServerLinkedService(string type, string version, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object host, object port, SftpAuthenticationType? authenticationType, object userName, SecretBase password, object encryptedCredential, object privateKeyPath, SecretBase privateKeyContent, SecretBase passPhrase, object skipHostKeyValidation, object hostKeyFingerprint) : base(type, version, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            Port = port;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            PrivateKeyPath = privateKeyPath;
            PrivateKeyContent = privateKeyContent;
            PassPhrase = passPhrase;
            SkipHostKeyValidation = skipHostKeyValidation;
            HostKeyFingerprint = hostKeyFingerprint;
            Type = type ?? "Sftp";
        }

        /// <summary> The SFTP server host name. Type: string (or Expression with resultType string). </summary>
        public object Host { get; set; }
        /// <summary> The TCP port number that the SFTP server uses to listen for client connections. Default value is 22. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public object Port { get; set; }
        /// <summary> The authentication type to be used to connect to the FTP server. </summary>
        public SftpAuthenticationType? AuthenticationType { get; set; }
        /// <summary> The username used to log on to the SFTP server. Type: string (or Expression with resultType string). </summary>
        public object UserName { get; set; }
        /// <summary>
        /// Password to logon the SFTP server for Basic authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
        /// <summary> The SSH private key file path for SshPublicKey authentication. Only valid for on-premises copy. For on-premises copy with SshPublicKey authentication, either PrivateKeyPath or PrivateKeyContent should be specified. SSH private key should be OpenSSH format. Type: string (or Expression with resultType string). </summary>
        public object PrivateKeyPath { get; set; }
        /// <summary>
        /// Base64 encoded SSH private key content for SshPublicKey authentication. For on-premises copy with SshPublicKey authentication, either PrivateKeyPath or PrivateKeyContent should be specified. SSH private key should be OpenSSH format.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase PrivateKeyContent { get; set; }
        /// <summary>
        /// The password to decrypt the SSH private key if the SSH private key is encrypted.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase PassPhrase { get; set; }
        /// <summary> If true, skip the SSH host key validation. Default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object SkipHostKeyValidation { get; set; }
        /// <summary> The host key finger-print of the SFTP server. When SkipHostKeyValidation is false, HostKeyFingerprint should be specified. Type: string (or Expression with resultType string). </summary>
        public object HostKeyFingerprint { get; set; }
    }
}
