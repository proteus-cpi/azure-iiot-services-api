# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 2.3.33.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class NodeReferenceApiModel(Model):
    """reference model.

    :param type_id: Reference Type identifier
    :type type_id: str
    :param browse_name: Browse name of reference
    :type browse_name: str
    :param direction: Browse direction of reference. Possible values include:
     'Forward', 'Backward', 'Both'
    :type direction: str or ~azure-iiot-opc-twin.models.BrowseDirection
    :param display_name: Display name of reference
    :type display_name: str
    :param target: Target node
    :type target: ~azure-iiot-opc-twin.models.NodeApiModel
    :param type_definition: Optional type definition of the reference
    :type type_definition: str
    """

    _validation = {
        'target': {'required': True},
    }

    _attribute_map = {
        'type_id': {'key': 'typeId', 'type': 'str'},
        'browse_name': {'key': 'browseName', 'type': 'str'},
        'direction': {'key': 'direction', 'type': 'BrowseDirection'},
        'display_name': {'key': 'displayName', 'type': 'str'},
        'target': {'key': 'target', 'type': 'NodeApiModel'},
        'type_definition': {'key': 'typeDefinition', 'type': 'str'},
    }

    def __init__(self, target, type_id=None, browse_name=None, direction=None, display_name=None, type_definition=None):
        super(NodeReferenceApiModel, self).__init__()
        self.type_id = type_id
        self.browse_name = browse_name
        self.direction = direction
        self.display_name = display_name
        self.target = target
        self.type_definition = type_definition