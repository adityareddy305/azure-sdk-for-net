// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary>
    /// Component results
    /// Based on [FHIR Observation.component](https://www.hl7.org/fhir/R4/observation.html)
    /// </summary>
    public partial class FhirR4ObservationComponent : FhirR4Element
    {
        /// <summary> Initializes a new instance of <see cref="FhirR4ObservationComponent"/>. </summary>
        /// <param name="code"> Type of component observation (code / type). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> is null. </exception>
        internal FhirR4ObservationComponent(FhirR4CodeableConcept code)
        {
            Argument.AssertNotNull(code, nameof(code));

            Code = code;
            Interpretation = new ChangeTrackingList<FhirR4CodeableConcept>();
            ReferenceRange = new ChangeTrackingList<FhirR4ObservationReferenceRange>();
        }

        /// <summary> Initializes a new instance of <see cref="FhirR4ObservationComponent"/>. </summary>
        /// <param name="id"> Unique id for inter-element referencing. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="code"> Type of component observation (code / type). </param>
        /// <param name="valueQuantity"> Value as Quantity. </param>
        /// <param name="valueCodeableConcept"> Value as CodeableConcept. </param>
        /// <param name="valueString"> Value as string. </param>
        /// <param name="valueBoolean"> Value as boolean. </param>
        /// <param name="valueInteger"> Value as integer. </param>
        /// <param name="valueRange"> Value as Range. </param>
        /// <param name="valueRatio"> Value as Ratio. </param>
        /// <param name="valueSampledData"> Value as SampledData. </param>
        /// <param name="valueTime"> Value as time (hh:mm:ss). </param>
        /// <param name="valueDateTime"> Value as dateTime. </param>
        /// <param name="valuePeriod"> Value as Period. </param>
        /// <param name="valueReference"> Value as reference. </param>
        /// <param name="dataAbsentReason"> Why the component result is missing. </param>
        /// <param name="interpretation"> High, low, normal, etc. </param>
        /// <param name="referenceRange"> Provides guide for interpretation of component result. </param>
        internal FhirR4ObservationComponent(string id, IList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData, FhirR4CodeableConcept code, FhirR4Quantity valueQuantity, FhirR4CodeableConcept valueCodeableConcept, string valueString, bool? valueBoolean, int? valueInteger, FhirR4Range valueRange, FhirR4Ratio valueRatio, FhirR4SampledData valueSampledData, TimeSpan? valueTime, string valueDateTime, FhirR4Period valuePeriod, FhirR4Reference valueReference, FhirR4CodeableConcept dataAbsentReason, IReadOnlyList<FhirR4CodeableConcept> interpretation, IReadOnlyList<FhirR4ObservationReferenceRange> referenceRange) : base(id, extension, serializedAdditionalRawData)
        {
            Code = code;
            ValueQuantity = valueQuantity;
            ValueCodeableConcept = valueCodeableConcept;
            ValueString = valueString;
            ValueBoolean = valueBoolean;
            ValueInteger = valueInteger;
            ValueRange = valueRange;
            ValueRatio = valueRatio;
            ValueSampledData = valueSampledData;
            ValueTime = valueTime;
            ValueDateTime = valueDateTime;
            ValuePeriod = valuePeriod;
            ValueReference = valueReference;
            DataAbsentReason = dataAbsentReason;
            Interpretation = interpretation;
            ReferenceRange = referenceRange;
        }

        /// <summary> Initializes a new instance of <see cref="FhirR4ObservationComponent"/> for deserialization. </summary>
        internal FhirR4ObservationComponent()
        {
        }

        /// <summary> Type of component observation (code / type). </summary>
        public FhirR4CodeableConcept Code { get; }
        /// <summary> Value as Quantity. </summary>
        public FhirR4Quantity ValueQuantity { get; }
        /// <summary> Value as CodeableConcept. </summary>
        public FhirR4CodeableConcept ValueCodeableConcept { get; }
        /// <summary> Value as string. </summary>
        public string ValueString { get; }
        /// <summary> Value as boolean. </summary>
        public bool? ValueBoolean { get; }
        /// <summary> Value as integer. </summary>
        public int? ValueInteger { get; }
        /// <summary> Value as Range. </summary>
        public FhirR4Range ValueRange { get; }
        /// <summary> Value as Ratio. </summary>
        public FhirR4Ratio ValueRatio { get; }
        /// <summary> Value as SampledData. </summary>
        public FhirR4SampledData ValueSampledData { get; }
        /// <summary> Value as time (hh:mm:ss). </summary>
        public TimeSpan? ValueTime { get; }
        /// <summary> Value as dateTime. </summary>
        public string ValueDateTime { get; }
        /// <summary> Value as Period. </summary>
        public FhirR4Period ValuePeriod { get; }
        /// <summary> Value as reference. </summary>
        public FhirR4Reference ValueReference { get; }
        /// <summary> Why the component result is missing. </summary>
        public FhirR4CodeableConcept DataAbsentReason { get; }
        /// <summary> High, low, normal, etc. </summary>
        public IReadOnlyList<FhirR4CodeableConcept> Interpretation { get; }
        /// <summary> Provides guide for interpretation of component result. </summary>
        public IReadOnlyList<FhirR4ObservationReferenceRange> ReferenceRange { get; }
    }
}
