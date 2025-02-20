// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// The configuration settings of the session cookie&apos;s expiration.
/// </summary>
public partial class ContainerAppCookieExpiration : ProvisionableConstruct
{
    /// <summary>
    /// The convention used when determining the session cookie&apos;s
    /// expiration.
    /// </summary>
    public BicepValue<ContainerAppCookieExpirationConvention> Convention 
    {
        get { Initialize(); return _convention!; }
        set { Initialize(); _convention!.Assign(value); }
    }
    private BicepValue<ContainerAppCookieExpirationConvention>? _convention;

    /// <summary>
    /// The time after the request is made when the session cookie should
    /// expire.
    /// </summary>
    public BicepValue<string> TimeToExpiration 
    {
        get { Initialize(); return _timeToExpiration!; }
        set { Initialize(); _timeToExpiration!.Assign(value); }
    }
    private BicepValue<string>? _timeToExpiration;

    /// <summary>
    /// Creates a new ContainerAppCookieExpiration.
    /// </summary>
    public ContainerAppCookieExpiration()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerAppCookieExpiration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _convention = DefineProperty<ContainerAppCookieExpirationConvention>("Convention", ["convention"]);
        _timeToExpiration = DefineProperty<string>("TimeToExpiration", ["timeToExpiration"]);
    }
}
