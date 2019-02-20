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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Value write request model
    /// </summary>
    public partial class ValueWriteRequestApiModel
    {
        /// <summary>
        /// Initializes a new instance of the ValueWriteRequestApiModel class.
        /// </summary>
        public ValueWriteRequestApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValueWriteRequestApiModel class.
        /// </summary>
        /// <param name="nodeId">Node id to to write value to.
        /// (Mandatory)</param>
        /// <param name="value">Value to write. The system tries to convert
        /// the value according to the data type value,
        /// e.g. convert comma seperated value strings
        /// into arrays.  (Mandatory)</param>
        /// <param name="dataType">A built in datatype for the value. This can
        /// be a data type from browse, or a built in
        /// type.
        /// (default: best effort)</param>
        /// <param name="indexRange">Index range to write</param>
        /// <param name="elevation">Optional User elevation</param>
        /// <param name="diagnostics">Optional diagnostics
        /// configuration</param>
        public ValueWriteRequestApiModel(string nodeId, object value, string dataType = default(string), string indexRange = default(string), CredentialApiModel elevation = default(CredentialApiModel), DiagnosticsApiModel diagnostics = default(DiagnosticsApiModel))
        {
            NodeId = nodeId;
            Value = value;
            DataType = dataType;
            IndexRange = indexRange;
            Elevation = elevation;
            Diagnostics = diagnostics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets node id to to write value to. (Mandatory)
        /// </summary>
        [JsonProperty(PropertyName = "nodeId")]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets value to write. The system tries to convert
        /// the value according to the data type value,
        /// e.g. convert comma seperated value strings
        /// into arrays.  (Mandatory)
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets a built in datatype for the value. This can
        /// be a data type from browse, or a built in
        /// type.
        /// (default: best effort)
        /// </summary>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets index range to write
        /// </summary>
        [JsonProperty(PropertyName = "indexRange")]
        public string IndexRange { get; set; }

        /// <summary>
        /// Gets or sets optional User elevation
        /// </summary>
        [JsonProperty(PropertyName = "elevation")]
        public CredentialApiModel Elevation { get; set; }

        /// <summary>
        /// Gets or sets optional diagnostics configuration
        /// </summary>
        [JsonProperty(PropertyName = "diagnostics")]
        public DiagnosticsApiModel Diagnostics { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NodeId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NodeId");
            }
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}