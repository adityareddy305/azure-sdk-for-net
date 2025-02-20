// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The response payload for unmuting participants from the call. </summary>
    public partial class UnmuteParticipantResult
    {
        /// <summary> Initializes a new instance of <see cref="UnmuteParticipantResult"/>. </summary>
        internal UnmuteParticipantResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnmuteParticipantResult"/>. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        internal UnmuteParticipantResult(string operationContext)
        {
            OperationContext = operationContext;
        }

        /// <summary> The operation context provided by client. </summary>
        public string OperationContext { get; }
    }
}
