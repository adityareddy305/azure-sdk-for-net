// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Cosmos DB capability object.
/// </summary>
public partial class CosmosDBAccountCapability : ProvisionableConstruct
{
    /// <summary>
    /// Name of the Cosmos DB capability. For example, &quot;name&quot;:
    /// &quot;EnableCassandra&quot;. Current values also include
    /// &quot;EnableTable&quot; and &quot;EnableGremlin&quot;.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Creates a new CosmosDBAccountCapability.
    /// </summary>
    public CosmosDBAccountCapability()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of CosmosDBAccountCapability.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
    }
}
