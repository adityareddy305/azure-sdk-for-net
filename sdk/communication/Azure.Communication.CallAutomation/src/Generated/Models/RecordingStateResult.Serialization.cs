// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.CallAutomation
{
    public partial class RecordingStateResult
    {
        internal static RecordingStateResult DeserializeRecordingStateResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string recordingId = default;
            RecordingState? recordingState = default;
            RecordingKind? recordingKind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recordingId"u8))
                {
                    recordingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recordingState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordingState = new RecordingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recordingKind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordingKind = new RecordingKind(property.Value.GetString());
                    continue;
                }
            }
            return new RecordingStateResult(recordingId, recordingState, recordingKind);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RecordingStateResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRecordingStateResult(document.RootElement);
        }
    }
}
