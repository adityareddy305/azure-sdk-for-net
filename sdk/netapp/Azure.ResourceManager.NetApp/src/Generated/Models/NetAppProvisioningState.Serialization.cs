// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NetApp.Models
{
    internal static partial class NetAppProvisioningStateExtensions
    {
        public static string ToSerialString(this NetAppProvisioningState value) => value switch
        {
            NetAppProvisioningState.Accepted => "Accepted",
            NetAppProvisioningState.Creating => "Creating",
            NetAppProvisioningState.Patching => "Patching",
            NetAppProvisioningState.Deleting => "Deleting",
            NetAppProvisioningState.Moving => "Moving",
            NetAppProvisioningState.Failed => "Failed",
            NetAppProvisioningState.Succeeded => "Succeeded",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown NetAppProvisioningState value.")
        };

        public static NetAppProvisioningState ToNetAppProvisioningState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Accepted")) return NetAppProvisioningState.Accepted;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Creating")) return NetAppProvisioningState.Creating;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Patching")) return NetAppProvisioningState.Patching;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Deleting")) return NetAppProvisioningState.Deleting;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Moving")) return NetAppProvisioningState.Moving;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Failed")) return NetAppProvisioningState.Failed;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Succeeded")) return NetAppProvisioningState.Succeeded;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown NetAppProvisioningState value.");
        }
    }
}
