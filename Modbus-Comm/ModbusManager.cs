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
            private string _COMPort, _BaudRate, _Parity, _DataBits, _StopBit;


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

            public string Parity
            {
                get
                {
                    return _Parity;
                }

                set
                {
                    _Parity = value;
                }
            }

            public string DataBits
            {
                get
                {
                    return _DataBits;
                }

                set
                {
                    _DataBits = value;
                }
            }

            public string StopBit
            {
                get
                {
                    return _StopBit;
                }

                set
                {
                    _StopBit = value;
                }
            }
        }

        private SerialPort port;
        public Coordinate Serial_Setup = new Coordinate();

        public ushort ConnectToLocalPort()
        {
         ushort result = 0;

            if(port == null)
            {
            bool Parsable;
            int ToParse;

                port = new SerialPort();
                port.PortName = Serial_Setup.COMPort;

                Parsable = Int32.TryParse(Serial_Setup.BaudRate, out ToParse);
                port.BaudRate = ToParse;


                if(Serial_Setup.Parity == "None Parity")
                {
                    port.Parity = Parity.None;
                }
                
                else if (Serial_Setup.Parity == "Odd Parity")
                {
                    port.Parity = Parity.Odd;
                }

                else if (Serial_Setup.Parity == "Even Parity")
                {
                    port.Parity = Parity.Even;
                }

                else
                {
                    port.Parity = Parity.None;
                }

                port.DataBits =


                result = 1;
            }

            else if(port.IsOpen == true)
            {
                result = 0;
            }

            else
            {

            }



            return result;
        }

    }
}
