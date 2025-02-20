// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlDatabaseBlobAuditingPolicy.
/// </summary>
public partial class SqlDatabaseBlobAuditingPolicy : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Specifies the Actions-Groups and Actions to audit.
    /// The recommended set of action groups to use
    /// is the following combination - this will audit all the queries and
    /// stored procedures executed against the database, as well as successful
    /// and failed logins:                           BATCH_COMPLETED_GROUP,
    /// SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP,
    /// FAILED_DATABASE_AUTHENTICATION_GROUP.
    /// This above combination is also the set that
    /// is configured by default when enabling auditing from the Azure portal.
    /// The supported action groups to audit are
    /// (note: choose only specific groups that cover your auditing needs.
    /// Using unnecessary groups could lead to very large quantities of audit
    /// records):
    /// APPLICATION_ROLE_CHANGE_PASSWORD_GROUP
    /// BACKUP_RESTORE_GROUP              DATABASE_LOGOUT_GROUP
    /// DATABASE_OBJECT_CHANGE_GROUP
    /// DATABASE_OBJECT_OWNERSHIP_CHANGE_GROUP
    /// DATABASE_OBJECT_PERMISSION_CHANGE_GROUP
    /// DATABASE_OPERATION_GROUP
    /// DATABASE_PERMISSION_CHANGE_GROUP
    /// DATABASE_PRINCIPAL_CHANGE_GROUP
    /// DATABASE_PRINCIPAL_IMPERSONATION_GROUP
    /// DATABASE_ROLE_MEMBER_CHANGE_GROUP
    /// FAILED_DATABASE_AUTHENTICATION_GROUP
    /// SCHEMA_OBJECT_ACCESS_GROUP
    /// SCHEMA_OBJECT_CHANGE_GROUP
    /// SCHEMA_OBJECT_OWNERSHIP_CHANGE_GROUP
    /// SCHEMA_OBJECT_PERMISSION_CHANGE_GROUP
    /// SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP
    /// USER_CHANGE_PASSWORD_GROUP
    /// BATCH_STARTED_GROUP              BATCH_COMPLETED_GROUP
    /// DBCC_GROUP              DATABASE_OWNERSHIP_CHANGE_GROUP
    /// DATABASE_CHANGE_GROUP              LEDGER_OPERATION_GROUP
    /// These are groups that cover all sql
    /// statements and stored procedures executed against the database, and
    /// should not be used in combination with other groups as this will
    /// result in duplicate audit logs.                           For more
    /// information, see [Database-Level Audit Action
    /// Groups](https://docs.microsoft.com/en-us/sql/relational-databases/security/auditing/sql-server-audit-action-groups-and-actions#database-level-audit-action-groups).
    /// For Database auditing policy, specific
    /// Actions can also be specified (note that Actions cannot be specified
    /// for Server auditing policy). The supported actions to audit are:
    /// SELECT              UPDATE              INSERT
    /// DELETE              EXECUTE              RECEIVE
    /// REFERENCES                           The general form for
    /// defining an action to be audited is:              {action} ON {object}
    /// BY {principal}                           Note that &lt;object&gt; in
    /// the above format can refer to an object like a table, view, or stored
    /// procedure, or an entire database or schema. For the latter cases, the
    /// forms DATABASE::{db_name} and SCHEMA::{schema_name} are used,
    /// respectively.                           For example:
    /// SELECT on dbo.myTable by public              SELECT on
    /// DATABASE::myDatabase by public              SELECT on SCHEMA::mySchema
    /// by public                           For more information, see
    /// [Database-Level Audit
    /// Actions](https://docs.microsoft.com/en-us/sql/relational-databases/security/auditing/sql-server-audit-action-groups-and-actions#database-level-audit-actions)
    /// </summary>
    public BicepList<string> AuditActionsAndGroups 
    {
        get { Initialize(); return _auditActionsAndGroups!; }
        set { Initialize(); _auditActionsAndGroups!.Assign(value); }
    }
    private BicepList<string>? _auditActionsAndGroups;

    /// <summary>
    /// Specifies whether audit events are sent to Azure Monitor.
    /// In order to send the events to Azure Monitor, specify
    /// &apos;State&apos; as &apos;Enabled&apos; and
    /// &apos;IsAzureMonitorTargetEnabled&apos; as true.
    /// When using REST API to configure auditing,
    /// Diagnostic Settings with &apos;SQLSecurityAuditEvents&apos; diagnostic
    /// logs category on the database should be also created.
    /// Note that for server level audit you should use the
    /// &apos;master&apos; database as {databaseName}.
    /// Diagnostic Settings URI format:
    /// PUT
    /// https://management.azure.com/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/providers/microsoft.insights/diagnosticSettings/{settingsName}?api-version=2017-05-01-preview
    /// For more information, see [Diagnostic
    /// Settings REST API](https://go.microsoft.com/fwlink/?linkid=2033207)
    /// or [Diagnostic Settings
    /// PowerShell](https://go.microsoft.com/fwlink/?linkid=2033043)
    /// </summary>
    public BicepValue<bool> IsAzureMonitorTargetEnabled 
    {
        get { Initialize(); return _isAzureMonitorTargetEnabled!; }
        set { Initialize(); _isAzureMonitorTargetEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isAzureMonitorTargetEnabled;

    /// <summary>
    /// Specifies whether Managed Identity is used to access blob storage.
    /// </summary>
    public BicepValue<bool> IsManagedIdentityInUse 
    {
        get { Initialize(); return _isManagedIdentityInUse!; }
        set { Initialize(); _isManagedIdentityInUse!.Assign(value); }
    }
    private BicepValue<bool>? _isManagedIdentityInUse;

    /// <summary>
    /// Specifies whether storageAccountAccessKey value is the storage&apos;s
    /// secondary key.
    /// </summary>
    public BicepValue<bool> IsStorageSecondaryKeyInUse 
    {
        get { Initialize(); return _isStorageSecondaryKeyInUse!; }
        set { Initialize(); _isStorageSecondaryKeyInUse!.Assign(value); }
    }
    private BicepValue<bool>? _isStorageSecondaryKeyInUse;

    /// <summary>
    /// Specifies the amount of time in milliseconds that can elapse before
    /// audit actions are forced to be processed.             The default
    /// minimum value is 1000 (1 second). The maximum is 2,147,483,647.
    /// </summary>
    public BicepValue<int> QueueDelayMs 
    {
        get { Initialize(); return _queueDelayMs!; }
        set { Initialize(); _queueDelayMs!.Assign(value); }
    }
    private BicepValue<int>? _queueDelayMs;

    /// <summary>
    /// Specifies the number of days to keep in the audit logs in the storage
    /// account.
    /// </summary>
    public BicepValue<int> RetentionDays 
    {
        get { Initialize(); return _retentionDays!; }
        set { Initialize(); _retentionDays!.Assign(value); }
    }
    private BicepValue<int>? _retentionDays;

    /// <summary>
    /// Specifies the state of the audit. If state is Enabled, storageEndpoint
    /// or isAzureMonitorTargetEnabled are required.
    /// </summary>
    public BicepValue<BlobAuditingPolicyState> State 
    {
        get { Initialize(); return _state!; }
        set { Initialize(); _state!.Assign(value); }
    }
    private BicepValue<BlobAuditingPolicyState>? _state;

    /// <summary>
    /// Specifies the identifier key of the auditing storage account.
    /// If state is Enabled and storageEndpoint is specified, not
    /// specifying the storageAccountAccessKey will use SQL server
    /// system-assigned managed identity to access the storage.
    /// Prerequisites for using managed identity authentication:
    /// 1. Assign SQL Server a system-assigned managed identity in
    /// Azure Active Directory (AAD).             2. Grant SQL Server identity
    /// access to the storage account by adding &apos;Storage Blob Data
    /// Contributor&apos; RBAC role to the server identity.             For
    /// more information, see [Auditing to storage using Managed Identity
    /// authentication](https://go.microsoft.com/fwlink/?linkid=2114355)
    /// </summary>
    public BicepValue<string> StorageAccountAccessKey 
    {
        get { Initialize(); return _storageAccountAccessKey!; }
        set { Initialize(); _storageAccountAccessKey!.Assign(value); }
    }
    private BicepValue<string>? _storageAccountAccessKey;

    /// <summary>
    /// Specifies the blob storage subscription Id.
    /// </summary>
    public BicepValue<Guid> StorageAccountSubscriptionId 
    {
        get { Initialize(); return _storageAccountSubscriptionId!; }
        set { Initialize(); _storageAccountSubscriptionId!.Assign(value); }
    }
    private BicepValue<Guid>? _storageAccountSubscriptionId;

    /// <summary>
    /// Specifies the blob storage endpoint (e.g.
    /// https://MyAccount.blob.core.windows.net). If state is Enabled,
    /// storageEndpoint or isAzureMonitorTargetEnabled is required.
    /// </summary>
    public BicepValue<string> StorageEndpoint 
    {
        get { Initialize(); return _storageEndpoint!; }
        set { Initialize(); _storageEndpoint!.Assign(value); }
    }
    private BicepValue<string>? _storageEndpoint;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Resource kind.
    /// </summary>
    public BicepValue<string> Kind 
    {
        get { Initialize(); return _kind!; }
    }
    private BicepValue<string>? _kind;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SqlDatabase.
    /// </summary>
    public SqlDatabase? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<SqlDatabase>? _parent;

    /// <summary>
    /// Creates a new SqlDatabaseBlobAuditingPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlDatabaseBlobAuditingPolicy
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlDatabaseBlobAuditingPolicy.</param>
    public SqlDatabaseBlobAuditingPolicy(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/databases/auditingSettings", resourceVersion ?? "2021-11-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// SqlDatabaseBlobAuditingPolicy.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _auditActionsAndGroups = DefineListProperty<string>("AuditActionsAndGroups", ["properties", "auditActionsAndGroups"]);
        _isAzureMonitorTargetEnabled = DefineProperty<bool>("IsAzureMonitorTargetEnabled", ["properties", "isAzureMonitorTargetEnabled"]);
        _isManagedIdentityInUse = DefineProperty<bool>("IsManagedIdentityInUse", ["properties", "isManagedIdentityInUse"]);
        _isStorageSecondaryKeyInUse = DefineProperty<bool>("IsStorageSecondaryKeyInUse", ["properties", "isStorageSecondaryKeyInUse"]);
        _queueDelayMs = DefineProperty<int>("QueueDelayMs", ["properties", "queueDelayMs"]);
        _retentionDays = DefineProperty<int>("RetentionDays", ["properties", "retentionDays"]);
        _state = DefineProperty<BlobAuditingPolicyState>("State", ["properties", "state"]);
        _storageAccountAccessKey = DefineProperty<string>("StorageAccountAccessKey", ["properties", "storageAccountAccessKey"]);
        _storageAccountSubscriptionId = DefineProperty<Guid>("StorageAccountSubscriptionId", ["properties", "storageAccountSubscriptionId"]);
        _storageEndpoint = DefineProperty<string>("StorageEndpoint", ["properties", "storageEndpoint"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _kind = DefineProperty<string>("Kind", ["kind"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<SqlDatabase>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SqlDatabaseBlobAuditingPolicy resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing SqlDatabaseBlobAuditingPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlDatabaseBlobAuditingPolicy
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlDatabaseBlobAuditingPolicy.</param>
    /// <returns>The existing SqlDatabaseBlobAuditingPolicy resource.</returns>
    public static SqlDatabaseBlobAuditingPolicy FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
