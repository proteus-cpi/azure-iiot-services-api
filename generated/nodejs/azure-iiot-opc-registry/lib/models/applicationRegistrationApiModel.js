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
 * Application with list of endpoints
 *
 */
class ApplicationRegistrationApiModel {
  /**
   * Create a ApplicationRegistrationApiModel.
   * @property {object} application Application information
   * @property {string} [application.applicationId] Unique application id
   * @property {string} [application.applicationType] Type of application.
   * Possible values include: 'Server', 'Client', 'ClientAndServer'
   * @property {string} [application.applicationUri] Unique application uri
   * @property {string} [application.productUri] Product uri
   * @property {string} [application.applicationName] Name of server
   * @property {string} [application.locale] Locale of name - defaults to "en"
   * @property {buffer} [application.certificate] Application public cert
   * @property {array} [application.capabilities] The capabilities advertised
   * by the server.
   * @property {array} [application.discoveryUrls] Discovery urls of the server
   * @property {string} [application.discoveryProfileUri] Discovery profile uri
   * @property {array} [application.hostAddresses] Host addresses of server
   * application or null
   * @property {string} [application.siteId] Site of the application
   * @property {string} [application.supervisorId] Supervisor having registered
   * the application
   * @property {date} [application.notSeenSince] Last time application was seen
   * @property {array} [endpoints] List of endpoint twins
   * @property {string} [securityAssessment] Application security assessment.
   * Possible values include: 'Unknown', 'Low', 'Medium', 'High'
   */
  constructor() {
  }

  /**
   * Defines the metadata of ApplicationRegistrationApiModel
   *
   * @returns {object} metadata of ApplicationRegistrationApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'ApplicationRegistrationApiModel',
      type: {
        name: 'Composite',
        className: 'ApplicationRegistrationApiModel',
        modelProperties: {
          application: {
            required: true,
            serializedName: 'application',
            type: {
              name: 'Composite',
              className: 'ApplicationInfoApiModel'
            }
          },
          endpoints: {
            required: false,
            serializedName: 'endpoints',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'EndpointRegistrationApiModelElementType',
                  type: {
                    name: 'Composite',
                    className: 'EndpointRegistrationApiModel'
                  }
              }
            }
          },
          securityAssessment: {
            required: false,
            serializedName: 'securityAssessment',
            type: {
              name: 'Enum',
              allowedValues: [ 'Unknown', 'Low', 'Medium', 'High' ]
            }
          }
        }
      }
    };
  }
}

module.exports = ApplicationRegistrationApiModel;
