/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * Browse request model
 *
 */
class BrowseRequestApiModel {
  /**
   * Create a BrowseRequestApiModel.
   * @property {string} [nodeId] Node to browse.
   * (default: RootFolder).
   * @property {string} [direction] Direction to browse in
   * (default: forward). Possible values include: 'Forward', 'Backward', 'Both'
   * @property {object} [view] View to browse
   * (default: null = new view = All nodes).
   * @property {string} [view.viewId] Node of the view to browse
   * @property {number} [view.version] Browses specific version of the view.
   * @property {date} [view.timestamp] Browses at or before this timestamp.
   * @property {string} [referenceTypeId] Reference types to browse.
   * (default: hierarchical).
   * @property {boolean} [noSubtypes] Whether to include subtypes of the
   * reference type.
   * (default is false). Default value: false .
   * @property {number} [maxReferencesToReturn] Max number of references to
   * return. There might
   * be less returned as this is up to the client
   * restrictions.  Set to 0 to return no references
   * or target nodes.
   * (default is decided by client e.g. 60)
   * @property {boolean} [targetNodesOnly] Whether to collapse all references
   * into a set of
   * unique target nodes and not show reference
   * information.
   * (default is false). Default value: false .
   * @property {boolean} [readVariableValues] Whether to read variable values
   * on target nodes.
   * (default is false). Default value: false .
   * @property {object} [elevation] Optional User elevation
   * @property {string} [elevation.type] Type of credential. Possible values
   * include: 'None', 'UserName', 'X509Certificate', 'JwtToken'
   * @property {object} [elevation.value] Value to pass to server
   * @property {object} [diagnostics] Optional diagnostics configuration
   * @property {string} [diagnostics.level] Requested level of response
   * diagnostics.
   * (default: Status). Possible values include: 'None', 'Status',
   * 'Operations', 'Diagnostics', 'Verbose'
   * @property {string} [diagnostics.auditId] Client audit log entry.
   * (default: client generated)
   * @property {date} [diagnostics.timeStamp] Timestamp of request.
   * (default: client generated)
   */
  constructor() {
  }

  /**
   * Defines the metadata of BrowseRequestApiModel
   *
   * @returns {object} metadata of BrowseRequestApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'BrowseRequestApiModel',
      type: {
        name: 'Composite',
        className: 'BrowseRequestApiModel',
        modelProperties: {
          nodeId: {
            required: false,
            serializedName: 'nodeId',
            type: {
              name: 'String'
            }
          },
          direction: {
            required: false,
            serializedName: 'direction',
            type: {
              name: 'Enum',
              allowedValues: [ 'Forward', 'Backward', 'Both' ]
            }
          },
          view: {
            required: false,
            serializedName: 'view',
            type: {
              name: 'Composite',
              className: 'BrowseViewApiModel'
            }
          },
          referenceTypeId: {
            required: false,
            serializedName: 'referenceTypeId',
            type: {
              name: 'String'
            }
          },
          noSubtypes: {
            required: false,
            serializedName: 'noSubtypes',
            defaultValue: false,
            type: {
              name: 'Boolean'
            }
          },
          maxReferencesToReturn: {
            required: false,
            serializedName: 'maxReferencesToReturn',
            type: {
              name: 'Number'
            }
          },
          targetNodesOnly: {
            required: false,
            serializedName: 'targetNodesOnly',
            defaultValue: false,
            type: {
              name: 'Boolean'
            }
          },
          readVariableValues: {
            required: false,
            serializedName: 'readVariableValues',
            defaultValue: false,
            type: {
              name: 'Boolean'
            }
          },
          elevation: {
            required: false,
            serializedName: 'elevation',
            type: {
              name: 'Composite',
              className: 'CredentialApiModel'
            }
          },
          diagnostics: {
            required: false,
            serializedName: 'diagnostics',
            type: {
              name: 'Composite',
              className: 'DiagnosticsApiModel'
            }
          }
        }
      }
    };
  }
}

module.exports = BrowseRequestApiModel;