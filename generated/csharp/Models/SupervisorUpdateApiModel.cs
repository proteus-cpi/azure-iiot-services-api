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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Supervisor registration update request
    /// </summary>
    public partial class SupervisorUpdateApiModel
    {
        /// <summary>
        /// Initializes a new instance of the SupervisorUpdateApiModel class.
        /// </summary>
        public SupervisorUpdateApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SupervisorUpdateApiModel class.
        /// </summary>
        /// <param name="siteId">Site of the supervisor</param>
        /// <param name="discovery">Whether the supervisor is in discovery
        /// mode.
        /// If null, does not change. Possible values include: 'Off', 'Local',
        /// 'Network', 'Fast', 'Scan'</param>
        /// <param name="discoveryConfig">Supervisor discovery
        /// configuration</param>
        /// <param name="discoveryCallbacks">Callbacks to add or remove (see
        /// below)</param>
        /// <param name="removeDiscoveryCallbacks">Whether to add or remove
        /// callbacks</param>
        /// <param name="logLevel">Current log level. Possible values include:
        /// 'Error', 'Information', 'Debug', 'Verbose'</param>
        public SupervisorUpdateApiModel(string siteId = default(string), DiscoveryMode? discovery = default(DiscoveryMode?), DiscoveryConfigApiModel discoveryConfig = default(DiscoveryConfigApiModel), IList<CallbackApiModel> discoveryCallbacks = default(IList<CallbackApiModel>), bool? removeDiscoveryCallbacks = default(bool?), SupervisorLogLevel? logLevel = default(SupervisorLogLevel?))
        {
            SiteId = siteId;
            Discovery = discovery;
            DiscoveryConfig = discoveryConfig;
            DiscoveryCallbacks = discoveryCallbacks;
            RemoveDiscoveryCallbacks = removeDiscoveryCallbacks;
            LogLevel = logLevel;
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
        /// Gets or sets whether the supervisor is in discovery mode.
        /// If null, does not change. Possible values include: 'Off', 'Local',
        /// 'Network', 'Fast', 'Scan'
        /// </summary>
        [JsonProperty(PropertyName = "discovery")]
        public DiscoveryMode? Discovery { get; set; }

        /// <summary>
        /// Gets or sets supervisor discovery configuration
        /// </summary>
        [JsonProperty(PropertyName = "discoveryConfig")]
        public DiscoveryConfigApiModel DiscoveryConfig { get; set; }

        /// <summary>
        /// Gets or sets callbacks to add or remove (see below)
        /// </summary>
        [JsonProperty(PropertyName = "discoveryCallbacks")]
        public IList<CallbackApiModel> DiscoveryCallbacks { get; set; }

        /// <summary>
        /// Gets or sets whether to add or remove callbacks
        /// </summary>
        [JsonProperty(PropertyName = "removeDiscoveryCallbacks")]
        public bool? RemoveDiscoveryCallbacks { get; set; }

        /// <summary>
        /// Gets or sets current log level. Possible values include: 'Error',
        /// 'Information', 'Debug', 'Verbose'
        /// </summary>
        [JsonProperty(PropertyName = "logLevel")]
        public SupervisorLogLevel? LogLevel { get; set; }

    }
}
