// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Resource Type of Application. </summary>
    public readonly partial struct RemoteApplicationType : IEquatable<RemoteApplicationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RemoteApplicationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RemoteApplicationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InBuiltValue = "InBuilt";
        private const string MsixApplicationValue = "MsixApplication";

        /// <summary> InBuilt. </summary>
        public static RemoteApplicationType InBuilt { get; } = new RemoteApplicationType(InBuiltValue);
        /// <summary> MsixApplication. </summary>
        public static RemoteApplicationType MsixApplication { get; } = new RemoteApplicationType(MsixApplicationValue);
        /// <summary> Determines if two <see cref="RemoteApplicationType"/> values are the same. </summary>
        public static bool operator ==(RemoteApplicationType left, RemoteApplicationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RemoteApplicationType"/> values are not the same. </summary>
        public static bool operator !=(RemoteApplicationType left, RemoteApplicationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RemoteApplicationType"/>. </summary>
        public static implicit operator RemoteApplicationType(string value) => new RemoteApplicationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RemoteApplicationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RemoteApplicationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
