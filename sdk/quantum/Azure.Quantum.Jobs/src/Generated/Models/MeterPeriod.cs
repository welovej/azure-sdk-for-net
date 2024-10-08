// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> The time period in which the quota's underlying meter is accumulated. Based on calendar year. 'None' is used for concurrent quotas. </summary>
    public readonly partial struct MeterPeriod : IEquatable<MeterPeriod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MeterPeriod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MeterPeriod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string MonthlyValue = "Monthly";

        /// <summary> None. </summary>
        public static MeterPeriod None { get; } = new MeterPeriod(NoneValue);
        /// <summary> Monthly. </summary>
        public static MeterPeriod Monthly { get; } = new MeterPeriod(MonthlyValue);
        /// <summary> Determines if two <see cref="MeterPeriod"/> values are the same. </summary>
        public static bool operator ==(MeterPeriod left, MeterPeriod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MeterPeriod"/> values are not the same. </summary>
        public static bool operator !=(MeterPeriod left, MeterPeriod right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MeterPeriod"/>. </summary>
        public static implicit operator MeterPeriod(string value) => new MeterPeriod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MeterPeriod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MeterPeriod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
