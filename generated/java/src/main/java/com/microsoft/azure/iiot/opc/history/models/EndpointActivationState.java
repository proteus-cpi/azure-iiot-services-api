/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package com.microsoft.azure.iiot.opc.history.models;

import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;

/**
 * Defines values for EndpointActivationState.
 */
public enum EndpointActivationState {
    /** Enum value Deactivated. */
    DEACTIVATED("Deactivated"),

    /** Enum value Activated. */
    ACTIVATED("Activated"),

    /** Enum value ActivatedAndConnected. */
    ACTIVATED_AND_CONNECTED("ActivatedAndConnected");

    /** The actual serialized value for a EndpointActivationState instance. */
    private String value;

    EndpointActivationState(String value) {
        this.value = value;
    }

    /**
     * Parses a serialized value to a EndpointActivationState instance.
     *
     * @param value the serialized value to parse.
     * @return the parsed EndpointActivationState object, or null if unable to parse.
     */
    @JsonCreator
    public static EndpointActivationState fromString(String value) {
        EndpointActivationState[] items = EndpointActivationState.values();
        for (EndpointActivationState item : items) {
            if (item.toString().equalsIgnoreCase(value)) {
                return item;
            }
        }
        return null;
    }

    @JsonValue
    @Override
    public String toString() {
        return this.value;
    }
}
