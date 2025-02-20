// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> An Access policy. </summary>
    public partial class BlobAccessPolicy
    {
        /// <summary> Initializes a new instance of <see cref="BlobAccessPolicy"/>. </summary>
        public BlobAccessPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BlobAccessPolicy"/>. </summary>
        /// <param name="policyStartsOn"> the date-time the policy is active. </param>
        /// <param name="policyExpiresOn"> the date-time the policy expires. </param>
        /// <param name="permissions"> the permissions for the acl policy. </param>
        internal BlobAccessPolicy(DateTimeOffset? policyStartsOn, DateTimeOffset? policyExpiresOn, string permissions)
        {
            PolicyStartsOn = policyStartsOn;
            PolicyExpiresOn = policyExpiresOn;
            Permissions = permissions;
        }
    }
}
