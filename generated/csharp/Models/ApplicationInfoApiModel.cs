// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.Registry.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Application model
    /// </summary>
    public partial class ApplicationInfoApiModel
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationInfoApiModel class.
        /// </summary>
        public ApplicationInfoApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationInfoApiModel class.
        /// </summary>
        /// <param name="applicationId">Unique application id</param>
        /// <param name="applicationType">Type of application. Possible values
        /// include: 'Server', 'Client', 'ClientAndServer'</param>
        /// <param name="applicationUri">Unique application uri</param>
        /// <param name="productUri">Product uri</param>
        /// <param name="applicationName">Name of server</param>
        /// <param name="locale">Locale of name - defaults to "en"</param>
        /// <param name="certificate">Application public cert</param>
        /// <param name="capabilities">The capabilities advertised by the
        /// server.</param>
        /// <param name="discoveryUrls">Discovery urls of the server</param>
        /// <param name="discoveryProfileUri">Discovery profile uri</param>
        /// <param name="hostAddresses">Host addresses of server application or
        /// null</param>
        /// <param name="siteId">Site of the application</param>
        /// <param name="supervisorId">Supervisor having registered the
        /// application</param>
        /// <param name="notSeenSince">Last time application was seen</param>
        public ApplicationInfoApiModel(string applicationId = default(string), ApplicationType? applicationType = default(ApplicationType?), string applicationUri = default(string), string productUri = default(string), string applicationName = default(string), string locale = default(string), byte[] certificate = default(byte[]), IList<string> capabilities = default(IList<string>), IList<string> discoveryUrls = default(IList<string>), string discoveryProfileUri = default(string), IList<string> hostAddresses = default(IList<string>), string siteId = default(string), string supervisorId = default(string), System.DateTime? notSeenSince = default(System.DateTime?))
        {
            ApplicationId = applicationId;
            ApplicationType = applicationType;
            ApplicationUri = applicationUri;
            ProductUri = productUri;
            ApplicationName = applicationName;
            Locale = locale;
            Certificate = certificate;
            Capabilities = capabilities;
            DiscoveryUrls = discoveryUrls;
            DiscoveryProfileUri = discoveryProfileUri;
            HostAddresses = hostAddresses;
            SiteId = siteId;
            SupervisorId = supervisorId;
            NotSeenSince = notSeenSince;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique application id
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets type of application. Possible values include:
        /// 'Server', 'Client', 'ClientAndServer'
        /// </summary>
        [JsonProperty(PropertyName = "applicationType")]
        public ApplicationType? ApplicationType { get; set; }

        /// <summary>
        /// Gets or sets unique application uri
        /// </summary>
        [JsonProperty(PropertyName = "applicationUri")]
        public string ApplicationUri { get; set; }

        /// <summary>
        /// Gets or sets product uri
        /// </summary>
        [JsonProperty(PropertyName = "productUri")]
        public string ProductUri { get; set; }

        /// <summary>
        /// Gets or sets name of server
        /// </summary>
        [JsonProperty(PropertyName = "applicationName")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or sets locale of name - defaults to "en"
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets application public cert
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public byte[] Certificate { get; set; }

        /// <summary>
        /// Gets or sets the capabilities advertised by the server.
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public IList<string> Capabilities { get; set; }

        /// <summary>
        /// Gets or sets discovery urls of the server
        /// </summary>
        [JsonProperty(PropertyName = "discoveryUrls")]
        public IList<string> DiscoveryUrls { get; set; }

        /// <summary>
        /// Gets or sets discovery profile uri
        /// </summary>
        [JsonProperty(PropertyName = "discoveryProfileUri")]
        public string DiscoveryProfileUri { get; set; }

        /// <summary>
        /// Gets or sets host addresses of server application or null
        /// </summary>
        [JsonProperty(PropertyName = "hostAddresses")]
        public IList<string> HostAddresses { get; set; }

        /// <summary>
        /// Gets or sets site of the application
        /// </summary>
        [JsonProperty(PropertyName = "siteId")]
        public string SiteId { get; set; }

        /// <summary>
        /// Gets or sets supervisor having registered the application
        /// </summary>
        [JsonProperty(PropertyName = "supervisorId")]
        public string SupervisorId { get; set; }

        /// <summary>
        /// Gets or sets last time application was seen
        /// </summary>
        [JsonProperty(PropertyName = "notSeenSince")]
        public System.DateTime? NotSeenSince { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Capabilities != null)
            {
                if (Capabilities.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(Capabilities)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "Capabilities");
                }
            }
            if (DiscoveryUrls != null)
            {
                if (DiscoveryUrls.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(DiscoveryUrls)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "DiscoveryUrls");
                }
            }
            if (HostAddresses != null)
            {
                if (HostAddresses.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(HostAddresses)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "HostAddresses");
                }
            }
        }
    }
}