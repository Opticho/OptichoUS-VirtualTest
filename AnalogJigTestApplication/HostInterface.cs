using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AnalogJigTestApplication
{
    class HostInterface
    {
        MainForm fm;
        PcieInterface pcieInterface;
        SerialPortConnection serialPortConnection; //주소 참조를 통해 Form1 class에서 정의된 object을 가지고온다.
        RegisterInfo rtcRegisterInfo;
        RegisterInfo AcqRegisterInfo;
        RegisterInfo AnaRegisterInfo;

        public static int temp =0;

        private void debugPrint(uint addr, uint data, string deviceName, bool isWrite)
        {
            if (isWrite)
            {
                fm.BeginInvoke(new MethodInvoker(() => { fm.debug_text.AppendText("Write [" + deviceName + "]Addr: " + addr.ToString("X8") + ", Data:" + data.ToString("X8") + "\r\n"); }));
            }
            else
            {
                fm.BeginInvoke(new MethodInvoker(() => { fm.debug_text.AppendText("Read [" + deviceName + "]Addr: " + addr.ToString("X8") + "\r\n"); }));
            }
        }

        public HostInterface(MainForm fm1,PcieInterface pcieInterface, SerialPortConnection serialPortConnection, RegisterInfo rtcRegisterInfo, RegisterInfo AcqRegisterInfo, RegisterInfo AnaRegisterInfo)
        {
            this.fm = fm1; ;
            this.pcieInterface = pcieInterface;
            this.serialPortConnection = serialPortConnection;
            this.rtcRegisterInfo = rtcRegisterInfo;
            this.AcqRegisterInfo = AcqRegisterInfo;
            this.AnaRegisterInfo = AnaRegisterInfo;
        }

        public byte[] ConvertUint32ToByte(UInt32 data)
        {
            byte[] dstByte = new byte[4];
            dstByte[3] = (byte)((data & 0xff000000) >> 24);
            dstByte[2] = (byte)((data & 0x00ff0000) >> 16);
            dstByte[1] = (byte)((data & 0x0000ff00) >> 8);
            dstByte[0] = (byte)(data & 0x000000ff);
            return dstByte;
        }

        public void RtcHostWriteXdma(uint addr, uint data, StreamWriter fw)
        {
            string strTemp = "wr " + addr.ToString() + " " + data.ToString();
            pcieInterface.XDMARtcWrite(data, addr);
            fw.WriteLine(strTemp);
        }

        public byte[] RtcHostReadXdma(uint addr, string board)
        {
            string strTemp = "rd " + addr.ToString();
            IntPtr readDataPtr = pcieInterface.XDMARtcRead(addr);
            Thread.Sleep(10);
            uint readData = (uint)Marshal.ReadInt32(readDataPtr);

            return ConvertUint32ToByte(readData);
        }

        public byte[] RtcHostReadXdma(uint addr, string board, StreamWriter fw)
        {
            string strTemp = "rd " + addr.ToString();
            string strTemp1 = strTemp + " " + "00000000";
            fw.WriteLine(strTemp1);

            IntPtr readDataPtr = pcieInterface.XDMARtcRead(addr);
            uint readData = (uint)Marshal.ReadInt32(readDataPtr);
            return ConvertUint32ToByte(readData);
        }

        public IntPtr DDRHostReadXdma(uint addr)
        {
            string strTemp = "ddr " + addr.ToString();
            IntPtr readDataPtr = pcieInterface.XDMAAcqRead("subsys_00072000", (UInt64)addr, (uint)4);
            //Thread.Sleep(10);
            //Thread.Sleep(5);
            //channel당 2byte -> 문자 4개 총 4byte

            return readDataPtr;
            //return serialPortConnection.GetMessage(130);
        }

        public IntPtr DDRHostRead(string board, uint addr, uint size)
        {
            string strTemp = "ddr " + addr.ToString();
            
            return pcieInterface.XDMAAcqRead(board, (UInt64)addr, size);

            //return serialPortConnection.GetMessage(130);
        }

        public IntPtr DDRHostRead(uint addr)
        {
            if (fm.ACQ_XDMA_EN_CHECK.Checked == false)
            {
                temp = (int)addr;
                string strTemp = "ddr " + addr.ToString();
                serialPortConnection.SendMessage(strTemp);
                //Thread.Sleep(10);
                //Thread.Sleep(5);
                //channel당 2byte -> 문자 4개 총 4byte
                return (IntPtr)Convert.ToInt32(serialPortConnection.GetMessage());
                //return serialPortConnection.GetMessage(130);
            }

            return DDRHostReadXdma(addr);
        }

        public void RtcHostWrite(uint addr, uint data)
        {
            //fm.debug_text.AppendText("\r\n"+ "Write [RTC]Addr: " + addr.ToString("X8") + ", Data:"+ data.ToString("X8") );
            debugPrint(addr, data, "RTC", true);
            //if(fm.ACQ_XDMA_EN_CHECK.Checked == false)
            //{
            //    temp = (int)data;
            //    string strTemp = "wr " + addr.ToString() + " " + temp.ToString();
            //    serialPortConnection.SendMessage(strTemp);
            //}
            //else
            //{
            //    pcieInterface.XDMARtcWrite(data, addr);
            //}
        }

        public void RtcHostWrite(uint addr, uint data, StreamWriter fw)
        {

            //fm.debug_text.AppendText("\r\n" + "Write [RTC]Addr: " + addr.ToString("X8") + ", Data:" + data.ToString("X8"));
            debugPrint(addr, data, "RTC", true);
            //string strTemp = "wr " + addr.ToString() + " " + data.ToString();

            //if (fm.ACQ_XDMA_EN_CHECK.Checked == false)
            //{
            //    //temp = (int)data;
            //    //string strTemp = "wr " + addr.ToString() + " " + temp.ToString();
            //    serialPortConnection.SendMessage(strTemp);

            //}
            //else
            //{
            //    pcieInterface.XDMARtcWrite(data, addr);
            //}
            //fw.WriteLine(strTemp);
        }

        public byte[] RtcHostRead(uint addr, string board)
        {
            //fm.BeginInvoke(new MethodInvoker (() => { fm.debug_text.AppendText("\r\n" + "Read [RTC]Addr: " + addr.ToString("X8")); }));
            debugPrint(addr, 0, "RTC", false);

            return new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            //if (fm.ACQ_XDMA_EN_CHECK.Checked == false)
            //{
            //    temp = (int)addr;
            //    string strTemp = "rd " + temp.ToString();
            //    serialPortConnection.SendMessage(strTemp);
            //    Thread.Sleep(10);
            //    return serialPortConnection.GetMessage(10);
            //}

            //return RtcHostReadXdma(addr, board);

        }

        public byte[] RtcHostRead(uint addr, string board, StreamWriter fw)
        {
            //fm.BeginInvoke(new MethodInvoker(() => { fm.debug_text.AppendText("\r\n" + "Read [RTC]Addr: " + addr.ToString("X8")); }));
            debugPrint(addr, 0, "RTC", false);

            return new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };

            //if (fm.ACQ_XDMA_EN_CHECK.Checked == false)
            //{
            //    temp = (int)addr;
            //    string strTemp = "rd " + temp.ToString();
            //    serialPortConnection.SendMessage(strTemp);
            //    string strTemp1 = strTemp + " " + "00000000";
            //    fw.WriteLine(strTemp1);
            //    return serialPortConnection.GetMessage(10);
            //}

            //return RtcHostReadXdma(addr, board, fw);
        }

        public void AcqHostWrite(uint addr, uint data, int boardSelect)
        {
            //fm.debug_text.AppendText("\r\n" + "Write [ACQ"+boardSelect.ToString()+"]Addr: " + addr.ToString("X8") + ", Data:" + data.ToString("X8"));
            debugPrint(addr, data, "ACQ", true);

            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_MODE")], 0x0);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_ADDR")], addr);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_WDATA")], data);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x1);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0);
        }

        public void AcqHostWrite(uint addr, uint data, int boardSelect, StreamWriter fw)
        {
            //fm.debug_text.AppendText("\r\n" + "Write [ACQ" + boardSelect.ToString() + "]Addr: " + addr.ToString("X8") + ", Data:" + data.ToString("X8"));
            debugPrint(addr, data, "ACQ", true);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_MODE")], 0x0, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_ADDR")], addr, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_WDATA")], data, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x1, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0, fw);
        }

        public byte[] AcqHostRead(uint addr, int boardSelect)
        {
            //fm.debug_text.AppendText("\r\n" + "Read [ACQ" + boardSelect.ToString() + "]Addr: " + addr.ToString("X8"));
            debugPrint(addr, 0, "ACQ", false);
            return new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };

            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_MODE")], 0x1);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_ADDR")], addr);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x1);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0);
            //Thread.Sleep(50);
            //WaitTimeBpiRead(1);
            //return RtcHostRead(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_RDATA")], "Acq");
        }

        public byte[] AcqHostRead(uint addr, int boardSelect, StreamWriter fw)
        {
            //fm.debug_text.AppendText("\r\n" + "Read [ACQ" + boardSelect.ToString() + "]Addr: " + addr.ToString("X8"));
            debugPrint(addr, 0, "ACQ", false);
            return new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };

            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_MODE")], 0x1, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_ADDR")], addr, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x1, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0, fw);
            //Thread.Sleep(50);
            //WaitTimeBpiRead(1);
            //return RtcHostRead(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_RDATA")], "Acq", fw);
        }

        public void AnaHostWrite(uint addr, uint data, int boardSelect)
        {
            //fm.debug_text.AppendText("\r\n" + "Write [ANA" + boardSelect.ToString() + "]Addr: " + addr.ToString("X8") + ", Data:" + data.ToString("X8"));
            debugPrint(addr, data, "ANA", true);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_MODE")], 0x0);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_ADDR")], addr);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_WDATA")], data);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x1);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0);
        }

        public void AnaHostWrite(uint addr, uint data, int boardSelect, StreamWriter fw)
        {
            //fm.debug_text.AppendText("\r\n" + "Write [ANA" + boardSelect.ToString() + "]Addr: " + addr.ToString("X8") + ", Data:" + data.ToString("X8"));
            debugPrint(addr, data, "ANA", true);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_MODE")], 0x0, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_ADDR")], addr, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_WDATA")], data, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x1, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0, fw);
        }

        public byte[] AnaHostRead(uint addr, int boardSelect)
        {
            //fm.debug_text.AppendText("\r\n" + "Read [ANA" + boardSelect.ToString() + "]Addr: " + addr.ToString("X8"));
            debugPrint(addr, 0, "ANA", false);
            return new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_MODE")], 0x1);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_ADDR")], addr);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x1);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0);                
            //Thread.Sleep(50);
            //WaitTimeBpiRead(1);

            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_MODE")], 0x1);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_ADDR")], 0x1000000E);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x1);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0);
            //Thread.Sleep(50);
            //WaitTimeBpiRead(1);
            //return RtcHostRead(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_RDATA")], "Ana");

        }

        public byte[] AnaHostRead(uint addr, int boardSelect, StreamWriter fw)
        {
            //fm.debug_text.AppendText("\r\n" + "Read [ANA" + boardSelect.ToString() + "]Addr: " + addr.ToString("X8"));
            debugPrint(addr, 0, "ANA", false);
            return new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_MODE")], 0x1, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_ADDR")], addr, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x1, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0, fw);
            //Thread.Sleep(50);
            //WaitTimeBpiRead(1, fw);

            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_MODE")], 0x1, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_ADDR")], 0x1000000E, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x1, fw);
            //RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_EN")], 0x0, fw);
            //Thread.Sleep(50);
            //WaitTimeBpiRead(1, fw);
            //return RtcHostRead(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TX" + boardSelect.ToString() + "_BPI_RDATA")], "Ana", fw);
        }

        public void Afe5809HostWrite(uint addr, uint data, int boardSelect, int afeSelect)
        {

            //fm.debug_text.AppendText("\r\n" + "Write [ANA"+boardSelect.ToString()+"_AFE" + afeSelect.ToString() + "]Addr: " + addr.ToString("X8") + ", Data:" + data.ToString("X8"));
            debugPrint(addr, data, "AFE", true);
            ////afe select
            //uint afeSel;
            //uint AnaAddr = 0x81000003;
            //if (afeSelect == 0) afeSel = 15;
            //else if (afeSelect == 1) afeSel = 1;
            //else if (afeSelect == 2) afeSel = 2;
            //else if (afeSelect == 3) afeSel = 4;
            //else if (afeSelect == 4) afeSel = 8;
            //else afeSel = 0;

            //AnaHostWrite(AnaAddr, afeSel, boardSelect);

            //uint afeWriteAddr;
            //uint afeWriteData;

            //afeWriteAddr = 0x81000004;
            //afeWriteData = ((addr & 0xff) << 16) + data;
            //AnaHostWrite(afeWriteAddr, afeWriteData, boardSelect);
        }

        public void Afe5809HostWrite(uint addr, uint data, int boardSelect, int afeSelect, StreamWriter fw)
        {
            //fm.debug_text.AppendText("\r\n" + "Write [ANA" + boardSelect.ToString() + "_AFE" + afeSelect.ToString() + "]Addr: " + addr.ToString("X8") + ", Data:" + data.ToString("X8"));
            debugPrint(addr, data, "AFE", true);
            ////afe select
            //uint afeSel;
            //uint AnaAddr = 0x81000003;
            //if (afeSelect == 0) afeSel = 15;
            //else if (afeSelect == 1) afeSel = 1;
            //else if (afeSelect == 2) afeSel = 2;
            //else if (afeSelect == 3) afeSel = 4;
            //else if (afeSelect == 4) afeSel = 8;
            //else afeSel = 0;

            //AnaHostWrite(AnaAddr, afeSel, boardSelect, fw);

            //uint afeWriteAddr;
            //uint afeWriteData;

            //afeWriteAddr = 0x81000004;
            //afeWriteData = ((addr & 0xff) << 16) + data;
            //AnaHostWrite(afeWriteAddr, afeWriteData, boardSelect, fw);
        }

        public byte[] Afe5809HostRead(uint addr, int boardSelect, int afeSelect)
        {
            //fm.debug_text.AppendText("\r\n" + "Read [ANA" + boardSelect.ToString() + "_AFE" + afeSelect.ToString() + "]Addr: " + addr.ToString("X8"));
            debugPrint(addr, 0, "AFE", false);
            return new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            ////afe select
            //uint afeSel;
            //uint AnaAddr = 0x81000003;
            //if (afeSelect == 0) afeSel = 15;
            //else if (afeSelect == 1) afeSel = 1;
            //else if (afeSelect == 2) afeSel = 2;
            //else if (afeSelect == 3) afeSel = 4;
            //else if (afeSelect == 4) afeSel = 8;
            //else afeSel = 0;

            //AnaHostWrite(AnaAddr, afeSel, boardSelect);

            //uint afeWriteAddr;
            //uint afeWriteData;

            //afeWriteAddr = 0x81000004;
            //afeWriteData = ((addr & 0xff) << 16) + 0x0000;
            //AnaHostWrite(afeWriteAddr, afeWriteData, boardSelect);
            ////Thread.Sleep(100);

            //Thread.Sleep(1);
            //AnaAddr = 0x81000005;
            //byte[] result = AnaHostRead(AnaAddr, boardSelect);

            //return result;
        }

        public byte[] Afe5809HostRead(uint addr, int boardSelect, int afeSelect, StreamWriter fw)
        {
            //fm.debug_text.AppendText("\r\n" + "Read [ANA" + boardSelect.ToString() + "_AFE" + afeSelect.ToString() + "]Addr: " + addr.ToString("X8"));
            debugPrint(addr, 0, "AFE", false);
            return new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };

            ////afe select
            //uint afeSel;
            //uint AnaAddr = 0x81000003;
            //if (afeSelect == 0) afeSel = 15;
            //else if (afeSelect == 1) afeSel = 1;
            //else if (afeSelect == 2) afeSel = 2;
            //else if (afeSelect == 3) afeSel = 4;
            //else if (afeSelect == 4) afeSel = 8;
            //else afeSel = 0;

            //AnaHostWrite(AnaAddr, afeSel, boardSelect, fw);

            //uint afeWriteAddr;
            //uint afeWriteData;

            //afeWriteAddr = 0x81000004;
            //afeWriteData = ((addr & 0xff) << 16) + 0x0000;
            //AnaHostWrite(afeWriteAddr, afeWriteData, boardSelect, fw);
            //Thread.Sleep(100);

            //WaitTimeAfeRead(10, fw);
            //Thread.Sleep(100);
            //AnaAddr = 0x81000005;
            //byte[] result = AnaHostRead(AnaAddr, boardSelect);

            //return result;
        }

        public void WaitTimeBpiRead(int dummyCycle)
        {
            for(int i = 0; i < dummyCycle; i++)
            {
                RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TEST_REGISTER")], 0x0);
            }
        }

        public void WaitTimeBpiRead(int dummyCycle, StreamWriter fw)
        {
            for (int i = 0; i < dummyCycle; i++)
            {
                RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TEST_REGISTER")], 0x0, fw);
            }
        }

        public void WaitTimeAfeRead(int dummyCycle, StreamWriter fw)
        {
            for (int i = 0; i < dummyCycle; i++)
            {
                AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_MODE")], 0x0, 0, fw);
            }
        }
    }
}
