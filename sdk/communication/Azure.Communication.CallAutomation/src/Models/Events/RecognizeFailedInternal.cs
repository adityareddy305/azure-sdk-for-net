﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// The recognize completed event internal.
    /// </summary>
    [CodeGenModel("RecognizeFailed", Usage = new string[] { "output" }, Formats = new string[] { "json" })]
    internal partial class RecognizeFailedInternal : CallAutomationEventBase
    {
        /// <summary>
        /// Reason code.
        /// </summary>
        public MediaEventReasonCode ReasonCode { get; internal set; }
    }
}
