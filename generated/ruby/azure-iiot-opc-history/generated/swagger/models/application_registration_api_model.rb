# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module azure.iiot.opc.history
  module Models
    #
    # Application with list of endpoints
    #
    class ApplicationRegistrationApiModel
      # @return [ApplicationInfoApiModel] Application information
      attr_accessor :application

      # @return [Array<EndpointRegistrationApiModel>] List of endpoint twins
      attr_accessor :endpoints

      # @return [SecurityAssessment] Application security assessment. Possible
      # values include: 'Unknown', 'Low', 'Medium', 'High'
      attr_accessor :security_assessment


      #
      # Mapper for ApplicationRegistrationApiModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'ApplicationRegistrationApiModel',
          type: {
            name: 'Composite',
            class_name: 'ApplicationRegistrationApiModel',
            model_properties: {
              application: {
                client_side_validation: true,
                required: true,
                serialized_name: 'application',
                type: {
                  name: 'Composite',
                  class_name: 'ApplicationInfoApiModel'
                }
              },
              endpoints: {
                client_side_validation: true,
                required: false,
                serialized_name: 'endpoints',
                type: {
                  name: 'Sequence',
                  element: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'EndpointRegistrationApiModelElementType',
                      type: {
                        name: 'Composite',
                        class_name: 'EndpointRegistrationApiModel'
                      }
                  }
                }
              },
              security_assessment: {
                client_side_validation: true,
                required: false,
                serialized_name: 'securityAssessment',
                type: {
                  name: 'Enum',
                  module: 'SecurityAssessment'
                }
              }
            }
          }
        }
      end
    end
  end
end
