// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> The properties of DbNodeResource. </summary>
    public partial class CloudVmClusterDBNodeProperties
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

        /// <summary> Initializes a new instance of <see cref="CloudVmClusterDBNodeProperties"/>. </summary>
        /// <param name="ocid"> DbNode OCID. </param>
        /// <param name="dbSystemId"> The OCID of the DB system. </param>
        public CloudVmClusterDBNodeProperties(ResourceIdentifier ocid, ResourceIdentifier dbSystemId)
        {
            Ocid = ocid;
            DBSystemId = dbSystemId;
        }

        /// <summary> Initializes a new instance of <see cref="CloudVmClusterDBNodeProperties"/>. </summary>
        /// <param name="ocid"> DbNode OCID. </param>
        /// <param name="additionalDetails"> Additional information about the planned maintenance. </param>
        /// <param name="backupIPId"> The OCID of the backup IP address associated with the database node. </param>
        /// <param name="backupVnic2Id"> The OCID of the second backup VNIC. </param>
        /// <param name="backupVnicId"> The OCID of the backup VNIC. </param>
        /// <param name="cpuCoreCount"> The number of CPU cores enabled on the Db node. </param>
        /// <param name="dbNodeStorageSizeInGbs"> The allocated local node storage in GBs on the Db node. </param>
        /// <param name="dbServerId"> The OCID of the Exacc Db server associated with the database node. </param>
        /// <param name="dbSystemId"> The OCID of the DB system. </param>
        /// <param name="faultDomain"> The name of the Fault Domain the instance is contained in. </param>
        /// <param name="hostIPId"> The OCID of the host IP address associated with the database node. </param>
        /// <param name="hostname"> The host name for the database node. </param>
        /// <param name="lifecycleState"> The current state of the database node. </param>
        /// <param name="lifecycleDetails"> Lifecycle details of Db Node. </param>
        /// <param name="maintenanceType"> The type of database node maintenance. </param>
        /// <param name="memorySizeInGbs"> The allocated memory in GBs on the Db node. </param>
        /// <param name="softwareStorageSizeInGb"> The size (in GB) of the block storage volume allocation for the DB system. This attribute applies only for virtual machine DB systems. </param>
        /// <param name="timeCreated"> The date and time that the database node was created. </param>
        /// <param name="timeMaintenanceWindowEnd"> End date and time of maintenance window. </param>
        /// <param name="timeMaintenanceWindowStart"> Start date and time of maintenance window. </param>
        /// <param name="vnic2Id"> The OCID of the second VNIC. </param>
        /// <param name="vnicId"> The OCID of the VNIC. </param>
        /// <param name="provisioningState"> Azure resource provisioning state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudVmClusterDBNodeProperties(ResourceIdentifier ocid, string additionalDetails, ResourceIdentifier backupIPId, ResourceIdentifier backupVnic2Id, ResourceIdentifier backupVnicId, int? cpuCoreCount, int? dbNodeStorageSizeInGbs, ResourceIdentifier dbServerId, ResourceIdentifier dbSystemId, string faultDomain, ResourceIdentifier hostIPId, string hostname, DBNodeProvisioningState? lifecycleState, string lifecycleDetails, DBNodeMaintenanceType? maintenanceType, int? memorySizeInGbs, int? softwareStorageSizeInGb, DateTimeOffset? timeCreated, DateTimeOffset? timeMaintenanceWindowEnd, DateTimeOffset? timeMaintenanceWindowStart, ResourceIdentifier vnic2Id, ResourceIdentifier vnicId, OracleDatabaseResourceProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Ocid = ocid;
            AdditionalDetails = additionalDetails;
            BackupIPId = backupIPId;
            BackupVnic2Id = backupVnic2Id;
            BackupVnicId = backupVnicId;
            CpuCoreCount = cpuCoreCount;
            DBNodeStorageSizeInGbs = dbNodeStorageSizeInGbs;
            DBServerId = dbServerId;
            DBSystemId = dbSystemId;
            FaultDomain = faultDomain;
            HostIPId = hostIPId;
            Hostname = hostname;
            LifecycleState = lifecycleState;
            LifecycleDetails = lifecycleDetails;
            MaintenanceType = maintenanceType;
            MemorySizeInGbs = memorySizeInGbs;
            SoftwareStorageSizeInGb = softwareStorageSizeInGb;
            TimeCreated = timeCreated;
            TimeMaintenanceWindowEnd = timeMaintenanceWindowEnd;
            TimeMaintenanceWindowStart = timeMaintenanceWindowStart;
            Vnic2Id = vnic2Id;
            VnicId = vnicId;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CloudVmClusterDBNodeProperties"/> for deserialization. </summary>
        internal CloudVmClusterDBNodeProperties()
        {
        }

        /// <summary> DbNode OCID. </summary>
        public ResourceIdentifier Ocid { get; }
        /// <summary> Additional information about the planned maintenance. </summary>
        public string AdditionalDetails { get; }
        /// <summary> The OCID of the backup IP address associated with the database node. </summary>
        public ResourceIdentifier BackupIPId { get; }
        /// <summary> The OCID of the second backup VNIC. </summary>
        public ResourceIdentifier BackupVnic2Id { get; }
        /// <summary> The OCID of the backup VNIC. </summary>
        public ResourceIdentifier BackupVnicId { get; }
        /// <summary> The number of CPU cores enabled on the Db node. </summary>
        public int? CpuCoreCount { get; }
        /// <summary> The allocated local node storage in GBs on the Db node. </summary>
        public int? DBNodeStorageSizeInGbs { get; }
        /// <summary> The OCID of the Exacc Db server associated with the database node. </summary>
        public ResourceIdentifier DBServerId { get; }
        /// <summary> The OCID of the DB system. </summary>
        public ResourceIdentifier DBSystemId { get; }
        /// <summary> The name of the Fault Domain the instance is contained in. </summary>
        public string FaultDomain { get; }
        /// <summary> The OCID of the host IP address associated with the database node. </summary>
        public ResourceIdentifier HostIPId { get; }
        /// <summary> The host name for the database node. </summary>
        public string Hostname { get; }
        /// <summary> The current state of the database node. </summary>
        public DBNodeProvisioningState? LifecycleState { get; }
        /// <summary> Lifecycle details of Db Node. </summary>
        public string LifecycleDetails { get; }
        /// <summary> The type of database node maintenance. </summary>
        public DBNodeMaintenanceType? MaintenanceType { get; }
        /// <summary> The allocated memory in GBs on the Db node. </summary>
        public int? MemorySizeInGbs { get; }
        /// <summary> The size (in GB) of the block storage volume allocation for the DB system. This attribute applies only for virtual machine DB systems. </summary>
        public int? SoftwareStorageSizeInGb { get; }
        /// <summary> The date and time that the database node was created. </summary>
        public DateTimeOffset? TimeCreated { get; }
        /// <summary> End date and time of maintenance window. </summary>
        public DateTimeOffset? TimeMaintenanceWindowEnd { get; }
        /// <summary> Start date and time of maintenance window. </summary>
        public DateTimeOffset? TimeMaintenanceWindowStart { get; }
        /// <summary> The OCID of the second VNIC. </summary>
        public ResourceIdentifier Vnic2Id { get; }
        /// <summary> The OCID of the VNIC. </summary>
        public ResourceIdentifier VnicId { get; }
        /// <summary> Azure resource provisioning state. </summary>
        public OracleDatabaseResourceProvisioningState? ProvisioningState { get; }
    }
}
