using System;
using System.Runtime.InteropServices;

namespace AnalogJigTestApplication
{
    public class XDMAImportDLL
    {
        [DllImport(@"..\..\..\settingFile\XDMA_dll\xdma_rw_dll.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "path_select_rw")]
        public static extern IntPtr XDMAInterface(int argc, string[] argv);
    }

    class PcieInterface
    {
        public string UintToHexLittleEndian(UInt32 _iValue, int index)
        {
            string sBigEndian = String.Format("{0:x" + (4 * 2).ToString() + "}", _iValue);
            //Console.WriteLine("sBigEndian = {0}", sBigEndian);
            string sLittleEndian = "";
            sLittleEndian += "0x" + sBigEndian.Substring(index * 2, 2) + " ";
            //Console.WriteLine(sLittleEndian);

            return sLittleEndian;
        }

        public void XDMAAcqWrite(string device, UInt64 address, UInt32 data)
        {
            string[] argv = new string[11];
            argv[0] = "xdma_rw.exe";
            argv[1] = device;
            argv[2] = "h2c_0";
            argv[3] = "write";
            argv[4] = "0x" + String.Format("{0:x}", address);
            argv[5] = "-l";
            argv[6] = Convert.ToString(4, 10);
            argv[7] = UintToHexLittleEndian(data, 3);
            argv[8] = UintToHexLittleEndian(data, 2);
            argv[9] = UintToHexLittleEndian(data, 1);
            argv[10] = UintToHexLittleEndian(data, 0);
            IntPtr readDataPtr;
            readDataPtr = XDMAImportDLL.XDMAInterface(11, argv);
        }

        public IntPtr XDMAAcqRead(string device, UInt64 address, UInt32 size)
        {
            string[] argv = new string[7];
            argv[0] = "xdma_rw.exe";
            argv[1] = device;
            argv[2] = "c2h_0";
            //argv[2] = "bypass";
            argv[3] = "read";
            argv[4] = "0x" + String.Format("{0:x}", address);
            argv[5] = "-l";
            argv[6] = Convert.ToString(size, 10);

            return XDMAImportDLL.XDMAInterface(7, argv);
        }

        public void XDMARtcWrite(byte data, UInt64 address)
        {
            string[] argv = new string[6];
            argv[0] = "xdma_rw.exe";
            //argv[1] = "dev_7024";
            argv[1] = "subsys_00071000";
            //argv[2] = "h2c_0";
            argv[2] = "bypass";
            argv[3] = "write";
            argv[4] = "0x" + String.Format("{0:x}", address);
            argv[5] = "0x" + String.Format("{0:x2}" , data); 
            IntPtr readDataPtr;
            readDataPtr = XDMAImportDLL.XDMAInterface(6, argv);
        }

        public void XDMARtcWrite(UInt32 data, UInt64 address)
        {
            string[] argv = new string[11];
            argv[0] = "xdma_rw.exe";
            //argv[1] = "dev_7024";
            argv[1] = "subsys_00071000";
            //argv[2] = "h2c_0";
            argv[2] = "bypass";
            argv[3] = "write";
            argv[4] = "0x" + String.Format("{0:x}", address);
            argv[5] = "-l";
            argv[6] = Convert.ToString(4, 10);
            argv[7] = UintToHexLittleEndian(data, 3);
            argv[8] = UintToHexLittleEndian(data, 2);
            argv[9] = UintToHexLittleEndian(data, 1);
            argv[10] = UintToHexLittleEndian(data, 0);
            IntPtr readDataPtr;
            readDataPtr = XDMAImportDLL.XDMAInterface(11, argv);
        }

        public IntPtr XDMARtcRead(Int64 address)
        {
            string[] argv = new string[7];
            argv[0] = "xdma_rw.exe";
            //argv[1] = "dev_7024";
            argv[1] = "subsys_00071000";
            //argv[2] = "c2h_0";
            argv[2] = "bypass";
            argv[3] = "read";
            argv[4] = "0x" + String.Format("{0:x}", address);
            argv[5] = "-l";
            argv[6] = Convert.ToString(4, 10);
            //Console.WriteLine(argv[6]);

            return XDMAImportDLL.XDMAInterface(7, argv);
        }
    }
}
