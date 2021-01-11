
using System.Threading;
using System.Windows.Forms;


namespace AnalogJigTestApplication
{
    class RpcSpiInterface
    {
	    MainForm fm;
		HostInterface hostInterface;

		private const byte RPC_MOSI_ADDR = 0x9C;
		private const byte RPC_MISO_ADDR = 0xA0;
		private const byte RPC_SPI_EN_ADDR = 0xA4;
        private int delay = 0;

		public RpcSpiInterface(MainForm fm, HostInterface hostInterface)
        {
			this.fm = fm;
			this.hostInterface = hostInterface;
		}

		public void RpcSpiInitialization()
		{
			hostInterface.RtcHostWrite(RPC_SPI_EN_ADDR, 0x00);
			RpcSpiWriteCommand(0x01, 0x00, 0x01);
			RpcSpiWriteCommand(0x02, 0x00, 0x03);
		}

		public void RpcSpiWrite(byte data)
        {
            hostInterface.RtcHostWrite(RPC_MOSI_ADDR, data);
            hostInterface.RtcHostWrite(RPC_SPI_EN_ADDR, 0x01);
            hostInterface.RtcHostWrite(RPC_SPI_EN_ADDR, 0x00);

            fm.Invoke(new MethodInvoker(delegate () {
                delay = fm.RPC_WR_DELAY_TRACK.Value;
            }));
            Thread.Sleep(delay);
		}

		public byte[] RpcSpiRead()
		{
            hostInterface.RtcHostWrite(RPC_MOSI_ADDR, 0x00);
            hostInterface.RtcHostWrite(RPC_SPI_EN_ADDR, 0x01);
            hostInterface.RtcHostWrite(RPC_SPI_EN_ADDR, 0x00);

            fm.Invoke(new MethodInvoker(delegate () {
                delay = fm.RPC_WR_DELAY_TRACK.Value;
            }));
            Thread.Sleep(delay);

            return hostInterface.RtcHostRead(RPC_MISO_ADDR, "Rtc");
		}

		public void RpcSpiWriteCommand(byte command, byte hdata, byte ldata)
		{
			command = (byte)(command & 0xff);
			byte not_command = (byte)(0xff - command);

            fm.Invoke(new MethodInvoker( delegate() {
                fm.debug_text.AppendText("\r\n" + "Write [RPC]Command: " + command.ToString("X8") + ", HData:" + hdata.ToString("X8") + ", LData:" + ldata.ToString("X8"));
                //fm.debug_text.AppendText("\r\n"+"command: " + "0x" + string.Format("{0:x2}", command));
                //fm.debug_text.AppendText("\r\n" + "not_command: " + "0x" + string.Format("{0:x2}", not_command));
                //fm.debug_text.AppendText("\r\n" + "HDATA: " + "0x" + string.Format("{0:x2}", hdata));
                //fm.debug_text.AppendText("\r\n" + "LDATA: " + "0x" + string.Format("{0:x2}", ldata));
            }));
            
            //RpcSpiWrite(command);
			//RpcSpiWrite(not_command);
			//RpcSpiWrite(hdata);
			//RpcSpiWrite(ldata);
		}

		//void test()
		//      {

		//	uint RPC_MISO_ADDR = 0x2000;
		//	uint RPC_SS_ADDR = 0x1000;
		//	uint RPC_MOSI_SCLK_ADDR = 0x3000;
		//	uint MIG_7SERIES_0_BASEADDR = 0x0000;

		//	int i;
		//	ulong[] rdata= new ulong[128];

		//	//init_platform();

		//	//xil_printf("RPC SPI ..........\n\r");
		//	//Xil_Out8(RPC_SS_ADDR, 0x1); // RPC SPI initialize

		//	RPC_command_write(0x01, 0x0001);     // set to remote mode
		//	RPC_command_write(0x02, 0x0003);     // RUS & RPC power switch on
		//	RPC_command_write(0x02, 0x000C);     // GDP & VTX power switch on
		//	RPC_command_write(0x05, 0x0064);     // set VTX to 10.0 volts
		//										 //RPC_command_write(0x05, 0x0320);     // set VTX to 80.0 volts

		//	//xil_printf("UART Display ..........\n\r");

		//	//xil_printf("DDR3 Test ..........\n\r");
		//	for (i = 0; i < 32; i++)
		//	{
		//		// RTC Read로 대체
		//		//*(BufferPtr + i) = i;
		//		//xil_printf("DDR3 Data[%02x] = %02x\n\r", i, BufferPtr[i]);
		//	}
		//	//xil_printf("DDR3 Test done\n\r");


		//	//cleanup_platform();
		//}

		//void spi_write_1byte(byte data)
		//{
		//	int i;
		//	byte[] buff = new byte[8];

		//	for (i = 0; i < 8; i++)
		//	{
		//		buff[i] = (byte)((data >> (7 - i) & 0xff)  & 0x01);
		//	}

		//	//Xil_out -> rtc write로 대체
		//	//Xil_Out8(RPC_SS_ADDR, 0x0); //ss low

		//	for (i = 0; i < 8; i++)
		//	{
		//		//Xil_Out8(RPC_MOSI_SCLK_ADDR, (buff[i] << 1) + 0x0); // mosi, sclk low
		//		//Xil_Out8(RPC_MOSI_SCLK_ADDR, (buff[i] << 1) + 0x1); // mosi, sclk low
		//	}
		//	//Xil_Out8(RPC_SS_ADDR, 0x1); //ss high
		//}

		//void RPC_command_write(byte addr, int data)
		//{
		//	byte data_h, data_l;
		//	data_h = (byte)((data >> 8) & 0xff);
		//	data_l = (byte)((data >> 0) & 0xff);
		//	byte saddr = (byte)(0xff - addr);  

		//	spi_write_1byte(addr);
		//	spi_write_1byte(saddr);
		//	spi_write_1byte(data_h);
		//	spi_write_1byte(data_l);
		//}

	}
}
