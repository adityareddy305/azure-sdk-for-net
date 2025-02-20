// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Unknown version of RecoveryAvailabilitySetCustomDetails. </summary>
    internal partial class UnknownRecoveryAvailabilitySetCustomDetails : RecoveryAvailabilitySetCustomDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRecoveryAvailabilitySetCustomDetails"/>. </summary>
        /// <param name="resourceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRecoveryAvailabilitySetCustomDetails(string resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(resourceType, serializedAdditionalRawData)
        {
            ResourceType = resourceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownRecoveryAvailabilitySetCustomDetails"/> for deserialization. </summary>
        internal UnknownRecoveryAvailabilitySetCustomDetails()
        {
        }
    }
}
