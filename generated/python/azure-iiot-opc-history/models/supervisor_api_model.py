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


class SupervisorApiModel(Model):
    """Supervisor registration model.

    :param id: Supervisor id
    :type id: str
    :param site_id: Site of the supervisor
    :type site_id: str
    :param discovery: Whether the supervisor is in discovery mode. Possible
     values include: 'Off', 'Local', 'Network', 'Fast', 'Scan'. Default value:
     "Off" .
    :type discovery: str or ~azure-iiot-opc-history.models.DiscoveryMode
    :param discovery_config: Supervisor configuration
    :type discovery_config:
     ~azure-iiot-opc-history.models.DiscoveryConfigApiModel
    :param certificate: Supervisor public client cert
    :type certificate: bytearray
    :param log_level: Current log level. Possible values include: 'Error',
     'Information', 'Debug', 'Verbose'. Default value: "Information" .
    :type log_level: str or ~azure-iiot-opc-history.models.SupervisorLogLevel
    :param out_of_sync: Whether the registration is out of sync between
     client (module) and server (service) (default: false).
    :type out_of_sync: bool
    :param connected: Whether supervisor is connected on this registration
    :type connected: bool
    """

    _validation = {
        'id': {'required': True},
    }

    _attribute_map = {
        'id': {'key': 'id', 'type': 'str'},
        'site_id': {'key': 'siteId', 'type': 'str'},
        'discovery': {'key': 'discovery', 'type': 'DiscoveryMode'},
        'discovery_config': {'key': 'discoveryConfig', 'type': 'DiscoveryConfigApiModel'},
        'certificate': {'key': 'certificate', 'type': 'bytearray'},
        'log_level': {'key': 'logLevel', 'type': 'SupervisorLogLevel'},
        'out_of_sync': {'key': 'outOfSync', 'type': 'bool'},
        'connected': {'key': 'connected', 'type': 'bool'},
    }

    def __init__(self, id, site_id=None, discovery="Off", discovery_config=None, certificate=None, log_level="Information", out_of_sync=None, connected=None):
        super(SupervisorApiModel, self).__init__()
        self.id = id
        self.site_id = site_id
        self.discovery = discovery
        self.discovery_config = discovery_config
        self.certificate = certificate
        self.log_level = log_level
        self.out_of_sync = out_of_sync
        self.connected = connected
