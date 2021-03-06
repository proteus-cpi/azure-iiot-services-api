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
 * List of application sites
 *
 */
class ApplicationSiteListApiModel {
  /**
   * Create a ApplicationSiteListApiModel.
   * @property {array} [sites] Distinct list of sites applications were
   * registered in.
   * @property {string} [continuationToken] Continuation or null if final
   */
  constructor() {
  }

  /**
   * Defines the metadata of ApplicationSiteListApiModel
   *
   * @returns {object} metadata of ApplicationSiteListApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'ApplicationSiteListApiModel',
      type: {
        name: 'Composite',
        className: 'ApplicationSiteListApiModel',
        modelProperties: {
          sites: {
            required: false,
            serializedName: 'sites',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'StringElementType',
                  type: {
                    name: 'String'
                  }
              }
            }
          },
          continuationToken: {
            required: false,
            serializedName: 'continuationToken',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = ApplicationSiteListApiModel;
