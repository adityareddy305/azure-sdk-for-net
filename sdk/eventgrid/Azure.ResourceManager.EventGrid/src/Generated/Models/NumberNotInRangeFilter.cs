// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> NumberNotInRange Filter. </summary>
    public partial class NumberNotInRangeFilter : EventGridFilter
    {
        /// <summary> Initializes a new instance of <see cref="NumberNotInRangeFilter"/>. </summary>
        public NumberNotInRangeFilter()
        {
            Values = new ChangeTrackingList<IList<double>>();
            OperatorType = FilterOperatorType.NumberNotInRange;
        }

        /// <summary> Initializes a new instance of <see cref="NumberNotInRangeFilter"/>. </summary>
        /// <param name="operatorType"> The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others. </param>
        /// <param name="key"> The field/property in the event based on which you want to filter. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="values"> The set of filter values. </param>
        internal NumberNotInRangeFilter(FilterOperatorType operatorType, string key, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<IList<double>> values) : base(operatorType, key, serializedAdditionalRawData)
        {
            Values = values;
            OperatorType = operatorType;
        }

        /// <summary> The set of filter values. </summary>
        [WirePath("values")]
        public IList<IList<double>> Values { get; }
    }
}
