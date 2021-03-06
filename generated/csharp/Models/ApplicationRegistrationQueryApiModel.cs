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
    /// Application information
    /// </summary>
    public partial class ApplicationRegistrationQueryApiModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationRegistrationQueryApiModel class.
        /// </summary>
        public ApplicationRegistrationQueryApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationRegistrationQueryApiModel class.
        /// </summary>
        /// <param name="applicationType">Type of application. Possible values
        /// include: 'Server', 'Client', 'ClientAndServer'</param>
        /// <param name="applicationUri">Application uri</param>
        /// <param name="productUri">Product uri</param>
        /// <param name="applicationName">Name of application</param>
        /// <param name="locale">Locale of application name - default is
        /// "en"</param>
        /// <param name="capability">Application capability to query
        /// with</param>
        /// <param name="siteOrSupervisorId">Supervisor or site the application
        /// belongs to.</param>
        /// <param name="includeNotSeenSince">Whether to include apps that were
        /// soft deleted</param>
        public ApplicationRegistrationQueryApiModel(ApplicationType? applicationType = default(ApplicationType?), string applicationUri = default(string), string productUri = default(string), string applicationName = default(string), string locale = default(string), string capability = default(string), string siteOrSupervisorId = default(string), bool? includeNotSeenSince = default(bool?))
        {
            ApplicationType = applicationType;
            ApplicationUri = applicationUri;
            ProductUri = productUri;
            ApplicationName = applicationName;
            Locale = locale;
            Capability = capability;
            SiteOrSupervisorId = siteOrSupervisorId;
            IncludeNotSeenSince = includeNotSeenSince;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of application. Possible values include:
        /// 'Server', 'Client', 'ClientAndServer'
        /// </summary>
        [JsonProperty(PropertyName = "applicationType")]
        public ApplicationType? ApplicationType { get; set; }

        /// <summary>
        /// Gets or sets application uri
        /// </summary>
        [JsonProperty(PropertyName = "applicationUri")]
        public string ApplicationUri { get; set; }

        /// <summary>
        /// Gets or sets product uri
        /// </summary>
        [JsonProperty(PropertyName = "productUri")]
        public string ProductUri { get; set; }

        /// <summary>
        /// Gets or sets name of application
        /// </summary>
        [JsonProperty(PropertyName = "applicationName")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or sets locale of application name - default is "en"
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets application capability to query with
        /// </summary>
        [JsonProperty(PropertyName = "capability")]
        public string Capability { get; set; }

        /// <summary>
        /// Gets or sets supervisor or site the application belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "siteOrSupervisorId")]
        public string SiteOrSupervisorId { get; set; }

        /// <summary>
        /// Gets or sets whether to include apps that were soft deleted
        /// </summary>
        [JsonProperty(PropertyName = "includeNotSeenSince")]
        public bool? IncludeNotSeenSince { get; set; }

    }
}
