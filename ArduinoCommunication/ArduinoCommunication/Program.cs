using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ArduinoCommunication
{
    class Program
    {
        static void Main(string[] args)
        {
            //var portNumber = "COM3";
            //var mySerialPort = new SerialPort(portNumber);
            //var ReceivedData = new SerialPortHandler(portNumber);

            //mySerialPort.DataReceived += new SerialDataReceivedEventHandler(ReceivedData.mySerialPort_DataReceived);
            //mySerialPort.Open();

            //var sph = new SerialPortHandler(portNumber);

            //sph.DataReceived += ProcessData();

            ArduinoController ac = new ArduinoController();
            Console.WriteLine("");

        }

        private void ProcessData(byte[] data)
        {
            //TODO do stuff with data
        }
    }
}
