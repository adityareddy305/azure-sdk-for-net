// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class MediaProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(MediaUri))
            {
                writer.WritePropertyName("mediaUri"u8);
                writer.WriteObjectValue<object>(MediaUri);
            }
            if (Optional.IsDefined(VideoEncoderConfiguration))
            {
                writer.WritePropertyName("videoEncoderConfiguration"u8);
                writer.WriteObjectValue(VideoEncoderConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static MediaProfile DeserializeMediaProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            object mediaUri = default;
            VideoEncoderConfiguration videoEncoderConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mediaUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mediaUri = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("videoEncoderConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    videoEncoderConfiguration = VideoEncoderConfiguration.DeserializeVideoEncoderConfiguration(property.Value);
                    continue;
                }
            }
            return new MediaProfile(name, mediaUri, videoEncoderConfiguration);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MediaProfile FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMediaProfile(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
