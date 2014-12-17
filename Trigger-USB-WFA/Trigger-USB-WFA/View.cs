using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trigger_USB_WFA
{
    public partial class View : Form
    {
        int count;

        string RxString;
        bool btConnectIsPressed = false;
        bool controlIsEnabled = false;

        public View()
        {
            InitializeComponent();
            
            var x = SerialPort.Get
            SerialPortHandler sph = new SerialPortHandler("COM3");


            sph.DataReceived += ProcessData;
        }

        public void detectArudinoPort()
        {
            
        }

        private void ProcessData(byte[] data)
        {
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(data));
        }

        #region old
        //private void btConnect_Click(object sender, EventArgs e)
        //{
        //    if (btConnectIsPressed == false)
        //    {
        //        try
        //        {
        //            mySerialPort.PortName = "COM3";
        //            mySerialPort.BaudRate = 9600;
        //            mySerialPort.Open();
        //            btConnectIsPressed = true;
        //            btConnect.Text = "Disconnect";

        //            rtbInfo.AppendText("Connection was initiated!\n");
        //            rtbInfo.AppendText("PortName" + mySerialPort.PortName.ToString() + "\n");
        //            rtbInfo.AppendText("BaudRate" + mySerialPort.BaudRate.ToString() + "\n");
        //            rtbInfo.AppendText("Port is open:" + mySerialPort.IsOpen.ToString() + "\n");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex);
        //        }
        //    }
        //    else
        //    {
        //        try
        //        {
        //            mySerialPort.Close();
        //            btConnectIsPressed = false;
        //            btConnect.Text = "Connect";

        //            rtbInfo.AppendText("\nConnection was terminated!\n");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex);
        //        }
        //    }
        //}

        //private void mySerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        //{
        //    RxString = mySerialPort.ReadExisting();

        //    this.Invoke(new EventHandler(ProcessData));
        //}

        //private void ProcessData(object sender, EventArgs e)
        //{
        //    rtbInfo.AppendText(RxString);
        //    this.Invoke(new EventHandler(ProcessClick));
        //}

        //private void ProcessClick(object sender, EventArgs e)
        //{
        //    if (cbMouseControl.CheckState == CheckState.Checked)
        //        DoMouseClick();
        //}

        //public void DoMouseClick()
        //{
        //    MouseHandler.doClick();
        //}
        #endregion
    }
}
