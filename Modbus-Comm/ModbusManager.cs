using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Modbus_Comm
{
    class ModbusManager
    {
        public struct Coordinate
        {
            private string _COMPort, _BaudRate;

            public string COMPort
            {
                get
                {
                    return _COMPort;
                }

                set
                {
                    _COMPort = value;
                }
            }

            public string BaudRate
            {
                get
                {
                    return _BaudRate;
                }

                set
                {
                    _BaudRate = value;
                }
            }
        }


        public Coordinate Serial_Setup = new Coordinate();

    }
}
