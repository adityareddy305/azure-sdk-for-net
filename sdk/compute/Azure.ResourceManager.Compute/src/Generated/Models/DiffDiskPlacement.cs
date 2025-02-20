// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the ephemeral disk placement for operating system disk. This property can be used by user in the request to choose the location i.e, cache disk, resource disk or nvme disk space for Ephemeral OS disk provisioning. For more information on Ephemeral OS disk size requirements, please refer Ephemeral OS disk size requirements for Windows VM at https://docs.microsoft.com/azure/virtual-machines/windows/ephemeral-os-disks#size-requirements and Linux VM at https://docs.microsoft.com/azure/virtual-machines/linux/ephemeral-os-disks#size-requirements. Minimum api-version for NvmeDisk: 2024-03-01. </summary>
    public readonly partial struct DiffDiskPlacement : IEquatable<DiffDiskPlacement>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiffDiskPlacement"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiffDiskPlacement(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CacheDiskValue = "CacheDisk";
        private const string ResourceDiskValue = "ResourceDisk";
        private const string NvmeDiskValue = "NvmeDisk";

        /// <summary> CacheDisk. </summary>
        public static DiffDiskPlacement CacheDisk { get; } = new DiffDiskPlacement(CacheDiskValue);
        /// <summary> ResourceDisk. </summary>
        public static DiffDiskPlacement ResourceDisk { get; } = new DiffDiskPlacement(ResourceDiskValue);
        /// <summary> NvmeDisk. </summary>
        public static DiffDiskPlacement NvmeDisk { get; } = new DiffDiskPlacement(NvmeDiskValue);
        /// <summary> Determines if two <see cref="DiffDiskPlacement"/> values are the same. </summary>
        public static bool operator ==(DiffDiskPlacement left, DiffDiskPlacement right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiffDiskPlacement"/> values are not the same. </summary>
        public static bool operator !=(DiffDiskPlacement left, DiffDiskPlacement right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DiffDiskPlacement"/>. </summary>
        public static implicit operator DiffDiskPlacement(string value) => new DiffDiskPlacement(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiffDiskPlacement other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiffDiskPlacement other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
