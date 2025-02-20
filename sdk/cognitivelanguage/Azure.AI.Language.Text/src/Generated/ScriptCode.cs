// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Text
{
    /// <summary> Identifies the script of the input document. Maps to the ISO 15924 standard script code. </summary>
    public readonly partial struct ScriptCode : IEquatable<ScriptCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScriptCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScriptCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ArabValue = "Arab";
        private const string ArmnValue = "Armn";
        private const string BengValue = "Beng";
        private const string CansValue = "Cans";
        private const string CyrlValue = "Cyrl";
        private const string DevaValue = "Deva";
        private const string EthiValue = "Ethi";
        private const string GeorValue = "Geor";
        private const string GrekValue = "Grek";
        private const string GujrValue = "Gujr";
        private const string GuruValue = "Guru";
        private const string HangValue = "Hang";
        private const string HaniValue = "Hani";
        private const string HansValue = "Hans";
        private const string HantValue = "Hant";
        private const string HebrValue = "Hebr";
        private const string JpanValue = "Jpan";
        private const string KhmrValue = "Khmr";
        private const string KndaValue = "Knda";
        private const string LaooValue = "Laoo";
        private const string LatnValue = "Latn";
        private const string MlymValue = "Mlym";
        private const string MongValue = "Mong";
        private const string MteiValue = "Mtei";
        private const string MymrValue = "Mymr";
        private const string OlckValue = "Olck";
        private const string OryaValue = "Orya";
        private const string SinhValue = "Sinh";
        private const string ShrdValue = "Shrd";
        private const string TamlValue = "Taml";
        private const string TeluValue = "Telu";
        private const string ThaaValue = "Thaa";
        private const string ThaiValue = "Thai";
        private const string TibtValue = "Tibt";

        /// <summary> Script code for the Arabic script. </summary>
        public static ScriptCode Arab { get; } = new ScriptCode(ArabValue);
        /// <summary> Script code for the Armenian script. </summary>
        public static ScriptCode Armn { get; } = new ScriptCode(ArmnValue);
        /// <summary> Script code for the Bangla script. </summary>
        public static ScriptCode Beng { get; } = new ScriptCode(BengValue);
        /// <summary> Script code for the UnifiedCanadianAboriginalSyllabics script. </summary>
        public static ScriptCode Cans { get; } = new ScriptCode(CansValue);
        /// <summary> Script code for the Cyrillic script. </summary>
        public static ScriptCode Cyrl { get; } = new ScriptCode(CyrlValue);
        /// <summary> Script code for the Devanagari script. </summary>
        public static ScriptCode Deva { get; } = new ScriptCode(DevaValue);
        /// <summary> Script code for the Ethiopic script. </summary>
        public static ScriptCode Ethi { get; } = new ScriptCode(EthiValue);
        /// <summary> Script code for the Georgian script. </summary>
        public static ScriptCode Geor { get; } = new ScriptCode(GeorValue);
        /// <summary> Script code for the Greek script. </summary>
        public static ScriptCode Grek { get; } = new ScriptCode(GrekValue);
        /// <summary> Script code for the Gujarati script. </summary>
        public static ScriptCode Gujr { get; } = new ScriptCode(GujrValue);
        /// <summary> Script code for the Gurmukhi script. </summary>
        public static ScriptCode Guru { get; } = new ScriptCode(GuruValue);
        /// <summary> Script code for the Hangul script. </summary>
        public static ScriptCode Hang { get; } = new ScriptCode(HangValue);
        /// <summary> Script code for the HanLiteral script. </summary>
        public static ScriptCode Hani { get; } = new ScriptCode(HaniValue);
        /// <summary> Script code for the HanSimplified script. </summary>
        public static ScriptCode Hans { get; } = new ScriptCode(HansValue);
        /// <summary> Script code for the HanTraditional script. </summary>
        public static ScriptCode Hant { get; } = new ScriptCode(HantValue);
        /// <summary> Script code for the Hebrew script. </summary>
        public static ScriptCode Hebr { get; } = new ScriptCode(HebrValue);
        /// <summary> Script code for the Japanese script. </summary>
        public static ScriptCode Jpan { get; } = new ScriptCode(JpanValue);
        /// <summary> Script code for the Khmer script. </summary>
        public static ScriptCode Khmr { get; } = new ScriptCode(KhmrValue);
        /// <summary> Script code for the Kannada script. </summary>
        public static ScriptCode Knda { get; } = new ScriptCode(KndaValue);
        /// <summary> Script code for the Lao script. </summary>
        public static ScriptCode Laoo { get; } = new ScriptCode(LaooValue);
        /// <summary> Script code for the Latin script. </summary>
        public static ScriptCode Latn { get; } = new ScriptCode(LatnValue);
        /// <summary> Script code for the Malayalam script. </summary>
        public static ScriptCode Mlym { get; } = new ScriptCode(MlymValue);
        /// <summary> Script code for the Mongolian script. </summary>
        public static ScriptCode Mong { get; } = new ScriptCode(MongValue);
        /// <summary> Script code for the Meitei script. </summary>
        public static ScriptCode Mtei { get; } = new ScriptCode(MteiValue);
        /// <summary> Script code for the Myanmar script. </summary>
        public static ScriptCode Mymr { get; } = new ScriptCode(MymrValue);
        /// <summary> Script code for the Santali script. </summary>
        public static ScriptCode Olck { get; } = new ScriptCode(OlckValue);
        /// <summary> Script code for the Odia script. </summary>
        public static ScriptCode Orya { get; } = new ScriptCode(OryaValue);
        /// <summary> Script code for the Sinhala script. </summary>
        public static ScriptCode Sinh { get; } = new ScriptCode(SinhValue);
        /// <summary> Script code for the Sharada script. </summary>
        public static ScriptCode Shrd { get; } = new ScriptCode(ShrdValue);
        /// <summary> Script code for the Tamil script. </summary>
        public static ScriptCode Taml { get; } = new ScriptCode(TamlValue);
        /// <summary> Script code for the Telugu script. </summary>
        public static ScriptCode Telu { get; } = new ScriptCode(TeluValue);
        /// <summary> Script code for the Thaana script. </summary>
        public static ScriptCode Thaa { get; } = new ScriptCode(ThaaValue);
        /// <summary> Script code for the Thai script. </summary>
        public static ScriptCode Thai { get; } = new ScriptCode(ThaiValue);
        /// <summary> Script code for the Tibetan script. </summary>
        public static ScriptCode Tibt { get; } = new ScriptCode(TibtValue);
        /// <summary> Determines if two <see cref="ScriptCode"/> values are the same. </summary>
        public static bool operator ==(ScriptCode left, ScriptCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScriptCode"/> values are not the same. </summary>
        public static bool operator !=(ScriptCode left, ScriptCode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ScriptCode"/>. </summary>
        public static implicit operator ScriptCode(string value) => new ScriptCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScriptCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScriptCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
