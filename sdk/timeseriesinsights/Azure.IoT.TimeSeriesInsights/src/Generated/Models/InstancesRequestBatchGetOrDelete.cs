// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Request to get or delete instances by time series IDs or time series names. Exactly one of "timeSeriesIds" or "names" must be set. </summary>
    internal partial class InstancesRequestBatchGetOrDelete
    {
        /// <summary> Initializes a new instance of <see cref="InstancesRequestBatchGetOrDelete"/>. </summary>
        /// <param name="timeSeriesIdsInternal"> List of time series IDs of the time series instances to return or delete. </param>
        /// <param name="names"> List of names of the time series instances to return or delete. </param>
        internal InstancesRequestBatchGetOrDelete(IList<IList<object>> timeSeriesIdsInternal, IList<string> names)
        {
            TimeSeriesIdsInternal = timeSeriesIdsInternal;
            Names = names;
        }
        /// <summary> List of names of the time series instances to return or delete. </summary>
        public IList<string> Names { get; }
    }
}
