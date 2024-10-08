// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> An enum describing the unit of usage measurement. </summary>
    public readonly partial struct ContainerAppUsageUnit : IEquatable<ContainerAppUsageUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerAppUsageUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerAppUsageUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CountValue = "Count";

        /// <summary> Count. </summary>
        public static ContainerAppUsageUnit Count { get; } = new ContainerAppUsageUnit(CountValue);
        /// <summary> Determines if two <see cref="ContainerAppUsageUnit"/> values are the same. </summary>
        public static bool operator ==(ContainerAppUsageUnit left, ContainerAppUsageUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerAppUsageUnit"/> values are not the same. </summary>
        public static bool operator !=(ContainerAppUsageUnit left, ContainerAppUsageUnit right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerAppUsageUnit"/>. </summary>
        public static implicit operator ContainerAppUsageUnit(string value) => new ContainerAppUsageUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerAppUsageUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerAppUsageUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
