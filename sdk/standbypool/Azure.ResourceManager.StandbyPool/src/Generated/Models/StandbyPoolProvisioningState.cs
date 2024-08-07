// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StandbyPool.Models
{
    /// <summary> Provisioning state. </summary>
    public readonly partial struct StandbyPoolProvisioningState : IEquatable<StandbyPoolProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StandbyPoolProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StandbyPoolProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string DeletingValue = "Deleting";

        /// <summary> Resource has been created. </summary>
        public static StandbyPoolProvisioningState Succeeded { get; } = new StandbyPoolProvisioningState(SucceededValue);
        /// <summary> Resource creation failed. </summary>
        public static StandbyPoolProvisioningState Failed { get; } = new StandbyPoolProvisioningState(FailedValue);
        /// <summary> Resource creation was canceled. </summary>
        public static StandbyPoolProvisioningState Canceled { get; } = new StandbyPoolProvisioningState(CanceledValue);
        /// <summary> Resource is being deleted. </summary>
        public static StandbyPoolProvisioningState Deleting { get; } = new StandbyPoolProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="StandbyPoolProvisioningState"/> values are the same. </summary>
        public static bool operator ==(StandbyPoolProvisioningState left, StandbyPoolProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StandbyPoolProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(StandbyPoolProvisioningState left, StandbyPoolProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StandbyPoolProvisioningState"/>. </summary>
        public static implicit operator StandbyPoolProvisioningState(string value) => new StandbyPoolProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StandbyPoolProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StandbyPoolProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
