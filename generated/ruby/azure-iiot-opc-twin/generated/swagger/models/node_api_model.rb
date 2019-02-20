# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module azure.iiot.opc.twin
  module Models
    #
    # node model
    #
    class NodeApiModel
      # @return [NodeClass] Type of node. Possible values include: 'Object',
      # 'Variable', 'Method', 'ObjectType', 'VariableType', 'ReferenceType',
      # 'DataType', 'View'
      attr_accessor :node_class

      # @return [String] Display name
      attr_accessor :display_name

      # @return [String] Id of node.
      # (Mandatory).
      attr_accessor :id

      # @return [String] Description if any
      attr_accessor :description

      # @return [Boolean] Whether node has children which are defined as
      # any forward hierarchical references.
      # (default: unknown)
      attr_accessor :children

      # @return [String] Browse name
      attr_accessor :name

      # @return [NodeAccessRestrictions] Node access restrictions if any.
      # (default: none). Possible values include: 'SigningRequired',
      # 'EncryptionRequired', 'SessionRequired'
      attr_accessor :access_restrictions

      # @return [Integer] Default write mask for the node
      # (default: 0)
      attr_accessor :write_mask

      # @return [Integer] User write mask for the node
      # (default: 0)
      attr_accessor :user_write_mask

      # @return [Boolean] Whether type is abstract, if type can
      # be abstract.  Null if not type node.
      # (default: false)
      attr_accessor :is_abstract

      # @return [Boolean] Whether a view contains loops. Null if
      # not a view.
      attr_accessor :contains_no_loops

      # @return [NodeEventNotifier] If object or view and eventing, event
      # notifier
      # to subscribe to.
      # (default: no events supported). Possible values include:
      # 'SubscribeToEvents', 'HistoryRead', 'HistoryWrite'
      attr_accessor :event_notifier

      # @return [Boolean] If method node class, whether method can
      # be called.
      attr_accessor :executable

      # @return [Boolean] If method node class, whether method can
      # be called by current user.
      # (default: false if not executable)
      attr_accessor :user_executable

      # @return Data type definition in case node is a
      # data type node and definition is available,
      # otherwise null.
      attr_accessor :data_type_definition

      # @return [NodeAccessLevel] Default access level for variable node.
      # (default: 0). Possible values include: 'CurrentRead', 'CurrentWrite',
      # 'HistoryRead', 'HistoryWrite', 'SemanticChange', 'StatusWrite',
      # 'TimestampWrite', 'NonatomicRead', 'NonatomicWrite',
      # 'WriteFullArrayOnly'
      attr_accessor :access_level

      # @return [NodeAccessLevel] User access level for variable node or null.
      # (default: 0). Possible values include: 'CurrentRead', 'CurrentWrite',
      # 'HistoryRead', 'HistoryWrite', 'SemanticChange', 'StatusWrite',
      # 'TimestampWrite', 'NonatomicRead', 'NonatomicWrite',
      # 'WriteFullArrayOnly'
      attr_accessor :user_access_level

      # @return [String] If variable the datatype of the variable.
      # (default: null)
      attr_accessor :data_type

      # @return [NodeValueRank] Value rank of the variable data of a variable
      # or variable type, otherwise null.
      # (default: scalar = -1). Possible values include:
      # 'ScalarOrOneDimension', 'Any', 'Scalar', 'OneOrMoreDimensions',
      # 'OneDimension', 'TwoDimensions'
      attr_accessor :value_rank

      # @return [Array<Integer>] Array dimensions of variable or variable type.
      # (default: empty array)
      attr_accessor :array_dimensions

      # @return [Boolean] Whether the value of a variable is historizing.
      # (default: false)
      attr_accessor :historizing

      # @return [Float] Minimum sampling interval for the variable
      # value, otherwise null if not a variable node.
      # (default: null)
      attr_accessor :minimum_sampling_interval

      # @return Value of variable or default value of the
      # subtyped variable in case node is a variable
      # type, otherwise null.
      attr_accessor :value

      # @return [String] Inverse name of the reference if the node is
      # a reference type, otherwise null.
      attr_accessor :inverse_name

      # @return [Boolean] Whether the reference is symmetric in case
      # the node is a reference type, otherwise
      # null.
      attr_accessor :symmetric

      # @return [Array<RolePermissionApiModel>] Role permissions
      attr_accessor :role_permissions

      # @return [Array<RolePermissionApiModel>] User Role permissions
      attr_accessor :user_role_permissions


      #
      # Mapper for NodeApiModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'NodeApiModel',
          type: {
            name: 'Composite',
            class_name: 'NodeApiModel',
            model_properties: {
              node_class: {
                client_side_validation: true,
                required: false,
                serialized_name: 'nodeClass',
                type: {
                  name: 'Enum',
                  module: 'NodeClass'
                }
              },
              display_name: {
                client_side_validation: true,
                required: false,
                serialized_name: 'displayName',
                type: {
                  name: 'String'
                }
              },
              id: {
                client_side_validation: true,
                required: true,
                serialized_name: 'id',
                type: {
                  name: 'String'
                }
              },
              description: {
                client_side_validation: true,
                required: false,
                serialized_name: 'description',
                type: {
                  name: 'String'
                }
              },
              children: {
                client_side_validation: true,
                required: false,
                serialized_name: 'children',
                type: {
                  name: 'Boolean'
                }
              },
              name: {
                client_side_validation: true,
                required: false,
                serialized_name: 'name',
                type: {
                  name: 'String'
                }
              },
              access_restrictions: {
                client_side_validation: true,
                required: false,
                serialized_name: 'accessRestrictions',
                type: {
                  name: 'Enum',
                  module: 'NodeAccessRestrictions'
                }
              },
              write_mask: {
                client_side_validation: true,
                required: false,
                serialized_name: 'writeMask',
                type: {
                  name: 'Number'
                }
              },
              user_write_mask: {
                client_side_validation: true,
                required: false,
                serialized_name: 'userWriteMask',
                type: {
                  name: 'Number'
                }
              },
              is_abstract: {
                client_side_validation: true,
                required: false,
                serialized_name: 'isAbstract',
                type: {
                  name: 'Boolean'
                }
              },
              contains_no_loops: {
                client_side_validation: true,
                required: false,
                serialized_name: 'containsNoLoops',
                type: {
                  name: 'Boolean'
                }
              },
              event_notifier: {
                client_side_validation: true,
                required: false,
                serialized_name: 'eventNotifier',
                type: {
                  name: 'Enum',
                  module: 'NodeEventNotifier'
                }
              },
              executable: {
                client_side_validation: true,
                required: false,
                serialized_name: 'executable',
                type: {
                  name: 'Boolean'
                }
              },
              user_executable: {
                client_side_validation: true,
                required: false,
                serialized_name: 'userExecutable',
                type: {
                  name: 'Boolean'
                }
              },
              data_type_definition: {
                client_side_validation: true,
                required: false,
                serialized_name: 'dataTypeDefinition',
                type: {
                  name: 'Object'
                }
              },
              access_level: {
                client_side_validation: true,
                required: false,
                serialized_name: 'accessLevel',
                type: {
                  name: 'Enum',
                  module: 'NodeAccessLevel'
                }
              },
              user_access_level: {
                client_side_validation: true,
                required: false,
                serialized_name: 'userAccessLevel',
                type: {
                  name: 'Enum',
                  module: 'NodeAccessLevel'
                }
              },
              data_type: {
                client_side_validation: true,
                required: false,
                serialized_name: 'dataType',
                type: {
                  name: 'String'
                }
              },
              value_rank: {
                client_side_validation: true,
                required: false,
                serialized_name: 'valueRank',
                type: {
                  name: 'Enum',
                  module: 'NodeValueRank'
                }
              },
              array_dimensions: {
                client_side_validation: true,
                required: false,
                serialized_name: 'arrayDimensions',
                type: {
                  name: 'Sequence',
                  element: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'NumberElementType',
                      type: {
                        name: 'Number'
                      }
                  }
                }
              },
              historizing: {
                client_side_validation: true,
                required: false,
                serialized_name: 'historizing',
                type: {
                  name: 'Boolean'
                }
              },
              minimum_sampling_interval: {
                client_side_validation: true,
                required: false,
                serialized_name: 'minimumSamplingInterval',
                type: {
                  name: 'Double'
                }
              },
              value: {
                client_side_validation: true,
                required: false,
                serialized_name: 'value',
                type: {
                  name: 'Object'
                }
              },
              inverse_name: {
                client_side_validation: true,
                required: false,
                serialized_name: 'inverseName',
                type: {
                  name: 'String'
                }
              },
              symmetric: {
                client_side_validation: true,
                required: false,
                serialized_name: 'symmetric',
                type: {
                  name: 'Boolean'
                }
              },
              role_permissions: {
                client_side_validation: true,
                required: false,
                serialized_name: 'rolePermissions',
                type: {
                  name: 'Sequence',
                  element: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'RolePermissionApiModelElementType',
                      type: {
                        name: 'Composite',
                        class_name: 'RolePermissionApiModel'
                      }
                  }
                }
              },
              user_role_permissions: {
                client_side_validation: true,
                required: false,
                serialized_name: 'userRolePermissions',
                type: {
                  name: 'Sequence',
                  element: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'RolePermissionApiModelElementType',
                      type: {
                        name: 'Composite',
                        class_name: 'RolePermissionApiModel'
                      }
                  }
                }
              }
            }
          }
        }
      end
    end
  end
end