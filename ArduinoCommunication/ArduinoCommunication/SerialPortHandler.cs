using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using System.Management.Instrumentation;

namespace ArduinoCommunication
{
    class SerialPortHandler
    {
        public SerialPort mySerialPort;

        public Action<byte[]> DataReceived;

        public SerialPortHandler(string com)
        {
            mySerialPort = new SerialPort(com);
            mySerialPort.DataReceived += mySerialPort_DataReceived;
            mySerialPort.Open();
        }
        public void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                //no. of data at the port
                int ByteToRead = mySerialPort.BytesToRead;

                //create array to store buffer data
                byte[] inputData = new byte[ByteToRead];

                //read the data and store
                mySerialPort.Read(inputData, 0, ByteToRead);

                var copy = DataReceived;
                if (copy != null) copy(inputData);
            }

            catch (SystemException ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
