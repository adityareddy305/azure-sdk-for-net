// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningTargetUtilizationScaleSettings. </summary>
    public partial class MachineLearningTargetUtilizationScaleSettings : MachineLearningOnlineScaleSettings
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningTargetUtilizationScaleSettings"/>. </summary>
        public MachineLearningTargetUtilizationScaleSettings()
        {
            ScaleType = ScaleType.TargetUtilization;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningTargetUtilizationScaleSettings"/>. </summary>
        /// <param name="scaleType"> [Required] Type of deployment scaling algorithm. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="pollingInterval"> The polling interval in ISO 8691 format. Only supports duration with precision as low as Seconds. </param>
        /// <param name="targetUtilizationPercentage"> Target CPU usage for the autoscaler. </param>
        /// <param name="minInstances"> The minimum number of instances to always be present. </param>
        /// <param name="maxInstances"> The maximum number of instances that the deployment can scale to. The quota will be reserved for max_instances. </param>
        internal MachineLearningTargetUtilizationScaleSettings(ScaleType scaleType, IDictionary<string, BinaryData> serializedAdditionalRawData, TimeSpan? pollingInterval, int? targetUtilizationPercentage, int? minInstances, int? maxInstances) : base(scaleType, serializedAdditionalRawData)
        {
            PollingInterval = pollingInterval;
            TargetUtilizationPercentage = targetUtilizationPercentage;
            MinInstances = minInstances;
            MaxInstances = maxInstances;
            ScaleType = scaleType;
        }

        /// <summary> The polling interval in ISO 8691 format. Only supports duration with precision as low as Seconds. </summary>
        [WirePath("pollingInterval")]
        public TimeSpan? PollingInterval { get; set; }
        /// <summary> Target CPU usage for the autoscaler. </summary>
        [WirePath("targetUtilizationPercentage")]
        public int? TargetUtilizationPercentage { get; set; }
        /// <summary> The minimum number of instances to always be present. </summary>
        [WirePath("minInstances")]
        public int? MinInstances { get; set; }
        /// <summary> The maximum number of instances that the deployment can scale to. The quota will be reserved for max_instances. </summary>
        [WirePath("maxInstances")]
        public int? MaxInstances { get; set; }
    }
}
