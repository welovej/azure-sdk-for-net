// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Health.Insights.CancerProfiling
{
    /// <summary> The type of the Onco Phenotype inference. </summary>
    public readonly partial struct OncoPhenotypeInferenceType : IEquatable<OncoPhenotypeInferenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OncoPhenotypeInferenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OncoPhenotypeInferenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TumorSiteValue = "tumorSite";
        private const string HistologyValue = "histology";
        private const string ClinicalStageTValue = "clinicalStageT";
        private const string ClinicalStageNValue = "clinicalStageN";
        private const string ClinicalStageMValue = "clinicalStageM";
        private const string PathologicStageTValue = "pathologicStageT";
        private const string PathologicStageNValue = "pathologicStageN";
        private const string PathologicStageMValue = "pathologicStageM";

        /// <summary> tumorSite. </summary>
        public static OncoPhenotypeInferenceType TumorSite { get; } = new OncoPhenotypeInferenceType(TumorSiteValue);
        /// <summary> histology. </summary>
        public static OncoPhenotypeInferenceType Histology { get; } = new OncoPhenotypeInferenceType(HistologyValue);
        /// <summary> clinicalStageT. </summary>
        public static OncoPhenotypeInferenceType ClinicalStageT { get; } = new OncoPhenotypeInferenceType(ClinicalStageTValue);
        /// <summary> clinicalStageN. </summary>
        public static OncoPhenotypeInferenceType ClinicalStageN { get; } = new OncoPhenotypeInferenceType(ClinicalStageNValue);
        /// <summary> clinicalStageM. </summary>
        public static OncoPhenotypeInferenceType ClinicalStageM { get; } = new OncoPhenotypeInferenceType(ClinicalStageMValue);
        /// <summary> pathologicStageT. </summary>
        public static OncoPhenotypeInferenceType PathologicStageT { get; } = new OncoPhenotypeInferenceType(PathologicStageTValue);
        /// <summary> pathologicStageN. </summary>
        public static OncoPhenotypeInferenceType PathologicStageN { get; } = new OncoPhenotypeInferenceType(PathologicStageNValue);
        /// <summary> pathologicStageM. </summary>
        public static OncoPhenotypeInferenceType PathologicStageM { get; } = new OncoPhenotypeInferenceType(PathologicStageMValue);
        /// <summary> Determines if two <see cref="OncoPhenotypeInferenceType"/> values are the same. </summary>
        public static bool operator ==(OncoPhenotypeInferenceType left, OncoPhenotypeInferenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OncoPhenotypeInferenceType"/> values are not the same. </summary>
        public static bool operator !=(OncoPhenotypeInferenceType left, OncoPhenotypeInferenceType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OncoPhenotypeInferenceType"/>. </summary>
        public static implicit operator OncoPhenotypeInferenceType(string value) => new OncoPhenotypeInferenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OncoPhenotypeInferenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OncoPhenotypeInferenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
