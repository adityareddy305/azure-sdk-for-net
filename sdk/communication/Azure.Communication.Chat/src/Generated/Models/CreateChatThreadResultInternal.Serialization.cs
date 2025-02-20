// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Communication.Chat
{
    internal partial class CreateChatThreadResultInternal
    {
        internal static CreateChatThreadResultInternal DeserializeCreateChatThreadResultInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ChatThreadPropertiesInternal chatThread = default;
            IReadOnlyList<ChatError> invalidParticipants = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("chatThread"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    chatThread = ChatThreadPropertiesInternal.DeserializeChatThreadPropertiesInternal(property.Value);
                    continue;
                }
                if (property.NameEquals("invalidParticipants"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChatError> array = new List<ChatError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatError.DeserializeChatError(item));
                    }
                    invalidParticipants = array;
                    continue;
                }
            }
            return new CreateChatThreadResultInternal(chatThread, invalidParticipants ?? new ChangeTrackingList<ChatError>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CreateChatThreadResultInternal FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateChatThreadResultInternal(document.RootElement);
        }
    }
}
