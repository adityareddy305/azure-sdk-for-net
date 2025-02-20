// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary>
    /// Job canceled event data. Schema of the data property of an EventGridEvent for a
    /// Microsoft.Media.JobCanceled event.
    /// </summary>
    public partial class MediaJobCanceledEventData : MediaJobStateChangeEventData
    {
        /// <summary> Initializes a new instance of <see cref="MediaJobCanceledEventData"/>. </summary>
        /// <param name="previousState"> The previous state of the Job. </param>
        /// <param name="state"> The new state of the Job. </param>
        /// <param name="correlationData"> Gets the Job correlation data. </param>
        /// <param name="outputs">
        /// Gets the Job outputs.
        /// Please note <see cref="MediaJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MediaJobOutputAsset"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="correlationData"/> or <paramref name="outputs"/> is null. </exception>
        internal MediaJobCanceledEventData(MediaJobState previousState, MediaJobState state, IReadOnlyDictionary<string, string> correlationData, IEnumerable<MediaJobOutput> outputs) : base(previousState, state, correlationData)
        {
            Argument.AssertNotNull(correlationData, nameof(correlationData));
            Argument.AssertNotNull(outputs, nameof(outputs));

            Outputs = outputs.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobCanceledEventData"/>. </summary>
        /// <param name="previousState"> The previous state of the Job. </param>
        /// <param name="state"> The new state of the Job. </param>
        /// <param name="correlationData"> Gets the Job correlation data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="outputs">
        /// Gets the Job outputs.
        /// Please note <see cref="MediaJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MediaJobOutputAsset"/>.
        /// </param>
        internal MediaJobCanceledEventData(MediaJobState previousState, MediaJobState state, IReadOnlyDictionary<string, string> correlationData, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<MediaJobOutput> outputs) : base(previousState, state, correlationData, serializedAdditionalRawData)
        {
            Outputs = outputs;
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobCanceledEventData"/> for deserialization. </summary>
        internal MediaJobCanceledEventData()
        {
        }

        /// <summary>
        /// Gets the Job outputs.
        /// Please note <see cref="MediaJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MediaJobOutputAsset"/>.
        /// </summary>
        public IReadOnlyList<MediaJobOutput> Outputs { get; }
    }
}
