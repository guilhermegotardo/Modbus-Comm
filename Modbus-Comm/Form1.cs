using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modbus_Comm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComboBoxSerialComm.SelectedIndex = 0;
            ComboBoxBaudRate.SelectedIndex = 0;
            ComboBoxDataBits.SelectedIndex = 0;
            ComboBoxStopBit.SelectedIndex = 0;
            ComboBoxDataBits.SelectedIndex = 0;
            ComboBoxParity.SelectedIndex = 0;

            modbusmanger = new ModbusManager();
            modbusmanger.Serial_Setup.COMPort = ComboBoxSerialComm.SelectedItem.ToString();
            modbusmanger.Serial_Setup.BaudRate = ComboBoxBaudRate.SelectedItem.ToString();

        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            string a = modbusmanger.Serial_Setup.COMPort;
        }
    }
}
