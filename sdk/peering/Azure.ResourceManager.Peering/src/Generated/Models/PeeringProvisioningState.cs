// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The provisioning state of the resource. </summary>
    public readonly partial struct PeeringProvisioningState : IEquatable<PeeringProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PeeringProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PeeringProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static PeeringProvisioningState Succeeded { get; } = new PeeringProvisioningState(SucceededValue);
        /// <summary> Updating. </summary>
        public static PeeringProvisioningState Updating { get; } = new PeeringProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static PeeringProvisioningState Deleting { get; } = new PeeringProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static PeeringProvisioningState Failed { get; } = new PeeringProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="PeeringProvisioningState"/> values are the same. </summary>
        public static bool operator ==(PeeringProvisioningState left, PeeringProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PeeringProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(PeeringProvisioningState left, PeeringProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PeeringProvisioningState"/>. </summary>
        public static implicit operator PeeringProvisioningState(string value) => new PeeringProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PeeringProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PeeringProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
