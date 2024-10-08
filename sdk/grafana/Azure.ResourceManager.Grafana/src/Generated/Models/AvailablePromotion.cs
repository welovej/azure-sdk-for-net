// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> The AvailablePromotion. </summary>
    public readonly partial struct AvailablePromotion : IEquatable<AvailablePromotion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AvailablePromotion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AvailablePromotion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string FreeTrialValue = "FreeTrial";

        /// <summary> None. </summary>
        public static AvailablePromotion None { get; } = new AvailablePromotion(NoneValue);
        /// <summary> FreeTrial. </summary>
        public static AvailablePromotion FreeTrial { get; } = new AvailablePromotion(FreeTrialValue);
        /// <summary> Determines if two <see cref="AvailablePromotion"/> values are the same. </summary>
        public static bool operator ==(AvailablePromotion left, AvailablePromotion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AvailablePromotion"/> values are not the same. </summary>
        public static bool operator !=(AvailablePromotion left, AvailablePromotion right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AvailablePromotion"/>. </summary>
        public static implicit operator AvailablePromotion(string value) => new AvailablePromotion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AvailablePromotion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AvailablePromotion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
