// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.GraphServices.Models
{
    /// <summary> Provisioning state. </summary>
    public readonly partial struct GraphServicesProvisioningState : IEquatable<GraphServicesProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GraphServicesProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GraphServicesProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static GraphServicesProvisioningState Succeeded { get; } = new GraphServicesProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static GraphServicesProvisioningState Failed { get; } = new GraphServicesProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static GraphServicesProvisioningState Canceled { get; } = new GraphServicesProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="GraphServicesProvisioningState"/> values are the same. </summary>
        public static bool operator ==(GraphServicesProvisioningState left, GraphServicesProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GraphServicesProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(GraphServicesProvisioningState left, GraphServicesProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="GraphServicesProvisioningState"/>. </summary>
        public static implicit operator GraphServicesProvisioningState(string value) => new GraphServicesProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GraphServicesProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GraphServicesProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
