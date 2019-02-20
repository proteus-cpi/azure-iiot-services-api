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
 * Request node history read
 *
 */
class HistoryReadRequestApiModel {
  /**
   * Create a HistoryReadRequestApiModel.
   * @property {string} nodeId Node to read from (mandatory)
   * @property {object} request The HistoryReadDetailsType extension object
   * encoded in json and containing the tunneled
   * Historian reader request.
   * @property {string} [indexRange] Index range to read, e.g. 1:2,0:1 for 2
   * slices
   * out of a matrix or 0:1 for the first item in
   * an array, string or bytestring.
   * See 7.22 of part 4: NumericRange.
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
   * Defines the metadata of HistoryReadRequestApiModel
   *
   * @returns {object} metadata of HistoryReadRequestApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'HistoryReadRequestApiModel',
      type: {
        name: 'Composite',
        className: 'HistoryReadRequestApiModel',
        modelProperties: {
          nodeId: {
            required: true,
            serializedName: 'nodeId',
            type: {
              name: 'String'
            }
          },
          request: {
            required: true,
            serializedName: 'request',
            type: {
              name: 'Object'
            }
          },
          indexRange: {
            required: false,
            serializedName: 'indexRange',
            type: {
              name: 'String'
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

module.exports = HistoryReadRequestApiModel;