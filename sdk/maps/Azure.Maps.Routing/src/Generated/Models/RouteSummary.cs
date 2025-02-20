// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Maps.Routing.Models
{
    /// <summary> Summary object. </summary>
    public partial class RouteSummary
    {
        /// <summary> Initializes a new instance of <see cref="RouteSummary"/>. </summary>
        internal RouteSummary()
        {
        }

        /// <summary> Length In Meters property. </summary>
        public int? LengthInMeters { get; }
        /// <summary> The estimated departure time for the route or leg. Time is in UTC. </summary>
        public DateTimeOffset? DepartureTime { get; }
        /// <summary> The estimated arrival time for the route or leg. Time is in UTC. </summary>
        public DateTimeOffset? ArrivalTime { get; }
    }
}
