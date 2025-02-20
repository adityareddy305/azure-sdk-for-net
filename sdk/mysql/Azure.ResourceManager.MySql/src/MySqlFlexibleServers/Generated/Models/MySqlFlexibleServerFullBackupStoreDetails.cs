// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> FullBackupStoreDetails is used for scenarios where backup data is streamed/copied over to a storage destination. </summary>
    public partial class MySqlFlexibleServerFullBackupStoreDetails : MySqlFlexibleServerBackupStoreDetails
    {
        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerFullBackupStoreDetails"/>. </summary>
        /// <param name="sasUriList"> SASUriList of storage containers where backup data is to be streamed/copied. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sasUriList"/> is null. </exception>
        public MySqlFlexibleServerFullBackupStoreDetails(IEnumerable<string> sasUriList)
        {
            Argument.AssertNotNull(sasUriList, nameof(sasUriList));

            SasUriList = sasUriList.ToList();
            ObjectType = "FullBackupStoreDetails";
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerFullBackupStoreDetails"/>. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="sasUriList"> SASUriList of storage containers where backup data is to be streamed/copied. </param>
        internal MySqlFlexibleServerFullBackupStoreDetails(string objectType, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<string> sasUriList) : base(objectType, serializedAdditionalRawData)
        {
            SasUriList = sasUriList;
            ObjectType = objectType ?? "FullBackupStoreDetails";
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerFullBackupStoreDetails"/> for deserialization. </summary>
        internal MySqlFlexibleServerFullBackupStoreDetails()
        {
        }

        /// <summary> SASUriList of storage containers where backup data is to be streamed/copied. </summary>
        public IList<string> SasUriList { get; }
    }
}
