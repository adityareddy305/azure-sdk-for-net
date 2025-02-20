// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Base class for backup items.
    /// Please note <see cref="BackupGenericProtectedItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FileshareProtectedItem"/>, <see cref="IaasVmProtectedItem"/>, <see cref="VmWorkloadProtectedItem"/>, <see cref="VmWorkloadSapAseDatabaseProtectedItem"/>, <see cref="VmWorkloadSapHanaDatabaseProtectedItem"/>, <see cref="VmWorkloadSapHanaDBInstanceProtectedItem"/>, <see cref="VmWorkloadSqlDatabaseProtectedItem"/>, <see cref="DpmProtectedItem"/>, <see cref="GenericProtectedItem"/>, <see cref="MabFileFolderProtectedItem"/>, <see cref="IaasClassicComputeVmProtectedItem"/>, <see cref="IaasComputeVmProtectedItem"/> and <see cref="SqlProtectedItem"/>.
    /// </summary>
    public abstract partial class BackupGenericProtectedItem
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BackupGenericProtectedItem"/>. </summary>
        protected BackupGenericProtectedItem()
        {
            ResourceGuardOperationRequests = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="BackupGenericProtectedItem"/>. </summary>
        /// <param name="protectedItemType"> backup item type. </param>
        /// <param name="backupManagementType"> Type of backup management for the backed up item. </param>
        /// <param name="workloadType"> Type of workload this item represents. </param>
        /// <param name="containerName"> Unique name of container. </param>
        /// <param name="sourceResourceId"> ARM ID of the resource to be backed up. </param>
        /// <param name="policyId"> ID of the backup policy with which this item is backed up. </param>
        /// <param name="lastRecoverOn"> Timestamp when the last (latest) backup copy was created for this backup item. </param>
        /// <param name="backupSetName"> Name of the backup set the backup item belongs to. </param>
        /// <param name="createMode"> Create mode to indicate recovery of existing soft deleted data source or creation of new data source. </param>
        /// <param name="deferredDeletedOn"> Time for deferred deletion in UTC. </param>
        /// <param name="isScheduledForDeferredDelete"> Flag to identify whether the DS is scheduled for deferred delete. </param>
        /// <param name="deferredDeleteTimeRemaining"> Time remaining before the DS marked for deferred delete is permanently deleted. </param>
        /// <param name="isDeferredDeleteScheduleUpcoming"> Flag to identify whether the deferred deleted DS is to be purged soon. </param>
        /// <param name="isRehydrate"> Flag to identify that deferred deleted DS is to be moved into Pause state. </param>
        /// <param name="resourceGuardOperationRequests"> ResourceGuardOperationRequests on which LAC check will be performed. </param>
        /// <param name="isArchiveEnabled"> Flag to identify whether datasource is protected in archive. </param>
        /// <param name="policyName"> Name of the policy used for protection. </param>
        /// <param name="softDeleteRetentionPeriodInDays"> Soft delete retention period in days. </param>
        /// <param name="vaultId"> ID of the vault which protects this item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupGenericProtectedItem(string protectedItemType, BackupManagementType? backupManagementType, BackupDataSourceType? workloadType, string containerName, ResourceIdentifier sourceResourceId, ResourceIdentifier policyId, DateTimeOffset? lastRecoverOn, string backupSetName, BackupCreateMode? createMode, DateTimeOffset? deferredDeletedOn, bool? isScheduledForDeferredDelete, string deferredDeleteTimeRemaining, bool? isDeferredDeleteScheduleUpcoming, bool? isRehydrate, IList<string> resourceGuardOperationRequests, bool? isArchiveEnabled, string policyName, int? softDeleteRetentionPeriodInDays, string vaultId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProtectedItemType = protectedItemType;
            BackupManagementType = backupManagementType;
            WorkloadType = workloadType;
            ContainerName = containerName;
            SourceResourceId = sourceResourceId;
            PolicyId = policyId;
            LastRecoverOn = lastRecoverOn;
            BackupSetName = backupSetName;
            CreateMode = createMode;
            DeferredDeletedOn = deferredDeletedOn;
            IsScheduledForDeferredDelete = isScheduledForDeferredDelete;
            DeferredDeleteTimeRemaining = deferredDeleteTimeRemaining;
            IsDeferredDeleteScheduleUpcoming = isDeferredDeleteScheduleUpcoming;
            IsRehydrate = isRehydrate;
            ResourceGuardOperationRequests = resourceGuardOperationRequests;
            IsArchiveEnabled = isArchiveEnabled;
            PolicyName = policyName;
            SoftDeleteRetentionPeriodInDays = softDeleteRetentionPeriodInDays;
            VaultId = vaultId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> backup item type. </summary>
        internal string ProtectedItemType { get; set; }
        /// <summary> Type of backup management for the backed up item. </summary>
        public BackupManagementType? BackupManagementType { get; }
        /// <summary> Type of workload this item represents. </summary>
        public BackupDataSourceType? WorkloadType { get; }
        /// <summary> Unique name of container. </summary>
        public string ContainerName { get; set; }
        /// <summary> ARM ID of the resource to be backed up. </summary>
        public ResourceIdentifier SourceResourceId { get; set; }
        /// <summary> ID of the backup policy with which this item is backed up. </summary>
        public ResourceIdentifier PolicyId { get; set; }
        /// <summary> Timestamp when the last (latest) backup copy was created for this backup item. </summary>
        public DateTimeOffset? LastRecoverOn { get; set; }
        /// <summary> Name of the backup set the backup item belongs to. </summary>
        public string BackupSetName { get; set; }
        /// <summary> Create mode to indicate recovery of existing soft deleted data source or creation of new data source. </summary>
        public BackupCreateMode? CreateMode { get; set; }
        /// <summary> Time for deferred deletion in UTC. </summary>
        public DateTimeOffset? DeferredDeletedOn { get; set; }
        /// <summary> Flag to identify whether the DS is scheduled for deferred delete. </summary>
        public bool? IsScheduledForDeferredDelete { get; set; }
        /// <summary> Time remaining before the DS marked for deferred delete is permanently deleted. </summary>
        public string DeferredDeleteTimeRemaining { get; set; }
        /// <summary> Flag to identify whether the deferred deleted DS is to be purged soon. </summary>
        public bool? IsDeferredDeleteScheduleUpcoming { get; set; }
        /// <summary> Flag to identify that deferred deleted DS is to be moved into Pause state. </summary>
        public bool? IsRehydrate { get; set; }
        /// <summary> ResourceGuardOperationRequests on which LAC check will be performed. </summary>
        public IList<string> ResourceGuardOperationRequests { get; }
        /// <summary> Flag to identify whether datasource is protected in archive. </summary>
        public bool? IsArchiveEnabled { get; set; }
        /// <summary> Name of the policy used for protection. </summary>
        public string PolicyName { get; set; }
        /// <summary> Soft delete retention period in days. </summary>
        public int? SoftDeleteRetentionPeriodInDays { get; set; }
        /// <summary> ID of the vault which protects this item. </summary>
        public string VaultId { get; }
    }
}
