// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Maps.Common;
using Azure.Maps.Routing.Models;

namespace Azure.Maps.Routing
{
    public partial class RouteDirectionParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Common.Optional.IsDefined(_GeoJsonSupportingPoints))
            {
                writer.WritePropertyName("supportingPoints"u8);
                writer.WriteObjectValue<GeoJsonGeometryCollection>(_GeoJsonSupportingPoints);
            }
            if (Common.Optional.IsCollectionDefined(AvoidVignette))
            {
                writer.WritePropertyName("avoidVignette"u8);
                writer.WriteStartArray();
                foreach (var item in AvoidVignette)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Common.Optional.IsCollectionDefined(AllowVignette))
            {
                writer.WritePropertyName("allowVignette"u8);
                writer.WriteStartArray();
                foreach (var item in AllowVignette)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Common.Optional.IsDefined(_GeoJsonAvoidAreas))
            {
                writer.WritePropertyName("avoidAreas"u8);
                writer.WriteObjectValue<GeoJsonMultiPolygon>(_GeoJsonAvoidAreas);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Common.Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
