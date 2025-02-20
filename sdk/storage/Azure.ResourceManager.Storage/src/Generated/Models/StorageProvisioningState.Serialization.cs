// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    internal static partial class StorageProvisioningStateExtensions
    {
        public static string ToSerialString(this StorageProvisioningState value) => value switch
        {
            StorageProvisioningState.Creating => "Creating",
            StorageProvisioningState.ResolvingDns => "ResolvingDNS",
            StorageProvisioningState.Succeeded => "Succeeded",
            StorageProvisioningState.ValidateSubscriptionQuotaBegin => "ValidateSubscriptionQuotaBegin",
            StorageProvisioningState.ValidateSubscriptionQuotaEnd => "ValidateSubscriptionQuotaEnd",
            StorageProvisioningState.Deleting => "Deleting",
            StorageProvisioningState.Canceled => "Canceled",
            StorageProvisioningState.Failed => "Failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StorageProvisioningState value.")
        };

        public static StorageProvisioningState ToStorageProvisioningState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Creating")) return StorageProvisioningState.Creating;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ResolvingDNS")) return StorageProvisioningState.ResolvingDns;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Succeeded")) return StorageProvisioningState.Succeeded;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ValidateSubscriptionQuotaBegin")) return StorageProvisioningState.ValidateSubscriptionQuotaBegin;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ValidateSubscriptionQuotaEnd")) return StorageProvisioningState.ValidateSubscriptionQuotaEnd;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Deleting")) return StorageProvisioningState.Deleting;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Canceled")) return StorageProvisioningState.Canceled;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Failed")) return StorageProvisioningState.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StorageProvisioningState value.");
        }
    }
}
