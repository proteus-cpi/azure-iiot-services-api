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
 * Value write response model
 *
 */
class ValueWriteResponseApiModel {
  /**
   * Create a ValueWriteResponseApiModel.
   * @property {object} [errorInfo] Service result in case of error
   * @property {number} [errorInfo.statusCode] Error code - if null operation
   * succeeded.
   * @property {string} [errorInfo.errorMessage] Error message in case of error
   * or null.
   * @property {object} [errorInfo.diagnostics] Additional diagnostics
   * information
   */
  constructor() {
  }

  /**
   * Defines the metadata of ValueWriteResponseApiModel
   *
   * @returns {object} metadata of ValueWriteResponseApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'ValueWriteResponseApiModel',
      type: {
        name: 'Composite',
        className: 'ValueWriteResponseApiModel',
        modelProperties: {
          errorInfo: {
            required: false,
            serializedName: 'errorInfo',
            type: {
              name: 'Composite',
              className: 'ServiceResultApiModel'
            }
          }
        }
      }
    };
  }
}

module.exports = ValueWriteResponseApiModel;
