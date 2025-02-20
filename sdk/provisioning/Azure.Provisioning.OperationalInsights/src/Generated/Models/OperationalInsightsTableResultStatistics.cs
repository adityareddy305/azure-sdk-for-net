// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// Search job execution statistics.
/// </summary>
public partial class OperationalInsightsTableResultStatistics : ProvisionableConstruct
{
    /// <summary>
    /// Search job completion percentage.
    /// </summary>
    public BicepValue<float> Progress 
    {
        get { Initialize(); return _progress!; }
    }
    private BicepValue<float>? _progress;

    /// <summary>
    /// The number of rows that were returned by the search job.
    /// </summary>
    public BicepValue<int> IngestedRecords 
    {
        get { Initialize(); return _ingestedRecords!; }
    }
    private BicepValue<int>? _ingestedRecords;

    /// <summary>
    /// Search job: Amount of scanned data.
    /// </summary>
    public BicepValue<float> ScannedGB 
    {
        get { Initialize(); return _scannedGB!; }
    }
    private BicepValue<float>? _scannedGB;

    /// <summary>
    /// Creates a new OperationalInsightsTableResultStatistics.
    /// </summary>
    public OperationalInsightsTableResultStatistics()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// OperationalInsightsTableResultStatistics.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _progress = DefineProperty<float>("Progress", ["progress"], isOutput: true);
        _ingestedRecords = DefineProperty<int>("IngestedRecords", ["ingestedRecords"], isOutput: true);
        _scannedGB = DefineProperty<float>("ScannedGB", ["scannedGb"], isOutput: true);
    }
}
