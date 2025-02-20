// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Maps.Search.Models
{
    /// <summary> Unknown version of GeoJsonObject. </summary>
    internal partial class UnknownGeoJsonObject : GeoJsonObject
    {
        /// <summary> Initializes a new instance of <see cref="UnknownGeoJsonObject"/>. </summary>
        /// <param name="type"> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </param>
        /// <param name="boundingBox"> Bounding box. Projection used - EPSG:3857. Please refer to [RFC 7946](https://datatracker.ietf.org/doc/html/rfc7946#section-5) for details. </param>
        internal UnknownGeoJsonObject(GeoJsonObjectType type, IReadOnlyList<double> boundingBox) : base(type, boundingBox)
        {
            Type = type;
        }
    }
}
