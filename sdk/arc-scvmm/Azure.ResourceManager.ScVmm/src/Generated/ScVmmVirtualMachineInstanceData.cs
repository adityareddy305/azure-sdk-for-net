// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.ScVmm.Models;

namespace Azure.ResourceManager.ScVmm
{
    /// <summary>
    /// A class representing the ScVmmVirtualMachineInstance data model.
    /// Define the virtualMachineInstance.
    /// </summary>
    public partial class ScVmmVirtualMachineInstanceData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ScVmmVirtualMachineInstanceData"/>. </summary>
        /// <param name="extendedLocation"> Gets or sets the extended location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extendedLocation"/> is null. </exception>
        public ScVmmVirtualMachineInstanceData(ExtendedLocation extendedLocation)
        {
            Argument.AssertNotNull(extendedLocation, nameof(extendedLocation));

            ExtendedLocation = extendedLocation;
            AvailabilitySets = new ChangeTrackingList<ScVmmAvailabilitySetItem>();
        }

        /// <summary> Initializes a new instance of <see cref="ScVmmVirtualMachineInstanceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="extendedLocation"> Gets or sets the extended location. </param>
        /// <param name="availabilitySets"> Availability Sets in vm. </param>
        /// <param name="osProfile"> OS properties. </param>
        /// <param name="hardwareProfile"> Hardware properties. </param>
        /// <param name="networkProfile"> Network properties. </param>
        /// <param name="storageProfile"> Storage properties. </param>
        /// <param name="infrastructureProfile"> Gets the infrastructure profile. </param>
        /// <param name="powerState"> Gets the power state of the virtual machine. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScVmmVirtualMachineInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ExtendedLocation extendedLocation, IList<ScVmmAvailabilitySetItem> availabilitySets, OSProfileForVmInstance osProfile, ScVmmHardwareProfile hardwareProfile, ScVmmNetworkProfile networkProfile, ScVmmStorageProfile storageProfile, ScVmmInfrastructureProfile infrastructureProfile, string powerState, ScVmmProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ExtendedLocation = extendedLocation;
            AvailabilitySets = availabilitySets;
            OSProfile = osProfile;
            HardwareProfile = hardwareProfile;
            NetworkProfile = networkProfile;
            StorageProfile = storageProfile;
            InfrastructureProfile = infrastructureProfile;
            PowerState = powerState;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ScVmmVirtualMachineInstanceData"/> for deserialization. </summary>
        internal ScVmmVirtualMachineInstanceData()
        {
        }

        /// <summary> Gets or sets the extended location. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Availability Sets in vm. </summary>
        public IList<ScVmmAvailabilitySetItem> AvailabilitySets { get; }
        /// <summary> OS properties. </summary>
        public OSProfileForVmInstance OSProfile { get; set; }
        /// <summary> Hardware properties. </summary>
        public ScVmmHardwareProfile HardwareProfile { get; set; }
        /// <summary> Network properties. </summary>
        internal ScVmmNetworkProfile NetworkProfile { get; set; }
        /// <summary> Gets or sets the list of network interfaces associated with the virtual machine. </summary>
        public IList<ScVmmNetworkInterface> NetworkInterfaces
        {
            get
            {
                if (NetworkProfile is null)
                    NetworkProfile = new ScVmmNetworkProfile();
                return NetworkProfile.NetworkInterfaces;
            }
        }

        /// <summary> Storage properties. </summary>
        internal ScVmmStorageProfile StorageProfile { get; set; }
        /// <summary> Gets or sets the list of virtual disks associated with the virtual machine. </summary>
        public IList<ScVmmVirtualDisk> StorageDisks
        {
            get
            {
                if (StorageProfile is null)
                    StorageProfile = new ScVmmStorageProfile();
                return StorageProfile.Disks;
            }
        }

        /// <summary> Gets the infrastructure profile. </summary>
        public ScVmmInfrastructureProfile InfrastructureProfile { get; set; }
        /// <summary> Gets the power state of the virtual machine. </summary>
        public string PowerState { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public ScVmmProvisioningState? ProvisioningState { get; }
    }
}
