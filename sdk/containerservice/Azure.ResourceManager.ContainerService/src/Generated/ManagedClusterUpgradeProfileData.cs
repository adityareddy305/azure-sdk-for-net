// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A class representing the ManagedClusterUpgradeProfile data model.
    /// The list of available upgrades for compute pools.
    /// </summary>
    public partial class ManagedClusterUpgradeProfileData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ManagedClusterUpgradeProfileData"/>. </summary>
        /// <param name="controlPlaneProfile"> The list of available upgrade versions for the control plane. </param>
        /// <param name="agentPoolProfiles"> The list of available upgrade versions for agent pools. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="controlPlaneProfile"/> or <paramref name="agentPoolProfiles"/> is null. </exception>
        internal ManagedClusterUpgradeProfileData(ManagedClusterPoolUpgradeProfile controlPlaneProfile, IEnumerable<ManagedClusterPoolUpgradeProfile> agentPoolProfiles)
        {
            Argument.AssertNotNull(controlPlaneProfile, nameof(controlPlaneProfile));
            Argument.AssertNotNull(agentPoolProfiles, nameof(agentPoolProfiles));

            ControlPlaneProfile = controlPlaneProfile;
            AgentPoolProfiles = agentPoolProfiles.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterUpgradeProfileData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="controlPlaneProfile"> The list of available upgrade versions for the control plane. </param>
        /// <param name="agentPoolProfiles"> The list of available upgrade versions for agent pools. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterUpgradeProfileData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedClusterPoolUpgradeProfile controlPlaneProfile, IReadOnlyList<ManagedClusterPoolUpgradeProfile> agentPoolProfiles, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ControlPlaneProfile = controlPlaneProfile;
            AgentPoolProfiles = agentPoolProfiles;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterUpgradeProfileData"/> for deserialization. </summary>
        internal ManagedClusterUpgradeProfileData()
        {
        }

        /// <summary> The list of available upgrade versions for the control plane. </summary>
        [WirePath("properties.controlPlaneProfile")]
        public ManagedClusterPoolUpgradeProfile ControlPlaneProfile { get; }
        /// <summary> The list of available upgrade versions for agent pools. </summary>
        [WirePath("properties.agentPoolProfiles")]
        public IReadOnlyList<ManagedClusterPoolUpgradeProfile> AgentPoolProfiles { get; }
    }
}
