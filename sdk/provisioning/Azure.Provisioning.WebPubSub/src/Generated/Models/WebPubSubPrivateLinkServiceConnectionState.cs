// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.WebPubSub;

/// <summary>
/// Connection state of the private endpoint connection.
/// </summary>
public partial class WebPubSubPrivateLinkServiceConnectionState : ProvisionableConstruct
{
    /// <summary>
    /// Indicates whether the connection has been Approved/Rejected/Removed by
    /// the owner of the service.
    /// </summary>
    public BicepValue<WebPubSubPrivateLinkServiceConnectionStatus> Status 
    {
        get { Initialize(); return _status!; }
        set { Initialize(); _status!.Assign(value); }
    }
    private BicepValue<WebPubSubPrivateLinkServiceConnectionStatus>? _status;

    /// <summary>
    /// The reason for approval/rejection of the connection.
    /// </summary>
    public BicepValue<string> Description 
    {
        get { Initialize(); return _description!; }
        set { Initialize(); _description!.Assign(value); }
    }
    private BicepValue<string>? _description;

    /// <summary>
    /// A message indicating if changes on the service provider require any
    /// updates on the consumer.
    /// </summary>
    public BicepValue<string> ActionsRequired 
    {
        get { Initialize(); return _actionsRequired!; }
        set { Initialize(); _actionsRequired!.Assign(value); }
    }
    private BicepValue<string>? _actionsRequired;

    /// <summary>
    /// Creates a new WebPubSubPrivateLinkServiceConnectionState.
    /// </summary>
    public WebPubSubPrivateLinkServiceConnectionState()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// WebPubSubPrivateLinkServiceConnectionState.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _status = DefineProperty<WebPubSubPrivateLinkServiceConnectionStatus>("Status", ["status"]);
        _description = DefineProperty<string>("Description", ["description"]);
        _actionsRequired = DefineProperty<string>("ActionsRequired", ["actionsRequired"]);
    }
}
