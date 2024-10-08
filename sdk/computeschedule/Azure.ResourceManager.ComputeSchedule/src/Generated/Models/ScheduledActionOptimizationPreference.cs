// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeSchedule.Models
{
    /// <summary> The preferences customers can select to optimize their requests to ScheduledActions. </summary>
    public readonly partial struct ScheduledActionOptimizationPreference : IEquatable<ScheduledActionOptimizationPreference>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScheduledActionOptimizationPreference"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScheduledActionOptimizationPreference(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CostValue = "Cost";
        private const string AvailabilityValue = "Availability";
        private const string CostAvailabilityBalancedValue = "CostAvailabilityBalanced";

        /// <summary> Optimize while considering cost savings. </summary>
        public static ScheduledActionOptimizationPreference Cost { get; } = new ScheduledActionOptimizationPreference(CostValue);
        /// <summary> Optimize while considering availability of resources. </summary>
        public static ScheduledActionOptimizationPreference Availability { get; } = new ScheduledActionOptimizationPreference(AvailabilityValue);
        /// <summary> Optimize while considering a balance of cost and availability. </summary>
        public static ScheduledActionOptimizationPreference CostAvailabilityBalanced { get; } = new ScheduledActionOptimizationPreference(CostAvailabilityBalancedValue);
        /// <summary> Determines if two <see cref="ScheduledActionOptimizationPreference"/> values are the same. </summary>
        public static bool operator ==(ScheduledActionOptimizationPreference left, ScheduledActionOptimizationPreference right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScheduledActionOptimizationPreference"/> values are not the same. </summary>
        public static bool operator !=(ScheduledActionOptimizationPreference left, ScheduledActionOptimizationPreference right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ScheduledActionOptimizationPreference"/>. </summary>
        public static implicit operator ScheduledActionOptimizationPreference(string value) => new ScheduledActionOptimizationPreference(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScheduledActionOptimizationPreference other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScheduledActionOptimizationPreference other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
