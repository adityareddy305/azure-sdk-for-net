// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the OS disk image. </summary>
    public partial class SharedGalleryOSDiskImage : SharedGalleryDiskImage
    {
        /// <summary> Initializes a new instance of <see cref="SharedGalleryOSDiskImage"/>. </summary>
        internal SharedGalleryOSDiskImage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SharedGalleryOSDiskImage"/>. </summary>
        /// <param name="diskSizeGB"> This property indicates the size of the VHD to be created. </param>
        /// <param name="hostCaching"> The host caching of the disk. Valid values are 'None', 'ReadOnly', and 'ReadWrite'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedGalleryOSDiskImage(int? diskSizeGB, SharedGalleryHostCaching? hostCaching, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(diskSizeGB, hostCaching, serializedAdditionalRawData)
        {
        }
    }
}
