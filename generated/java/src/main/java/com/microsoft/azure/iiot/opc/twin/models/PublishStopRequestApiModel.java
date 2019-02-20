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

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Unpublish request.
 */
public class PublishStopRequestApiModel {
    /**
     * Node of item to unpublish.
     */
    @JsonProperty(value = "nodeId", required = true)
    private String nodeId;

    /**
     * Attribute of item to unpublish. Possible values include: 'NodeClass',
     * 'BrowseName', 'DisplayName', 'Description', 'WriteMask',
     * 'UserWriteMask', 'IsAbstract', 'Symmetric', 'InverseName',
     * 'ContainsNoLoops', 'EventNotifier', 'Value', 'DataType', 'ValueRank',
     * 'ArrayDimensions', 'AccessLevel', 'UserAccessLevel',
     * 'MinimumSamplingInterval', 'Historizing', 'Executable',
     * 'UserExecutable', 'DataTypeDefinition', 'RolePermissions',
     * 'UserRolePermissions', 'AccessRestrictions'.
     */
    @JsonProperty(value = "nodeAttribute")
    private NodeAttribute nodeAttribute;

    /**
     * Optional diagnostics configuration.
     */
    @JsonProperty(value = "diagnostics")
    private DiagnosticsApiModel diagnostics;

    /**
     * Get node of item to unpublish.
     *
     * @return the nodeId value
     */
    public String nodeId() {
        return this.nodeId;
    }

    /**
     * Set node of item to unpublish.
     *
     * @param nodeId the nodeId value to set
     * @return the PublishStopRequestApiModel object itself.
     */
    public PublishStopRequestApiModel withNodeId(String nodeId) {
        this.nodeId = nodeId;
        return this;
    }

    /**
     * Get attribute of item to unpublish. Possible values include: 'NodeClass', 'BrowseName', 'DisplayName', 'Description', 'WriteMask', 'UserWriteMask', 'IsAbstract', 'Symmetric', 'InverseName', 'ContainsNoLoops', 'EventNotifier', 'Value', 'DataType', 'ValueRank', 'ArrayDimensions', 'AccessLevel', 'UserAccessLevel', 'MinimumSamplingInterval', 'Historizing', 'Executable', 'UserExecutable', 'DataTypeDefinition', 'RolePermissions', 'UserRolePermissions', 'AccessRestrictions'.
     *
     * @return the nodeAttribute value
     */
    public NodeAttribute nodeAttribute() {
        return this.nodeAttribute;
    }

    /**
     * Set attribute of item to unpublish. Possible values include: 'NodeClass', 'BrowseName', 'DisplayName', 'Description', 'WriteMask', 'UserWriteMask', 'IsAbstract', 'Symmetric', 'InverseName', 'ContainsNoLoops', 'EventNotifier', 'Value', 'DataType', 'ValueRank', 'ArrayDimensions', 'AccessLevel', 'UserAccessLevel', 'MinimumSamplingInterval', 'Historizing', 'Executable', 'UserExecutable', 'DataTypeDefinition', 'RolePermissions', 'UserRolePermissions', 'AccessRestrictions'.
     *
     * @param nodeAttribute the nodeAttribute value to set
     * @return the PublishStopRequestApiModel object itself.
     */
    public PublishStopRequestApiModel withNodeAttribute(NodeAttribute nodeAttribute) {
        this.nodeAttribute = nodeAttribute;
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
     * @return the PublishStopRequestApiModel object itself.
     */
    public PublishStopRequestApiModel withDiagnostics(DiagnosticsApiModel diagnostics) {
        this.diagnostics = diagnostics;
        return this;
    }

}