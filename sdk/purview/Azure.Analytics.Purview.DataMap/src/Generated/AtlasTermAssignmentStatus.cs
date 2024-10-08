// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> Status for term assignment. </summary>
    public readonly partial struct AtlasTermAssignmentStatus : IEquatable<AtlasTermAssignmentStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AtlasTermAssignmentStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AtlasTermAssignmentStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DiscoveredValue = "DISCOVERED";
        private const string ProposedValue = "PROPOSED";
        private const string ImportedValue = "IMPORTED";
        private const string ValidatedValue = "VALIDATED";
        private const string DeprecatedValue = "DEPRECATED";
        private const string ObsoleteValue = "OBSOLETE";
        private const string OtherValue = "OTHER";

        /// <summary> The status is discovered. </summary>
        public static AtlasTermAssignmentStatus Discovered { get; } = new AtlasTermAssignmentStatus(DiscoveredValue);
        /// <summary> The status is proposed. </summary>
        public static AtlasTermAssignmentStatus Proposed { get; } = new AtlasTermAssignmentStatus(ProposedValue);
        /// <summary> The status is imported. </summary>
        public static AtlasTermAssignmentStatus Imported { get; } = new AtlasTermAssignmentStatus(ImportedValue);
        /// <summary> The status is validated. </summary>
        public static AtlasTermAssignmentStatus Validated { get; } = new AtlasTermAssignmentStatus(ValidatedValue);
        /// <summary> The status is deprecated. </summary>
        public static AtlasTermAssignmentStatus Deprecated { get; } = new AtlasTermAssignmentStatus(DeprecatedValue);
        /// <summary> The status is obsolete. </summary>
        public static AtlasTermAssignmentStatus Obsolete { get; } = new AtlasTermAssignmentStatus(ObsoleteValue);
        /// <summary> Other status. </summary>
        public static AtlasTermAssignmentStatus Other { get; } = new AtlasTermAssignmentStatus(OtherValue);
        /// <summary> Determines if two <see cref="AtlasTermAssignmentStatus"/> values are the same. </summary>
        public static bool operator ==(AtlasTermAssignmentStatus left, AtlasTermAssignmentStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AtlasTermAssignmentStatus"/> values are not the same. </summary>
        public static bool operator !=(AtlasTermAssignmentStatus left, AtlasTermAssignmentStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AtlasTermAssignmentStatus"/>. </summary>
        public static implicit operator AtlasTermAssignmentStatus(string value) => new AtlasTermAssignmentStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AtlasTermAssignmentStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AtlasTermAssignmentStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
