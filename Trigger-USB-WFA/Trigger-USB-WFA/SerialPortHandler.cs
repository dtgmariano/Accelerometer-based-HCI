using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO.Ports;
using System.Management.Instrumentation;

namespace Trigger_USB_WFA
{
    class SerialPortHandler
    {
        public SerialPort mySerialPort;

        public Action<byte[]> DataReceived;

        public SerialPortHandler(string com)
        {
            var portNames = SerialPort.GetPortNames();
            

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

        //private string AutodetectArduinoPort()
        //{
        //    ManagementScope connectionScope = new ManagementScope();
        //    SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
        //    ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

        //    try
        //    {
        //        foreach (ManagementObject item in searcher.Get())
        //        {
        //            string desc = item["Description"].ToString();
        //            string deviceId = item["DeviceID"].ToString();

        //            if (desc.Contains("Arduino"))
        //            {
        //                return deviceId;
        //            }
        //        }
        //    }
        //    catch (ManagementException e)
        //    {
        //        /* Do Nothing */
        //    }

        //    return null;
        //}
    }
}
