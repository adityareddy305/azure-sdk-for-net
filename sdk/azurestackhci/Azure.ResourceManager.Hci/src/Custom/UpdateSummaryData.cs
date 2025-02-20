// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing the UpdateSummary data model.
    /// Get the update summaries for the cluster
    /// </summary>
    [Obsolete("This class is now deprecated. Please use the new class `HciClusterUpdateSummaryData` moving forward.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class UpdateSummaryData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="UpdateSummaryData"/>. </summary>
        public UpdateSummaryData()
        {
            PackageVersions = new ChangeTrackingList<HciPackageVersionInfo>();
            HealthCheckResult = new ChangeTrackingList<HciPrecheckResult>();
        }

        /// <summary> Initializes a new instance of <see cref="UpdateSummaryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="provisioningState"> Provisioning state of the UpdateSummaries proxy resource. </param>
        /// <param name="oemFamily"> OEM family name. </param>
        /// <param name="hardwareModel"> Name of the hardware model. </param>
        /// <param name="packageVersions"> Current version of each updatable component. </param>
        /// <param name="currentVersion"> Current Solution Bundle version of the stamp. </param>
        /// <param name="lastUpdated"> Last time an update installation completed successfully. </param>
        /// <param name="lastChecked"> Last time the update service successfully checked for updates. </param>
        /// <param name="healthState"> Overall health state for update-specific health checks. </param>
        /// <param name="healthCheckResult"> An array of pre-check result objects. </param>
        /// <param name="healthCheckOn"> Last time the package-specific checks were run. </param>
        /// <param name="state"> Overall update state of the stamp. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdateSummaryData(ResourceIdentifier id, string name, ResourceType resourceType, ResourceManager.Models.SystemData systemData, AzureLocation? location, HciProvisioningState? provisioningState, string oemFamily, string hardwareModel, IList<HciPackageVersionInfo> packageVersions, string currentVersion, DateTimeOffset? lastUpdated, DateTimeOffset? lastChecked, HciHealthState? healthState, IList<HciPrecheckResult> healthCheckResult, DateTimeOffset? healthCheckOn, UpdateSummariesPropertiesState? state, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            ProvisioningState = provisioningState;
            OemFamily = oemFamily;
            HardwareModel = hardwareModel;
            PackageVersions = packageVersions;
            CurrentVersion = currentVersion;
            LastUpdated = lastUpdated;
            LastChecked = lastChecked;
            HealthState = healthState;
            HealthCheckResult = healthCheckResult;
            HealthCheckOn = healthCheckOn;
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal UpdateSummaryData(HciClusterUpdateSummaryData data) : base(data.Id, data.Name, data.ResourceType, data.SystemData)
        {
            Location = data.Location;
            ProvisioningState = data.ProvisioningState;
            OemFamily = data.OemFamily;
            HardwareModel = data.HardwareModel;
            PackageVersions = data.PackageVersions;
            CurrentVersion = data.CurrentVersion;
            LastUpdated = data.LastUpdatedOn;
            LastChecked = data.LastCheckedOn;
            HealthState = data.HealthState;
            HealthCheckResult = data.HealthCheckResult;
            HealthCheckOn = data.HealthCheckOn;
            State = data.State.ToString();
            _serializedAdditionalRawData = null;
        }

        internal HciClusterUpdateSummaryData ToHciClusterUpdateSummaryData()
        {
            return new HciClusterUpdateSummaryData(Id, Name, ResourceType, SystemData, Location, ProvisioningState, OemFamily, default, HardwareModel, PackageVersions,
                CurrentVersion, default, LastUpdated, LastChecked, HealthState, HealthCheckResult, HealthCheckOn, State.ToString(), _serializedAdditionalRawData);
        }

        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Provisioning state of the UpdateSummaries proxy resource. </summary>
        public HciProvisioningState? ProvisioningState { get; }
        /// <summary> OEM family name. </summary>
        public string OemFamily { get; set; }
        /// <summary> Name of the hardware model. </summary>
        public string HardwareModel { get; set; }
        /// <summary> Current version of each updatable component. </summary>
        public IList<HciPackageVersionInfo> PackageVersions { get; }
        /// <summary> Current Solution Bundle version of the stamp. </summary>
        public string CurrentVersion { get; set; }
        /// <summary> Last time an update installation completed successfully. </summary>
        public DateTimeOffset? LastUpdated { get; set; }
        /// <summary> Last time the update service successfully checked for updates. </summary>
        public DateTimeOffset? LastChecked { get; set; }
        /// <summary> Overall health state for update-specific health checks. </summary>
        public HciHealthState? HealthState { get; set; }
        /// <summary> An array of pre-check result objects. </summary>
        public IList<HciPrecheckResult> HealthCheckResult { get; }
        /// <summary> Last time the package-specific checks were run. </summary>
        public DateTimeOffset? HealthCheckOn { get; set; }
        /// <summary> Overall update state of the stamp. </summary>
        public UpdateSummariesPropertiesState? State { get; set; }
    }
}
