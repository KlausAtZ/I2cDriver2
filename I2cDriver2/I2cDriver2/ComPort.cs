using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;


namespace I2cDriver2
{
    public class ComPort
    {
        public static SerialPort _serialPort;

        public static void ComPortOpen(string PortName)
        {
            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();

            _serialPort.PortName = PortName;
            _serialPort.BaudRate = 1000000;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.None;

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 1000;
            _serialPort.WriteTimeout = 1000;

            _serialPort.Open();
        }

        public static void ComPortClose()
        {
            _serialPort.Close();
        }

        public static String[] SerialPortNames ()
        {
            string[] Ports;
            Ports = SerialPort.GetPortNames();
            return Ports;
        }

    }
}
