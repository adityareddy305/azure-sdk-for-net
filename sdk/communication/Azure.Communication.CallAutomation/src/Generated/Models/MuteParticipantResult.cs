// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The result payload for muting participants from the call. </summary>
    public partial class MuteParticipantResult
    {
        /// <summary> Initializes a new instance of <see cref="MuteParticipantResult"/>. </summary>
        internal MuteParticipantResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MuteParticipantResult"/>. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        internal MuteParticipantResult(string operationContext)
        {
            OperationContext = operationContext;
        }

        /// <summary> The operation context provided by client. </summary>
        public string OperationContext { get; }
    }
}
