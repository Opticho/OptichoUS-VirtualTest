using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing;

namespace AnalogJigTestApplication
{
    class SerialPortConnection
    {
        MainForm fm;
        //Form1 fm = new Form1();
        List<String> tList = new List<String>();

        //string ddrMessage = null;
        string[] stringSeparators = new string[] { "\r\n" };
        string ddrRxData {get; set;}
        //string masterRxData;
        //bool _RtcHostReadEn = false;
        //bool _AcqHostReadEn = false;
        //bool _AnaHostReadEn = false;
        //bool _DDRHostReadEn = false;

        public SerialPortConnection(MainForm fm)
        {
            this.fm = fm;
            //this.SerialComboBox.SelectedIndexChanged += new System.EventHandler(this.SerialComboBox_SelectedIndexChanged);
            //fm.serialMaster.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(serialMaster_DataReceived);
            fm.SerialComboBox.SelectedIndexChanged += new System.EventHandler(SerialComboBox_SelectedIndexChanged);
            fm.ACQ_XDMA_EN_CHECK.CheckedChanged += new System.EventHandler(CheckBox5_CheckedChange);
        }
        
        public void SerialPortSearch()
        {
            fm.SerialComboBox.Items.Clear();
            tList.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                tList.Add(s);
            }

            tList.Sort();
            fm.SerialComboBox.Items.Add("Select COM port...");
            fm.SerialComboBox.Items.AddRange(tList.ToArray());
            fm.SerialComboBox.SelectedIndex = 0;
        }
        
        private void SerialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TryConnectionComPort();
        }

        private void CheckBox5_CheckedChange(object sender, EventArgs e)
        {
            if(fm.ACQ_XDMA_EN_CHECK.CheckState == CheckState.Checked)
            {
                fm.SerialComboBox.Enabled = false;
                fm.SerialComboBox.BackColor = Color.Gray;
            }
            else
            {
                fm.SerialComboBox.Enabled = true;
                fm.SerialComboBox.BackColor = Color.Empty;
            }
        }

        public void SerialPortBufferClear()
        {
            fm.serialMaster.DiscardInBuffer();
            fm.serialMaster.DiscardOutBuffer();
        }

        public void TryConnectionComPort()
        {
            if (fm.serialMaster.IsOpen == true)
            {
                fm.serialMaster.Close();
            }

            if ((fm.SerialComboBox.SelectedIndex != 0) && !(fm.serialMaster.IsOpen))
            {
                fm.serialMaster.PortName = fm.SerialComboBox.SelectedItem.ToString();
                fm.serialMaster.BaudRate = 115200;
                fm.serialMaster.DataBits = 8;
                fm.serialMaster.Parity = Parity.None;
                fm.serialMaster.StopBits = StopBits.One;

                fm.serialMaster.ReadTimeout = 5000;
                fm.serialMaster.WriteTimeout = 5000;

                //fm.serialMaster.DiscardInBuffer();
                //fm.serialMaster.DiscardOutBuffer();
                
                try
                {
                    fm.serialMaster.Open();
                    fm.serialMaster.DiscardNull.ToString();
                    fm.serialMaster.Encoding.ToString();
                    SendMessage("UART");
                    Thread.Sleep(50);
                    fm.COMPORT_RICH.AppendText(ByteToString(GetMessage(100)));
                    fm.COMPORT_RICH.AppendText("\nCOM port Opened...\n");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "Please configure correct COM port", "Error!");
                    fm.serialMaster.Close();
                    return;
                }
            }
        }
        

        private string ByteToString(byte[] strByte)
        {
            string str = Encoding.Default.GetString(strByte);
            return str;
        }

        public void SendMessage(string message)
        {
            string strTemp = message + "\r";

            if (fm.serialMaster.IsOpen)
            {
                fm.serialMaster.WriteLine(strTemp);
            }
            else
            {
                //MessageBox.Show("Error!, fail send message. Plase check the COM Ports");
            }
            
        }

        public unsafe byte[] GetMessage(int size)
        {
            byte[] serialReadBuf = new byte[size];

            int count = fm.serialMaster.Read(serialReadBuf, 0, size);

            if (count < 32)
            {
                fm.serialMaster.Read(serialReadBuf, count, size - count);
            }

            return serialReadBuf;
        }

        public unsafe byte[] GetMessage()
        {
            int count = 0;
            byte[] serialReadBuf = new byte[32];
            
            while (count < serialReadBuf.Length)
            {
                try
                {
                    count += fm.serialMaster.Read(serialReadBuf, count, serialReadBuf.Length - count);
                }
                catch (TimeoutException)
                {
                    MessageBox.Show("Uart Read Time Out, Try RF data read once again.");
                }
            }
            return serialReadBuf;
        }

    }
}
