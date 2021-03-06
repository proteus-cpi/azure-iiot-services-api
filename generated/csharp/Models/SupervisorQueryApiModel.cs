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
    using System.Linq;

    /// <summary>
    /// Supervisor registration query
    /// </summary>
    public partial class SupervisorQueryApiModel
    {
        /// <summary>
        /// Initializes a new instance of the SupervisorQueryApiModel class.
        /// </summary>
        public SupervisorQueryApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SupervisorQueryApiModel class.
        /// </summary>
        /// <param name="siteId">Site of the supervisor</param>
        /// <param name="discovery">Discovery mode of supervisor. Possible
        /// values include: 'Off', 'Local', 'Network', 'Fast', 'Scan'</param>
        /// <param name="connected">Included connected or disconnected</param>
        public SupervisorQueryApiModel(string siteId = default(string), DiscoveryMode? discovery = default(DiscoveryMode?), bool? connected = default(bool?))
        {
            SiteId = siteId;
            Discovery = discovery;
            Connected = connected;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets site of the supervisor
        /// </summary>
        [JsonProperty(PropertyName = "siteId")]
        public string SiteId { get; set; }

        /// <summary>
        /// Gets or sets discovery mode of supervisor. Possible values include:
        /// 'Off', 'Local', 'Network', 'Fast', 'Scan'
        /// </summary>
        [JsonProperty(PropertyName = "discovery")]
        public DiscoveryMode? Discovery { get; set; }

        /// <summary>
        /// Gets or sets included connected or disconnected
        /// </summary>
        [JsonProperty(PropertyName = "connected")]
        public bool? Connected { get; set; }

    }
}
