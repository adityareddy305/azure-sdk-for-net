// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> DNSZone information for Microsoft.RecoveryServices. </summary>
    public partial class DnsZoneResult : DnsZone
    {
        /// <summary> Initializes a new instance of <see cref="DnsZoneResult"/>. </summary>
        public DnsZoneResult()
        {
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DnsZoneResult"/>. </summary>
        /// <param name="subResource"> Subresource type for vault AzureBackup, AzureBackup_secondary or AzureSiteRecovery. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="requiredZoneNames"> The private link resource Private link DNS zone names. </param>
        internal DnsZoneResult(VaultSubResourceType? subResource, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<string> requiredZoneNames) : base(subResource, serializedAdditionalRawData)
        {
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> The private link resource Private link DNS zone names. </summary>
        public IList<string> RequiredZoneNames { get; }
    }
}
