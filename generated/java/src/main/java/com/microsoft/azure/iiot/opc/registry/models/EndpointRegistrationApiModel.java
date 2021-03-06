/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package com.microsoft.azure.iiot.opc.registry.models;

import java.util.List;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Endpoint registration model.
 */
public class EndpointRegistrationApiModel {
    /**
     * Registered identifier of the endpoint.
     */
    @JsonProperty(value = "id", required = true)
    private String id;

    /**
     * Original endpoint url of the endpoint.
     */
    @JsonProperty(value = "endpointUrl")
    private String endpointUrl;

    /**
     * Registered site of the endpoint.
     */
    @JsonProperty(value = "siteId")
    private String siteId;

    /**
     * Endpoint information of the registration.
     */
    @JsonProperty(value = "endpoint", required = true)
    private EndpointApiModel endpoint;

    /**
     * Security level of the endpoint.
     */
    @JsonProperty(value = "securityLevel")
    private Integer securityLevel;

    /**
     * Endpoint cert that was registered.
     */
    @JsonProperty(value = "certificate")
    private byte[] certificate;

    /**
     * Supported authentication methods that can be selected to
     * obtain a credential and used to interact with the endpoint.
     */
    @JsonProperty(value = "authenticationMethods")
    private List<AuthenticationMethodApiModel> authenticationMethods;

    /**
     * Get registered identifier of the endpoint.
     *
     * @return the id value
     */
    public String id() {
        return this.id;
    }

    /**
     * Set registered identifier of the endpoint.
     *
     * @param id the id value to set
     * @return the EndpointRegistrationApiModel object itself.
     */
    public EndpointRegistrationApiModel withId(String id) {
        this.id = id;
        return this;
    }

    /**
     * Get original endpoint url of the endpoint.
     *
     * @return the endpointUrl value
     */
    public String endpointUrl() {
        return this.endpointUrl;
    }

    /**
     * Set original endpoint url of the endpoint.
     *
     * @param endpointUrl the endpointUrl value to set
     * @return the EndpointRegistrationApiModel object itself.
     */
    public EndpointRegistrationApiModel withEndpointUrl(String endpointUrl) {
        this.endpointUrl = endpointUrl;
        return this;
    }

    /**
     * Get registered site of the endpoint.
     *
     * @return the siteId value
     */
    public String siteId() {
        return this.siteId;
    }

    /**
     * Set registered site of the endpoint.
     *
     * @param siteId the siteId value to set
     * @return the EndpointRegistrationApiModel object itself.
     */
    public EndpointRegistrationApiModel withSiteId(String siteId) {
        this.siteId = siteId;
        return this;
    }

    /**
     * Get endpoint information of the registration.
     *
     * @return the endpoint value
     */
    public EndpointApiModel endpoint() {
        return this.endpoint;
    }

    /**
     * Set endpoint information of the registration.
     *
     * @param endpoint the endpoint value to set
     * @return the EndpointRegistrationApiModel object itself.
     */
    public EndpointRegistrationApiModel withEndpoint(EndpointApiModel endpoint) {
        this.endpoint = endpoint;
        return this;
    }

    /**
     * Get security level of the endpoint.
     *
     * @return the securityLevel value
     */
    public Integer securityLevel() {
        return this.securityLevel;
    }

    /**
     * Set security level of the endpoint.
     *
     * @param securityLevel the securityLevel value to set
     * @return the EndpointRegistrationApiModel object itself.
     */
    public EndpointRegistrationApiModel withSecurityLevel(Integer securityLevel) {
        this.securityLevel = securityLevel;
        return this;
    }

    /**
     * Get endpoint cert that was registered.
     *
     * @return the certificate value
     */
    public byte[] certificate() {
        return this.certificate;
    }

    /**
     * Set endpoint cert that was registered.
     *
     * @param certificate the certificate value to set
     * @return the EndpointRegistrationApiModel object itself.
     */
    public EndpointRegistrationApiModel withCertificate(byte[] certificate) {
        this.certificate = certificate;
        return this;
    }

    /**
     * Get supported authentication methods that can be selected to
     obtain a credential and used to interact with the endpoint.
     *
     * @return the authenticationMethods value
     */
    public List<AuthenticationMethodApiModel> authenticationMethods() {
        return this.authenticationMethods;
    }

    /**
     * Set supported authentication methods that can be selected to
     obtain a credential and used to interact with the endpoint.
     *
     * @param authenticationMethods the authenticationMethods value to set
     * @return the EndpointRegistrationApiModel object itself.
     */
    public EndpointRegistrationApiModel withAuthenticationMethods(List<AuthenticationMethodApiModel> authenticationMethods) {
        this.authenticationMethods = authenticationMethods;
        return this;
    }

}
