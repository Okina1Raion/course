import warnings
from serial.serialwin32 import Serial
from serial.tools import list_ports


class Arduino:
    def __init__(self):
        self.arduino_ports = [
            p.device
            for p in list_ports.comports()
            if 'Arduino' in p.description
        ]
        if not self.arduino_ports:
            raise IOError("No Arduino found")
        if len(self.arduino_ports) > 1:
            warnings.warn('Multiple Arduino\'s found - using the first')
        print(self.arduino_ports[0])

    @property
    def serial_a(self):
        return Serial("3", 9600)


a_serial = Arduino()
serial_a = a_serial.serial_a
serial_a.open()
serial_a.write('aaa')
