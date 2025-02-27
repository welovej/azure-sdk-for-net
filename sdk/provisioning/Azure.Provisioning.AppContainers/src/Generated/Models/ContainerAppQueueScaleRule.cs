// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Container App container Azure Queue based scaling rule.
/// </summary>
public partial class ContainerAppQueueScaleRule : ProvisionableConstruct
{
    /// <summary>
    /// Queue name.
    /// </summary>
    public BicepValue<string> QueueName 
    {
        get { Initialize(); return _queueName!; }
        set { Initialize(); _queueName!.Assign(value); }
    }
    private BicepValue<string>? _queueName;

    /// <summary>
    /// Queue length.
    /// </summary>
    public BicepValue<int> QueueLength 
    {
        get { Initialize(); return _queueLength!; }
        set { Initialize(); _queueLength!.Assign(value); }
    }
    private BicepValue<int>? _queueLength;

    /// <summary>
    /// Authentication secrets for the queue scale rule.
    /// </summary>
    public BicepList<ContainerAppScaleRuleAuth> Auth 
    {
        get { Initialize(); return _auth!; }
        set { Initialize(); _auth!.Assign(value); }
    }
    private BicepList<ContainerAppScaleRuleAuth>? _auth;

    /// <summary>
    /// Creates a new ContainerAppQueueScaleRule.
    /// </summary>
    public ContainerAppQueueScaleRule()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerAppQueueScaleRule.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _queueName = DefineProperty<string>("QueueName", ["queueName"]);
        _queueLength = DefineProperty<int>("QueueLength", ["queueLength"]);
        _auth = DefineListProperty<ContainerAppScaleRuleAuth>("Auth", ["auth"]);
    }
}
