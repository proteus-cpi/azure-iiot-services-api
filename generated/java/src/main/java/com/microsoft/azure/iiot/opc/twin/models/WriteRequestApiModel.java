/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package com.microsoft.azure.iiot.opc.twin.models;

import java.util.List;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Request node attribute write.
 */
public class WriteRequestApiModel {
    /**
     * Attributes to update.
     */
    @JsonProperty(value = "attributes", required = true)
    private List<AttributeWriteRequestApiModel> attributes;

    /**
     * Optional User Elevation.
     */
    @JsonProperty(value = "elevation")
    private CredentialApiModel elevation;

    /**
     * Optional diagnostics configuration.
     */
    @JsonProperty(value = "diagnostics")
    private DiagnosticsApiModel diagnostics;

    /**
     * Get attributes to update.
     *
     * @return the attributes value
     */
    public List<AttributeWriteRequestApiModel> attributes() {
        return this.attributes;
    }

    /**
     * Set attributes to update.
     *
     * @param attributes the attributes value to set
     * @return the WriteRequestApiModel object itself.
     */
    public WriteRequestApiModel withAttributes(List<AttributeWriteRequestApiModel> attributes) {
        this.attributes = attributes;
        return this;
    }

    /**
     * Get optional User Elevation.
     *
     * @return the elevation value
     */
    public CredentialApiModel elevation() {
        return this.elevation;
    }

    /**
     * Set optional User Elevation.
     *
     * @param elevation the elevation value to set
     * @return the WriteRequestApiModel object itself.
     */
    public WriteRequestApiModel withElevation(CredentialApiModel elevation) {
        this.elevation = elevation;
        return this;
    }

    /**
     * Get optional diagnostics configuration.
     *
     * @return the diagnostics value
     */
    public DiagnosticsApiModel diagnostics() {
        return this.diagnostics;
    }

    /**
     * Set optional diagnostics configuration.
     *
     * @param diagnostics the diagnostics value to set
     * @return the WriteRequestApiModel object itself.
     */
    public WriteRequestApiModel withDiagnostics(DiagnosticsApiModel diagnostics) {
        this.diagnostics = diagnostics;
        return this;
    }

}