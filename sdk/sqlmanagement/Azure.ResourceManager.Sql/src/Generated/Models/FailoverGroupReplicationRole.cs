// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Local replication role of the failover group instance. </summary>
    public readonly partial struct FailoverGroupReplicationRole : IEquatable<FailoverGroupReplicationRole>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FailoverGroupReplicationRole"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FailoverGroupReplicationRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryValue = "Primary";
        private const string SecondaryValue = "Secondary";

        /// <summary> Primary. </summary>
        public static FailoverGroupReplicationRole Primary { get; } = new FailoverGroupReplicationRole(PrimaryValue);
        /// <summary> Secondary. </summary>
        public static FailoverGroupReplicationRole Secondary { get; } = new FailoverGroupReplicationRole(SecondaryValue);
        /// <summary> Determines if two <see cref="FailoverGroupReplicationRole"/> values are the same. </summary>
        public static bool operator ==(FailoverGroupReplicationRole left, FailoverGroupReplicationRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FailoverGroupReplicationRole"/> values are not the same. </summary>
        public static bool operator !=(FailoverGroupReplicationRole left, FailoverGroupReplicationRole right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FailoverGroupReplicationRole"/>. </summary>
        public static implicit operator FailoverGroupReplicationRole(string value) => new FailoverGroupReplicationRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FailoverGroupReplicationRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FailoverGroupReplicationRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
