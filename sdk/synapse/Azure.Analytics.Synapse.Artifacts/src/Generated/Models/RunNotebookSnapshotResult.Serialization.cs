// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RunNotebookSnapshotResultConverter))]
    public partial class RunNotebookSnapshotResult
    {
        internal static RunNotebookSnapshotResult DeserializeRunNotebookSnapshotResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RunNotebookSnapshot snapshot = default;
            RunNotebookError error = default;
            string runId = default;
            string runStatus = default;
            string lastCheckedOn = default;
            string sessionId = default;
            string sparkPool = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("snapshot"u8))
                {
                    snapshot = RunNotebookSnapshot.DeserializeRunNotebookSnapshot(property.Value);
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = RunNotebookError.DeserializeRunNotebookError(property.Value);
                    continue;
                }
                if (property.NameEquals("runId"u8))
                {
                    runId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runStatus"u8))
                {
                    runStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastCheckedOn"u8))
                {
                    lastCheckedOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sparkPool"u8))
                {
                    sparkPool = property.Value.GetString();
                    continue;
                }
            }
            return new RunNotebookSnapshotResult(
                snapshot,
                error,
                runId,
                runStatus,
                lastCheckedOn,
                sessionId,
                sparkPool);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RunNotebookSnapshotResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRunNotebookSnapshotResult(document.RootElement);
        }

        internal partial class RunNotebookSnapshotResultConverter : JsonConverter<RunNotebookSnapshotResult>
        {
            public override void Write(Utf8JsonWriter writer, RunNotebookSnapshotResult model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override RunNotebookSnapshotResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRunNotebookSnapshotResult(document.RootElement);
            }
        }
    }
}
