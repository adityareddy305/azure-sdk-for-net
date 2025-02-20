// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> Conversion settings describe the origin of input files and destination of output files. </summary>
    public partial class AssetConversionOptions
    {
        /// <summary> Initializes a new instance of <see cref="AssetConversionOptions"/>. </summary>
        /// <param name="inputOptions"> Conversion input settings describe the origin of conversion input. </param>
        /// <param name="outputOptions"> Conversion output settings describe the destination of conversion output. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputOptions"/> or <paramref name="outputOptions"/> is null. </exception>
        public AssetConversionOptions(AssetConversionInputOptions inputOptions, AssetConversionOutputOptions outputOptions)
        {
            Argument.AssertNotNull(inputOptions, nameof(inputOptions));
            Argument.AssertNotNull(outputOptions, nameof(outputOptions));

            InputOptions = inputOptions;
            OutputOptions = outputOptions;
        }
    }
}
