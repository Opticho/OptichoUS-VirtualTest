using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
//using MathWorks.MATLAB.NET.Arrays;
//using MathWorks.MATLAB.NET.Utility;
//using MatlabFunction;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.ExceptionServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms.VisualStyles;
using WorkTimer = System.Timers.Timer;
using UITimer = System.Windows.Forms.Timer;

namespace AnalogJigTestApplication
{
    public partial class MainForm : Form
    {
        // seiyon check     

        /// <summary>
        /// Declare global variable, Initializing UI, Load data
        /// </summary>

        /// <summary>
        /// 변수 선언 및 초기화 작업.
        /// 전역변수로 사용되는 변수.
        /// </summary>
        #region Global Value in Class Form1

        // initial form
        InitialForm initForm = new InitialForm();

        //initialize setting path
        PathInfo PI = new PathInfo();

        RegisterInfo rtcRegisterInfo = new RegisterInfo();
        RegisterInfo AcqRegisterInfo = new RegisterInfo();
        RegisterInfo AnaRegisterInfo = new RegisterInfo();
        RegisterInfo AfeRegisterInfo = new RegisterInfo();
        
        PcieInterface pcieInterface;
        SerialPortConnection serialPortConnection;
        HostInterface hostInterface;
        RpcSpiInterface rpcSpiInterface;

        public Point[] points = new Point[64];

        //tgc test
        double[] y = new double[8];
        double[] x = new double[8];
        double interval = 0;

        //MatlabClass matlab = new MatlabClass();
        
        //System Parameter
        int steerAngle;
        int systemChannel;
        double txFrequency;
        int txBurst;

        //Tx Parameter
        public uint[] BPulseShape = new uint[8];
        public uint BPulseCommand = new uint();
        UInt32[] TXDelay;

        TxParameterGeneration txParameterGeneration = new TxParameterGeneration();

        //Ultra Sonic tab var
        Graphics g;                   // Graphics of the panel object
        public static int width = 512;
        public static int height = 512;       // Dimensions of the bitmap

        int G_DATA = 0;
        public static Bitmap bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format8bppIndexed); // Bitmap object
        public static ColorPalette colorPalette = bmp.Palette;
        Color[] colors = colorPalette.Entries;
        public static BitmapData bmd = new BitmapData();
        IntPtr pNative;// = bmd.Scan0;
        //string G_MODE = "US";
        int G_SEQUENCE = 1;
        //int G_SCAN_MODE = 1;
        int G_SPEED = 1;
        int pixelCount = -1;

        //image data
        //byte[] ImageFile_Byte = new Byte[896 * 596 * 3];
        byte[] ImageFile_Byte = new Byte[896 * 596 * 3];
        //short[] RData = new short[4096 * 128];
        byte[] OutputData = new Byte[width * height];
        
        //afe tool tip
        ToolTip tooltip = new ToolTip();
        //Point? mousePosition = null;

        //Make Image Process obj
        ImageProcess imageProcess;
        
        //sw : scan performance timer in the Application level
        Stopwatch sw = new Stopwatch();
        Stopwatch sw2 = new Stopwatch();

        //host test Timer using worker thread
        WorkTimer hostTestTimer = new WorkTimer();
        //Scan Timer using ui thread
        UITimer scanTimer = new UITimer();
        //VTX Voltage Control timer using worker thread
        WorkTimer VTXTimer = new WorkTimer();
        uint VTXData = 0;

        //host test byte : test memory to communicate with OptichoUS used by PCIe
        //uint hostTestAddr =0;
        byte[] hostTestByte = new byte[4];
        Bitmap redBitMap = Properties.Resources.Red;
        Bitmap greenBitMap = Properties.Resources.Green;

        #endregion

        /// <summary>
        /// Form1() function.
        /// ui object 초기화, 이벤트 핸들러, 트리거 정의
        /// </summary>
        #region Initialize GUI
        public MainForm()
        {
            initForm.Show();

            initForm.CalculateProcessBar("initializing GUI", 10);
            InitializeComponent();

            //host rutine test timer
            hostTestTimer.Interval = 2500;
            hostTestTimer.Elapsed += new System.Timers.ElapsedEventHandler(hostTestTimer_Tick);
            hostTestTimer.Enabled = true;

            //scan timer
            scanTimer.Interval = 1;
            scanTimer.Tick += new EventHandler(Timer_Tick);
            scanTimer.Tick += new EventHandler(FrameDelayUpdate);
            scanTimer.Enabled = false;

            //HV Control timer
            VTXTimer.Interval = 100; //100ms delay
            VTXTimer.Elapsed += new System.Timers.ElapsedEventHandler(VTXTimer_tick);
            VTXTimer.Enabled = false;

        }
        #endregion

        /// <summary>
        /// Form1_Load(sender, e) function.
        /// Version, File path update, Excel data read.
        /// PCIE XDMA 클래스 생성자, Serial Port 클래스 생성자.
        /// TGC 변수 선언, TGC 그래프 초기화, Tx Pulse 변수 선언 및 계산, Tx Pulse 그래프 초기화
        /// PLL(Phase Locked Loop) 초기화
        /// AFE5809 초기화
        /// RPC(RUS Power Controller) 초기화
        /// AFE Register grid map 로드
        /// </summary>
        #region Load Data
        private void Form1_Load(object sender, EventArgs e)
        {
            initForm.CalculateProcessBar("Version Check", 5);
            //Version Check
            VersionCheck();

            initForm.CalculateProcessBar("search excel File Path", 5);
            //Update Xlsx File Path
            FilePathUpdate();

            initForm.CalculateProcessBar("Opening Excel file...", 10);
            //open xlsx file
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(PathInfo.excelPath);

            initForm.CalculateProcessBar("Loading RTC Register Value...", 5);
            rtcRegisterInfo.RegisterUpdate("Rtc_FPGA", xlWorkBook);

            initForm.CalculateProcessBar("Loading ACQ Register Value...", 5);
            AcqRegisterInfo.RegisterUpdate("Acquisition_FPGA", xlWorkBook);

            initForm.CalculateProcessBar("Loading ANA Register Value...", 5);
            AnaRegisterInfo.RegisterUpdate("Analog_FPGA", xlWorkBook);

            initForm.CalculateProcessBar("Loading AFE5809 Register Value...", 5);
            AfeRegisterInfo.RegisterUpdate("AFE5809", 1, xlWorkBook); //critical time waste

            //Release com objects to fully kill excel process from running in the background
            xlWorkBook.Close();
            Marshal.ReleaseComObject(xlWorkBook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            initForm.CalculateProcessBar("Initializing Interface...", 25);
            pcieInterface = new PcieInterface();

            //Make serialPortConnection Object 
            serialPortConnection = new SerialPortConnection(this);
            serialPortConnection.SerialPortSearch();

            //Make Hostinteface Object
            hostInterface = new HostInterface(this, pcieInterface ,serialPortConnection, rtcRegisterInfo, AcqRegisterInfo, AnaRegisterInfo);
            rpcSpiInterface = new RpcSpiInterface(this, hostInterface);

            initForm.CalculateProcessBar("System Configuration", 15);
            //System Configuration
            SystemConfiguration();

            //Tgc Configuration
            TgcSetup();
            TgcDepthUpdate();
            TgcChartUpdate();
            TgcPointCalculator();
                        
            //Tgc test config
            TgcTestGraphUpdate();
            TgcTestDrawGraph();
            
            //TX Delay & TX Pulse
            TxDelayUpdate();
            TxPulseUpdate();
            TxWaveDrawingInit();
            TxWaveDrawing();

            initForm.CalculateProcessBar("Reset OptichoUS Equipment...", 5);
            PLLReset();
            Thread.Sleep(100);
            Afe5809Reset();
            Thread.Sleep(100);
            rpcSpiInterface.RpcSpiInitialization();

            initForm.CalculateProcessBar("Processing DataGridView for AFE5809...", 2);
            //Initialize AFE5809 Register MAP
            SetupDataGridView(AfeRegisterInfo.registerAddr, AfeRegisterInfo.registerDefault, AfeRegisterInfo.registerFunction);

            initForm.CalculateProcessBar("Initializing US Scanning Panel...", 2);
            //Ultra Sonic tab
            g = US_FRAME.CreateGraphics();
            scanTimer.Stop();
            
            initForm.CalculateProcessBar("Wait a second...", 1);
            Thread.Sleep(1000);

            initForm.Close();
            initForm.Dispose();
        }
        #endregion

        private void debugPrint(string var)
        {
            Invoke(new MethodInvoker(() => { debug_text.AppendText(var); }));
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        /// TAB name: System Test
        ///////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Device reset function and System Configuration function
        /// EX) PLL reset, Acquisition init, AFE5809 init, System Configuration, saving debug text 
        /// </summary>
        #region Reset Function and System Configure Function

        public void PLLReset()
        {
            hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_BF_FPGA_PLL_RST")], 0x0);
            hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_BF_FPGA_PLL_RST")], 0x3);
            hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_BF_FPGA_PLL_RST")], 0x0);
            Thread.Sleep(500); //wait Acqusition PLL done
        }

        public void AcquisitionReset()
        {
            for (int i = 0; i < 4; i++)
            {
                hostInterface.AcqHostWrite(AnaRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_SERDES_RESET")], 0, i);
                hostInterface.AcqHostWrite(AnaRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_SERDES_RESET")], 1, i);
                hostInterface.AcqHostWrite(AnaRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_SERDES_RESET")], 0, i);

                hostInterface.AcqHostWrite(AnaRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_AXI_BUFFER_FIFO_RST")], 0, i);
                hostInterface.AcqHostWrite(AnaRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_AXI_BUFFER_FIFO_RST")], 1, i);
                hostInterface.AcqHostWrite(AnaRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_AXI_BUFFER_FIFO_RST")], 0, i);

                hostInterface.AcqHostWrite(AnaRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_MOVER_FIFO_RST")], 0, i);
                hostInterface.AcqHostWrite(AnaRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_MOVER_FIFO_RST")], 1, i);
                hostInterface.AcqHostWrite(AnaRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_MOVER_FIFO_RST")], 0, i);

                hostInterface.AcqHostWrite(AnaRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_MOVER_RST")], 0, i);
                hostInterface.AcqHostWrite(AnaRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_MOVER_RST")], 1, i);
                hostInterface.AcqHostWrite(AnaRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_MOVER_RST")], 0, i);
            }
            Thread.Sleep(100);
        }

        public void Afe5809Reset()
        {
            for (int i = 0; i < 4; i++)
            {
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_RESET")], 0, i);
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_RESET")], 1, i);
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_RESET")], 0, i);

                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_FIFO_RST")], 0, i);
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_FIFO_RST")], 1, i);
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_FIFO_RST")], 0, i);
            }
            Thread.Sleep(100);
        }

        public void SystemConfiguration()
        {
            int viewDepth = Convert.ToInt32(SYS_VIEW_DEPTH_TXT.Text, 10);
            int frameCount = Convert.ToInt32(SYS_FRAME_COUNT_TXT.Text, 10);
            int prfCount = Convert.ToInt32(SYS_PRF_COUNT_TXT.Text, 10);

            C_R_ACQ_RX_LENGTH.Text = (viewDepth * 512).ToString();
            C_R_RTC_PRF_H_LENGTH.Text = (viewDepth * 512 * 5).ToString();
            C_R_RTC_PRF_COUNT.Text = prfCount.ToString();
            C_R_RTC_OFN_COUNT.Text = frameCount.ToString();
        }

        private void BtnSaveDebug_Click(object sender, EventArgs e)
        {
            File.WriteAllText("debug_text.txt",debug_text.Text, Encoding.Default);

            MessageBox.Show("Save Text Success","save success");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            debug_text.Clear();
        }

        #endregion

        /// <summary>
        /// TGC setup, drawing curve
        /// EX) TGC setup, update
        /// </summary>
        #region TGC Function
        private void TgcSetup()
        {
            int viewDepth = Convert.ToInt32(SYS_VIEW_DEPTH_TXT.Text, 10);
            //int rxLength = (viewDepth * 512);

            TGC_MIN_TRACK.Maximum = viewDepth;
            TGC_MIN_TRACK.Minimum = 0;

            TGC_MAX_TRACK.Maximum = viewDepth;
            TGC_MAX_TRACK.Minimum = 0;
        }

        private void TgcChartUpdate()
        {
            int viewDepth = Convert.ToInt32(SYS_VIEW_DEPTH_TXT.Text, 10);

            TGC_GRAPH.ChartAreas[0].AxisX.Minimum = 0;
            TGC_GRAPH.ChartAreas[0].AxisY.Minimum = 0;

            TGC_GRAPH.ChartAreas[0].AxisX.Maximum = viewDepth;
            TGC_GRAPH.ChartAreas[0].AxisY.Maximum = 1023;

            TGC_GRAPH.ChartAreas[0].AxisX.Interval = 1;
            TGC_GRAPH.ChartAreas[0].AxisY.Interval = 128;

            TGC_GRAPH.ChartAreas[0].AxisX.Title = "Depth(Cm)";
            TGC_GRAPH.ChartAreas[0].AxisY.Title = "Gain";

            TGC_GRAPH.ChartAreas[0].BorderWidth = 3;

            TGC_GRAPH.Text = "TGC Control";
            //chart1.BackColor = Color.Gray;
        }

        private void TgcPointCalculator()
        {
            int viewDepthCount = 512;
            int viewDepth = Convert.ToInt32(SYS_VIEW_DEPTH_TXT.Text, 10);
            int minGain = Convert.ToInt32(ATGC_MIN.Text, 10);
            int maxGain = Convert.ToInt32(ATGC_MAX.Text, 10);

            int temp = 0;


            for (int i = 0; i < viewDepth + 1; i++)
            {
                points[i].X = i;
                if (minGain == maxGain)
                {
                    points[i].Y = minGain;
                }
                else
                {
                    if (i <= TGC_MIN_TRACK.Value)
                    {
                        points[i].Y = minGain;
                    }
                    else if (i >= TGC_MAX_TRACK.Value)
                    {
                        points[i].Y = maxGain;
                    }
                    else
                    {
                        temp++;
                        points[i].Y = minGain + (((maxGain - minGain) / (TGC_MAX_TRACK.Value - TGC_MIN_TRACK.Value)) * temp);
                    }
                }
            }

            for (int i = 0; i < viewDepth + 1; i++)
            {
                TGC_GRAPH.Series[0].Points.AddXY(points[i].X, points[i].Y);
            }

            C_R_RTC_TGC_MIN.Text = minGain.ToString();
            C_R_RTC_TGC_MAX.Text = maxGain.ToString();
            C_R_RTC_TGC_MIN_COUNT.Text = (TGC_MIN_TRACK.Value * viewDepthCount).ToString();
            double incrValue = ((double)maxGain - (double)minGain) / (((double)TGC_MAX_TRACK.Value - (double)TGC_MIN_TRACK.Value) * (double)viewDepthCount);
            double incrValueTemp = MathMethod.HW_FORMAT(incrValue, 'u', 10, 16) * 65536;
            C_R_RTC_TGC_INCR.Text = incrValueTemp.ToString();
        }

        private void TGCTextChanged(object sender, EventArgs e)
        {
            ClearSeries();
            TgcPointCalculator();
        }

        private void ClearSeries()
        {
            TGC_GRAPH.Series[0].Points.Clear();
        }
        
        private void TgcDepthUpdate()
        {
            ATGC_MIN_DEPTH.Text = TGC_MIN_TRACK.Value.ToString() + Environment.NewLine + "Cm";
            ATGC_MAX_DEPTH.Text = TGC_MAX_TRACK.Value.ToString() + Environment.NewLine + "Cm";
        }
        
        private void SysConfigTextChanged(object sender, EventArgs e)
        {
            int temp = 0;
            if (!int.TryParse(SYS_VIEW_DEPTH_TXT.Text, out temp))
            {
                debug_text.AppendText("SYS_VIEW_DEPTH Error: " + temp.ToString() + "\r\n");
                return;
            }

            SystemConfiguration();
            TgcSetup();
            TgcDepthUpdate();
            TgcChartUpdate();
            ClearSeries();
            TgcPointCalculator();

            //update tgc test func
            TgcTestGraphUpdate();
            TgcTestDrawGraph();
        }

        private void TGCTrackScroll(object sender, EventArgs e)
        {
            TgcDepthUpdate();
            TgcChartUpdate();
            ClearSeries();
            TgcPointCalculator();
        }
               
        #endregion

        /// <summary>
        /// Tx Pulse setup
        /// drawing of Tx Delay & Tx Pulse
        /// EX) Tx setup, update
        /// </summary>
        #region Tx Setting Function

        private void TxDelayUpdate()
        {
            steerAngle = Convert.ToInt32(SYS_STEER_ANGLE_TXT.Text, 10);
            systemChannel = Convert.ToInt32(SYS_CHANNEL_TXT.Text, 10);

            TXDelay = new UInt32[systemChannel];

            TXDelay = txParameterGeneration.TxDelayCalcualtor(systemChannel, steerAngle);

            TX_DELAY_RICHTXT.Clear();
            for (int i = 0; i < TXDelay.Count(); i++)
            {
                string strTemp = "Channel" + i.ToString() + " : " + TXDelay[i].ToString() + Environment.NewLine;
                TX_DELAY_RICHTXT.AppendText(strTemp);
                TX_DELAY_RICHTXT.ScrollToCaret();
            }
        }

        private void SysChannelTextChanged(object sender, EventArgs e)
        {
            TxDelayUpdate();
        }

        private void TxPulseUpdate()
        {
            txFrequency = Convert.ToDouble(SYS_TX_FREQ_TXT.Text);
            txBurst = Convert.ToInt32(SYS_TX_PULSE_BURST_TXT.Text, 10);
            BPulseShape = txParameterGeneration.TxPulseGenerator(txFrequency);
            BPulseCommand = (uint)((txBurst << 9) + (1 << 6) + 1);

            C_R_TX_B_TX_PC.Text = BPulseCommand.ToString();
            C_R_TX_B_TX_PS0.Text = BPulseShape[0].ToString();
            C_R_TX_B_TX_PS1.Text = BPulseShape[1].ToString();
            C_R_TX_B_TX_PS2.Text = BPulseShape[2].ToString();
            C_R_TX_B_TX_PS3.Text = BPulseShape[3].ToString();
            C_R_TX_B_TX_PS4.Text = BPulseShape[4].ToString();
            C_R_TX_B_TX_PS5.Text = BPulseShape[5].ToString();
            C_R_TX_B_TX_PS6.Text = BPulseShape[6].ToString();
            C_R_TX_B_TX_PS7.Text = BPulseShape[7].ToString();
        }

        private void SysTxConfigTextChanged(object sender, EventArgs e)
        {
            TxPulseUpdate();
            //TxWaveDrawingInit();
            TxWaveDrawing();
        }

        public void TxWaveDrawingInit()
        {
            int chartAxisXMin = 0;
            int chartAxisXMax = 0;

            for (int i = 0; i < BPulseShape.Count(); i++)
            {
                chartAxisXMax += ((int)BPulseShape[i] >> 1) + 3;
            }

            chartAxisXMax = chartAxisXMax * ((((int)BPulseCommand) & 0x3E00) >> 9);

            TX_PULSE_GRAPH.ChartAreas[0].AxisX.Minimum = chartAxisXMin;

            TX_PULSE_GRAPH.ChartAreas[0].AxisY.Maximum = +2;
            TX_PULSE_GRAPH.ChartAreas[0].AxisY.Minimum = -2;

            TX_PULSE_GRAPH.ChartAreas[0].AxisX.Interval = 1;
            TX_PULSE_GRAPH.ChartAreas[0].AxisY.Interval = 1;
        }

        public void TxWaveDrawing()
        {
            List<Point> DebugPoint = new List<Point>();
            Point pTemp = new Point();
            int[] pulseLength = new int[8];
            int[] pulseData = new int[8];
            int pulseEnd;
            int burstStart;
            int burstEnd;
            int burstLength;

            pulseEnd = ((((int)BPulseCommand) & 0x0007));
            burstStart = ((((int)BPulseCommand) & 0x00038) >> 3);
            burstEnd = ((((int)BPulseCommand) & 0x001C0) >> 6);
            burstLength = ((((int)BPulseCommand) & 0x3E00) >> 9);
            for (int i = 0; i < BPulseShape.Count(); i++)
            {
                pulseLength[i] = ((int)BPulseShape[i] >> 1) & 0xFF;
                pulseData[i] = ((int)BPulseShape[i] & 1);
            }

            if (burstStart % 2 == 1)
            {
                MessageBox.Show("Burst start Parameter setting Error. Always select 0 or 2 or 4 or 6");
                return;
            }

            if (burstEnd % 2 == 0)
            {
                MessageBox.Show("Burst End Parameter setting Error. Always select 1 or 3 or 5 or 7");
                return;
            }

            if (pulseEnd % 2 == 0)
            {
                MessageBox.Show("Pulse End Parameter setting Error. Always select 1 or 3 or 5 or 7");
                return;
            }

            int x = 0;
            int y = 0;
            int length = 0;
            int temp = 0;

            pTemp.X = 0;
            pTemp.Y = 0;
            DebugPoint.Add(pTemp);

            if (burstStart > pulseEnd)
            {
                for (int i = 0; i <= pulseEnd; i++)
                {
                    for (int k = 1; k <= pulseLength[i]; k++)
                    {
                        temp = length + k;
                        y = pulseData[i];
                        x = temp;
                        if (y == 0)
                        {
                            y = -1;
                        }
                        pTemp.X = temp;
                        pTemp.Y = y;
                        DebugPoint.Add(pTemp);
                    }
                    length = length + pulseLength[i];
                }
                pTemp.X = length + 1;
                pTemp.Y = 0;
                DebugPoint.Add(pTemp);

                pTemp.X = length + 2;
                pTemp.Y = 0;
                DebugPoint.Add(pTemp);
            }
            else
            {
                for (int i = 0; i < burstStart; i++)
                {
                    for (int k = 1; k <= pulseLength[i]; k++)
                    {
                        temp = length + k;
                        y = pulseData[i];
                        x = temp;
                        if (y == 0)
                        {
                            y = -1;
                        }
                        pTemp.X = temp;
                        pTemp.Y = y;
                        DebugPoint.Add(pTemp);
                    }
                    length = length + pulseLength[i];
                }

                for (int i = 0; i < burstLength; i++)
                {
                    for (int j = burstStart; j <= burstEnd; j++)
                    {
                        for (int k = 1; k <= pulseLength[j]; k++)
                        {
                            temp = length + k;
                            y = pulseData[j];
                            x = temp;
                            if (y == 0)
                            {
                                y = -1;
                            }
                            pTemp.X = temp;
                            pTemp.Y = y;
                            DebugPoint.Add(pTemp);
                        }
                        length = length + pulseLength[j];
                    }
                }

                for (int i = burstEnd + 1; i <= pulseEnd; i++)
                {
                    for (int k = 1; k <= pulseLength[i]; k++)
                    {
                        temp = length + k;
                        y = pulseData[i];
                        x = temp;
                        if (y == 0)
                        {
                            y = -1;
                        }
                        pTemp.X = temp;
                        pTemp.Y = y;
                        DebugPoint.Add(pTemp);
                    }
                    length = length + pulseLength[i];
                }

                pTemp.X = length + 1;
                pTemp.Y = 0;
                DebugPoint.Add(pTemp);

                pTemp.X = length + 2;
                pTemp.Y = 0;
                DebugPoint.Add(pTemp);

            }

            TX_PULSE_GRAPH.Series[0].Points.Clear();

            for (int i = 0; i < DebugPoint.Count(); i++)
            {
                TX_PULSE_GRAPH.Series[0].Points.AddXY(DebugPoint[i].X, DebugPoint[i].Y);
            }
        }
        #endregion

        /// <summary>
        /// Test Start, Done
        /// EX) System Test Start, Test done, Test Host read/write
        /// </summary>
        #region System Test Function

        private string ByteToString(byte[] strByte)
        {
            string str = Encoding.UTF8.GetString(strByte);
            str = strByte[3].ToString("X2") + strByte[2].ToString("X2") + strByte[1].ToString("X2") + strByte[0].ToString("X2");
            return str;
            //string str = Encoding.Default.GetString(strByte);
            //return str;
        }

        private void BtnSystemTestStart_Click(object sender, EventArgs e)
        {
            hostTestTimer.Enabled = false;
            //StreamWriter hostVector = new StreamWriter("hostVector.txt");
            //SystemHostReadWrite(hostVector);
            //hostVector.Close();
            bool debugRegister = true;
            StreamWriter testVector = new StreamWriter("testVector.txt");

            //Acqusition PLL reset
            PLLReset();
            //hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_BF_FPGA_PLL_RST")], 0x0, testVector);
            //hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_BF_FPGA_PLL_RST")], 0x3, testVector);
            //hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_BF_FPGA_PLL_RST")], 0x0, testVector);
            //Thread.Sleep(500); //wait Acqusition PLL done

            //----------------------------------------------------
            //AFE5809 Setup
            //----------------------------------------------------
            Afe5809Reset();
            ////AFE5809 Reset
            //hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_RESET")], 0, 0, testVector);
            //hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_RESET")], 0, 1, testVector);
            //hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_RESET")], 1, 0, testVector);
            //hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_RESET")], 1, 1, testVector);
            //hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_RESET")], 0, 0, testVector);
            //hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_RESET")], 0, 1, testVector);

            ////AFE5809 Control Fifo Reset
            //hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_FIFO_RST")], 0, 0, testVector);
            //hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_FIFO_RST")], 0, 1, testVector);
            //hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_FIFO_RST")], 1, 0, testVector);
            //hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_FIFO_RST")], 1, 1, testVector);
            //hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_FIFO_RST")], 0, 0, testVector);
            //hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_FIFO_RST")], 0, 1, testVector);

            //AFE5809 Register Setup
            for (int i = 0; i < AfeRegisterInfo.registerName.Count(); i++)
            {
                if (AfeRegisterInfo.registerName[i].Contains("DIG"))
                {
                    hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 0, testVector);
                    hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 1, testVector);
                    hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 2, testVector);
                    hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 3, testVector);
                }
                else
                {
                    hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 0, testVector);
                    hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 1, testVector);
                    hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 2, testVector);
                    hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 3, testVector);
                }

                hostInterface.Afe5809HostWrite(AfeRegisterInfo.registerAddr[i], AfeRegisterInfo.registerValue[i], 0, 0);
                hostInterface.Afe5809HostWrite(AfeRegisterInfo.registerAddr[i], AfeRegisterInfo.registerValue[i], 1, 0);
                hostInterface.Afe5809HostWrite(AfeRegisterInfo.registerAddr[i], AfeRegisterInfo.registerValue[i], 2, 0);
                hostInterface.Afe5809HostWrite(AfeRegisterInfo.registerAddr[i], AfeRegisterInfo.registerValue[i], 3, 0);


                if (debugRegister)
                {
                    debug_text.AppendText("Afe5809 addr : " + AfeRegisterInfo.registerAddr[i].ToString("X4") + " Afe5809 data : " + AfeRegisterInfo.registerValue[i].ToString("X4") + "\r\n");
                }
            }

            if (debugRegister)
            {
                for (int i = 0; i < AfeRegisterInfo.registerName.Count(); i++)
                {
                    if (AfeRegisterInfo.registerName[i].Contains("DIG"))
                    {
                        Afe5809DigReadEnable();
                        debug_text.AppendText("Afe5809 addr " + AfeRegisterInfo.registerAddr[i].ToString("X4") + " Afe5809 data : " + ByteToString(hostInterface.Afe5809HostRead(AfeRegisterInfo.registerAddr[i], 2, 1)) + "\r\n");
                        Afe5809DigReadDisable();
                    }
                    else
                    {
                        Afe5809AdcReadEnable();
                        debug_text.AppendText("Afe5809 addr " + AfeRegisterInfo.registerAddr[i].ToString("X4") + " Afe5809 data : " + ByteToString(hostInterface.Afe5809HostRead(AfeRegisterInfo.registerAddr[i], 2, 1)) + "\r\n");
                        Afe5809AdcReadDisable();
                    }
                }
            }

            //MAX14808 Register Setup
            uint max14808Mode;
            uint max14808Cc;

            if (ANA_MAX14808_MODE_COMB.Text == "00") max14808Mode = 0;
            else if (ANA_MAX14808_MODE_COMB.Text == "01") max14808Mode = 1;
            else if (ANA_MAX14808_MODE_COMB.Text == "10") max14808Mode = 2;
            else max14808Mode = 3;

            if (ANA_MAX14808_CC_COMB.Text == "00") max14808Cc = 0;
            else if (ANA_MAX14808_CC_COMB.Text == "01") max14808Cc = 1;
            else if (ANA_MAX14808_CC_COMB.Text == "10") max14808Cc = 2;
            else max14808Cc = 3;

            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_MAX_MODE")], max14808Mode, 0, testVector);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_MAX_MODE")], max14808Mode, 1, testVector);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_MAX_MODE")], max14808Mode, 2, testVector);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_MAX_MODE")], max14808Mode, 3, testVector);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_MAX_CC")], max14808Cc, 0, testVector);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_MAX_CC")], max14808Cc, 1, testVector);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_MAX_CC")], max14808Cc, 2, testVector);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_MAX_CC")], max14808Cc, 3, testVector);

            if (debugRegister)
            {
                debug_text.AppendText("C_R_MAX_MODE : " + ByteToString(hostInterface.AnaHostRead(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_MAX_MODE")], 2)) + "\r\n");
            }

            //----------------------------------------------------
            //Communication FPGA Setup
            //----------------------------------------------------
            //TX DELAY
            for (uint i = 0; i < TXDelay.Count(); i++)
            {
                if (i > 95)
                {
                    hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_DELAY")] + i - 96, TXDelay[i], 3, testVector);
                    if (debugRegister)
                    {
                        debug_text.AppendText("C_R_TX_DELAY[" + (i - 96).ToString() + "] : " + ByteToString(hostInterface.AnaHostRead(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_DELAY")] + i - 96, 3)) + "\r\n");
                    }
                }
                else if (i > 63)
                {
                    hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_DELAY")] + i - 64, TXDelay[i], 2, testVector);
                    if (debugRegister)
                    {
                        debug_text.AppendText("C_R_TX_DELAY[" + (i - 64).ToString() + "] : " + ByteToString(hostInterface.AnaHostRead(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_DELAY")] + i - 64, 2)) + "\r\n");
                    }
                }
                else if (i > 31)
                {
                    hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_DELAY")] + i - 32, TXDelay[i], 1, testVector);
                    if (debugRegister)
                    {
                        debug_text.AppendText("C_R_TX_DELAY[" + (i - 32).ToString() + "] : " + ByteToString(hostInterface.AnaHostRead(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_DELAY")] + i - 32, 1)) + "\r\n");
                    }
                }
                else
                {
                    hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_DELAY")] + i, TXDelay[i], 0, testVector);
                    if (debugRegister)
                    {
                        debug_text.AppendText("C_R_TX_DELAY[" + (i).ToString() + "] : " + ByteToString(hostInterface.AnaHostRead(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_DELAY")] + i, 0)) + "\r\n");
                    }
                }
            }

            for (int j = 0; j < 4; j++)
            {
                //TX Pulse Command & Shpae
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_B_TX_PC")], BPulseCommand, j, testVector);
                for (uint i = 0; i < BPulseShape.Count(); i++)
                {
                    hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_B_TX_PS")] + i, BPulseShape[i] - 1, j, testVector);
                    if (BPulseShape[i] - 1 < 2)
                    {
                        MessageBox.Show("check the pulse shape");
                        break;
                    }
                }

                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_DELAY_SEL")], 0, j, testVector);
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_MODE")], 0, j, testVector);
            }

            //TX Pulse Mask
            if (TX_PULSE_MASK_CHECK.Checked == true)
            {
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_APERTURE")], 0, 0, testVector);
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_APERTURE")], 0, 1, testVector);
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_APERTURE")], 0, 2, testVector);
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_APERTURE")], 0, 3, testVector);
            }
            else
            {
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_APERTURE")], 0xffffffff, 0, testVector);
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_APERTURE")], 0xffffffff, 1, testVector);
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_APERTURE")], 0xffffffff, 2, testVector);
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_APERTURE")], 0xffffffff, 3, testVector);
            }

            //----------------------------------------------------
            //Acquisition FPGA Register Setup & Initialize
            //----------------------------------------------------
            //Acqusition Register Write
            foreach (Control control in this.ACQ_REGIST_GROUP.Controls)
            {
                TextBox textBox = control as TextBox;
                if (textBox != null)
                {
                    int index = AcqRegisterInfo.RegisterSearch(textBox.Name);
                    hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[index], Convert.ToUInt32(textBox.Text, 10), 0, testVector);
                    hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[index], Convert.ToUInt32(textBox.Text, 10), 1, testVector);
                    hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[index], Convert.ToUInt32(textBox.Text, 10), 2, testVector);
                    hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[index], Convert.ToUInt32(textBox.Text, 10), 3, testVector);
                }
            }

            //Serdes Reset
            for (int i = 0; i < 4; i++)
            {
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_SERDES_RESET")], 0x0, i, testVector);
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_SERDES_RESET")], 0x1, i, testVector);
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_SERDES_RESET")], 0x0, i, testVector);
            }

            //AXI4 Master Register Setup
            for (int i = 0; i < 4; i++)
            {
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_AXI_BUFFER_FIFO_RST")], 0x0, i, testVector);
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_AXI_BUFFER_FIFO_RST")], 0x1, i, testVector);
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_AXI_BUFFER_FIFO_RST")], 0x0, i, testVector);

                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_MOVER_FIFO_RST")], 0x0, i, testVector);
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_MOVER_FIFO_RST")], 0x1, i, testVector);
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_MOVER_FIFO_RST")], 0x0, i, testVector);

                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_MOVER_RST")], 0x0, i, testVector);
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_MOVER_RST")], 0x1, i, testVector);
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_MOVER_RST")], 0x0, i, testVector);
            }

            uint writeSize = (Convert.ToUInt32(C_R_ACQ_RX_LENGTH.Text, 10) * 4 * Convert.ToUInt32(C_R_RTC_PRF_COUNT.Text, 10) * Convert.ToUInt32(C_R_RTC_OFN_COUNT.Text, 10) / 64) + 1;
            hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_AXI_ADDR_COUNT")], writeSize, 0, testVector);
            hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_AXI_ADDR_COUNT")], writeSize, 1, testVector);
            hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_AXI_ADDR_COUNT")], writeSize, 2, testVector);
            hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_AXI_ADDR_COUNT")], writeSize, 3, testVector);

            if (ACQ_TEST_PATTERN_CHECK.Checked == true)
            {
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_RF_TEST_PATTERN")], Convert.ToUInt32(ACQ_TEST_PATTERN_COMB.Text, 10), 0, testVector);
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_RF_TEST_PATTERN")], Convert.ToUInt32(ACQ_TEST_PATTERN_COMB.Text, 10), 1, testVector);
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_RF_TEST_PATTERN")], Convert.ToUInt32(ACQ_TEST_PATTERN_COMB.Text, 10), 2, testVector);
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_RF_TEST_PATTERN")], Convert.ToUInt32(ACQ_TEST_PATTERN_COMB.Text, 10), 3, testVector);
            }
            else
            {
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_RF_TEST_PATTERN")], 0x0, 0, testVector);
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_RF_TEST_PATTERN")], 0x0, 1, testVector);
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_RF_TEST_PATTERN")], 0x0, 2, testVector);
                hostInterface.AcqHostWrite(AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_RF_TEST_PATTERN")], 0x0, 3, testVector);
            }

            //----------------------------------------------------
            //RTC FPGA Register Setup & Initialize
            //----------------------------------------------------
            //RTC Register Write
            foreach (Control control in this.RTC_REGIST_GROUP.Controls)
            {
                TextBox textBox = control as TextBox;
                if (textBox != null)
                {
                    int index = rtcRegisterInfo.RegisterSearch(textBox.Name);
                    hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[index], Convert.ToUInt32(textBox.Text, 10), testVector);
                }
            }

            //PRF, OFN Generation
            if (RBtnCon.Checked == true)
            {
                hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_AUTO_PRF_CONT_EN")], 0x1, testVector);
            }
            else if (RBtnNCon.Checked == true)
            {
                hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_AUTO_PRF_TRIG_EN")], 0x0, testVector);
                hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_AUTO_PRF_TRIG_EN")], 0x1, testVector);
                hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_AUTO_PRF_TRIG_EN")], 0x0, testVector);
            }

            MessageBox.Show("Register setup Done");
            hostTestTimer.Enabled = true;
            //System Start
            testVector.Close();
        }

        private void BtnTestDoneClick(object sender, EventArgs e)
        {
            hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_AUTO_PRF_CONT_EN")], 0x0);
            MessageBox.Show("test Done");
            //serialPortConnection.SendMessage("done");
            //ComPortTextBox.AppendText(ByteToString(serialPortConnection.GetMessage(100)));
        }

        private void SystemHostReadWrite(StreamWriter fw)
        {
            //Acqusition PLL reset
            hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_BF_FPGA_PLL_RST")], 0x0, fw);
            hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_BF_FPGA_PLL_RST")], 0x3, fw);
            hostInterface.RtcHostWrite(rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_BF_FPGA_PLL_RST")], 0x0, fw);

            //----------------------------------------------------
            //Communication FPGA Setup
            //----------------------------------------------------
            //TX DELAY
            for (uint i = 0; i < 3; i++)
            {
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_DELAY")] + i, TXDelay[i], 0, fw);
                hostInterface.AnaHostRead(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_DELAY")] + i, 0, fw);
            }

            for (int j = 0; j < 1; j++)
            {
                //TX Pulse Command & Shpae
                hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_B_TX_PC")], BPulseCommand, j, fw);
                hostInterface.AnaHostRead(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_B_TX_PC")], j, fw);
                for (uint i = 0; i < 2; i++)
                {
                    hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_B_TX_PS")] + i, BPulseShape[i], j, fw);
                    hostInterface.AnaHostRead(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_TX_B_TX_PS")] + i, j, fw);
                }
            }
            //AFE Host Read/Write
            hostInterface.Afe5809HostWrite(0x5, 0x1234, 0, 1, fw);
            hostInterface.Afe5809HostWrite(0xa, 0x55aa, 0, 1, fw);
            hostInterface.AnaHostRead(0x10000000, 1, fw);
            hostInterface.AnaHostRead(0x10000000, 1, fw);
            hostInterface.Afe5809HostRead(0x5, 0, 1, fw);
            hostInterface.AnaHostRead(0x10000000, 1, fw);
            hostInterface.AnaHostRead(0x10000000, 1, fw);
            hostInterface.AnaHostRead(0x10000000, 1, fw);
            hostInterface.AnaHostRead(0x10000000, 1, fw);
            hostInterface.AnaHostRead(0x10000000, 1, fw);
            hostInterface.AnaHostRead(0x10000000, 1, fw);
            hostInterface.Afe5809HostRead(0xa, 0, 1, fw);
        }
        #endregion

        /// <summary>
        /// Read Acq ddr3 RF data and another options
        /// EX) RF Data read, Plot Test Pattern, Remapping AFE5809 register
        /// </summary>
        #region Read RF Data and Switch AFE5809 Register Function
        //----------------------------------------------------
        //Saving DDR3 RF data to HardDisk
        //----------------------------------------------------
        [HandleProcessCorruptedStateExceptionsAttribute]
        private void BtnRfDataReadClick(object sender, EventArgs e)
        {
            //Serial Port Buffer Clear
            //serialPortConnection.SerialPortBufferClear();

            int channel = 32;
            int viewDepth = Convert.ToInt32(SYS_VIEW_DEPTH_TXT.Text, 10);
            int rxLength = (viewDepth * 512);
            int frameCount = Convert.ToInt32(SYS_FRAME_COUNT_TXT.Text, 10);
            int prfCount = Convert.ToInt32(SYS_PRF_COUNT_TXT.Text, 10);
            uint readSize = (uint)rxLength * (uint)channel * 2;
            IntPtr readDataPtr;

            //For Memory Dump
            //byte[] res = new byte[32];
            //string sRes = null;
            for (uint frame = 0; frame < frameCount; frame++)
            {
                for (uint prf = 0; prf < prfCount; prf++)
                {
                    string sFName = "RfData" + "_Frame" + frame.ToString() + "_Prf" + prf.ToString() + "_" + ACQ_FPGA_SEL_COMB.SelectedItem.ToString() + ".txt";
                    StreamWriter FmemoryDump = new StreamWriter(sFName);
                    uint selectMemory = prf * (frame + 1);
                    uint baseAddr = 0x80000000 + selectMemory * readSize;

                    debug_text.AppendText("baseAddr : " + baseAddr.ToString("X8") + "\r\n");
                    debug_text.AppendText("readSize : " + readSize.ToString() + "\r\n");

                    readDataPtr = hostInterface.DDRHostRead(ACQ_FPGA_SEL_COMB.SelectedItem.ToString(), baseAddr, readSize);
                    //IntPtr readDataPtrNext = readDataPtr + 4;
                    Thread.Sleep(100);

                    //debug_text.AppendText("readDataPtr_"+ comboBox5.SelectedItem.ToString() + " : \r\n" + readDataPtr.ToString()+ "\r\n");
                    //debug_text.AppendText("readDataPtrNext : " + readDataPtrNext.ToString() + "\n");

                    try
                    {
                        for (int sample = 0; sample < readSize; sample += 4)
                        {
                            FmemoryDump.WriteLine("{0:d8}   {1:x8}", sample, Marshal.ReadInt32(readDataPtr + sample));
                        }
                    }
                    catch (AccessViolationException Ex)
                    {
                        MessageBox.Show("Error : " + Ex);
                    }


                    FmemoryDump.Close();
                    /*
                    string sFName = "binary_RfData" + "_Frame" + frame.ToString() + "_Prf" + prf.ToString() + ".txt";
                    BinaryWriter FMemoryDump = new BinaryWriter(File.OpenWrite(sFName));
                    byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);

                    int selectMemory = prf * (frame + 1);
                    int baseAddr = selectMemory * (rxLength * (channel / 2));

                    for (int sample = 0; sample < rxLength * channel; sample = sample + 8)
                    {
                        res = hostInterface.DDRHostRead((baseAddr * 4) + (sample * 2));
                        FMemoryDump.Write(res);
                        FMemoryDump.Write(newline);
                    }
                    FMemoryDump.Close();
                    */
                }
            }

            MessageBox.Show("File write Done.");
        }


        //----------------------------------------------------
        //Plot Acqusition Test Pattern
        //----------------------------------------------------
        private void BtnPlotClick(object sender, EventArgs e)
        {
            int channel = 32;
            int viewDepth = Convert.ToInt32(SYS_VIEW_DEPTH_TXT.Text, 10);
            int rxLength = (viewDepth * 512);
            int frameCount = Convert.ToInt32(SYS_FRAME_COUNT_TXT.Text, 10);
            int prfCount = Convert.ToInt32(SYS_PRF_COUNT_TXT.Text, 10);

            //For Memory Dump
            for (int frame = 0; frame < frameCount; frame++)
            {
                for (int prf = 0; prf < prfCount; prf++)
                {
                    string sFName = "RfData" + "_Frame" + frame.ToString() + "_Prf" + prf.ToString() + ".txt";
                    StreamReader FRfDataRead = new StreamReader(sFName);
                    int[,] patternData = new int[channel, rxLength];
                    string line;
                    int lineCount = 0;
                    int ch = 0;
                    while ((line = FRfDataRead.ReadLine()) != null)
                    {
                        string strTemp0 = line.Substring(0, 4);
                        string strTemp1 = line.Substring(4, 4);
                        string strTemp2 = line.Substring(8, 4);
                        string strTemp3 = line.Substring(12, 4);
                        string strTemp4 = line.Substring(16, 4);
                        string strTemp5 = line.Substring(20, 4);
                        string strTemp6 = line.Substring(24, 4);
                        string strTemp7 = line.Substring(28, 4);

                        if (((lineCount % rxLength) == 0) && lineCount > 1)
                        {
                            ch = ch + 8;
                        }
                        patternData[ch + 0, lineCount % rxLength] = Convert.ToInt16(strTemp0, 16);
                        patternData[ch + 1, lineCount % rxLength] = Convert.ToInt16(strTemp1, 16);
                        patternData[ch + 2, lineCount % rxLength] = Convert.ToInt16(strTemp2, 16);
                        patternData[ch + 3, lineCount % rxLength] = Convert.ToInt16(strTemp3, 16);
                        patternData[ch + 4, lineCount % rxLength] = Convert.ToInt16(strTemp4, 16);
                        patternData[ch + 5, lineCount % rxLength] = Convert.ToInt16(strTemp5, 16);
                        patternData[ch + 6, lineCount % rxLength] = Convert.ToInt16(strTemp6, 16);
                        patternData[ch + 7, lineCount % rxLength] = Convert.ToInt16(strTemp7, 16);

                        lineCount++;
                    }

                    FRfDataRead.Close();

                    for (int i = 0; i < channel; i++)
                    {
                        int[] temp = new int[rxLength];
                        for (int j = 0; j < rxLength; j++)
                        {
                            temp[j] = patternData[i, j];
                        }
                        //matlab.Figure();
                        //matlab.yplot((MWNumericArray)temp);

                    }

                    MessageBox.Show("OK Plot Done.");
                }
            }
        }

        //----------------------------------------------------
        //Setup AFE5809 Register Setup
        //----------------------------------------------------

        private void AfeTestPatternCheckedChanged(object sender, EventArgs e)
        {
            AFE5809RegisterUpdate();
        }

        private void AFE5809RegisterUpdate()
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(PathInfo.excelPath);

            if (ANA_AFE_PATTERN_CHECK.Checked == true)
            {
                AfeRegisterInfo.RegisterClear();

                AfeRegisterInfo.RegisterUpdate("AFE5809", 0, xlWorkBook);
            }
            else
            {
                AfeRegisterInfo.RegisterClear();
                AfeRegisterInfo.RegisterUpdate("AFE5809", 1, xlWorkBook);
            }
            xlWorkBook.Close();
            Marshal.ReleaseComObject(xlWorkBook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void AcqTestPatternCheckedChanged(object sender, EventArgs e)
        {
            if (ACQ_TEST_PATTERN_CHECK.Checked == true)
            {
                ACQ_TEST_PATTERN_COMB.Visible = true;
            }
            else
            {
                ACQ_TEST_PATTERN_COMB.Visible = false;
            }
        }


        #endregion

        /// <summary>
        /// Host test Timer
        /// EX) XDMA RTC, BPI Acq test, using red/green icon
        /// </summary>
        #region Host Test Timer

        private void hostTestDraw(PictureBox picture, bool isCorrect)
        {
            BeginInvoke(new MethodInvoker(() => {
                if (isCorrect)
                {
                    picture.Image = greenBitMap;
                }
                else
                {
                    picture.Image = redBitMap;
                }
            }));
        }

        private void hostTestTimer_Tick(object sender, EventArgs e)
        {
            //ui thread로 test
            //hostTestAddr = rtcRegisterInfo.registerAddr[rtcRegisterInfo.RegisterSearch("C_R_RTC_TEST_REGISTER")];
            //hostInterface.RtcHostWrite(hostTestAddr, 0x1234);
            Invoke(new MethodInvoker(() => { hostTestTimer.Stop(); }));

            Thread.Sleep(1000);
            Invoke(new MethodInvoker(() => { debug_text.AppendText("timer ticked\r\n"); }));

            //debug_text.AppendText("timer tecked \r\n");

            //hostTestByte = hostInterface.RtcHostRead(hostTestAddr, "RTC");

            //test로 디버깅
            if (ByteToString(hostTestByte) == "00001234")
            {
                hostTestByte = new byte[4] { 0, 0, 0, 0 };
            }
            else
            {
                hostTestByte = new byte[4] { 0x34, 0x12, 00, 00 };
            }

            //debug_text.AppendText($"\r\n RTC {ByteToString(hostTestByte)} \r\n");

            hostTestDraw(COM_RTC_IMG, ByteToString(hostTestByte) == "00001234");
            hostTestDraw(COM_RPC_IMG, ByteToString(hostTestByte) == "00001234");

            //hostTestAddr = AcqRegisterInfo.registerAddr[AcqRegisterInfo.RegisterSearch("C_R_ACQ_TEST_REGISTER")];
            //hostInterface.AcqHostWrite(hostTestAddr, 0x1234, 0);
            //hostInterface.AcqHostWrite(hostTestAddr, 0x1234, 1);
            //hostInterface.AcqHostWrite(hostTestAddr, 0x1234, 2);
            //hostInterface.AcqHostWrite(hostTestAddr, 0x1234, 3);

            //hostTestByte = hostInterface.AcqHostRead(hostTestAddr, 0);

            hostTestDraw(COM_ACQ_IMG1, ByteToString(hostTestByte) == "00001234");

            //hostTestByte = hostInterface.AcqHostRead(hostTestAddr, 1);

            hostTestDraw(COM_ACQ_IMG2, ByteToString(hostTestByte) == "00001234");

            //hostTestByte = hostInterface.AcqHostRead(hostTestAddr, 2);
            hostTestDraw(COM_ACQ_IMG3, ByteToString(hostTestByte) == "00001234");

            //hostTestByte = hostInterface.AcqHostRead(hostTestAddr, 3);
            hostTestDraw(COM_ACQ_IMG4, ByteToString(hostTestByte) == "00001234");


            //debug_text.AppendText($"\r\n Acq {ByteToString(hostTestByte)} \r\n");

            //hostTestAddr = AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("??")];
            //hostInterface.AnaHostWrite(hostTestAddr, 0x1234, 0);
            //hostInterface.AnaHostWrite(hostTestAddr, 0x1234, 1);
            //hostInterface.AnaHostWrite(hostTestAddr, 0x1234, 2);
            //hostInterface.AnaHostWrite(hostTestAddr, 0x1234, 3);


            //hostTestByte = hostInterface.AnaHostRead(hostTestAddr, 0);
            hostTestDraw(COM_ANA_IMG1, ByteToString(hostTestByte) == "00001234");

            //hostTestByte = hostInterface.AnaHostRead(hostTestAddr, 1);
            hostTestDraw(COM_ANA_IMG2, ByteToString(hostTestByte) == "00001234");

            //hostTestByte = hostInterface.AnaHostRead(hostTestAddr, 2);
            hostTestDraw(COM_ANA_IMG3, ByteToString(hostTestByte) == "00001234");

            //hostTestByte = hostInterface.AnaHostRead(hostTestAddr, 3);
            hostTestDraw(COM_ANA_IMG4, ByteToString(hostTestByte) == "00001234");

            Invoke(new MethodInvoker(()=>{hostTestTimer.Start(); }));

            return;

            
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////////
        /// TAB name: Host Test
        ///////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Host Test, Button function. 
        /// EX) RTC Write/Read. ACQ Write/Read. ANA Write/Read. AFE Enable/Disable Write/Read.
        /// </summary>
        #region Host test Write/Read Function
        private void BtnRtcHostWrite_Click(object sender, EventArgs e)
        {
            hostTestTimer.Enabled = false;
            DisableHostButton();
            BtnRtcHostWrite.BackColor = Color.GreenYellow;

            uint addr = Convert.ToUInt32(RTC_ADDR_TXT.Text, 16);
            uint data = Convert.ToUInt32(RTC_WDATA_TXT.Text, 16);
            int delay = TEST_DELAY_TRACK.Value;
            Task task = Task.Run(() =>
            {
                do
                {
                    Invoke(new MethodInvoker(delegate () { delay = TEST_DELAY_TRACK.Value; }));

                    hostInterface.RtcHostWrite(addr, data);
                    Thread.Sleep(delay);
                } while (TEST_CONTINUOUS_CHECK.Checked == true);
            });
            Task_Log(task, BtnRtcHostWrite);
        }

        private void BtnRtcHostRead_Click(object sender, EventArgs e)
        {
            hostTestTimer.Enabled = false;
            DisableHostButton();
            BtnRtcHostRead.BackColor = Color.GreenYellow;
            byte[] res = new byte[4];
            uint addr = Convert.ToUInt32(RTC_ADDR_TXT.Text, 16);
            int delay = TEST_DELAY_TRACK.Value;
            Task task = new Task(() =>
            {
                do
                {
                    res = hostInterface.RtcHostRead(addr, "Rtc");

                    Invoke(new MethodInvoker(delegate ()
                    {
                        RTC_RDATA_TXT.Text = ByteToString(res);
                        delay = TEST_DELAY_TRACK.Value;
                    }));
                    Thread.Sleep(delay);

                } while (TEST_CONTINUOUS_CHECK.Checked);
            });
            task.Start();
            Task_Log(task, BtnRtcHostRead);
        }

        private void BtnAcqHostWrite_Click(object sender, EventArgs e)
        {
            hostTestTimer.Enabled = false;
            DisableHostButton();
            BtnAcqHostWrite.BackColor = Color.GreenYellow;

            int delay = TEST_DELAY_TRACK.Value;

            uint addr = Convert.ToUInt32(ACQ_ADDR_TXT.Text, 16);
            uint data = Convert.ToUInt32(ACQ_WDATA_TXT.Text, 16);
            int boardSel = 0;

            if (RBtnAcqBoard1.Checked && RBtnAcqFpga1.Checked)
                boardSel = 0;
            else if (RBtnAcqBoard1.Checked && RBtnAcqFpga2.Checked)
                boardSel = 1;
            else if (RBtnAcqBoard2.Checked && RBtnAcqFpga1.Checked)
                boardSel = 2;
            else if (RBtnAcqBoard2.Checked && RBtnAcqFpga2.Checked)
                boardSel = 3;

            Task task = new Task(() =>
            {
                do
                {
                    Invoke(new MethodInvoker(delegate () { delay = TEST_DELAY_TRACK.Value; }));

                    hostInterface.AcqHostWrite(addr, data, boardSel);

                    Thread.Sleep(delay);
                } while (TEST_CONTINUOUS_CHECK.Checked);
            });
            task.Start();

            Task_Log(task, BtnAcqHostWrite);
        }

        private void BtnAcqHostRead_Click(object sender, EventArgs e)
        {
            hostTestTimer.Enabled = false;
            DisableHostButton();
            BtnAcqHostRead.BackColor = Color.GreenYellow;

            byte[] res = new byte[4];
            uint addr = Convert.ToUInt32(ACQ_ADDR_TXT.Text, 16);
            int delay = TEST_DELAY_TRACK.Value;

            int boardSel = 0;

            if (RBtnAcqBoard1.Checked && RBtnAcqFpga1.Checked)
                boardSel = 0;
            else if (RBtnAcqBoard1.Checked && RBtnAcqFpga2.Checked)
                boardSel = 1;
            else if (RBtnAcqBoard2.Checked && RBtnAcqFpga1.Checked)
                boardSel = 2;
            else if (RBtnAcqBoard2.Checked && RBtnAcqFpga2.Checked)
                boardSel = 3;

            Task task = new Task(() =>
            {
                do
                {

                    res = hostInterface.AcqHostRead(addr, boardSel);

                    Invoke(new MethodInvoker(delegate () {
                        ACQ_RDATA_TXT.Text = ByteToString(res);
                        delay = TEST_DELAY_TRACK.Value;
                    }));

                    Thread.Sleep(delay);
                } while (TEST_CONTINUOUS_CHECK.Checked);
            });
            task.Start();
            Task_Log(task, BtnAcqHostRead);
        }

        private void BtnAnaHostWrite_Click(object sender, EventArgs e)
        {
            hostTestTimer.Enabled = false;
            DisableHostButton();
            BtnAnaHostWrite.BackColor = Color.GreenYellow;

            uint addr = Convert.ToUInt32(ANA_ADDR_TXT.Text, 16);
            uint data = Convert.ToUInt32(ANA_WDATA_TXT.Text, 16);
            int delay = TEST_DELAY_TRACK.Value;

            int boardSel = 0;

            if (RBtnAnaBoard1.Checked && RBtnAnaFpga1.Checked)
                boardSel = 0;
            else if (RBtnAnaBoard1.Checked && RBtnAnaFpga2.Checked)
                boardSel = 1;
            else if (RBtnAnaBoard2.Checked && RBtnAnaFpga1.Checked)
                boardSel = 2;
            else if (RBtnAnaBoard2.Checked && RBtnAnaFpga2.Checked)
                boardSel = 3;

            Task task = new Task(() =>
            {
                do
                {
                    Invoke(new MethodInvoker(delegate () { delay = TEST_DELAY_TRACK.Value; }));
                    hostInterface.AnaHostWrite(addr, data, boardSel);
                    Thread.Sleep(delay);
                } while (TEST_CONTINUOUS_CHECK.Checked);
            });
            task.Start();
            Task_Log(task, BtnAnaHostWrite);
        }

        private void BtnAnaHostRead_Click(object sender, EventArgs e)
        {
            hostTestTimer.Enabled = false;
            DisableHostButton();
            BtnAnaHostRead.BackColor = Color.GreenYellow;

            byte[] res = new byte[4];
            uint addr = Convert.ToUInt32(ANA_ADDR_TXT.Text, 16);
            int delay = TEST_DELAY_TRACK.Value;
            int boardSel = 0;

            if (RBtnAnaBoard1.Checked && RBtnAnaFpga1.Checked)
                boardSel = 0;
            else if (RBtnAnaBoard1.Checked && RBtnAnaFpga2.Checked)
                boardSel = 1;
            else if (RBtnAnaBoard2.Checked && RBtnAnaFpga1.Checked)
                boardSel = 2;
            else if (RBtnAnaBoard2.Checked && RBtnAnaFpga2.Checked)
                boardSel = 3;

            Task task = new Task(() =>
            {
                do
                {
                    res = hostInterface.AnaHostRead(addr, boardSel);

                    Invoke(new MethodInvoker(delegate () {
                        ANA_RDATA_TXT.Text = ByteToString(res);
                        delay = TEST_DELAY_TRACK.Value;
                    }));
                    Thread.Sleep(delay);

                } while (TEST_CONTINUOUS_CHECK.Checked);
            });
            task.Start();
            Task_Log(task, BtnAnaHostRead);
        }

        private void BtnAfeHostWrite_Click(object sender, EventArgs e)
        {
            hostTestTimer.Enabled = false;
            DisableHostButton();
            BtnAfeHostWrite.BackColor = Color.GreenYellow;

            int afeSelect = Convert.ToInt32(AFE_SEL_COMB.SelectedItem.ToString(), 10);
            uint addr = Convert.ToUInt32(AFE_ADDR_TXT.Text, 16);
            uint data = Convert.ToUInt32(AFE_WDATA_TXT.Text, 16);
            int delay = TEST_DELAY_TRACK.Value;
            int boardSel = 0;

            if (RBtnAnaBoard1.Checked && RBtnAnaFpga1.Checked)
                boardSel = 0;
            else if (RBtnAnaBoard1.Checked && RBtnAnaFpga2.Checked)
                boardSel = 1;
            else if (RBtnAnaBoard2.Checked && RBtnAnaFpga1.Checked)
                boardSel = 2;
            else if (RBtnAnaBoard2.Checked && RBtnAnaFpga2.Checked)
                boardSel = 3;

            Task task = new Task(() =>
            {
                do
                {
                    TEST_DELAY_TRACK.Invoke(new MethodInvoker(delegate () { delay = TEST_DELAY_TRACK.Value; }));

                    if (RBtnDig.Checked == true)
                    {
                        hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 0);
                        hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 1);
                        hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 2);
                        hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 3);
                    }
                    else if (RBtnAdcVca.Checked == true)
                    {
                        hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 0);
                        hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 1);
                        hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 2);
                        hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 3);
                    }

                    hostInterface.Afe5809HostWrite(addr, data, boardSel, afeSelect);

                    Thread.Sleep(delay);

                } while (TEST_CONTINUOUS_CHECK.Checked);
            });
            task.Start();
            Task_Log(task, BtnAfeHostWrite);
        }


        private void BtnAfeHostRead_Click(object sender, EventArgs e)
        {
            hostTestTimer.Enabled = false;
            DisableHostButton();
            BtnAfeHostRead.BackColor = Color.GreenYellow;

            int afeSelect = Convert.ToInt32(AFE_SEL_COMB.SelectedItem.ToString(), 10);
            byte[] res = new byte[10];
            uint addr = Convert.ToUInt32(AFE_ADDR_TXT.Text, 16);
            int delay = TEST_DELAY_TRACK.Value;

            int boardSel = 0;

            if (RBtnAnaBoard1.Checked && RBtnAnaFpga1.Checked)
                boardSel = 0;
            else if (RBtnAnaBoard1.Checked && RBtnAnaFpga2.Checked)
                boardSel = 1;
            else if (RBtnAnaBoard2.Checked && RBtnAnaFpga1.Checked)
                boardSel = 2;
            else if (RBtnAnaBoard2.Checked && RBtnAnaFpga2.Checked)
                boardSel = 3;

            Task task = new Task(() =>
            {
                do
                {
                    if (RBtnDig.Checked == true)
                    {
                        Afe5809DigReadEnable();
                    }
                    else if (RBtnAdcVca.Checked == true)
                    {
                        Afe5809AdcReadEnable();
                    }


                    res = hostInterface.Afe5809HostRead(addr, boardSel, afeSelect);


                    if (RBtnDig.Checked == true)
                    {
                        Afe5809DigReadDisable();
                    }
                    else
                    {
                        Afe5809AdcReadDisable();
                    }

                    Invoke(new MethodInvoker(delegate () {
                        AFE_RDATA_TXT.Text = ByteToString(res);
                        delay = TEST_DELAY_TRACK.Value;
                    }));


                    Thread.Sleep(delay);

                } while (TEST_CONTINUOUS_CHECK.Checked);
            });
            task.Start();
            Task_Log(task, BtnAfeHostRead);
        }

        private void Afe5809DigReadEnable()
        {
            hostTestTimer.Enabled = false;
            uint afeWriteData;
            afeWriteData = ((0xC0 & 0xff) << 16) + 0x0002;
            // 0xc0 & 0xff = 1100 0000
            //12582914
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 0);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 1);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 2);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 3);

            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 0);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 1);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 2);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 3);

            afeWriteData = ((0x00 & 0xff) << 16) + 0x0002;
            //2
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 0);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 1);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 2);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 3);

            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 0);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 1);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 2);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 3);

            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 0);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 1);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 2);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 3);
            hostTestTimer.Enabled = true;
        }

        private void Afe5809DigReadDisable()
        {
            hostTestTimer.Enabled = false;
            uint afeWriteData;
            afeWriteData = ((0x00 & 0xff) << 16) + 0x0000;
            //12582912

            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 0);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 1);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 2);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 3);

            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 0);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 1);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 2);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 3);

            afeWriteData = ((0xC0 & 0xff) << 16) + 0x0000;
            //0
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 0);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 1);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 2);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 0, 3);

            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 0);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 1);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 2);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 3);
            hostTestTimer.Enabled = true;
        }

        private void Afe5809AdcReadEnable()
        {
            hostTestTimer.Enabled = false;
            uint afeWriteData;
            afeWriteData = ((0x00 & 0xff) << 16) + 0x0002;
            //2
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 0);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 1);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 2);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 3);

            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 0);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 1);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 2);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 3);
            hostTestTimer.Enabled = true;
        }

        private void Afe5809AdcReadDisable()
        {
            hostTestTimer.Enabled = false;
            uint afeWriteData;
            afeWriteData = ((0x00 & 0xff) << 16) + 0x0000;
            //0
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 0);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 1);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 2);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_DIG_EN")], 1, 3);

            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 0);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 1);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 2);
            hostInterface.AnaHostWrite(AnaRegisterInfo.registerAddr[AnaRegisterInfo.RegisterSearch("C_R_AFE_SPI_WRITE")], afeWriteData, 3);

            hostTestTimer.Enabled = true;
        }

        #endregion

        /// <summary>
        /// GROUP name: Host Test Interface
        /// EX) Task Log, Button Disable/Enable, Continuous Trackbar, Board/FGPA textbox, search register name, reset button
        /// </summary>
        #region Test Interface Function

        public void Task_Log(Task task, Button button)
        {
            //작업 성공 시 출력
            //성공하거나 실패하거나 취소했을때 테스크 제거

            task.ContinueWith(
                temp =>
                {
                    if (temp.IsFaulted)
                    {
                        //작업 실패 로그 출력
                        TEST_TASK_LOG.Invoke(new MethodInvoker(delegate () {
                            TEST_TASK_LOG.AppendText("Task ID " + temp.Id + ": " + temp.Exception.InnerException.ToString() + "\n");

                        }));
                    }
                    else if (temp.IsCanceled)
                    {
                        //작업 취소 로그 출력
                        TEST_TASK_LOG.Invoke(new MethodInvoker(delegate () {

                            TEST_TASK_LOG.AppendText("Task ID " + temp.Id + ": Task Running Canceled\n");

                        }));
                    }
                    else if (temp.IsCompleted)
                    {
                        //작업 성공 로그 출력
                        TEST_TASK_LOG.Invoke(new MethodInvoker(delegate () {

                            TEST_TASK_LOG.AppendText("Task ID " + temp.Id + ": Task is Complete\n");

                        }));
                    }
                    else
                    {
                        //작업 진행중 로그 출력
                        TEST_TASK_LOG.Invoke(new MethodInvoker(delegate () {

                            TEST_TASK_LOG.AppendText("Task ID " + temp.Id + ": Task is still running..\n");

                        }));
                    }

                    TEST_TASK_LOG.Invoke(new MethodInvoker(delegate () {

                        button.BackColor = Color.Empty;
                        EnableHostButton();
                        hostTestTimer.Enabled = true;

                    }));

                    temp.Dispose();

                }
            );
        }

        private void TaskLogClear(object sender, EventArgs e)
        {
            TEST_TASK_LOG.Clear();
        }

        public void DisableHostButton()
        {
            BtnRtcHostRead.Enabled = false;
            BtnRtcHostWrite.Enabled = false;
            BtnAcqHostRead.Enabled = false;
            BtnAcqHostWrite.Enabled = false;
            BtnAfeHostRead.Enabled = false;
            BtnAfeHostWrite.Enabled = false;
            BtnAnaHostRead.Enabled = false;
            BtnAnaHostWrite.Enabled = false;
            BtnRpcRead.Enabled = false;
            BtnRpcWrite.Enabled = false;

            BtnRtcHostRead.BackColor = Color.Gray;
            BtnRtcHostWrite.BackColor = Color.Gray;
            BtnAcqHostRead.BackColor = Color.Gray;
            BtnAcqHostWrite.BackColor = Color.Gray;
            BtnAfeHostRead.BackColor = Color.Gray;
            BtnAfeHostWrite.BackColor = Color.Gray;
            BtnAnaHostRead.BackColor = Color.Gray;
            BtnAnaHostWrite.BackColor = Color.Gray;
            BtnRpcRead.BackColor = Color.Gray;
            BtnRpcWrite.BackColor = Color.Gray;
        }

        public void EnableHostButton()
        {
            BtnRtcHostRead.Enabled = true;
            BtnRtcHostWrite.Enabled = true;
            BtnAcqHostRead.Enabled = true;
            BtnAcqHostWrite.Enabled = true;
            BtnAfeHostRead.Enabled = true;
            BtnAfeHostWrite.Enabled = true;
            BtnAnaHostRead.Enabled = true;
            BtnAnaHostWrite.Enabled = true;
            BtnRpcRead.Enabled = true;
            BtnRpcWrite.Enabled = true;

            BtnRtcHostRead.BackColor = Color.Empty;
            BtnRtcHostWrite.BackColor = Color.Empty;
            BtnAcqHostRead.BackColor = Color.Empty;
            BtnAcqHostWrite.BackColor = Color.Empty;
            BtnAfeHostRead.BackColor = Color.Empty;
            BtnAfeHostWrite.BackColor = Color.Empty;
            BtnAnaHostRead.BackColor = Color.Empty;
            BtnAnaHostWrite.BackColor = Color.Empty;
            BtnRpcRead.BackColor = Color.Empty;
            BtnRpcWrite.BackColor = Color.Empty;
        }

        private void HostDelayUpdate(object sender, EventArgs e)
        {
            TEST_DELAY_TXT.Text = TEST_DELAY_TRACK.Value.ToString();
        }

        private void HostDelayTextUpdate(object sender, EventArgs e)
        {
            Thread.Sleep(10);
            int textValue = 1;
            bool isnum = int.TryParse(TEST_DELAY_TXT.Text, out textValue);

            if (isnum && textValue > 0 && textValue <= 1000)
            {
                TEST_DELAY_TRACK.Value = textValue;
            }
        }

        private void RBtnAcqBoard2_CheckedChanged(object sender, EventArgs e)
        {
            string text = "Acq Board";
            if (RBtnAcqBoard1.Checked) text += "1";
            else if (RBtnAcqBoard2.Checked) text += "2";

            text += ", FPGA";

            if (RBtnAcqFpga1.Checked) text += "1";
            else if (RBtnAcqFpga2.Checked) text += "2";

            ACQ_SEL_FPGA.Text = text;
        }

        private void RBtnAcqFpga2_CheckedChanged(object sender, EventArgs e)
        {
            RBtnAcqBoard2_CheckedChanged(sender, e);
        }

        private void RBtnAnaBoard2_CheckedChanged(object sender, EventArgs e)
        {
            string text = "Ana Board";
            if (RBtnAnaBoard1.Checked) text += "1";
            else if (RBtnAnaBoard2.Checked) text += "2";

            text += ", FPGA";

            if (RBtnAnaFpga1.Checked) text += "1";
            else if (RBtnAnaFpga2.Checked) text += "2";

            ANA_SEL_FPGA.Text = text;

            RBtnAdcVca_CheckedChanged(sender, e);
        }

        private void RBtnAnaFpga2_CheckedChanged(object sender, EventArgs e)
        {
            RBtnAnaBoard2_CheckedChanged(sender, e);
            RBtnAdcVca_CheckedChanged(sender, e);
        }

        private void RBtnAdcVca_CheckedChanged(object sender, EventArgs e)
        {
            string text = ANA_SEL_FPGA.Text + ", AFE" + AFE_SEL_COMB.SelectedItem + " ";

            if (RBtnAdcVca.Checked) text += "ADC";
            else text += "DIG";

            AFE_SEL_FPGA.Text = text;
        }

        private void AfeSelectCombChanged(object sender, EventArgs e)
        {
            RBtnAdcVca_CheckedChanged(sender, e);
        }

        private void SerachRegisterBtn(object sender, EventArgs e)
        {

            int index = 0;

            switch (TEST_REGIST_AREA_COMB.SelectedItem.ToString())
            {
                case ("RTC"):
                    index = rtcRegisterInfo.RegisterSearch(TEST_REGIST_NAME_COMB.SelectedItem.ToString().Trim());
                    if (index == 10000)
                    {
                        TEST_REGIST_ADDR_TXT.Text = "Not found";
                        return;
                    }
                    TEST_REGIST_ADDR_TXT.Text = rtcRegisterInfo.registerAddr[index].ToString("X8");
                    return;
                case ("Acquisition"):
                    index = AcqRegisterInfo.RegisterSearch(TEST_REGIST_NAME_COMB.SelectedItem.ToString().Trim());
                    if (index == 10000)
                    {
                        TEST_REGIST_ADDR_TXT.Text = "Not found";
                        return;
                    }
                    TEST_REGIST_ADDR_TXT.Text = AcqRegisterInfo.registerAddr[index].ToString("X8");
                    return;
                case ("Analog"):
                    index = AnaRegisterInfo.RegisterSearch(TEST_REGIST_NAME_COMB.SelectedItem.ToString().Trim());
                    if (index == 10000)
                    {
                        TEST_REGIST_ADDR_TXT.Text = "Not found";
                        return;
                    }
                    TEST_REGIST_ADDR_TXT.Text = AnaRegisterInfo.registerAddr[index].ToString("X8");
                    return;
                case ("AFE5809"):
                    index = AfeRegisterInfo.RegisterSearch(TEST_REGIST_NAME_COMB.SelectedItem.ToString().Trim());
                    if (index == 10000)
                    {
                        TEST_REGIST_ADDR_TXT.Text = "Not found";
                        return;
                    }
                    TEST_REGIST_ADDR_TXT.Text = AfeRegisterInfo.registerAddr[index].ToString("X8");
                    TEST_REGIST_VALUE_TXT.Text = AfeRegisterInfo.registerValue[index].ToString("X8");
                    return;
                default:
                    MessageBox.Show("TEST_REGIST_AREA_COMB EXCEPT", "Not selected item");
                    return;
            }

        }

        private void SearchRegisterAreaIndexChanged(object sender, EventArgs e)
        {
            TEST_REGIST_ADDR_TXT.Text = "";
            TEST_REGIST_VALUE_TXT.Text = "";

            TEST_REGIST_NAME_COMB.Items.Clear();
            TEST_REGIST_NAME_COMB.Text = "";

            object[] temp;

            if (TEST_REGIST_AREA_COMB.SelectedItem.ToString() == "RTC")
            {
                int arraySize = rtcRegisterInfo.registerName.ToArray().Length;
                temp = new object[arraySize];
                Array.Copy( rtcRegisterInfo.registerName.ToArray(), temp, arraySize);
                Array.Sort(temp);

                TEST_REGIST_NAME_COMB.Items.AddRange(temp);
            }
            else if (TEST_REGIST_AREA_COMB.SelectedItem.ToString() == "Acquisition")
            {
                int arraySize = AcqRegisterInfo.registerName.ToArray().Length;
                temp = new object[arraySize];
                Array.Copy(AcqRegisterInfo.registerName.ToArray(), temp, arraySize);
                Array.Sort(temp);

                TEST_REGIST_NAME_COMB.Items.AddRange(temp);
            }
            else if (TEST_REGIST_AREA_COMB.SelectedItem.ToString() == "Analog")
            {
                int arraySize = AnaRegisterInfo.registerName.ToArray().Length;
                temp = new object[arraySize];
                Array.Copy(AnaRegisterInfo.registerName.ToArray(), temp, arraySize);
                Array.Sort(temp);

                TEST_REGIST_NAME_COMB.Items.AddRange(temp);
            }
            else if (TEST_REGIST_AREA_COMB.SelectedItem.ToString() == "AFE5809")
            {
                int arraySize = AfeRegisterInfo.registerName.ToArray().Length;
                temp = new object[arraySize];
                Array.Copy(AfeRegisterInfo.registerName.ToArray(), temp, arraySize);
                //Array.Sort(temp, (a, b) => string.Compare(a.ToString().Substring(0,3), b.ToString().Substring(0, 3)));
                Array.Sort(temp, (a, b) => (string.Compare(a.ToString().Substring(0, 3), b.ToString().Substring(0, 3)) >= 0 && (Convert.ToInt32(a.ToString().Substring(4)) > Convert.ToInt32(b.ToString().Substring(4)))) ? 1 : -1);

                TEST_REGIST_NAME_COMB.Items.AddRange(temp);
            }
            else
            {
                TEST_REGIST_ADDR_TXT.Text = "Exception of DataSheetName mismatch";
                TEST_REGIST_VALUE_TXT.Text = "Exception of DataSheetName mismatch";
            }
        }

        private void ResetButtonClick(object sender, EventArgs e)
        {
            PLLReset();
            AcquisitionReset();
            Afe5809Reset();
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////////
        /// TAB name: COM PORT
        ///////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>
        /// serialport option: discard in/out buffer
        /// </summary>
        #region Comport Clean Buffer Function
        private void DiscardInBuff(object sender, EventArgs e)
        {
            serialMaster.DiscardInBuffer();
        }

        private void DiscardOutBuff(object sender, EventArgs e)
        {

            serialMaster.DiscardOutBuffer();
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////////
        /// TAB name: Acq xdma Test
        ///////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>
        /// Acquisition FPGA PCIE communication
        /// </summary>
        #region Acquisition ddr3 memory Write/Read Function

        // 2020.10.30 : acquisition ddr3 write/read test
        private void BtnAcqDDR3Write(object sender, EventArgs e)
        {

            uint addr = Convert.ToUInt32(ACQ_XDMA_ADDR_TXT.Text, 16);
            uint data = Convert.ToUInt32(ACQ_XDMA_WDATA_TXT.Text, 16);
            string device_name = ACQ_FPGA_SEL_COMB.SelectedItem.ToString();
            int delay = TEST_DELAY_TRACK.Value;
            Task task = Task.Run(() =>
            {

                pcieInterface.XDMAAcqWrite(device_name, addr, data);
                Invoke(new MethodInvoker(delegate ()
                {
                    debug_text.AppendText("device  : " + ACQ_FPGA_SEL_COMB.SelectedItem.ToString() + "\r\n");
                    debug_text.AppendText("address  : " + addr.ToString() + "\r\n");
                    delay = TEST_DELAY_TRACK.Value;
                }));

                Thread.Sleep(delay);
            });

            Task_Log(task, BtnRtcHostWrite);
        }

        private void BtnAcqDDR3Read(object sender, EventArgs e)
        {
            IntPtr res;
            uint addr = Convert.ToUInt32(ACQ_XDMA_ADDR_TXT.Text, 16);
            int delay = TEST_DELAY_TRACK.Value;
            string device_name = ACQ_FPGA_SEL_COMB.SelectedItem.ToString();

            Task task = Task.Run(() =>
            {

                res = pcieInterface.XDMAAcqRead(device_name, addr, 4);

                Invoke(new MethodInvoker(delegate ()
                {
                    debug_text.AppendText("device  : " + ACQ_FPGA_SEL_COMB.SelectedItem.ToString() + "\r\n");
                    debug_text.AppendText("address  : " + addr.ToString() + "\r\n");
                    ACQ_XDMA_RDATA_TXT.Text = String.Format("0x{0:x8}", Marshal.ReadInt32(res));
                }));

                Thread.Sleep(delay);
            });

            Task_Log(task, BtnRtcHostWrite);
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////////
        /// TAB name: HV Power Supply
        ///////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// RPC(RUS Power Controller) SPI read/write Communication, RPC control
        /// </summary>
        #region RPC SPI Communication Function
        private void BtnRpcSpiRead_Click(object sender, EventArgs e)
        {
            DisableHostButton();
            BtnRpcRead.BackColor = Color.GreenYellow;

            byte[] res = new byte[4];
            int delay = RPC_BTN_DELAY_TRACK.Value;

            Task task = Task.Run(() =>
            {
                do
                {
                    res = rpcSpiInterface.RpcSpiRead();

                    Invoke(new MethodInvoker(delegate ()
                    {
                        SPI_RDATA_TXT.Text = ByteToString(res);
                        delay = RPC_BTN_DELAY_TRACK.Value;

                        if (RPC_BTN_PROGRESS.Text + "." == "....")
                            RPC_BTN_PROGRESS.Text = "";
                        RPC_BTN_PROGRESS.Text += ".";
                    }));

                    Thread.Sleep(delay);
                } while (SPI_CONTINUOUS_CHECK.Checked);
            });

            Task_Log(task, BtnRpcRead);
        }

        private void BtnRpcSpiWrite_Click(object sender, EventArgs e)
        {
            byte Command = 0;
            byte hdata = 0;
            byte ldata = 0;

            try
            {
                Command = Convert.ToByte(SPI_COMMAND_TXT.Text, 16);

                hdata = Convert.ToByte(SPI_HDATA_TXT.Text, 16);
                ldata = Convert.ToByte(SPI_LDATA_TXT.Text, 16);
            }
            catch (Exception error)
            {
                MessageBox.Show("인식할 수 있는 COMMAND or Write 값이 아닙니다.\n" + error.ToString(), "COMMAND EXCEPT");
                return;
            }

            if ((Command != 0x00) &
                (Command != 0x01) &
                (Command != 0x02) &
                (Command != 0x03) &
                (Command != 0x04) &
                (Command != 0x05) &
                (Command != 0x06) &
                (Command != 0x7F))
            {
                MessageBox.Show("Command가 존재하지 않습니다.", "NOT EXIST", MessageBoxButtons.OK);
                return;
            }

            DisableHostButton();
            BtnRpcWrite.BackColor = Color.GreenYellow;

            int delay = RPC_BTN_DELAY_TRACK.Value;

            Task task = Task.Run(() =>
            {
                do
                {
                    Invoke(new MethodInvoker(delegate () {
                        delay = RPC_BTN_DELAY_TRACK.Value;
                        if (RPC_BTN_PROGRESS.Text + "." == "....")
                            RPC_BTN_PROGRESS.Text = "";
                        RPC_BTN_PROGRESS.Text += ".";
                    }));

                    rpcSpiInterface.RpcSpiWriteCommand(Command, hdata, ldata);
                    Thread.Sleep(delay);

                } while (SPI_CONTINUOUS_CHECK.Checked == true);
            });

            Task_Log(task, BtnRpcWrite);

        }

        private void RPC_BTN_DELAY_TRACK_Scroll(object sender, EventArgs e)
        {
            RPC_BTN_DELAY_TXT.Text = RPC_BTN_DELAY_TRACK.Value.ToString();
        }

        private void RPC_WR_DELAY_TRACK_Scroll(object sender, EventArgs e)
        {
            RPC_WR_DELAY_TXT.Text = RPC_WR_DELAY_TRACK.Value.ToString();
        }

        private void RPC_VTX_TRACK_Scroll(object sender, EventArgs e)
        {
            uint data = Convert.ToUInt16(RPC_VTX_TRACK.Value);

            if (data > 0x3E8)
            {
                MessageBox.Show($"NOT Correct Value. {data}", "High Voltage Error");
                RPC_VTX_TRACK.Value = 0;
                RPC_VTX_TEXT.Text = "0";
                return;
            }
            
            if (!VTXTimer.Enabled)
                VTXTimer.Start();


        }

        private void VTXTimer_tick(object sender, EventArgs e)
        {
            uint data = 0;

            RPC_VTX_TEXT.Invoke(new MethodInvoker(() => { data = Convert.ToUInt16(RPC_VTX_TRACK.Value); }));

            if (VTXData +100 < data)
            {
                VTXData += 100;
            }
            else if((VTXData -100 > data) && (VTXData - 100U < 1000))
            {
                VTXData -= 100;
            }
            else
            {
                VTXData = data;

            }

            if (VTXData == data)
            {
                VTXTimer.Stop();
            }

            if(VTXData > 1000)
            {
                debugPrint("VTXData over valued");
                return;
            }

            //parameter: command 1byte, high data 1byte, low data 1byte
            rpcSpiInterface.RpcSpiWriteCommand(0x05, Convert.ToByte((VTXData & 0x0000ff00) >> 8), Convert.ToByte(VTXData & 0x000000ff));

            RPC_VTX_TEXT.Invoke(new MethodInvoker(()=> { RPC_VTX_TEXT.Text = (Convert.ToSingle(VTXData) / 10D).ToString("F1"); }));
        }

        private void btnVTXOn_Click(object sender, EventArgs e)
        {
            rpcSpiInterface.RpcSpiWriteCommand(0x02,0x00,0x08);
            btnVTXOn.BackColor = Color.Yellow;
            btnVTXOff.BackColor = Color.Empty;
        }

        private void btnVTXOff_Click(object sender, EventArgs e)
        {
            rpcSpiInterface.RpcSpiWriteCommand(0x03, 0x00, 0x08);
            btnVTXOn.BackColor = Color.Empty;
            btnVTXOff.BackColor = Color.Yellow;
        }

        private void btnGDPOn_Click(object sender, EventArgs e)
        {
            rpcSpiInterface.RpcSpiWriteCommand(0x02, 0x00, 0x04);
            btnGDPOn.BackColor = Color.Yellow;
            btnGDPOff.BackColor = Color.Empty;
        }

        private void btnGDPOff_Click(object sender, EventArgs e)
        {
            rpcSpiInterface.RpcSpiWriteCommand(0x03, 0x00, 0x04);
            btnGDPOn.BackColor = Color.Empty; 
            btnGDPOff.BackColor = Color.Yellow;
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////////
        /// TAB name: ULTRA SONIC 
        ///////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// BF CUDA process with ImageProcess class
        /// ref of postec-ultra-sonic.sln. add Drawing Image, ui 
        /// </summary>
        #region Image Process Function
        private void BtnScanStart_Click(object sender, EventArgs e)
        {
            if (scanTimer.Enabled == false)
            {
                scanTimer.Interval = G_SPEED;
                scanTimer.Enabled = true;
                BtnScanStart.Text = "SCAN STOP";
                G_SEQUENCE = 0;
                
            }
            else
            {
                scanTimer.Enabled = false;
                BtnScanStart.Text = "SCAN START";
                G_SEQUENCE = 0;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            sw.Reset();
            sw.Start();
            G_SEQUENCE++;
            ProcessImageFile();
            sw.Stop();

            label86.Text = (1f / (sw.ElapsedMilliseconds + (float)G_SPEED) * 1000f).ToString();
        }
        
        // Read the image file, and populate the short array output 512*512 8 bits.
        private void ProcessImageFile()
        {
            string result = string.Empty;

            if (pixelCount < 0)
            {
                pixelCount = 0;
                //Make Image Process 1. cuda mem allocate 2. Read sample raw data
                string path = @"..\..\..\settingFile\" + "rawdata.bin";
                sw2.Reset();
                sw2.Start();
                imageProcess = new ImageProcess(this);

                result = imageProcess.AllocMem();
                if (result != "Success")
                {
                    debug_text.AppendText("CUDA Mem Alloc Failed : " + result + "\n");
                    return;
                }

                sw2.Stop();
                debug_text.AppendText("CUDA Mem Alloc SUCCESS\n Time: " + sw2.ElapsedMilliseconds.ToString() + " ms\n");

                sw2.Reset();
                sw2.Start();
                imageProcess.ReadRawData(path);
                sw2.Stop();
                debug_text.AppendText("Read Time: " + sw2.ElapsedMilliseconds.ToString() + " ms\n");

                for (int i = 0; i < 256; i++)
                {
                    colors[i] = Color.FromArgb((byte)i, (byte)i, (byte)i);
                } //set color for gray scale image format

                bmp.Palette = colorPalette;

            }

            sw2.Reset();
            sw2.Start();
            result = imageProcess.LoadRData();
            if (result != "Success")
            {
                debug_text.AppendText("CUDA Load RData Failed : " + result + "\n");
                return;
            }
            sw2.Stop();
            label91.Text = sw2.ElapsedMilliseconds.ToString();

            sw2.Reset();
            sw2.Start();
            lock (imageProcess)
            {
                result = imageProcess.imageProcess();
                if(result != "Success")
                {
                    debug_text.AppendText("CUDA Process Data Failed: " + result + "\n");
                    return;
                }
            }

            pixelCount++;
            if (pixelCount >= 512)
            {
                pixelCount = 0;
            }
            sw2.Stop();

            label87.Text = sw2.ElapsedMilliseconds.ToString();
            CreateBitmap8bit512(pixelCount);
            Invalidate();

            //BinaryReader br = new BinaryReader(File.Open(Application.StartupPath + "\\USPA_testImage\\" + fileName + ".bin", FileMode.Open));
            //long iTotalSize = br.BaseStream.Length;
            //br.Read(ImageFile_Byte, 0, (int)iTotalSize);
            //br.Close();
        }

        // Create the Bitmap object and populate its pixel data with the stored pixel values.
        private void CreateBitmap24bit896(byte[] data)
        {
            int n1 = 0;
            int n2 = 0;
            int pos = 0;
            for (int h = 0; h < data.Length; h += 3)
            {
                pos = (n2 * 896 * 3) + (n1 * 3);

                ImageFile_Byte[pos] = data[h];
                ImageFile_Byte[pos + 1] = data[h + 1];
                ImageFile_Byte[pos + 2] = data[h + 2];
                n2++;
                if (n2 == 596)
                {
                    n1++;
                    n2 = 0;
                }
            }
            
            bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            BitmapData bmd = bmp.LockBits(new Rectangle(0, 0, width, height),
                System.Drawing.Imaging.ImageLockMode.ReadOnly, bmp.PixelFormat);

            IntPtr pNative = bmd.Scan0;
            Marshal.Copy(ImageFile_Byte, 0, pNative, ImageFile_Byte.Length);
            bmp.UnlockBits(bmd);
            G_DATA = 1;

        }

        private void CreateBitmap8bit512(int pixelCount)
        {
            for (int i = 0; i < 512; i++)
            {
                for (int j = 0; j < 512; j++)
                {
                    OutputData[i * 512 + j] = ImageProcess.ScanconvData[i * 512 + (j + pixelCount) % 512];
                }
            }

            bmd = bmp.LockBits(new Rectangle(0, 0, width, height),
                            System.Drawing.Imaging.ImageLockMode.ReadOnly, bmp.PixelFormat);
            pNative = bmd.Scan0;

            Marshal.Copy(OutputData, 0, pNative, OutputData.Length);
            bmp.UnlockBits(bmd);
            G_DATA = 1;
        }

        private void DrawPaint(object sender, PaintEventArgs e)
        {
            if (G_DATA > 0)
            {
                Invoke(new MethodInvoker(() => {
                    g.DrawImage(bmp, 0, 0);
                }));
                G_DATA = 0;
            }
        }

        private void FrameDelayUpdate(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(() => {
                G_SPEED = US_FRAME_DELAY_TRACK.Value;
                label82.Text = G_SPEED.ToString();
                scanTimer.Interval = G_SPEED;
            }));
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////////
        /// TAB name: TGC Figure
        ///////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Test TGC setup, drawing curve. 
        /// connected with system configuration value, view depth
        /// EX) Test TGC setup, update, trackbar update
        /// </summary>
        #region Test TGC Function

        private void CUBIC_HERMIT_SPLINE_CheckedChanged(object sender, EventArgs e)
        {
            if (HERMIT_SPLINE_RADIO.Checked)
            {
                HERMIT_OP_GROUP.Enabled = true;
            }
            else
            {
                HERMIT_OP_GROUP.Enabled = false;
            }
        }

        private void TgcTestGraphUpdate()
        {
            //debug_text.AppendText("tgctestupdate count: " + Count.ToString() + "\r\n");
            // chart1 컨트롤에 Collection에 있었던 내용을 삭제
            TGC_GRAPH_TEST.ChartAreas.Clear();
            TGC_GRAPH_TEST.Series.Clear();

            // ChartArea 추가
            TGC_GRAPH_TEST.ChartAreas.Add("Draw");
            TGC_GRAPH_TEST.ChartAreas["Draw"].BackColor = Color.White;

            // ChartArea X축과 Y축을 설정
            TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Minimum = 0;
            TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Maximum = 1024;//int.Parse(SYS_VIEW_DEPTH_TXT.Text);
            TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Interval = 128;
            TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.MajorGrid.LineColor = Color.Gray;
            TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            TGC_GRAPH_TEST.ChartAreas["Draw"].AxisY.Minimum = -1;
            TGC_GRAPH_TEST.ChartAreas["Draw"].AxisY.Maximum = 1;
            TGC_GRAPH_TEST.ChartAreas["Draw"].AxisY.Interval = 0.1;
            TGC_GRAPH_TEST.ChartAreas["Draw"].AxisY.MajorGrid.LineColor = Color.Gray;
            TGC_GRAPH_TEST.ChartAreas["Draw"].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // Series 추가(Curve)       
            TGC_GRAPH_TEST.Series.Add("Curve");
            TGC_GRAPH_TEST.Series["Curve"].ChartType = SeriesChartType.Spline;
            TGC_GRAPH_TEST.Series["Curve"].Color = Color.Black;
            TGC_GRAPH_TEST.Series["Curve"].BorderWidth = 2;
            //TGC_GRAPH_TEST.Series["Curve"].LegendText = "ax^3+bx^2+cx+d";

            // Series 추가(Points) 
            TGC_GRAPH_TEST.Series.Add("Points");
            TGC_GRAPH_TEST.Series["Points"].ChartType = SeriesChartType.FastPoint;
            TGC_GRAPH_TEST.Series["Points"].Color = Color.Red;
            TGC_GRAPH_TEST.Series["Points"].BorderWidth = 2;
            TGC_GRAPH_TEST.Series["Points"].LegendText = "Points";

            // Series 추가(Line)      
            TGC_GRAPH_TEST.Series.Add("Line");
            TGC_GRAPH_TEST.Series["Line"].ChartType = SeriesChartType.Line;
            TGC_GRAPH_TEST.Series["Line"].Color = Color.Black;
            TGC_GRAPH_TEST.Series["Line"].BorderWidth = 1;

            //matlab data plot
            TGC_GRAPH_TEST.Series.Add("Mtlb pchip");
            TGC_GRAPH_TEST.Series["Mtlb pchip"].ChartType = SeriesChartType.Line;
            TGC_GRAPH_TEST.Series["Mtlb pchip"].Color = Color.Green;
            TGC_GRAPH_TEST.Series["Mtlb pchip"].BorderWidth = 1;

            TGC_GRAPH_TEST.Series.Add("Mtlb Points");
            TGC_GRAPH_TEST.Series["Mtlb Points"].ChartType = SeriesChartType.Point;
            TGC_GRAPH_TEST.Series["Mtlb Points"].Color = Color.Black;
            TGC_GRAPH_TEST.Series["Mtlb Points"].BorderWidth = 2;

            TGC_GRAPH_TEST.Series.Add("Mtlb Spline");
            TGC_GRAPH_TEST.Series["Mtlb Spline"].ChartType = SeriesChartType.Line;
            TGC_GRAPH_TEST.Series["Mtlb Spline"].Color = Color.Blue;
            TGC_GRAPH_TEST.Series["Mtlb Spline"].BorderWidth = 1;

            interval = (TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Maximum - TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Minimum) / 8D;

            x[0] = TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Minimum + interval / 2D;
            x[1] = TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Minimum + interval * 1 + interval / 2D;
            x[2] = TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Minimum + interval * 2 + interval / 2D;
            x[3] = TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Minimum + interval * 3 + interval / 2D;
            x[4] = TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Minimum + interval * 4 + interval / 2D;
            x[5] = TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Minimum + interval * 5 + interval / 2D;
            x[6] = TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Minimum + interval * 6 + interval / 2D;
            x[7] = TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Minimum + interval * 7 + interval / 2D;

            TGC1_DEPTH.Text = string.Format("{0:0,0.00}", x[0]);
            TGC2_DEPTH.Text = string.Format("{0:0,0.00}", x[1]);
            TGC3_DEPTH.Text = string.Format("{0:0,0.00}", x[2]);
            TGC4_DEPTH.Text = string.Format("{0:0,0.00}", x[3]);
            TGC5_DEPTH.Text = string.Format("{0:0,0.00}", x[4]);
            TGC6_DEPTH.Text = string.Format("{0:0,0.00}", x[5]);
            TGC7_DEPTH.Text = string.Format("{0:0,0.00}", x[6]);
            TGC8_DEPTH.Text = string.Format("{0:0,0.00}", x[7]);

        }

        private void TgcTestDrawGraph()
        {
            //Count++;
            //debug_text.AppendText("tgctestpaint count: " + Count.ToString() + "\r\n");

            y[0] = TGC1_TRACK.Value/100D;
            y[1] = TGC2_TRACK.Value / 100D;
            y[2] = TGC3_TRACK.Value / 100D;
            y[3] = TGC4_TRACK.Value / 100D;
            y[4] = TGC5_TRACK.Value / 100D;
            y[5] = TGC6_TRACK.Value / 100D;
            y[6] = TGC7_TRACK.Value / 100D;
            y[7] = TGC8_TRACK.Value / 100D;

            TGC_GRAPH_TEST.Series["Curve"].Points.Clear();
            TGC_GRAPH_TEST.Series["Points"].Points.Clear();
            TGC_GRAPH_TEST.Series["Line"].Points.Clear();

            if (CSHARP_CURVE_RADIO.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    TGC_GRAPH_TEST.Series["Curve"].Points.AddXY(x[i], y[i]);
                    TGC_GRAPH_TEST.Series["Points"].Points.AddXY(x[i], y[i]);
                }
            }
            else if (CUBIC_SPLINE_RADIO.Checked)
            {
                PlotSplineInterpolation();
            }
            else if (HERMIT_SPLINE_RADIO.Checked)
            {
                PlotHermitInterpolation();
            }
            else if(CMROM_SPLINE_RADIO.Checked)
            {
                CatmullRomSpline(y);

            }
        }

        public void CatmullRomSpline(double [] y)
        {
        
            double t0 = 0;
            double t1 = Calcurate_t(t0, x[1], x[0], y[1], y[0]);
            double t2 = Calcurate_t(t1, x[2], x[1], y[2], y[1]);
            double t3 = Calcurate_t(t2, x[3], x[2], y[3], y[2]);
            double t4 = Calcurate_t(t3, x[4], x[3], y[4], y[3]);
            double t5 = Calcurate_t(t4, x[5], x[4], y[5], y[4]);
            double t6 = Calcurate_t(t5, x[6], x[5], y[6], y[5]);
            double t7 = Calcurate_t(t6, x[7], x[6], y[7], y[6]);

            var C0 = CatmullRom(t0, t1, t2, t3, x[0], y[0], x[0], y[0], x[1], y[1], x[2], y[2]);
            var C1 = CatmullRom(t0, t1, t2, t3, x[0], y[0], x[1], y[1], x[2], y[2], x[3], y[3]);
            var C2 = CatmullRom(t1, t2, t3, t4, x[1], y[1], x[2], y[2], x[3], y[3], x[4], y[4]);
            var C3 = CatmullRom(t2, t3, t4, t5, x[2], y[2], x[3], y[3], x[4], y[4], x[5], y[5]);
            var C4 = CatmullRom(t3, t4, t5, t6, x[3], y[3], x[4], y[4], x[5], y[5], x[6], y[6]);
            var C5 = CatmullRom(t4, t5, t6, t7, x[4], y[4], x[5], y[5], x[6], y[6], x[7], y[7]);
            var C6 = CatmullRom(t4, t5, t6, t7, x[5], y[5], x[6], y[6], x[7], y[7], x[7], y[7]);

            Chart("catmull-Rom Spline", C0.Item1, C0.Item2,
                C1.Item1, C1.Item2,
                C2.Item1, C2.Item2,
                C3.Item1, C3.Item2,
                C4.Item1, C4.Item2,
                C5.Item1, C5.Item2,
                C6.Item1, C6.Item2);
        }




        // t 값을 계산하는 코드입니다.
        private double Calcurate_t(double t_i, double x1, double x0, double y1, double y0)
        {
            float alpha = 0.5f;
            double t = 0;

            double sub_x = x1 - x0;

            double sub_y = y1 - y0;

            double pow_x = Math.Pow(sub_x, 2);

            double pow_y = Math.Pow(sub_y, 2);

            double x_Plus_y = pow_x + pow_y;

            double sqrtXPY = Math.Sqrt(x_Plus_y);

            double powSqrtXpY = Math.Pow(sqrtXPY, alpha);

            t = powSqrtXpY + t_i;

            return t;
        }

        // t값들과 (x,y) 포인터 값들을 이용하여 Catmull-Rom 방정식을 구하는 코드입니다.
        private (double[], double[]) CatmullRom(
            double t0, double t1, double t2, double t3,
            double p0_x, double p0_y,
            double p1_x, double p1_y,
            double p2_x, double p2_y,
            double p3_x, double p3_y)
        {
            double[] P0_x = new double[146];
            for (int i = 0; i < 146; i++)
            {
                P0_x[i] = p0_x;
            }
            double[] P0_y = new double[146];
            for (int i = 0; i < 146; i++)
            {
                P0_y[i] = p0_y;
            }
            double[] P1_x = new double[146];
            for (int i = 0; i < 146; i++)
            {
                P1_x[i] = p1_x;
            }
            double[] P1_y = new double[146];
            for (int i = 0; i < 146; i++)
            {
                P1_y[i] = p1_y;
            }

            double[] P2_x = new double[146];
            for (int i = 0; i < 146; i++)
            {
                P2_x[i] = p2_x;
            }
            double[] P2_y = new double[146];
            for (int i = 0; i < 146; i++)
            {
                P2_y[i] = p2_y;
            }
            double[] P3_x = new double[146];
            for (int i = 0; i < 146; i++)
            {
                P3_x[i] = p3_x;
            }
            double[] P3_y = new double[146];
            for (int i = 0; i < 146; i++)
            {
                P3_y[i] = p3_y;
            }

            double[] A1_x = new double[146];
            double[] A1_y = new double[146];

            double[] A2_x = new double[146];
            double[] A2_y = new double[146];

            double[] A3_x = new double[146];
            double[] A3_y = new double[146];

            double[] B1_x = new double[146];
            double[] B1_y = new double[146];

            double[] B2_x = new double[146];
            double[] B2_y = new double[146];

            double[] C_x = new double[146];
            double[] C_y = new double[146];


            double[] t = new double[146];
            t[0] = t1;

            for (int i = 1; i < 146; i++)
            {
                t[i] = t[i - 1] + ((t2 - t1) / 146);
            }


            double t3t2 = t3 - t2;
            double t3t1 = t3 - t1;
            double[] t3t = new double[146];
            for (int i = 0; i < 146; i++)
            {
                t3t[i] = t3 - t[i];
            }

            double t2t1 = t2 - t1;
            double t2t0 = t2 - t0;
            double[] t2t = new double[146];
            for (int i = 0; i < 146; i++)
            {
                t2t[i] = t2 - t[i];
            }

            double t1t0 = t1 - t0;
            double[] t1t = new double[146];
            for (int i = 0; i < 146; i++)
            {
                t1t[i] = t1 - t[i];
            }

            double[] tt2 = new double[146];
            for (int i = 0; i < 146; i++)
            {
                tt2[i] = t[i] - t2;
            }

            double[] tt1 = new double[146];
            for (int i = 0; i < 146; i++)
            {
                tt1[i] = t[i] - t1;
            }

            double[] tt0 = new double[146];
            for (int i = 0; i < 146; i++)
            {
                tt0[i] = t[i] - t0;
            }

            double[] t1t_div_t1t0 = new double[146];
            for (int i = 0; i < 146; i++)
            {
                t1t_div_t1t0[i] = t1t[i] / t1t0;
            }

            double[] tt0_div_t1t0 = new double[146];
            for (int i = 0; i < 146; i++)
            {
                tt0_div_t1t0[i] = tt0[i] / t1t0;
            }

            double[] t2t_div_t2t1 = new double[146];
            for (int i = 0; i < 146; i++)
            {
                t2t_div_t2t1[i] = t2t[i] / t2t1;
            }

            double[] tt1_div_t2t1 = new double[146];
            for (int i = 0; i < 146; i++)
            {
                tt1_div_t2t1[i] = tt1[i] / t2t1;
            }

            double[] t3t_div_t3t2 = new double[146];
            for (int i = 0; i < 146; i++)
            {
                t3t_div_t3t2[i] = t3t[i] / t3t2;
            }

            double[] tt2_div_t3t2 = new double[146];
            for (int i = 0; i < 146; i++)
            {
                tt2_div_t3t2[i] = tt2[i] / t3t2;
            }

            for (int i = 0; i < 146; i++)
            {
                A1_x[i] = (t1t_div_t1t0[i] * (P0_x[i]) + (tt0_div_t1t0[i] * P1_x[i]));
            }

            for (int i = 0; i < 146; i++)
            {
                A1_y[i] = (t1t_div_t1t0[i] * (P0_y[i]) + (tt0_div_t1t0[i] * P1_y[i]));
            }

            for (int i = 0; i < 146; i++)
            {
                A2_x[i] = (t2t_div_t2t1[i] * (P1_x[i]) + (tt1_div_t2t1[i] * P2_x[i]));
            }

            for (int i = 0; i < 146; i++)
            {
                A2_y[i] = (t2t_div_t2t1[i] * (P1_y[i]) + (tt1_div_t2t1[i] * P2_y[i]));
            }

            for (int i = 0; i < 146; i++)
            {
                A3_x[i] = (t3t_div_t3t2[i] * (P2_x[i]) + (tt2_div_t3t2[i] * P3_x[i]));
            }

            for (int i = 0; i < 146; i++)
            {
                A3_y[i] = (t3t_div_t3t2[i] * (P2_y[i]) + (tt2_div_t3t2[i] * P3_y[i]));
            }


            double[] t2t_div_t2t0 = new double[146];
            for (int i = 0; i < 146; i++)
            {
                t2t_div_t2t0[i] = t2t[i] / t2t0;
            }

            double[] tt0_div_t2t0 = new double[146];
            for (int i = 0; i < 146; i++)
            {
                tt0_div_t2t0[i] = tt0[i] / t2t0;
            }

            double[] t3t_div_t3t1 = new double[146];
            for (int i = 0; i < 146; i++)
            {
                t3t_div_t3t1[i] = t3t[i] / t3t1;
            }

            double[] tt1_div_t3t1 = new double[146];
            for (int i = 0; i < 146; i++)
            {
                tt1_div_t3t1[i] = tt1[i] / t3t1;
            }

            double[] tt1_div_t2t0 = new double[146];
            for (int i = 0; i < 146; i++)
            {
                tt1_div_t2t0[i] = tt1[i] / t2t0;
            }

            for (int i = 0; i < 146; i++)
            {
                B1_x[i] = (t2t_div_t2t0[i] * A1_x[i]) + (tt0_div_t2t0[i] * A2_x[i]);
            }

            for (int i = 0; i < 146; i++)
            {
                B1_y[i] = (t2t_div_t2t0[i] * A1_y[i]) + (tt0_div_t2t0[i] * A2_y[i]);
            }

            for (int i = 0; i < 146; i++)
            {
                B2_x[i] = (t3t_div_t3t1[i] * A2_x[i]) + (tt1_div_t3t1[i] * A3_x[i]);
            }

            for (int i = 0; i < 146; i++)
            {
                B2_y[i] = (t3t_div_t3t1[i] * A2_y[i]) + (tt1_div_t3t1[i] * A3_y[i]);
            }

            for (int i = 0; i < 146; i++)
            {
                C_x[i] = (t2t_div_t2t1[i] * B1_x[i]) + (tt1_div_t2t1[i] * B2_x[i]);
            }


            for (int i = 0; i < 146; i++)
            {
                C_y[i] = ((t2t_div_t2t1[i] * B1_y[i]) + (tt1_div_t2t1[i] * B2_y[i]));
            }

            for (int i = 0; i < C_y.Length; i++)
            {
                Console.Write(C_y[i] + ",");
            }
            return (C_x, C_y);
        }


         private void Chart(string title,
            double[] x0, double[] y0,
            double[] x1, double[] y1,
            double[] x2, double[] y2,
            double[] x3, double[] y3,
            double[] x4, double[] y4,
            double[] x5, double[] y5,
            double[] x6, double[] y6)
        {
            var chart = new Chart();
            chart.Size = new Size(1025, 767);
            chart.Titles.Add(title);
            chart.Legends.Add(new Legend("Legend"));

         
            CreateSeries(CreateDataPoints(x0, y0), Color.Blue, MarkerStyle.None);
            CreateSeries(CreateDataPoints(x1, y1), Color.Blue, MarkerStyle.None);
            CreateSeries(CreateDataPoints(x2, y2), Color.Blue, MarkerStyle.None);
            CreateSeries(CreateDataPoints(x3, y3), Color.Blue, MarkerStyle.None);
            CreateSeries(CreateDataPoints(x4, y4), Color.Blue, MarkerStyle.None);
            CreateSeries(CreateDataPoints(x5, y5), Color.Blue, MarkerStyle.None);
            CreateSeries(CreateDataPoints(x6, y6), Color.Blue, MarkerStyle.None);

            //TGC_GRAPH_TEST.Series.Add(s0);
            //TGC_GRAPH_TEST.Series.Add(s1);
            //TGC_GRAPH_TEST.Series.Add(s2);
            //TGC_GRAPH_TEST.Series.Add(s3);
            //TGC_GRAPH_TEST.Series.Add(s4);
            //TGC_GRAPH_TEST.Series.Add(s5);
            //TGC_GRAPH_TEST.Series.Add(s6);

            //ca.RecalculateAxesScale();
            //ca.AxisX.Minimum = 0;
            //ca.AxisX.Maximum = 1030;
            //int nIntervals = (x1.Length - 1);
            //nIntervals = Math.Max(4, nIntervals);
            //ca.AxisX.Interval = 146.15;
        }


        private List<DataPoint> CreateDataPoints(double[] x, double[] y)
        {
            Debug.Assert(x.Length == y.Length);
            List<DataPoint> points = new List<DataPoint>();

            for (int i = 0; i < x.Length; i++)
            {
                points.Add(new DataPoint(x[i], y[i]));
            }

            return points;
        }

        private void CreateSeries(IEnumerable<DataPoint> points, Color color, MarkerStyle markerStyle = MarkerStyle.None)
        {
          
            foreach (var p in points)
            {
                TGC_GRAPH_TEST.Series["Points"].Points.Add(p);
            }
        }


        public void PlotSplineInterpolation()
        {
            //matlab ref
            double init_x = TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Minimum;
            double init_y = -0.7633;
            double fin_x = TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Maximum;
            double fin_y = 0.9826;

            double[] F2 = new double[10];
            F2[0] = 0;
            F2[9] = 0;

            double Z = interval * 2D / 3D;
            double X =interval/6D;
            double[] G = new double[8];

            G[0] = (y[1] - y[0]) / (interval) - 2D * (y[0] - init_y) / (interval);
            G[7] = 2D * (fin_y - y[7]) / (interval) - (y[7] - y[6]) / (interval);

            for (int i =1; i < 7; i++)
            {
                G[i] = (y[i+1] - y[i]) / interval - (y[i] - y[i - 1]) / interval;
            }

            //abcd//
            //a=c=X//
            //b=Z//
            double w = X / Z;
            double b = Z - w * X;
            double[] d = new double[8];

            d[0] = G[0];
            for(int i =1; i<8; i++)
            {
                d[i] = G[i] - w * d[i - 1];
            }

            F2[8] = d[7] / b;

            for (int i= 6; i>-1; i--)
            {
                F2[i + 1] = (d[i] - X * F2[i + 2])/b;
            }


            double B = 0;
            double C = 0;
            double D = 0;
            double temp_y = 0;

            for (double A = 1; A > 0; A -= 2D / interval)
            {
                B = 1 - A;
                C = (Math.Pow(A, 3) - A) * Math.Pow(interval / 2D, 2) / 6D;
                D = (Math.Pow(B, 3) - B) * Math.Pow(interval / 2D, 2) / 6D;

                temp_y = A * init_y + B * y[0] + C * F2[0] + D * F2[1];

                TGC_GRAPH_TEST.Series["Line"].Points.AddXY(init_x + B * interval/2D, temp_y);
            }
            TGC_GRAPH_TEST.Series["Points"].Points.AddXY(init_x,init_y);

            for (int i = 0; i<7;i++)
            {
                for(double A = 1; A>0; A-=1/interval)
                {
                    B = 1 - A;
                    C = (Math.Pow(A, 3) - A) * Math.Pow(interval, 2)/6D;
                    D = (Math.Pow(B, 3) - B) * Math.Pow(interval, 2)/6D;

                    temp_y = A * y[i] + B * y[i + 1]+ C * F2[i+1] + D * F2[i + 2];

                    TGC_GRAPH_TEST.Series["Line"].Points.AddXY(x[i]+B*interval, temp_y);
                }
                TGC_GRAPH_TEST.Series["Points"].Points.AddXY(x[i], y[i]);
            }

            TGC_GRAPH_TEST.Series["Points"].Points.AddXY(x[7], y[7]);

            for (double A = 1; A >= 0; A -= 2D / interval)
            {
                B = 1 - A;
                C = (Math.Pow(A, 3) - A) * Math.Pow(interval/2D, 2) / 6D;
                D = (Math.Pow(B, 3) - B) * Math.Pow(interval/2D, 2) / 6D;

                temp_y = A * y[7] + B * fin_y + C * F2[8] + D * F2[9];

                TGC_GRAPH_TEST.Series["Line"].Points.AddXY(x[7] + B * interval/2D, temp_y);
            }
            TGC_GRAPH_TEST.Series["Points"].Points.AddXY(fin_x, fin_y);

            //debug_text.AppendText($"Cubic Spline interp 점 개수: {TGC_GRAPH_TEST.Series["Line"].Points.Count()}");
        }

        public void PlotHermitInterpolation()
        {
            double[] m = new double[10];
            double temp_y = 0;
            double init_x = TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Minimum;
            double init_y = -0.3075;
            double fin_x = TGC_GRAPH_TEST.ChartAreas["Draw"].AxisX.Maximum;
            double fin_y = 0.9118;

            m[0] = (y[0] - init_y) / (x[0]- init_x);
            m[1] = ((y[1] - y[0]) / (x[1] - x[0]) + (y[0] - init_y) / (x[0] - init_y)) / 2D;
            m[8] = ((fin_y - y[7]) / (fin_x - x[7]) + (fin_y - y[7]) / (fin_x - x[7])) / 2D;
            m[9] = (fin_y - y[7]) / (fin_x - x[7]);

            for (int i = 1; i < 7; i++)
            {
                m[i+1] = ((y[i + 1] - y[i]) / (x[i + 1] - x[i]) + (y[i] - y[i - 1]) / (x[i] - x[i - 1])) / 2D;
            }

            if (M_OP_MONO_CHECK.Checked)
            {
                double[] alpha = new double[7];
                double[] beta = new double[7];
                double[] tou = new double[7];

                for (int i = 0; i < 7; i++)
                {
                    if ((y[i + 1] - y[i]) / (x[i + 1] - x[i]) <= Math.Exp(-9))
                    {
                        m[i] = 0;
                        m[i + 1] = 0;
                    }
                    else
                    {
                        alpha[i] = m[i] / ((y[i + 1] - y[i]) / (x[i + 1] - x[i]));
                        beta[i] = m[i + 1] / ((y[i + 1] - y[i]) / (x[i + 1] - x[i]));


                        if ((alpha[i] > 3) ^ (beta[i] > 3))
                        {
                            m[i] = 3D * (y[i + 1] - y[i]) / (x[i + 1] - x[i]);
                        }
                        else
                        {
                            tou[i] = 3D / Math.Sqrt(Math.Pow(alpha[i], 2) + Math.Pow(beta[i], 2));

                            m[i] = tou[i] * alpha[i] * (y[i + 1] - y[i]) / (x[i + 1] - x[i]);
                            m[i + 1] = tou[i] * beta[i] * (y[i + 1] - y[i]) / (x[i + 1] - x[i]);
                        }
                    }

                }
                
                //debug_text.AppendText("0: " + alpha[0].ToString() + "\r\n" +
                //                      "1: " + alpha[1].ToString() + "\r\n" +
                //                      "2: " + alpha[2].ToString() + "\r\n" +
                //                      "3: " + alpha[3].ToString() + "\r\n" +
                //                      "4: " + alpha[4].ToString() + "\r\n" +
                //                      "5: " + alpha[5].ToString() + "\r\n" +
                //                      "6: " + alpha[6].ToString() + "\r\n" );
            }

            for (double t = 0; t < 1; t += 1D / 64D)
            {
                temp_y = (2D * Math.Pow(t, 3) - 3D * Math.Pow(t, 2) + 1D) * init_y +
                    (Math.Pow(t, 3) - 2D * Math.Pow(t, 2) + t) * (x[0] - init_x) * m[0] +
                    (-2D * Math.Pow(t, 3) + 3D * Math.Pow(t, 2)) * y[0] +
                    (Math.Pow(t, 3) - Math.Pow(t, 2)) * (x[0] - init_x) * m[1];


                TGC_GRAPH_TEST.Series["Line"].Points.AddXY(init_x+ t * interval/2D, temp_y);
            }

            TGC_GRAPH_TEST.Series["Points"].Points.AddXY(init_x, init_y);

            for (int i = 0; i < 7; i++)
            {

                for (double t = 0; t < 1; t += 1D/128D)
                {
                    temp_y = (2D * Math.Pow(t, 3) - 3D * Math.Pow(t, 2) + 1D) * y[i] +
                        (Math.Pow(t, 3) - 2D * Math.Pow(t, 2) + t) * (x[i + 1] - x[i]) * m[i+1] +
                        (-2D * Math.Pow(t, 3) + 3D * Math.Pow(t, 2)) * y[i + 1] +
                        (Math.Pow(t, 3) - Math.Pow(t, 2)) * (x[i + 1] - x[i]) * m[i+2];


                    TGC_GRAPH_TEST.Series["Line"].Points.AddXY(x[i] + t * interval, temp_y);
                }

                TGC_GRAPH_TEST.Series["Points"].Points.AddXY(x[i], y[i]);
            }

            TGC_GRAPH_TEST.Series["Points"].Points.AddXY(x[7], y[7]);

            for (double t = 0; t <= 1; t += 1D / 64D)
            {
                temp_y = (2D * Math.Pow(t, 3) - 3D * Math.Pow(t, 2) + 1D) * y[7] +
                    (Math.Pow(t, 3) - 2D * Math.Pow(t, 2) + t) * (fin_x - x[7]) * m[8] +
                    (-2D * Math.Pow(t, 3) + 3D * Math.Pow(t, 2)) * fin_y +
                    (Math.Pow(t, 3) - Math.Pow(t, 2)) * (fin_x - x[7]) * m[9];

                TGC_GRAPH_TEST.Series["Line"].Points.AddXY(x[7] + t * interval/2D, temp_y);
            }
            TGC_GRAPH_TEST.Series["Points"].Points.AddXY(fin_x, fin_y);

            debug_text.AppendText($"Cubic Hermit interp 점 개수:: { TGC_GRAPH_TEST.Series["Line"].Points.Count()}개");
        }


        public Tuple<double, double> chart_cord(MouseEventArgs e)
        {
            HitTestResult result = TGC_GRAPH_TEST.HitTest(e.Location.X, e.Location.Y);
            
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                double xVal = result.ChartArea.AxisX.PixelPositionToValue(e.Location.X);
                double yVal = result.ChartArea.AxisY.PixelPositionToValue(e.Location.Y);

                return new Tuple<double, double>(xVal, yVal);
            }

            return new Tuple<double, double>(0, 0);
        }


        private void chart3_MouseMove(object sender, MouseEventArgs e)
        {

            Tuple<double, double> cordinates = chart_cord(e);
            TGC_XY_POINT_LABEL.Text = "(X = " + cordinates.Item1.ToString("F4") + ", Y = " + cordinates.Item2.ToString("F4") + ")";

            //그래프 포인트에 마우스 올려놓을 시 툴팁 작동
            TGC_GRAPH_TEST.Series[0].ToolTip = "X=#VALX, Y=#VALY";

            //tooltip.RemoveAll();
            //mousePosition = null;

        }


        private void BtnSplinePlot_Click(object sender, EventArgs e)
        {
            TGC_ERROR_NAME.Enabled = true;
            TGC_ERROR_VALUE.Enabled = true;
            bool debug = false;
            int count = 0;
            string dataPath = Path.GetFullPath(@"..\..\..\settingFile\splineData.bin");
            FileInfo fileInfo = new FileInfo(dataPath);

            if (!fileInfo.Exists)
            {
                MessageBox.Show("can't find data file", "file not exists");
                return;
            }

            byte[] ytemp = new byte[1025];
            using (BinaryReader reader = new BinaryReader(File.Open(dataPath, FileMode.Open)))
            {
                ytemp = reader.ReadBytes(1025 * sizeof(double));
            }

            double[] yData = new double[1025];
            for (int i = 0; i < ytemp.Count(); i += 8)
            {
                yData[i / 8] = BitConverter.ToDouble(ytemp, i);
            }

            if (debug)
            {
                debug_text.AppendText($"yByte count: {ytemp.Count()}\r\n");
                foreach (double data in yData)
                {
                    debug_text.AppendText($"yData[{count}] = {data}\r\n");
                    count++;
                }
            }

            double[] yPoints = new double[8] { 0, 0.3, 0.12, 0.40, 0.60, 0.80, 0.86, 0.90 };
            count = 0;

            TGC_GRAPH_TEST.Series["Mtlb Points"].Points.Clear();
            TGC_GRAPH_TEST.Series["Mtlb Spline"].Points.Clear();

            for (int x = 1024 / 16; x <= 1024 * 7 / 8 + 1024 / 16; x += 1024 / 8)
            {
                TGC_GRAPH_TEST.Series["Mtlb Points"].Points.AddXY(x, yPoints[count]);
                count++;
            }

            for (int x = 0; x <= 1024; x++)
            {
                TGC_GRAPH_TEST.Series["Mtlb Spline"].Points.AddXY(x, yData[x]);
            }
        }

        private void btnPchipPlot_Click(object sender, EventArgs e)
        {
            TGC_ERROR_NAME.Enabled = true;
            TGC_ERROR_VALUE.Enabled = true;

            bool debug = false;
            int count = 0;

            string dataPath = Path.GetFullPath(@"..\..\..\settingFile\pchipData.bin");
            FileInfo fileInfo = new FileInfo(dataPath);

            if (!fileInfo.Exists)
            {
                MessageBox.Show("can't find data file", "file not exists");
                return;
            }

            byte[] ytemp = new byte[1025];

            using (BinaryReader reader = new BinaryReader(File.Open(dataPath, FileMode.Open)))
            {
                ytemp = reader.ReadBytes(1025 * sizeof(double));
            }


            double[] yData = new double[1025];
            for (int i = 0; i < ytemp.Count(); i += 8)
            {
                yData[i / 8] = BitConverter.ToDouble(ytemp, i);
            }

            if (debug)
            {
                debug_text.AppendText($"yByte count: {ytemp.Count()}\r\n");
                foreach (double data in yData)
                {
                    debug_text.AppendText($"yData[{count}] = {data}\r\n");
                    count++;
                }
            }

            double[] yPoints = new double[8] { 0, 0.3, 0.12, 0.40, 0.60, 0.80, 0.86, 0.90 };


            TGC_GRAPH_TEST.Series["Mtlb Points"].Points.Clear();
            TGC_GRAPH_TEST.Series["Mtlb pchip"].Points.Clear();
            count = 0;
            for (int x = 1024 / 16; x <= 1024 * 7 / 8 + 1024 / 16; x += 1024 / 8)
            {
                TGC_GRAPH_TEST.Series["Mtlb Points"].Points.AddXY(x, yPoints[count]);
                count++;
            }

            for (int x = 0; x <= 1024; x++)
            {
                TGC_GRAPH_TEST.Series["Mtlb pchip"].Points.AddXY(x, yData[x]);
            }
        }

        private void BtnClearTestPlot_Click(object sender, EventArgs e)
        {
            TGC_ERROR_NAME.Enabled = false;
            TGC_ERROR_VALUE.Enabled = false;
            TGC_ERROR_VALUE.Text = "";

            TGC_GRAPH_TEST.Series["Mtlb Points"].Points.Clear();
            TGC_GRAPH_TEST.Series["Mtlb pchip"].Points.Clear();
            TGC_GRAPH_TEST.Series["Mtlb Spline"].Points.Clear();
        }

        private void TgcErrorAcc()
        {
            if(TGC_GRAPH_TEST.Series["Line"].Points.Count < 1)
            {
                debug_text.AppendText("Line의 점이 존재하지 않습니다.\r\n");
                return;
            }

            string seriesName = "Mtlb Spline";
            if (TGC_GRAPH_TEST.Series["Mtlb pchip"].Points.Any())
            {
                seriesName = "Mtlb pchip";
            }

            double ErrValue = 0;
            for (int i =0; i<1024; i++)
            {
                 ErrValue+= Math.Pow( TGC_GRAPH_TEST.Series[seriesName].Points[i].YValues[0] - TGC_GRAPH_TEST.Series["Line"].Points[i].YValues[0],2);
            }

            TGC_ERROR_VALUE.Text = ErrValue.ToString();
        }

        private void TGC1_TRACK_Scroll(object sender, EventArgs e)
        {
            TGC1_GAIN.Text = TGC1_TRACK.Value.ToString();
            TgcTestDrawGraph();
            if (TGC_ERROR_VALUE.Enabled)
            {
                TgcErrorAcc();
            }
        }

        private void TGC2_TRACK_Scroll(object sender, EventArgs e)
        {
            TGC2_GAIN.Text = TGC2_TRACK.Value.ToString();
            TgcTestDrawGraph();
            if (TGC_ERROR_VALUE.Enabled)
            {
                TgcErrorAcc();
            }
        }

        private void TGC3_TRACK_Scroll(object sender, EventArgs e)
        {
            TGC3_GAIN.Text = TGC3_TRACK.Value.ToString();
            TgcTestDrawGraph();
            if (TGC_ERROR_VALUE.Enabled)
            {
                TgcErrorAcc();
            }
        }

        private void TGC4_TRACK_Scroll(object sender, EventArgs e)
        {
            TGC4_GAIN.Text = TGC4_TRACK.Value.ToString();
            TgcTestDrawGraph();
            if (TGC_ERROR_VALUE.Enabled)
            {
                TgcErrorAcc();
            }
        }

        private void TGC5_TRACK_Scroll(object sender, EventArgs e)
        {
            TGC5_GAIN.Text = TGC5_TRACK.Value.ToString();
            TgcTestDrawGraph();
            if (TGC_ERROR_VALUE.Enabled)
            {
                TgcErrorAcc();
            }
        }

        private void TGC6_TRACK_Scroll(object sender, EventArgs e)
        {
            TGC6_GAIN.Text = TGC6_TRACK.Value.ToString();
            TgcTestDrawGraph();
            if (TGC_ERROR_VALUE.Enabled)
            {
                TgcErrorAcc();
            }
        }

        private void TGC7_TRACK_Scroll(object sender, EventArgs e)
        {
            TGC7_GAIN.Text = TGC7_TRACK.Value.ToString();
            TgcTestDrawGraph();
            if (TGC_ERROR_VALUE.Enabled)
            {
                TgcErrorAcc();
            }
        }

        private void TGC8_TRACK_Scroll(object sender, EventArgs e)
        {
            TGC8_GAIN.Text = TGC8_TRACK.Value.ToString();
            TgcTestDrawGraph();
            if (TGC_ERROR_VALUE.Enabled)
            {
                TgcErrorAcc();
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////////
        /// TAB name: AFE5809 Register Map
        ///////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// AFE5809 Register Grid Map initialization
        /// </summary>
        #region AFE Register Grid Map Function
        public void SetupDataGridView(List<uint> addr, List<string> dft_hex, List<string> function)
        {
            //init datagridview
            AFE_REGIST_MAP_GRID.Rows.Clear();

            //prepare data
            List<string> dft_bit = new List<string>();
            int temp = 0;
            string temps = string.Empty;

            for (int i = 0; i < dft_hex.Count; i++)
            {
                if (dft_hex[i] != "-")
                {
                    temp = Convert.ToInt32(dft_hex[i], 16);
                    temps = Convert.ToString(temp, 2);
                    if (temps.Count() != 16)
                    {
                        for (int k = 16 - temps.Count(); k > 0; k--)
                        {
                            temps = "0" + temps;
                        }
                    }
                    dft_bit.Add(temps);
                }
                else
                {
                    dft_bit.Add("----------------");
                }
            }

            //data columns
            AFE_REGIST_MAP_GRID.ColumnCount = 19;
            AFE_REGIST_MAP_GRID.Columns[0].Name = "ADDRESS";
            AFE_REGIST_MAP_GRID.Columns[1].Name = "RD_DATA";
            for (int i = 2; i < 18; i++)
            {
                AFE_REGIST_MAP_GRID.Columns[i].Name = (17 - i).ToString();
            }
            AFE_REGIST_MAP_GRID.Columns[18].Name = "COMPARE";

            Random random = new Random();
            //data add
            for (int j = 0; j < addr.Count; j++)
            {
                AFE_REGIST_MAP_GRID.Rows.Add("0x" + addr[j].ToString("X2").ToUpper(), "0x" + MathMethod.RandomInt_16To10(random).ToString("X4"), dft_bit[j][0], dft_bit[j][1], dft_bit[j][2], dft_bit[j][3], dft_bit[j][4], dft_bit[j][5], dft_bit[j][6], dft_bit[j][7], dft_bit[j][8], dft_bit[j][9], dft_bit[j][10], dft_bit[j][11], dft_bit[j][12], dft_bit[j][13], dft_bit[j][14], dft_bit[j][15], "compare");
            }

            //prepare function
            List<List<int>> Sn = new List<List<int>>();
            //List<string> ToolTips = new List<string>();
            int startNum = 0;
            int endNum = 0;

            for (int i = 0; i < function.Count(); i++)
            {
                Sn.Add(new List<int>());
                for (int j = 0; j < function[i].Count(); j++)
                {
                    if (function[i][j].ToString() == "[")
                    {
                        startNum = j + 1;
                    }
                    else if (function[i][j].ToString() == "]")
                    {
                        endNum = j - 1;
                    }

                    if (endNum != 0)
                    {
                        if ((startNum == endNum) ^ (startNum + 1 == endNum))
                        {
                            Sn[i].Add(int.Parse(function[i].Substring(startNum, endNum - startNum + 1)));
                        }
                        else
                        {
                            string[] vs = function[i].Substring(startNum, endNum - startNum + 1).Split(new char[] { ':' });

                            for (int k = int.Parse(vs[1]); k < int.Parse(vs[0]) + 1; k++)
                            {
                                Sn[i].Add(k);
                            }
                        }
                        endNum = 0;
                    }
                }
            }

            //compare and coloring data
            for (int i = 0; i < addr.Count; i++)
            {
                int k = Convert.ToInt32(AFE_REGIST_MAP_GRID.Rows[i].Cells[1].Value.ToString(), 16);
                string ks = Convert.ToString(k, 2);
                if (ks.Count() != 16)
                {
                    for (int l = 16 - ks.Count(); l > 0; l--)
                    {
                        ks = "0" + ks;
                    }
                }

                List<int> bitArray = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

                for (int j = 0; j < Sn[i].Count; j++)
                {
                    bitArray.Remove(Sn[i][j]);
                }

                for (int j = 0; j < bitArray.Count; j++)
                {
                    AFE_REGIST_MAP_GRID.Rows[i].Cells[17 - bitArray[j]].Style.BackColor = Color.Gray;
                }

                bool isRed = false;
                bool isnull = false;
                for (int j = 0; j < 16; j++)
                {
                    if ((ks[j] != dft_bit[i][j]) & AFE_REGIST_MAP_GRID.Rows[i].Cells[j + 2].Style.BackColor != Color.Gray)
                    {
                        AFE_REGIST_MAP_GRID.Rows[i].Cells[j + 2].Style.BackColor = Color.Red;
                        isRed = true;
                    }
                    else if (AFE_REGIST_MAP_GRID.Rows[i].Cells[j + 2].Style.BackColor != Color.Gray)
                    {
                        AFE_REGIST_MAP_GRID.Rows[i].Cells[j + 2].Style.BackColor = Color.Green;
                    }

                    //예외상황
                    if (dft_bit[i][j].ToString() == "-")
                    {
                        AFE_REGIST_MAP_GRID.Rows[i].Cells[j + 2].Style.BackColor = Color.Gray;
                        isnull = true;
                    }
                }

                if (isRed == true)
                {
                    AFE_REGIST_MAP_GRID.Rows[i].Cells[18].Value = "MissMatch";
                    AFE_REGIST_MAP_GRID.Rows[i].Cells[18].Style.BackColor = Color.Red;
                }
                else
                {
                    AFE_REGIST_MAP_GRID.Rows[i].Cells[18].Value = "Match";
                    AFE_REGIST_MAP_GRID.Rows[i].Cells[18].Style.BackColor = Color.Green;
                }

                //예외상황
                if (isnull == true)
                {
                    AFE_REGIST_MAP_GRID.Rows[i].Cells[18].Value = "NULL";
                    AFE_REGIST_MAP_GRID.Rows[i].Cells[18].Style.BackColor = Color.Gray;
                }
            }

            //datagridview format
            AFE_REGIST_MAP_GRID.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            AFE_REGIST_MAP_GRID.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AFE_REGIST_MAP_GRID.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in AFE_REGIST_MAP_GRID.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        #endregion

        ///////////////////////////////////////////////////////////////////////////////////////////////
        /// TAB name: File Setting 
        ///////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// EX) version check, Renew excel path and intialization
        /// </summary>
        #region File Setting Function
        //Version Check, open excel file and initialize
        public void VersionCheck()
        {
            if (FILE_VERSION_TXT.Text == "1.0.1")
            {
                //MessageBox.Show("Change\n1. 파일 추가 관리 탭 생성.\n2.프로그램 실행 시 xlsx파일 찾기", "UPDATE 1.0.1", MessageBoxButtons.OK);
            }
            else if (FILE_VERSION_TXT.Text == "1.0.2")
            {
                //MessageBox.Show("Change\n1. 테스크 기능 추가, Error 카운트 세는 기능 추가", "UPDATE 1.0.2", MessageBoxButtons.OK);
            }
            else if (FILE_VERSION_TXT.Text == "1.0.3")
            {
                //MessageBox.Show("Change\20200401", "UPDATE 1.0.3", MessageBoxButtons.OK);
            }
            else if (FILE_VERSION_TXT.Text == "1.0.4")
            {
                //MessageBox.Show("Change\20200408", "UPDATE 1.0.4", MessageBoxButtons.OK);
            }

            FILE_VERSION_LABEL.Text = "version 1.0.0 ~ 1.0.1, date: 2020/03/08\n Update: open excel file, repeat button, task function\n" +
                            "version 1.0.2, date: 2020/03/27\n Update: version check, open excel file and initialize\n" +
                            "version 1.0.3, date: 2020/04/02\n Update: read excel file and compare, adjust button velocity\n" +
                            "version 1.0.4 ~ 1.0.6, date: 2020/04/08~ 2020/09/04\n Update: ref of postec-ultra-sonic.sln. add function(video), ui. BF CUDA process with ImageProcess class\n" +
                            "version 1.0.5 date: 2020/04/29\n Update: TGC Figure graph draw, python connection\n" +
                            "version 1.0.7 date: 2020/12/02\n Update: RPC SPI Read/Write, change object name, remove python function, add tgc figure with 8 track bar\n" +
                            "version 1.0.8 date: 2020/12/23\n Update: increase OFN dummy value, initialzing Form";
        }

        //File Path Update
        public void FilePathUpdate()
        {
            FILE_LOCATION_TXT.Text = PathInfo.excelPath;
        }

        private void RenewExcelRegister(object sender, EventArgs e)
        {
            PathInfo.excelPath = PI.Search_Path();

            FilePathUpdate();

            DialogResult dialogResult = MessageBox.Show("프로그램을 다시 로드하고자 합니다.\nYes: 연결된 하드웨어를 같이 reset합니다.\nNo: register값만 다시 읽어드립니다.", "Initialize Program", MessageBoxButtons.YesNo);

            rtcRegisterInfo.RegisterClear();
            AcqRegisterInfo.RegisterClear();
            AnaRegisterInfo.RegisterClear();
            AfeRegisterInfo.RegisterClear();

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(PathInfo.excelPath);

            rtcRegisterInfo.RegisterUpdate("Rtc_FPGA", xlWorkBook);
            AcqRegisterInfo.RegisterUpdate("Acquisition_FPGA", xlWorkBook);
            AnaRegisterInfo.RegisterUpdate("Analog_FPGA", xlWorkBook);
            AfeRegisterInfo.RegisterUpdate("AFE5809", 1, xlWorkBook);

            xlWorkBook.Close();
            Marshal.ReleaseComObject(xlWorkBook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            //hostInterface = new HostInterface(this,pcieInterface,serialPortConnection, rtcRegisterInfo, AcqRegisterInfo, AnaRegisterInfo);

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();


            if (dialogResult == DialogResult.Yes)
            {
                //Initialize AFE5809 Register MAP
                SetupDataGridView(AfeRegisterInfo.registerAddr, AfeRegisterInfo.registerDefault, AfeRegisterInfo.registerFunction);

                PLLReset();
                Afe5809Reset();
                AcquisitionReset();
            }

        }




        #endregion

        
    }
}
