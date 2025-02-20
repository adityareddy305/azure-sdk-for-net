// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Properties for a binary hardening analysis summary. </summary>
    public partial class BinaryHardeningSummary : FirmwareAnalysisSummaryProperties
    {
        /// <summary> Initializes a new instance of <see cref="BinaryHardeningSummary"/>. </summary>
        internal BinaryHardeningSummary()
        {
            SummaryType = FirmwareAnalysisSummaryType.BinaryHardening;
        }

        /// <summary> Initializes a new instance of <see cref="BinaryHardeningSummary"/>. </summary>
        /// <param name="summaryType"> Describes the type of summary. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="totalFiles"> Total number of binaries that were analyzed. </param>
        /// <param name="nxPercentage"> NX summary percentage. </param>
        /// <param name="piePercentage"> PIE summary percentage. </param>
        /// <param name="relroPercentage"> RELRO summary percentage. </param>
        /// <param name="canaryPercentage"> Canary summary percentage. </param>
        /// <param name="strippedPercentage"> Stripped summary percentage. </param>
        internal BinaryHardeningSummary(FirmwareAnalysisSummaryType summaryType, IDictionary<string, BinaryData> serializedAdditionalRawData, long? totalFiles, int? nxPercentage, int? piePercentage, int? relroPercentage, int? canaryPercentage, int? strippedPercentage) : base(summaryType, serializedAdditionalRawData)
        {
            TotalFiles = totalFiles;
            NXPercentage = nxPercentage;
            PiePercentage = piePercentage;
            RelroPercentage = relroPercentage;
            CanaryPercentage = canaryPercentage;
            StrippedPercentage = strippedPercentage;
            SummaryType = summaryType;
        }

        /// <summary> Total number of binaries that were analyzed. </summary>
        public long? TotalFiles { get; }
        /// <summary> NX summary percentage. </summary>
        public int? NXPercentage { get; }
        /// <summary> PIE summary percentage. </summary>
        public int? PiePercentage { get; }
        /// <summary> RELRO summary percentage. </summary>
        public int? RelroPercentage { get; }
        /// <summary> Canary summary percentage. </summary>
        public int? CanaryPercentage { get; }
        /// <summary> Stripped summary percentage. </summary>
        public int? StrippedPercentage { get; }
    }
}
