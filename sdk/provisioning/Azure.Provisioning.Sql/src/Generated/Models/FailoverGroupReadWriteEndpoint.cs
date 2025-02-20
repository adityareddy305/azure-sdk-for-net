// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// Read-write endpoint of the failover group instance.
/// </summary>
public partial class FailoverGroupReadWriteEndpoint : ProvisionableConstruct
{
    /// <summary>
    /// Failover policy of the read-write endpoint for the failover group. If
    /// failoverPolicy is Automatic then
    /// failoverWithDataLossGracePeriodMinutes is required.
    /// </summary>
    public BicepValue<ReadWriteEndpointFailoverPolicy> FailoverPolicy 
    {
        get { Initialize(); return _failoverPolicy!; }
        set { Initialize(); _failoverPolicy!.Assign(value); }
    }
    private BicepValue<ReadWriteEndpointFailoverPolicy>? _failoverPolicy;

    /// <summary>
    /// Grace period before failover with data loss is attempted for the
    /// read-write endpoint. If failoverPolicy is Automatic then
    /// failoverWithDataLossGracePeriodMinutes is required.
    /// </summary>
    public BicepValue<int> FailoverWithDataLossGracePeriodMinutes 
    {
        get { Initialize(); return _failoverWithDataLossGracePeriodMinutes!; }
        set { Initialize(); _failoverWithDataLossGracePeriodMinutes!.Assign(value); }
    }
    private BicepValue<int>? _failoverWithDataLossGracePeriodMinutes;

    /// <summary>
    /// Creates a new FailoverGroupReadWriteEndpoint.
    /// </summary>
    public FailoverGroupReadWriteEndpoint()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// FailoverGroupReadWriteEndpoint.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _failoverPolicy = DefineProperty<ReadWriteEndpointFailoverPolicy>("FailoverPolicy", ["failoverPolicy"]);
        _failoverWithDataLossGracePeriodMinutes = DefineProperty<int>("FailoverWithDataLossGracePeriodMinutes", ["failoverWithDataLossGracePeriodMinutes"]);
    }
}
