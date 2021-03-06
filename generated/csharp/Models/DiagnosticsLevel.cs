// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.Twin.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DiagnosticsLevel.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DiagnosticsLevel
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Status")]
        Status,
        [EnumMember(Value = "Operations")]
        Operations,
        [EnumMember(Value = "Diagnostics")]
        Diagnostics,
        [EnumMember(Value = "Verbose")]
        Verbose
    }
    internal static class DiagnosticsLevelEnumExtension
    {
        internal static string ToSerializedValue(this DiagnosticsLevel? value)
        {
            return value == null ? null : ((DiagnosticsLevel)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DiagnosticsLevel value)
        {
            switch( value )
            {
                case DiagnosticsLevel.None:
                    return "None";
                case DiagnosticsLevel.Status:
                    return "Status";
                case DiagnosticsLevel.Operations:
                    return "Operations";
                case DiagnosticsLevel.Diagnostics:
                    return "Diagnostics";
                case DiagnosticsLevel.Verbose:
                    return "Verbose";
            }
            return null;
        }

        internal static DiagnosticsLevel? ParseDiagnosticsLevel(this string value)
        {
            switch( value )
            {
                case "None":
                    return DiagnosticsLevel.None;
                case "Status":
                    return DiagnosticsLevel.Status;
                case "Operations":
                    return DiagnosticsLevel.Operations;
                case "Diagnostics":
                    return DiagnosticsLevel.Diagnostics;
                case "Verbose":
                    return DiagnosticsLevel.Verbose;
            }
            return null;
        }
    }
}
