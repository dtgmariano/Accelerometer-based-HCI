namespace Trigger_USB_WFA
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.cbMouseControl = new System.Windows.Forms.CheckBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(12, 12);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(185, 184);
            this.rtbInfo.TabIndex = 0;
            this.rtbInfo.Text = "";
            // 
            // cbMouseControl
            // 
            this.cbMouseControl.AutoSize = true;
            this.cbMouseControl.Location = new System.Drawing.Point(103, 206);
            this.cbMouseControl.Name = "cbMouseControl";
            this.cbMouseControl.Size = new System.Drawing.Size(94, 17);
            this.cbMouseControl.TabIndex = 1;
            this.cbMouseControl.Text = "Mouse Control";
            this.cbMouseControl.UseVisualStyleBackColor = true;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(12, 202);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(60, 23);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // mySerialPort
            // 
            this.mySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.mySerialPort_DataReceived);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 235);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.cbMouseControl);
            this.Controls.Add(this.rtbInfo);
            this.Name = "View";
            this.Text = "Mouse Trigger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.CheckBox cbMouseControl;
        private System.Windows.Forms.Button btConnect;
        private System.IO.Ports.SerialPort mySerialPort;
    }
}

