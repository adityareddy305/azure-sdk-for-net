// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Dra model properties. </summary>
    public partial class DataReplicationDraProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataReplicationDraProperties"/>. </summary>
        /// <param name="machineId"> Gets or sets the machine Id where Dra is running. </param>
        /// <param name="machineName"> Gets or sets the machine name where Dra is running. </param>
        /// <param name="authenticationIdentity"> Identity model. </param>
        /// <param name="resourceAccessIdentity"> Identity model. </param>
        /// <param name="customProperties">
        /// Dra model custom properties.
        /// Please note <see cref="DraModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeneralDraModelCustomProperties"/> and <see cref="VMwareDraModelCustomProperties"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="machineId"/>, <paramref name="machineName"/>, <paramref name="authenticationIdentity"/>, <paramref name="resourceAccessIdentity"/> or <paramref name="customProperties"/> is null. </exception>
        public DataReplicationDraProperties(string machineId, string machineName, DataReplicationIdentity authenticationIdentity, DataReplicationIdentity resourceAccessIdentity, DraModelCustomProperties customProperties)
        {
            Argument.AssertNotNull(machineId, nameof(machineId));
            Argument.AssertNotNull(machineName, nameof(machineName));
            Argument.AssertNotNull(authenticationIdentity, nameof(authenticationIdentity));
            Argument.AssertNotNull(resourceAccessIdentity, nameof(resourceAccessIdentity));
            Argument.AssertNotNull(customProperties, nameof(customProperties));

            MachineId = machineId;
            MachineName = machineName;
            AuthenticationIdentity = authenticationIdentity;
            ResourceAccessIdentity = resourceAccessIdentity;
            HealthErrors = new ChangeTrackingList<DataReplicationHealthErrorInfo>();
            CustomProperties = customProperties;
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationDraProperties"/>. </summary>
        /// <param name="correlationId"> Gets or sets the Dra correlation Id. </param>
        /// <param name="machineId"> Gets or sets the machine Id where Dra is running. </param>
        /// <param name="machineName"> Gets or sets the machine name where Dra is running. </param>
        /// <param name="authenticationIdentity"> Identity model. </param>
        /// <param name="resourceAccessIdentity"> Identity model. </param>
        /// <param name="isResponsive"> Gets or sets a value indicating whether Dra is responsive. </param>
        /// <param name="lastHeartbeatOn"> Gets or sets the time when last heartbeat was sent by the Dra. </param>
        /// <param name="versionNumber"> Gets or sets the Dra version. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state of the Dra. </param>
        /// <param name="healthErrors"> Gets or sets the list of health errors. </param>
        /// <param name="customProperties">
        /// Dra model custom properties.
        /// Please note <see cref="DraModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeneralDraModelCustomProperties"/> and <see cref="VMwareDraModelCustomProperties"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataReplicationDraProperties(string correlationId, string machineId, string machineName, DataReplicationIdentity authenticationIdentity, DataReplicationIdentity resourceAccessIdentity, bool? isResponsive, DateTimeOffset? lastHeartbeatOn, string versionNumber, DataReplicationProvisioningState? provisioningState, IReadOnlyList<DataReplicationHealthErrorInfo> healthErrors, DraModelCustomProperties customProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CorrelationId = correlationId;
            MachineId = machineId;
            MachineName = machineName;
            AuthenticationIdentity = authenticationIdentity;
            ResourceAccessIdentity = resourceAccessIdentity;
            IsResponsive = isResponsive;
            LastHeartbeatOn = lastHeartbeatOn;
            VersionNumber = versionNumber;
            ProvisioningState = provisioningState;
            HealthErrors = healthErrors;
            CustomProperties = customProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationDraProperties"/> for deserialization. </summary>
        internal DataReplicationDraProperties()
        {
        }

        /// <summary> Gets or sets the Dra correlation Id. </summary>
        public string CorrelationId { get; }
        /// <summary> Gets or sets the machine Id where Dra is running. </summary>
        public string MachineId { get; set; }
        /// <summary> Gets or sets the machine name where Dra is running. </summary>
        public string MachineName { get; set; }
        /// <summary> Identity model. </summary>
        public DataReplicationIdentity AuthenticationIdentity { get; set; }
        /// <summary> Identity model. </summary>
        public DataReplicationIdentity ResourceAccessIdentity { get; set; }
        /// <summary> Gets or sets a value indicating whether Dra is responsive. </summary>
        public bool? IsResponsive { get; }
        /// <summary> Gets or sets the time when last heartbeat was sent by the Dra. </summary>
        public DateTimeOffset? LastHeartbeatOn { get; }
        /// <summary> Gets or sets the Dra version. </summary>
        public string VersionNumber { get; }
        /// <summary> Gets or sets the provisioning state of the Dra. </summary>
        public DataReplicationProvisioningState? ProvisioningState { get; }
        /// <summary> Gets or sets the list of health errors. </summary>
        public IReadOnlyList<DataReplicationHealthErrorInfo> HealthErrors { get; }
        /// <summary>
        /// Dra model custom properties.
        /// Please note <see cref="DraModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeneralDraModelCustomProperties"/> and <see cref="VMwareDraModelCustomProperties"/>.
        /// </summary>
        public DraModelCustomProperties CustomProperties { get; set; }
    }
}
