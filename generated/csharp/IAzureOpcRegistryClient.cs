// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.Opc.Registry
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Azure Industrial IoT OPC UA Registry Service
    /// </summary>
    public partial interface IAzureOpcRegistryClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Get list of applications
        /// </summary>
        /// <remarks>
        /// Get all registered applications in paged form.
        /// The returned model can contain a continuation token if more results
        /// are
        /// available.
        /// Call this operation again using the token to retrieve more results.
        /// </remarks>
        /// <param name='continuationToken'>
        /// Optional Continuation
        /// token
        /// </param>
        /// <param name='pageSize'>
        /// Optional number of results to
        /// return
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ApplicationInfoListApiModel>> GetListOfApplicationsWithHttpMessagesAsync(string continuationToken = default(string), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create new application
        /// </summary>
        /// <remarks>
        /// The application is registered using the provided information, but
        /// it
        /// is not associated with a supervisor.  This is useful for when you
        /// need
        /// to register clients or you want to register a server that is
        /// located
        /// in a network not reachable through a Twin module.
        /// </remarks>
        /// <param name='request'>
        /// Application registration request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ApplicationRegistrationResponseApiModel>> CreateApplicationWithHttpMessagesAsync(ApplicationRegistrationRequestApiModel request, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Register new server
        /// </summary>
        /// <remarks>
        /// Registers a server solely using a discovery url. Requires that
        /// the onboarding agent service is running and the server can be
        /// located by a supervisor in its network using the discovery url.
        /// </remarks>
        /// <param name='request'>
        /// Server registration request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> RegisterServerWithHttpMessagesAsync(ServerRegistrationRequestApiModel request, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Purge applications
        /// </summary>
        /// <remarks>
        /// Purges all applications that have not been seen for a specified
        /// amount of time.
        /// </remarks>
        /// <param name='notSeenFor'>
        /// A duration in milliseconds
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteAllDisabledApplicationsWithHttpMessagesAsync(string notSeenFor = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Discover servers
        /// </summary>
        /// <remarks>
        /// Registers servers by running a discovery scan in a supervisor's
        /// network. Requires that the onboarding agent service is running.
        /// </remarks>
        /// <param name='request'>
        /// Discovery request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DiscoverServerWithHttpMessagesAsync(DiscoveryRequestApiModel request, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get application registration
        /// </summary>
        /// <param name='applicationId'>
        /// Application id for the server
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ApplicationRegistrationApiModel>> GetApplicationRegistrationWithHttpMessagesAsync(string applicationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Unregister application
        /// </summary>
        /// <remarks>
        /// Unregisters and deletes application and all its associated
        /// endpoints.
        /// </remarks>
        /// <param name='applicationId'>
        /// The identifier of the application
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteApplicationWithHttpMessagesAsync(string applicationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update application registration
        /// </summary>
        /// <remarks>
        /// The application information is updated with new properties.  Note
        /// that
        /// this information might be overridden if the application is
        /// re-discovered
        /// during a discovery run (recurring or one-time).
        /// </remarks>
        /// <param name='applicationId'>
        /// The identifier of the application
        /// </param>
        /// <param name='request'>
        /// Application update request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> UpdateApplicationRegistrationWithHttpMessagesAsync(string applicationId, ApplicationRegistrationUpdateApiModel request, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get list of sites
        /// </summary>
        /// <remarks>
        /// List all sites applications are registered in.
        /// </remarks>
        /// <param name='continuationToken'>
        /// Optional Continuation
        /// token
        /// </param>
        /// <param name='pageSize'>
        /// Optional number of results to
        /// return
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ApplicationSiteListApiModel>> GetListOfSitesWithHttpMessagesAsync(string continuationToken = default(string), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get filtered list of applications
        /// </summary>
        /// <remarks>
        /// Get a list of applications filtered using the specified query
        /// parameters.
        /// The returned model can contain a continuation token if more results
        /// are
        /// available.
        /// Call the GetListOfApplications operation using the token to
        /// retrieve
        /// more results.
        /// </remarks>
        /// <param name='query'>
        /// Applications Query model
        /// </param>
        /// <param name='pageSize'>
        /// Number of results to return
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ApplicationInfoListApiModel>> GetFilteredListOfApplicationsWithHttpMessagesAsync(ApplicationRegistrationQueryApiModel query, int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Query applications
        /// </summary>
        /// <remarks>
        /// List applications that match a query model.
        /// The returned model can contain a continuation token if more results
        /// are
        /// available.
        /// Call the GetListOfApplications operation using the token to
        /// retrieve
        /// more results.
        /// </remarks>
        /// <param name='query'>
        /// Application query
        /// </param>
        /// <param name='pageSize'>
        /// Optional number of results to
        /// return
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ApplicationInfoListApiModel>> QueryApplicationsWithHttpMessagesAsync(ApplicationRegistrationQueryApiModel query, int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Activate endpoint
        /// </summary>
        /// <remarks>
        /// Activates an endpoint for subsequent use in twin service.
        /// All endpoints must be activated using this API or through a
        /// activation filter during application registration or discovery.
        /// </remarks>
        /// <param name='endpointId'>
        /// endpoint identifier
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ActivateEndpointWithHttpMessagesAsync(string endpointId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get endpoint information
        /// </summary>
        /// <remarks>
        /// Gets information about an endpoint.
        /// </remarks>
        /// <param name='endpointId'>
        /// endpoint identifier
        /// </param>
        /// <param name='onlyServerState'>
        /// Whether to include only server
        /// state, or display current client state of the endpoint if
        /// available
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<EndpointInfoApiModel>> GetEndpointWithHttpMessagesAsync(string endpointId, bool? onlyServerState = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update endpoint information
        /// </summary>
        /// <param name='endpointId'>
        /// endpoint identifier
        /// </param>
        /// <param name='request'>
        /// Endpoint update request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> UpdateEndpointWithHttpMessagesAsync(string endpointId, EndpointRegistrationUpdateApiModel request, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get list of endpoints
        /// </summary>
        /// <remarks>
        /// Get all registered endpoints in paged form.
        /// The returned model can contain a continuation token if more results
        /// are
        /// available.
        /// Call this operation again using the token to retrieve more results.
        /// </remarks>
        /// <param name='onlyServerState'>
        /// Whether to include only server
        /// state, or display current client state of the endpoint if available
        /// </param>
        /// <param name='continuationToken'>
        /// Optional Continuation token
        /// </param>
        /// <param name='pageSize'>
        /// Optional number of results to return
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<EndpointInfoListApiModel>> GetListOfEndpointsWithHttpMessagesAsync(bool? onlyServerState = default(bool?), string continuationToken = default(string), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get filtered list of endpoints
        /// </summary>
        /// <remarks>
        /// Get a list of endpoints filtered using the specified query
        /// parameters.
        /// The returned model can contain a continuation token if more results
        /// are
        /// available.
        /// Call the GetListOfEndpoints operation using the token to retrieve
        /// more results.
        /// </remarks>
        /// <param name='url'>
        /// Endoint url for direct server access
        /// </param>
        /// <param name='userAuthentication'>
        /// Type of credential selected for authentication. Possible values
        /// include: 'None', 'UserName', 'X509Certificate', 'JwtToken'
        /// </param>
        /// <param name='certificate'>
        /// Certificate of the endpoint
        /// </param>
        /// <param name='securityMode'>
        /// Security Mode. Possible values include: 'Best', 'Sign',
        /// 'SignAndEncrypt', 'None'
        /// </param>
        /// <param name='securityPolicy'>
        /// Security policy uri
        /// </param>
        /// <param name='activated'>
        /// Whether the endpoint was activated
        /// </param>
        /// <param name='connected'>
        /// Whether the endpoint is connected on supervisor.
        /// </param>
        /// <param name='endpointState'>
        /// The last state of the the activated endpoint. Possible values
        /// include: 'Connecting', 'NotReachable', 'Busy', 'NoTrust',
        /// 'CertificateInvalid', 'Ready', 'Error'
        /// </param>
        /// <param name='includeNotSeenSince'>
        /// Whether to include endpoints that were soft deleted
        /// </param>
        /// <param name='onlyServerState'>
        /// Whether to include only server state, or display
        /// current client state of the endpoint if available
        /// </param>
        /// <param name='pageSize'>
        /// Optional number of results to
        /// return
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<EndpointInfoListApiModel>> GetFilteredListOfEndpointsWithHttpMessagesAsync(string url = default(string), string userAuthentication = default(string), byte[] certificate = default(byte[]), string securityMode = default(string), string securityPolicy = default(string), bool? activated = default(bool?), bool? connected = default(bool?), string endpointState = default(string), bool? includeNotSeenSince = default(bool?), bool? onlyServerState = default(bool?), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Query endpoints
        /// </summary>
        /// <remarks>
        /// Return endpoints that match the specified query.
        /// The returned model can contain a continuation token if more results
        /// are
        /// available.
        /// Call the GetListOfEndpoints operation using the token to retrieve
        /// more results.
        /// </remarks>
        /// <param name='query'>
        /// Query to match
        /// </param>
        /// <param name='onlyServerState'>
        /// Whether to include only server
        /// state, or display current client state of the endpoint if available
        /// </param>
        /// <param name='pageSize'>
        /// Optional number of results to return
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<EndpointInfoListApiModel>> QueryEndpointsWithHttpMessagesAsync(EndpointRegistrationQueryApiModel query, bool? onlyServerState = default(bool?), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deactivate endpoint
        /// </summary>
        /// <remarks>
        /// Deactivates the endpoint and disable access through twin service.
        /// </remarks>
        /// <param name='endpointId'>
        /// endpoint identifier
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeactivateEndpointWithHttpMessagesAsync(string endpointId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Return the service status in the form of the service status
        /// api model.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<StatusResponseApiModel>> GetStatusWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get supervisor registration information
        /// </summary>
        /// <remarks>
        /// Returns a supervisor's registration and connectivity information.
        /// A supervisor id corresponds to the twin modules module identity.
        /// </remarks>
        /// <param name='supervisorId'>
        /// Supervisor identifier
        /// </param>
        /// <param name='onlyServerState'>
        /// Whether to include only server
        /// state, or display current client state of the endpoint if
        /// available
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SupervisorApiModel>> GetSupervisorWithHttpMessagesAsync(string supervisorId, bool? onlyServerState = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update supervisor information
        /// </summary>
        /// <remarks>
        /// Allows a caller to configure recurring discovery runs on the twin
        /// module
        /// identified by the supervisor id or update site information.
        /// </remarks>
        /// <param name='supervisorId'>
        /// supervisor identifier
        /// </param>
        /// <param name='request'>
        /// Patch request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> UpdateSupervisorWithHttpMessagesAsync(string supervisorId, SupervisorUpdateApiModel request, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get runtime status of supervisor
        /// </summary>
        /// <remarks>
        /// Allows a caller to get runtime status for a supervisor.
        /// </remarks>
        /// <param name='supervisorId'>
        /// supervisor identifier
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SupervisorStatusApiModel>> GetSupervisorStatusWithHttpMessagesAsync(string supervisorId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Reset supervisor
        /// </summary>
        /// <remarks>
        /// Allows a caller to reset the twin module using its supervisor
        /// identity identifier.
        /// </remarks>
        /// <param name='supervisorId'>
        /// supervisor identifier
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> ResetSupervisorWithHttpMessagesAsync(string supervisorId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get list of supervisors
        /// </summary>
        /// <remarks>
        /// Get all registered supervisors and therefore twin modules in paged
        /// form.
        /// The returned model can contain a continuation token if more results
        /// are
        /// available.
        /// Call this operation again using the token to retrieve more results.
        /// </remarks>
        /// <param name='onlyServerState'>
        /// Whether to include only server
        /// state, or display current client state of the endpoint if available
        /// </param>
        /// <param name='continuationToken'>
        /// Optional Continuation token
        /// </param>
        /// <param name='pageSize'>
        /// Optional number of results to return
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SupervisorListApiModel>> GetListOfSupervisorsWithHttpMessagesAsync(bool? onlyServerState = default(bool?), string continuationToken = default(string), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get filtered list of supervisors
        /// </summary>
        /// <remarks>
        /// Get a list of supervisors filtered using the specified query
        /// parameters.
        /// The returned model can contain a continuation token if more results
        /// are
        /// available.
        /// Call the GetListOfSupervisors operation using the token to retrieve
        /// more results.
        /// </remarks>
        /// <param name='siteId'>
        /// Site of the supervisor
        /// </param>
        /// <param name='discovery'>
        /// Discovery mode of supervisor. Possible values include: 'Off',
        /// 'Local', 'Network', 'Fast', 'Scan'
        /// </param>
        /// <param name='connected'>
        /// Included connected or disconnected
        /// </param>
        /// <param name='onlyServerState'>
        /// Whether to include only server
        /// state, or display current client state of the endpoint if
        /// available
        /// </param>
        /// <param name='pageSize'>
        /// Number of results to return
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SupervisorListApiModel>> GetFilteredListOfSupervisorsWithHttpMessagesAsync(string siteId = default(string), string discovery = default(string), bool? connected = default(bool?), bool? onlyServerState = default(bool?), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Query supervisors
        /// </summary>
        /// <remarks>
        /// Get all supervisors that match a specified query.
        /// The returned model can contain a continuation token if more results
        /// are
        /// available.
        /// Call the GetListOfSupervisors operation using the token to retrieve
        /// more results.
        /// </remarks>
        /// <param name='query'>
        /// Supervisors query model
        /// </param>
        /// <param name='onlyServerState'>
        /// Whether to include only server
        /// state, or display current client state of the endpoint if
        /// available
        /// </param>
        /// <param name='pageSize'>
        /// Number of results to return
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SupervisorListApiModel>> QuerySupervisorsWithHttpMessagesAsync(SupervisorQueryApiModel query, bool? onlyServerState = default(bool?), int? pageSize = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
