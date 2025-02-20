// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Deleted repository. </summary>
    internal partial class DeleteRepositoryResult
    {
        /// <summary> Initializes a new instance of <see cref="DeleteRepositoryResult"/>. </summary>
        internal DeleteRepositoryResult()
        {
            DeletedManifests = new ChangeTrackingList<string>();
            DeletedTags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DeleteRepositoryResult"/>. </summary>
        /// <param name="deletedManifests"> SHA of the deleted image. </param>
        /// <param name="deletedTags"> Tag of the deleted image. </param>
        internal DeleteRepositoryResult(IReadOnlyList<string> deletedManifests, IReadOnlyList<string> deletedTags)
        {
            DeletedManifests = deletedManifests;
            DeletedTags = deletedTags;
        }

        /// <summary> SHA of the deleted image. </summary>
        public IReadOnlyList<string> DeletedManifests { get; }
        /// <summary> Tag of the deleted image. </summary>
        public IReadOnlyList<string> DeletedTags { get; }
    }
}
