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
 * Defines values for DiscoveryMode.
 */
public enum DiscoveryMode {
    /** Enum value Off. */
    OFF("Off"),

    /** Enum value Local. */
    LOCAL("Local"),

    /** Enum value Network. */
    NETWORK("Network"),

    /** Enum value Fast. */
    FAST("Fast"),

    /** Enum value Scan. */
    SCAN("Scan");

    /** The actual serialized value for a DiscoveryMode instance. */
    private String value;

    DiscoveryMode(String value) {
        this.value = value;
    }

    /**
     * Parses a serialized value to a DiscoveryMode instance.
     *
     * @param value the serialized value to parse.
     * @return the parsed DiscoveryMode object, or null if unable to parse.
     */
    @JsonCreator
    public static DiscoveryMode fromString(String value) {
        DiscoveryMode[] items = DiscoveryMode.values();
        for (DiscoveryMode item : items) {
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
