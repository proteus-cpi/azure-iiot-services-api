// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.Clients {
    using Microsoft.Azure.IIoT.OpcUa.Api.Models;
    using Microsoft.Azure.IIoT.Diagnostics;
    using Microsoft.Azure.IIoT.Http;
    using Newtonsoft.Json;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Implementation of v1 twin service api.
    /// </summary>
    public class TwinServiceClient : ITwinServiceApi {

        /// <summary>
        /// Create service client
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="config"></param>
        /// <param name="logger"></param>
        public TwinServiceClient(IHttpClient httpClient, ITwinConfig config,
            ILogger logger) :
            this(httpClient, config.OpcUaTwinServiceUrl,
                config.OpcUaTwinServiceResourceId, logger) {
        }

        /// <summary>
        /// Create service client
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="serviceUri"></param>
        /// <param name="resourceId"></param>
        /// <param name="logger"></param>
        public TwinServiceClient(IHttpClient httpClient, string serviceUri,
            string resourceId, ILogger logger) {
            if (string.IsNullOrEmpty(serviceUri)) {
                throw new ArgumentNullException(nameof(serviceUri),
                    "Please configure the Url of the twin micro service.");
            }
            _serviceUri = serviceUri;
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _resourceId = resourceId;
        }

        /// <summary>
        /// Returns service status
        /// </summary>
        /// <returns></returns>
        public async Task<StatusResponseApiModel> GetServiceStatusAsync() {
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/status",
                _resourceId);
            var response = await _httpClient.GetAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<StatusResponseApiModel>(
                response.GetContentAsString());
        }

        /// <summary>
        /// Browse a tree node, returns node properties and all child nodes
        /// if not excluded.
        /// </summary>
        /// <param name="twinId">Server twin to talk to</param>
        /// <param name="content">browse node and filters</param>
        /// <returns></returns>
        public async Task<BrowseResponseApiModel> NodeBrowseAsync(string twinId,
            BrowseRequestApiModel content) {
            if (string.IsNullOrEmpty(twinId)) {
                throw new ArgumentNullException(nameof(twinId));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/browse/{twinId}",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<BrowseResponseApiModel>(
                response.GetContentAsString());
        }

        /// <summary>
        /// Browse next references on twin
        /// </summary>
        /// <param name="twinId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<BrowseNextResponseApiModel> NodeBrowseNextAsync(string twinId,
            BrowseNextRequestApiModel content) {
            if (string.IsNullOrEmpty(twinId)) {
                throw new ArgumentNullException(nameof(twinId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (content.ContinuationToken == null) {
                throw new ArgumentNullException(nameof(content.ContinuationToken));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/browse/{twinId}/next",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<BrowseNextResponseApiModel>(
                response.GetContentAsString());
        }

        /// <summary>
        /// Publish node values
        /// </summary>
        /// <param name="twinId">Server twin to talk to</param>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<PublishResponseApiModel> NodePublishAsync(string twinId,
            PublishRequestApiModel content) {
            if (string.IsNullOrEmpty(twinId)) {
                throw new ArgumentNullException(nameof(twinId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (string.IsNullOrEmpty(content.NodeId)) {
                throw new ArgumentNullException(nameof(content.NodeId));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/publish/{twinId}",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<PublishResponseApiModel>(
                response.GetContentAsString());
        }

        /// <summary>
        /// Get list of published nodes
        /// </summary>
        /// <param name="continuation"></param>
        /// <param name="twinId">Server twin to talk to</param>
        /// <returns></returns>
        public async Task<PublishedNodeListApiModel> ListPublishedNodesAsync(
            string continuation, string twinId) {
            if (string.IsNullOrEmpty(twinId)) {
                throw new ArgumentNullException(nameof(twinId));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/publish/{twinId}/state",
                _resourceId);
            if (continuation != null) {
                request.AddHeader(kContinuationTokenHeaderKey, continuation);
            }
            var response = await _httpClient.GetAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<PublishedNodeListApiModel>(
                response.GetContentAsString());
        }

        /// <summary>
        /// Read a variable value
        /// </summary>
        /// <param name="twinId"></param>
        /// <param name="content">Read nodes</param>
        /// <returns></returns>
        public async Task<ValueReadResponseApiModel> NodeValueReadAsync(string twinId,
            ValueReadRequestApiModel content) {
            if (string.IsNullOrEmpty(twinId)) {
                throw new ArgumentNullException(nameof(twinId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (string.IsNullOrEmpty(content.NodeId)) {
                throw new ArgumentException(nameof(content.NodeId));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/read/{twinId}",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<ValueReadResponseApiModel>(
                response.GetContentAsString());
        }

        /// <summary>
        /// Write variable value
        /// </summary>
        /// <param name="twinId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<ValueWriteResponseApiModel> NodeValueWriteAsync(string twinId,
            ValueWriteRequestApiModel content) {
            if (string.IsNullOrEmpty(twinId)) {
                throw new ArgumentNullException(nameof(twinId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (content.Node == null) {
                throw new ArgumentNullException(nameof(content.Node));
            }
            if (content.Value == null) {
                throw new ArgumentNullException(nameof(content.Value));
            }
            if (string.IsNullOrEmpty(content.Node.Id)) {
                throw new ArgumentException(nameof(content.Node.Id));
            }
            if (string.IsNullOrEmpty(content.Node.DataType)) {
                throw new ArgumentException(nameof(content.Node.DataType));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/write/{twinId}",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<ValueWriteResponseApiModel>(
                response.GetContentAsString());
        }

        /// <summary>
        /// Get method meta data
        /// </summary>
        /// <param name="twinId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<MethodMetadataResponseApiModel> NodeMethodGetMetadataAsync(
            string twinId, MethodMetadataRequestApiModel content) {
            if (string.IsNullOrEmpty(twinId)) {
                throw new ArgumentNullException(nameof(twinId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (string.IsNullOrEmpty(content.MethodId)) {
                throw new ArgumentNullException(nameof(content.MethodId));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/call/{twinId}/$metadata",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<MethodMetadataResponseApiModel>(
                response.GetContentAsString());
        }

        /// <summary>
        /// Call method
        /// </summary>
        /// <param name="twinId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<MethodCallResponseApiModel> NodeMethodCallAsync(
            string twinId, MethodCallRequestApiModel content) {
            if (string.IsNullOrEmpty(twinId)) {
                throw new ArgumentNullException(nameof(twinId));
            }
            if (content == null) {
                throw new ArgumentNullException(nameof(content));
            }
            if (string.IsNullOrEmpty(content.MethodId)) {
                throw new ArgumentNullException(nameof(content.MethodId));
            }
            var request = _httpClient.NewRequest($"{_serviceUri}/v1/call/{twinId}",
                _resourceId);
            request.SetContent(content);
            var response = await _httpClient.PostAsync(request).ConfigureAwait(false);
            response.Validate();
            return JsonConvertEx.DeserializeObject<MethodCallResponseApiModel>(
                response.GetContentAsString());
        }


        private const string kContinuationTokenHeaderKey = "x-ms-continuation";
        private const string kPageSizeHeaderKey = "x-ms-max-item-count";
        private readonly IHttpClient _httpClient;
        private readonly ILogger _logger;
        private readonly string _serviceUri;
        private readonly string _resourceId;
    }
}