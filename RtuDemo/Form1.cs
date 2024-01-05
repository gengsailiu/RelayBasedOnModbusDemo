using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NModbus.Serial;

using NModbus;
using SeeSharpTools.JY.GUI;

namespace RtuDemo
{
    public partial class Form1 : Form
    {
        private readonly string _serialPortName = "COM6";
        private SerialPort _serialPort;
        private IModbusSerialMaster _modbusSerialRtuMaster;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort = new SerialPort()
                {
                    PortName = _serialPortName,
                    BaudRate = 115200,
                    DataBits = 8,
                    Parity = Parity.None,
                    StopBits = StopBits.One,
                    ReadTimeout = 2000,
                    WriteTimeout = 2000
                };
                _serialPort.Open();
                var factory = new ModbusFactory(); 
                _modbusSerialRtuMaster  =factory.CreateRtuMaster(_serialPort);
                
                ledConnected.Value = true;
            }
            catch (Exception exception)
            {
                ledConnected.Value = false;
                MessageBox.Show(exception.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ledConnected.Value = false;
            _serialPort.Close();
        }

        private void btnRelays_ControlValueChanged(object sender, ButtonSwitchArray.ValueChangedEventArgs e)
        {
            try
            {
                var coilAddress = e.SelectedIndex;
                var coilValue = e.Data;
                _modbusSerialRtuMaster.WriteSingleCoil(1, (ushort)coilAddress, coilValue);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnReadDoStatus_Click(object sender, EventArgs e)
        {
            try
            {
                var readData =_modbusSerialRtuMaster.ReadCoils(1, 0, 8);
                ledDoStatus.Value = readData;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
