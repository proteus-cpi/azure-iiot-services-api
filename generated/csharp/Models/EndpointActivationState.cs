// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.History.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EndpointActivationState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EndpointActivationState
    {
        [EnumMember(Value = "Deactivated")]
        Deactivated,
        [EnumMember(Value = "Activated")]
        Activated,
        [EnumMember(Value = "ActivatedAndConnected")]
        ActivatedAndConnected
    }
    internal static class EndpointActivationStateEnumExtension
    {
        internal static string ToSerializedValue(this EndpointActivationState? value)
        {
            return value == null ? null : ((EndpointActivationState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EndpointActivationState value)
        {
            switch( value )
            {
                case EndpointActivationState.Deactivated:
                    return "Deactivated";
                case EndpointActivationState.Activated:
                    return "Activated";
                case EndpointActivationState.ActivatedAndConnected:
                    return "ActivatedAndConnected";
            }
            return null;
        }

        internal static EndpointActivationState? ParseEndpointActivationState(this string value)
        {
            switch( value )
            {
                case "Deactivated":
                    return EndpointActivationState.Deactivated;
                case "Activated":
                    return EndpointActivationState.Activated;
                case "ActivatedAndConnected":
                    return EndpointActivationState.ActivatedAndConnected;
            }
            return null;
        }
    }
}
