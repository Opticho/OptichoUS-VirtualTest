namespace AnalogJigTestApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.serialMaster = new System.IO.Ports.SerialPort(this.components);
            this.debug_text = new System.Windows.Forms.TextBox();
            this.AFE_MAP_TAB = new System.Windows.Forms.TabPage();
            this.AFE_REGIST_MAP_GRID = new System.Windows.Forms.DataGridView();
            this.FILE_TAB = new System.Windows.Forms.TabPage();
            this.FILE_COMMON_GROUP = new System.Windows.Forms.GroupBox();
            this.FILE_LOCATION_TXT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FILE_VERSION_LABEL = new System.Windows.Forms.Label();
            this.BtnFolderOpen = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.FILE_VERSION_TXT = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.COMPORT_TAB = new System.Windows.Forms.TabPage();
            this.label90 = new System.Windows.Forms.Label();
            this.BtnClearOutBuffer = new System.Windows.Forms.Button();
            this.BtnClearInBuffer = new System.Windows.Forms.Button();
            this.COMPORT_RICH = new System.Windows.Forms.RichTextBox();
            this.SerialComboBox = new System.Windows.Forms.ComboBox();
            this.COMPORT_GROUP = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HOST_TEST_TAB = new System.Windows.Forms.TabPage();
            this.TEST_INTERFACE_GROUP = new System.Windows.Forms.GroupBox();
            this.TEST_REGIST_NAME_COMB = new System.Windows.Forms.ComboBox();
            this.label124 = new System.Windows.Forms.Label();
            this.TEST_REGIST_VALUE_TXT = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.TEST_REGIST_ADDR_TXT = new System.Windows.Forms.TextBox();
            this.label120 = new System.Windows.Forms.Label();
            this.TEST_REGIST_AREA_COMB = new System.Windows.Forms.ComboBox();
            this.BtnTestRegistSearch = new System.Windows.Forms.Button();
            this.label55 = new System.Windows.Forms.Label();
            this.TEST_DELAY_TXT = new System.Windows.Forms.TextBox();
            this.TEST_DELAY_TRACK = new System.Windows.Forms.TrackBar();
            this.BtnClearTaskLog = new System.Windows.Forms.Button();
            this.TEST_TASK_LOG = new System.Windows.Forms.RichTextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.BtnPLLReset = new System.Windows.Forms.Button();
            this.TEST_CONTINUOUS_CHECK = new System.Windows.Forms.CheckBox();
            this.AFE_HOST_GROUP = new System.Windows.Forms.GroupBox();
            this.AFE_SEL_FPGA = new System.Windows.Forms.TextBox();
            this.ADC_DIG_SEL_GROUP = new System.Windows.Forms.Panel();
            this.RBtnAdcVca = new System.Windows.Forms.RadioButton();
            this.RBtnDig = new System.Windows.Forms.RadioButton();
            this.label49 = new System.Windows.Forms.Label();
            this.AFE_SEL_COMB = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.AFE_ADDR_TXT = new System.Windows.Forms.TextBox();
            this.BtnAfeHostRead = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.BtnAfeHostWrite = new System.Windows.Forms.Button();
            this.AFE_WDATA_TXT = new System.Windows.Forms.TextBox();
            this.AFE_RDATA_TXT = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.ANA_HOST_GROUP = new System.Windows.Forms.GroupBox();
            this.ANA_SEL_FPGA = new System.Windows.Forms.TextBox();
            this.ANA_FPGA_SEL_GROUP = new System.Windows.Forms.GroupBox();
            this.RBtnAnaFpga2 = new System.Windows.Forms.RadioButton();
            this.RBtnAnaFpga1 = new System.Windows.Forms.RadioButton();
            this.BtnAnaHostRead = new System.Windows.Forms.Button();
            this.ANA_BOARD_SEL_GROUP = new System.Windows.Forms.GroupBox();
            this.RBtnAnaBoard2 = new System.Windows.Forms.RadioButton();
            this.RBtnAnaBoard1 = new System.Windows.Forms.RadioButton();
            this.BtnAnaHostWrite = new System.Windows.Forms.Button();
            this.ANA_RDATA_TXT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ANA_WDATA_TXT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ANA_ADDR_TXT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ACQ_HOST_GROUP = new System.Windows.Forms.GroupBox();
            this.ACQ_SEL_FPGA = new System.Windows.Forms.TextBox();
            this.ACQ_FPGA_SEL_GROUP = new System.Windows.Forms.GroupBox();
            this.RBtnAcqFpga2 = new System.Windows.Forms.RadioButton();
            this.RBtnAcqFpga1 = new System.Windows.Forms.RadioButton();
            this.ACQ_BOARD_SEL_GROUP = new System.Windows.Forms.GroupBox();
            this.RBtnAcqBoard2 = new System.Windows.Forms.RadioButton();
            this.RBtnAcqBoard1 = new System.Windows.Forms.RadioButton();
            this.BtnAcqHostRead = new System.Windows.Forms.Button();
            this.BtnAcqHostWrite = new System.Windows.Forms.Button();
            this.ACQ_RDATA_TXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ACQ_WDATA_TXT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ACQ_ADDR_TXT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RTC_HOST_GROUP = new System.Windows.Forms.GroupBox();
            this.BtnRtcHostRead = new System.Windows.Forms.Button();
            this.BtnRtcHostWrite = new System.Windows.Forms.Button();
            this.RTC_RDATA_TXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RTC_WDATA_TXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RTC_ADDR_TXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SYS_TEST_TAB = new System.Windows.Forms.TabPage();
            this.SYS_CONFIG_GROUP = new System.Windows.Forms.GroupBox();
            this.SYS_CHANNEL_TXT = new System.Windows.Forms.TextBox();
            this.SYS_CHANNEL_LABEL = new System.Windows.Forms.Label();
            this.SYS_TX_PULSE_BURST_TXT = new System.Windows.Forms.TextBox();
            this.SYS_TX_PULSE_BURST_LABEL = new System.Windows.Forms.Label();
            this.SYS_STEER_ANGLE_TXT = new System.Windows.Forms.TextBox();
            this.SYS_STEER_ANGLE_LABEL = new System.Windows.Forms.Label();
            this.SYS_TX_FREQ_TXT = new System.Windows.Forms.TextBox();
            this.SYS_TX_FREQ_LABEL = new System.Windows.Forms.Label();
            this.SYS_PRF_COUNT_TXT = new System.Windows.Forms.TextBox();
            this.SYS_PRF_COUNT_LABEL = new System.Windows.Forms.Label();
            this.SYS_FRAME_COUNT_TXT = new System.Windows.Forms.TextBox();
            this.SYS_FRAME_COUNT_LABEL = new System.Windows.Forms.Label();
            this.SYS_VIEW_DEPTH_TXT = new System.Windows.Forms.TextBox();
            this.SYS_VIEW_DEPTH_LABEL = new System.Windows.Forms.Label();
            this.ACQ_REGIST_GROUP = new System.Windows.Forms.GroupBox();
            this.ACQ_TEST_PATTERN_COMB = new System.Windows.Forms.ComboBox();
            this.ACQ_BtnPlot = new System.Windows.Forms.Button();
            this.ACQ_TEST_PATTERN_CHECK = new System.Windows.Forms.CheckBox();
            this.C_R_ACQ_RX_LENGTH = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.C_R_ACQ_RX_START = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ANA_CONFIG_GROUP = new System.Windows.Forms.GroupBox();
            this.label51 = new System.Windows.Forms.Label();
            this.ANA_MAX14808_CC_COMB = new System.Windows.Forms.ComboBox();
            this.label50 = new System.Windows.Forms.Label();
            this.ANA_MAX14808_MODE_COMB = new System.Windows.Forms.ComboBox();
            this.ANA_AFE_PATTERN_CHECK = new System.Windows.Forms.CheckBox();
            this.TX_PULSE_GROUP = new System.Windows.Forms.GroupBox();
            this.TX_PULSE_MASK_CHECK = new System.Windows.Forms.CheckBox();
            this.label44 = new System.Windows.Forms.Label();
            this.C_R_TX_B_TX_PS7 = new System.Windows.Forms.TextBox();
            this.C_R_TX_B_TX_PS6 = new System.Windows.Forms.TextBox();
            this.C_R_TX_B_TX_PS5 = new System.Windows.Forms.TextBox();
            this.C_R_TX_B_TX_PS4 = new System.Windows.Forms.TextBox();
            this.C_R_TX_B_TX_PS3 = new System.Windows.Forms.TextBox();
            this.C_R_TX_B_TX_PS2 = new System.Windows.Forms.TextBox();
            this.C_R_TX_B_TX_PS1 = new System.Windows.Forms.TextBox();
            this.C_R_TX_B_TX_PS0 = new System.Windows.Forms.TextBox();
            this.C_R_TX_B_TX_PC = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.TX_DELAY_RICHTXT = new System.Windows.Forms.RichTextBox();
            this.TX_PULSE_GRAPH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ATGC_GROUP = new System.Windows.Forms.GroupBox();
            this.ATGC_MAX_DEPTH = new System.Windows.Forms.TextBox();
            this.ATGC_MAX = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TGC_MAX_TRACK = new System.Windows.Forms.TrackBar();
            this.ATGC_MIN_DEPTH = new System.Windows.Forms.TextBox();
            this.ATGC_MIN = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TGC_MIN_TRACK = new System.Windows.Forms.TrackBar();
            this.TGC_GRAPH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TEST_START_GROUP = new System.Windows.Forms.GroupBox();
            this.BtnRfDataRead = new System.Windows.Forms.Button();
            this.BtnTestDone = new System.Windows.Forms.Button();
            this.BtnSystemTestStart = new System.Windows.Forms.Button();
            this.RBtnNCon = new System.Windows.Forms.RadioButton();
            this.RBtnCon = new System.Windows.Forms.RadioButton();
            this.RTC_REGIST_GROUP = new System.Windows.Forms.GroupBox();
            this.C_R_RTC_TGC_INCR = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.C_R_RTC_TGC_MAX = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.C_R_RTC_TGC_MIN_COUNT = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.C_R_RTC_TGC_MIN = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.C_R_RTC_TGC_START = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.C_R_RTC_TGC_CLOCK_MASK = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.C_R_RTC_TGC_CTRL3 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.C_R_RTC_TGC_SLEEP = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.C_R_RTC_TGC_MODE = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.C_R_RTC_OFN_DUMMY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.C_R_RTC_OFN_COUNT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.C_R_RTC_PRF_COUNT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.C_R_RTC_PRF_L_LENGTH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.C_R_RTC_PRF_H_LENGTH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ANA_JIG_TEST_TAB = new System.Windows.Forms.TabControl();
            this.POWER_SUPPLY_TAB = new System.Windows.Forms.TabPage();
            this.RPC_CTR_GROUP = new System.Windows.Forms.GroupBox();
            this.btnGDPOff = new System.Windows.Forms.Button();
            this.btnGDPOn = new System.Windows.Forms.Button();
            this.label153 = new System.Windows.Forms.Label();
            this.btnVTXOff = new System.Windows.Forms.Button();
            this.btnVTXOn = new System.Windows.Forms.Button();
            this.label136 = new System.Windows.Forms.Label();
            this.RPC_VTX_TRACK = new System.Windows.Forms.TrackBar();
            this.label152 = new System.Windows.Forms.Label();
            this.RPC_VTX_TEXT = new System.Windows.Forms.TextBox();
            this.label151 = new System.Windows.Forms.Label();
            this.RPC_TEST_INTERFACE = new System.Windows.Forms.GroupBox();
            this.RPC_BTN_PROGRESS = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.RPC_WR_DELAY_TXT = new System.Windows.Forms.TextBox();
            this.RPC_WR_DELAY_TRACK = new System.Windows.Forms.TrackBar();
            this.label133 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.RPC_BTN_DELAY_TXT = new System.Windows.Forms.TextBox();
            this.RPC_BTN_DELAY_TRACK = new System.Windows.Forms.TrackBar();
            this.label139 = new System.Windows.Forms.Label();
            this.SPI_CONTINUOUS_CHECK = new System.Windows.Forms.CheckBox();
            this.RPC_HELP_GROUP = new System.Windows.Forms.GroupBox();
            this.label118 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.RPC_MONITOR_GROUP = new System.Windows.Forms.GroupBox();
            this.label104 = new System.Windows.Forms.Label();
            this.RPC_SPI_GROUP = new System.Windows.Forms.GroupBox();
            this.label119 = new System.Windows.Forms.Label();
            this.SPI_RDATA_TXT = new System.Windows.Forms.TextBox();
            this.BtnRpcRead = new System.Windows.Forms.Button();
            this.BtnRpcWrite = new System.Windows.Forms.Button();
            this.SPI_COMMAND_TXT = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.SPI_HDATA_TXT = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.SPI_LDATA_TXT = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.ACQ_XDMA_TAB = new System.Windows.Forms.TabPage();
            this.ACQ_XDMA_GROUP = new System.Windows.Forms.GroupBox();
            this.BtnAcqXdmaRead = new System.Windows.Forms.Button();
            this.BtnAcqXdmaWrite = new System.Windows.Forms.Button();
            this.ACQ_XDMA_RDATA_TXT = new System.Windows.Forms.TextBox();
            this.label94 = new System.Windows.Forms.Label();
            this.ACQ_XDMA_WDATA_TXT = new System.Windows.Forms.TextBox();
            this.label97 = new System.Windows.Forms.Label();
            this.ACQ_XDMA_ADDR_TXT = new System.Windows.Forms.TextBox();
            this.label98 = new System.Windows.Forms.Label();
            this.ACQ_PCIE_GROUP = new System.Windows.Forms.GroupBox();
            this.ACQ_FPGA_SEL_COMB = new System.Windows.Forms.ComboBox();
            this.label93 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.ACQ_XDMA_EN_CHECK = new System.Windows.Forms.CheckBox();
            this.US_SCAN_TAB = new System.Windows.Forms.TabPage();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.US_FPS_DELAY_GROUP = new System.Windows.Forms.GroupBox();
            this.label83 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.US_FRAME_DELAY_TRACK = new System.Windows.Forms.TrackBar();
            this.US_FRAME = new System.Windows.Forms.Panel();
            this.US_SCAN_GROUP = new System.Windows.Forms.GroupBox();
            this.BtnScanStart = new System.Windows.Forms.Button();
            this.RANDOM_RADIO = new System.Windows.Forms.RadioButton();
            this.SIMUL_RADIO = new System.Windows.Forms.RadioButton();
            this.SCANNER_RADIO = new System.Windows.Forms.RadioButton();
            this.US_COLOR_GROUP = new System.Windows.Forms.GroupBox();
            this.PA_MODE_RADIO = new System.Windows.Forms.RadioButton();
            this.US_MODE_RADIO = new System.Windows.Forms.RadioButton();
            this.US_CF_GROUP = new System.Windows.Forms.GroupBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.US_2D_GROUP = new System.Windows.Forms.GroupBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.TGC_FIG_TAB = new System.Windows.Forms.TabPage();
            this.TGC_TEST_GROUP = new System.Windows.Forms.GroupBox();
            this.TGC_ERROR_NAME = new System.Windows.Forms.Label();
            this.TGC_ERROR_VALUE = new System.Windows.Forms.Label();
            this.BtnClearTestPlot = new System.Windows.Forms.Button();
            this.BtnSplinePlot = new System.Windows.Forms.Button();
            this.btnPchipPlot = new System.Windows.Forms.Button();
            this.HERMIT_OP_GROUP = new System.Windows.Forms.GroupBox();
            this.M_OP_FINIT_CHECK = new System.Windows.Forms.RadioButton();
            this.M_OP_MONO_CHECK = new System.Windows.Forms.RadioButton();
            this.label140 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.TGC8_GAIN = new System.Windows.Forms.Label();
            this.TGC7_GAIN = new System.Windows.Forms.Label();
            this.TGC6_GAIN = new System.Windows.Forms.Label();
            this.TGC5_GAIN = new System.Windows.Forms.Label();
            this.TGC4_GAIN = new System.Windows.Forms.Label();
            this.TGC3_GAIN = new System.Windows.Forms.Label();
            this.TGC2_GAIN = new System.Windows.Forms.Label();
            this.TGC1_GAIN = new System.Windows.Forms.Label();
            this.TGC8_DEPTH = new System.Windows.Forms.Label();
            this.TGC7_DEPTH = new System.Windows.Forms.Label();
            this.TGC6_DEPTH = new System.Windows.Forms.Label();
            this.TGC5_DEPTH = new System.Windows.Forms.Label();
            this.TGC4_DEPTH = new System.Windows.Forms.Label();
            this.TGC3_DEPTH = new System.Windows.Forms.Label();
            this.TGC2_DEPTH = new System.Windows.Forms.Label();
            this.TGC1_DEPTH = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.TGC_CURVE_SEL_GROUP = new System.Windows.Forms.GroupBox();
            this.HERMIT_SPLINE_RADIO = new System.Windows.Forms.RadioButton();
            this.CSHARP_CURVE_RADIO = new System.Windows.Forms.RadioButton();
            this.CUBIC_SPLINE_RADIO = new System.Windows.Forms.RadioButton();
            this.label45 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TGC8_TRACK = new System.Windows.Forms.TrackBar();
            this.TGC7_TRACK = new System.Windows.Forms.TrackBar();
            this.TGC6_TRACK = new System.Windows.Forms.TrackBar();
            this.TGC5_TRACK = new System.Windows.Forms.TrackBar();
            this.TGC4_TRACK = new System.Windows.Forms.TrackBar();
            this.TGC3_TRACK = new System.Windows.Forms.TrackBar();
            this.TGC2_TRACK = new System.Windows.Forms.TrackBar();
            this.TGC1_TRACK = new System.Windows.Forms.TrackBar();
            this.TGC_STATE_STRIP = new System.Windows.Forms.StatusStrip();
            this.TGC_XY_POINT_LABEL = new System.Windows.Forms.ToolStripStatusLabel();
            this.TGC_CURVE_POINT_LABEL = new System.Windows.Forms.ToolStripStatusLabel();
            this.TGC_GRAPH_TEST = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.COM_PANEL = new System.Windows.Forms.Panel();
            this.COM_RPC_IMG = new System.Windows.Forms.PictureBox();
            this.label148 = new System.Windows.Forms.Label();
            this.COM_ANA_IMG4 = new System.Windows.Forms.PictureBox();
            this.COM_ANA_IMG2 = new System.Windows.Forms.PictureBox();
            this.COM_ANA_IMG3 = new System.Windows.Forms.PictureBox();
            this.COM_ANA_IMG1 = new System.Windows.Forms.PictureBox();
            this.label138 = new System.Windows.Forms.Label();
            this.COM_ACQ_IMG4 = new System.Windows.Forms.PictureBox();
            this.COM_ACQ_IMG2 = new System.Windows.Forms.PictureBox();
            this.COM_ACQ_IMG3 = new System.Windows.Forms.PictureBox();
            this.COM_ACQ_IMG1 = new System.Windows.Forms.PictureBox();
            this.COM_RTC_IMG = new System.Windows.Forms.PictureBox();
            this.label135 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CMROM_SPLINE_RADIO = new System.Windows.Forms.RadioButton();
            this.AFE_MAP_TAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AFE_REGIST_MAP_GRID)).BeginInit();
            this.FILE_TAB.SuspendLayout();
            this.FILE_COMMON_GROUP.SuspendLayout();
            this.COMPORT_TAB.SuspendLayout();
            this.COMPORT_GROUP.SuspendLayout();
            this.HOST_TEST_TAB.SuspendLayout();
            this.TEST_INTERFACE_GROUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEST_DELAY_TRACK)).BeginInit();
            this.AFE_HOST_GROUP.SuspendLayout();
            this.ADC_DIG_SEL_GROUP.SuspendLayout();
            this.ANA_HOST_GROUP.SuspendLayout();
            this.ANA_FPGA_SEL_GROUP.SuspendLayout();
            this.ANA_BOARD_SEL_GROUP.SuspendLayout();
            this.ACQ_HOST_GROUP.SuspendLayout();
            this.ACQ_FPGA_SEL_GROUP.SuspendLayout();
            this.ACQ_BOARD_SEL_GROUP.SuspendLayout();
            this.RTC_HOST_GROUP.SuspendLayout();
            this.SYS_TEST_TAB.SuspendLayout();
            this.SYS_CONFIG_GROUP.SuspendLayout();
            this.ACQ_REGIST_GROUP.SuspendLayout();
            this.ANA_CONFIG_GROUP.SuspendLayout();
            this.TX_PULSE_GROUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TX_PULSE_GRAPH)).BeginInit();
            this.ATGC_GROUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TGC_MAX_TRACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC_MIN_TRACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC_GRAPH)).BeginInit();
            this.TEST_START_GROUP.SuspendLayout();
            this.RTC_REGIST_GROUP.SuspendLayout();
            this.ANA_JIG_TEST_TAB.SuspendLayout();
            this.POWER_SUPPLY_TAB.SuspendLayout();
            this.RPC_CTR_GROUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_VTX_TRACK)).BeginInit();
            this.RPC_TEST_INTERFACE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_WR_DELAY_TRACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_BTN_DELAY_TRACK)).BeginInit();
            this.RPC_HELP_GROUP.SuspendLayout();
            this.RPC_MONITOR_GROUP.SuspendLayout();
            this.RPC_SPI_GROUP.SuspendLayout();
            this.ACQ_XDMA_TAB.SuspendLayout();
            this.ACQ_XDMA_GROUP.SuspendLayout();
            this.ACQ_PCIE_GROUP.SuspendLayout();
            this.US_SCAN_TAB.SuspendLayout();
            this.US_FPS_DELAY_GROUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.US_FRAME_DELAY_TRACK)).BeginInit();
            this.US_SCAN_GROUP.SuspendLayout();
            this.US_COLOR_GROUP.SuspendLayout();
            this.US_CF_GROUP.SuspendLayout();
            this.US_2D_GROUP.SuspendLayout();
            this.TGC_FIG_TAB.SuspendLayout();
            this.TGC_TEST_GROUP.SuspendLayout();
            this.HERMIT_OP_GROUP.SuspendLayout();
            this.TGC_CURVE_SEL_GROUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TGC8_TRACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC7_TRACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC6_TRACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC5_TRACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC4_TRACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC3_TRACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC2_TRACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC1_TRACK)).BeginInit();
            this.TGC_STATE_STRIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TGC_GRAPH_TEST)).BeginInit();
            this.COM_PANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COM_RPC_IMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ANA_IMG4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ANA_IMG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ANA_IMG3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ANA_IMG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ACQ_IMG4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ACQ_IMG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ACQ_IMG3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ACQ_IMG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_RTC_IMG)).BeginInit();
            this.SuspendLayout();
            // 
            // serialMaster
            // 
            this.serialMaster.BaudRate = 115200;
            this.serialMaster.PortName = "COM3";
            // 
            // debug_text
            // 
            this.debug_text.Location = new System.Drawing.Point(1357, 45);
            this.debug_text.Multiline = true;
            this.debug_text.Name = "debug_text";
            this.debug_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debug_text.Size = new System.Drawing.Size(294, 591);
            this.debug_text.TabIndex = 1;
            // 
            // AFE_MAP_TAB
            // 
            this.AFE_MAP_TAB.Controls.Add(this.AFE_REGIST_MAP_GRID);
            this.AFE_MAP_TAB.Location = new System.Drawing.Point(4, 44);
            this.AFE_MAP_TAB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AFE_MAP_TAB.Name = "AFE_MAP_TAB";
            this.AFE_MAP_TAB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AFE_MAP_TAB.Size = new System.Drawing.Size(1346, 591);
            this.AFE_MAP_TAB.TabIndex = 6;
            this.AFE_MAP_TAB.Text = "AFE5809 Register MAP";
            this.AFE_MAP_TAB.UseVisualStyleBackColor = true;
            // 
            // AFE_REGIST_MAP_GRID
            // 
            this.AFE_REGIST_MAP_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AFE_REGIST_MAP_GRID.Location = new System.Drawing.Point(6, 5);
            this.AFE_REGIST_MAP_GRID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AFE_REGIST_MAP_GRID.Name = "AFE_REGIST_MAP_GRID";
            this.AFE_REGIST_MAP_GRID.RowHeadersWidth = 51;
            this.AFE_REGIST_MAP_GRID.RowTemplate.Height = 27;
            this.AFE_REGIST_MAP_GRID.Size = new System.Drawing.Size(660, 591);
            this.AFE_REGIST_MAP_GRID.TabIndex = 0;
            // 
            // FILE_TAB
            // 
            this.FILE_TAB.Controls.Add(this.FILE_COMMON_GROUP);
            this.FILE_TAB.Location = new System.Drawing.Point(4, 44);
            this.FILE_TAB.Name = "FILE_TAB";
            this.FILE_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.FILE_TAB.Size = new System.Drawing.Size(1346, 591);
            this.FILE_TAB.TabIndex = 5;
            this.FILE_TAB.Text = "File Setting";
            this.FILE_TAB.UseVisualStyleBackColor = true;
            // 
            // FILE_COMMON_GROUP
            // 
            this.FILE_COMMON_GROUP.Controls.Add(this.FILE_LOCATION_TXT);
            this.FILE_COMMON_GROUP.Controls.Add(this.panel1);
            this.FILE_COMMON_GROUP.Controls.Add(this.FILE_VERSION_LABEL);
            this.FILE_COMMON_GROUP.Controls.Add(this.BtnFolderOpen);
            this.FILE_COMMON_GROUP.Controls.Add(this.label54);
            this.FILE_COMMON_GROUP.Controls.Add(this.FILE_VERSION_TXT);
            this.FILE_COMMON_GROUP.Controls.Add(this.label53);
            this.FILE_COMMON_GROUP.Controls.Add(this.label52);
            this.FILE_COMMON_GROUP.Location = new System.Drawing.Point(5, 3);
            this.FILE_COMMON_GROUP.Name = "FILE_COMMON_GROUP";
            this.FILE_COMMON_GROUP.Size = new System.Drawing.Size(1335, 585);
            this.FILE_COMMON_GROUP.TabIndex = 0;
            this.FILE_COMMON_GROUP.TabStop = false;
            this.FILE_COMMON_GROUP.Text = "Common";
            // 
            // FILE_LOCATION_TXT
            // 
            this.FILE_LOCATION_TXT.Location = new System.Drawing.Point(22, 334);
            this.FILE_LOCATION_TXT.Name = "FILE_LOCATION_TXT";
            this.FILE_LOCATION_TXT.Size = new System.Drawing.Size(1284, 25);
            this.FILE_LOCATION_TXT.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(881, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 298);
            this.panel1.TabIndex = 7;
            // 
            // FILE_VERSION_LABEL
            // 
            this.FILE_VERSION_LABEL.AutoSize = true;
            this.FILE_VERSION_LABEL.Location = new System.Drawing.Point(130, 78);
            this.FILE_VERSION_LABEL.Name = "FILE_VERSION_LABEL";
            this.FILE_VERSION_LABEL.Size = new System.Drawing.Size(133, 15);
            this.FILE_VERSION_LABEL.TabIndex = 6;
            this.FILE_VERSION_LABEL.Text = "fill out your work";
            // 
            // BtnFolderOpen
            // 
            this.BtnFolderOpen.Location = new System.Drawing.Point(21, 406);
            this.BtnFolderOpen.Name = "BtnFolderOpen";
            this.BtnFolderOpen.Size = new System.Drawing.Size(100, 28);
            this.BtnFolderOpen.TabIndex = 5;
            this.BtnFolderOpen.Text = "Open";
            this.BtnFolderOpen.UseVisualStyleBackColor = true;
            this.BtnFolderOpen.Click += new System.EventHandler(this.RenewExcelRegister);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(20, 379);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(136, 15);
            this.label54.TabIndex = 4;
            this.label54.Text = "Renew Excel File";
            // 
            // FILE_VERSION_TXT
            // 
            this.FILE_VERSION_TXT.Location = new System.Drawing.Point(22, 69);
            this.FILE_VERSION_TXT.Name = "FILE_VERSION_TXT";
            this.FILE_VERSION_TXT.Size = new System.Drawing.Size(61, 25);
            this.FILE_VERSION_TXT.TabIndex = 2;
            this.FILE_VERSION_TXT.Text = "1.0.7";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(20, 309);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(121, 15);
            this.label53.TabIndex = 1;
            this.label53.Text = "Excel File Path";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(20, 44);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(68, 15);
            this.label52.TabIndex = 0;
            this.label52.Text = "AJT Ver.";
            // 
            // COMPORT_TAB
            // 
            this.COMPORT_TAB.Controls.Add(this.label90);
            this.COMPORT_TAB.Controls.Add(this.BtnClearOutBuffer);
            this.COMPORT_TAB.Controls.Add(this.BtnClearInBuffer);
            this.COMPORT_TAB.Controls.Add(this.COMPORT_RICH);
            this.COMPORT_TAB.Controls.Add(this.SerialComboBox);
            this.COMPORT_TAB.Controls.Add(this.COMPORT_GROUP);
            this.COMPORT_TAB.Location = new System.Drawing.Point(4, 44);
            this.COMPORT_TAB.Name = "COMPORT_TAB";
            this.COMPORT_TAB.Size = new System.Drawing.Size(1346, 591);
            this.COMPORT_TAB.TabIndex = 4;
            this.COMPORT_TAB.Text = "COM Port";
            this.COMPORT_TAB.UseVisualStyleBackColor = true;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(133, 485);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(148, 15);
            this.label90.TabIndex = 7;
            this.label90.Text = "Serial buffer delete";
            // 
            // BtnClearOutBuffer
            // 
            this.BtnClearOutBuffer.Location = new System.Drawing.Point(207, 500);
            this.BtnClearOutBuffer.Name = "BtnClearOutBuffer";
            this.BtnClearOutBuffer.Size = new System.Drawing.Size(152, 60);
            this.BtnClearOutBuffer.TabIndex = 6;
            this.BtnClearOutBuffer.Text = "Clear Out Buffer";
            this.BtnClearOutBuffer.UseVisualStyleBackColor = true;
            this.BtnClearOutBuffer.Click += new System.EventHandler(this.DiscardOutBuff);
            // 
            // BtnClearInBuffer
            // 
            this.BtnClearInBuffer.Location = new System.Drawing.Point(30, 500);
            this.BtnClearInBuffer.Name = "BtnClearInBuffer";
            this.BtnClearInBuffer.Size = new System.Drawing.Size(152, 60);
            this.BtnClearInBuffer.TabIndex = 5;
            this.BtnClearInBuffer.Text = "Clear In Buffer";
            this.BtnClearInBuffer.UseVisualStyleBackColor = true;
            this.BtnClearInBuffer.Click += new System.EventHandler(this.DiscardInBuff);
            // 
            // COMPORT_RICH
            // 
            this.COMPORT_RICH.Location = new System.Drawing.Point(7, 79);
            this.COMPORT_RICH.Name = "COMPORT_RICH";
            this.COMPORT_RICH.Size = new System.Drawing.Size(381, 390);
            this.COMPORT_RICH.TabIndex = 4;
            this.COMPORT_RICH.Text = "";
            // 
            // SerialComboBox
            // 
            this.SerialComboBox.Enabled = false;
            this.SerialComboBox.FormattingEnabled = true;
            this.SerialComboBox.Location = new System.Drawing.Point(125, 35);
            this.SerialComboBox.Name = "SerialComboBox";
            this.SerialComboBox.Size = new System.Drawing.Size(243, 23);
            this.SerialComboBox.TabIndex = 0;
            // 
            // COMPORT_GROUP
            // 
            this.COMPORT_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.COMPORT_GROUP.Controls.Add(this.label7);
            this.COMPORT_GROUP.Location = new System.Drawing.Point(7, 12);
            this.COMPORT_GROUP.Name = "COMPORT_GROUP";
            this.COMPORT_GROUP.Size = new System.Drawing.Size(381, 61);
            this.COMPORT_GROUP.TabIndex = 2;
            this.COMPORT_GROUP.TabStop = false;
            this.COMPORT_GROUP.Text = "COM PORT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Serial Ports";
            // 
            // HOST_TEST_TAB
            // 
            this.HOST_TEST_TAB.Controls.Add(this.TEST_INTERFACE_GROUP);
            this.HOST_TEST_TAB.Controls.Add(this.AFE_HOST_GROUP);
            this.HOST_TEST_TAB.Controls.Add(this.ANA_HOST_GROUP);
            this.HOST_TEST_TAB.Controls.Add(this.ACQ_HOST_GROUP);
            this.HOST_TEST_TAB.Controls.Add(this.RTC_HOST_GROUP);
            this.HOST_TEST_TAB.Location = new System.Drawing.Point(4, 44);
            this.HOST_TEST_TAB.Name = "HOST_TEST_TAB";
            this.HOST_TEST_TAB.Size = new System.Drawing.Size(1346, 591);
            this.HOST_TEST_TAB.TabIndex = 3;
            this.HOST_TEST_TAB.Text = "Host Test";
            this.HOST_TEST_TAB.UseVisualStyleBackColor = true;
            // 
            // TEST_INTERFACE_GROUP
            // 
            this.TEST_INTERFACE_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TEST_INTERFACE_GROUP.Controls.Add(this.TEST_REGIST_NAME_COMB);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.label124);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.TEST_REGIST_VALUE_TXT);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.label123);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.label122);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.label121);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.TEST_REGIST_ADDR_TXT);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.label120);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.TEST_REGIST_AREA_COMB);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.BtnTestRegistSearch);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.label55);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.TEST_DELAY_TXT);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.TEST_DELAY_TRACK);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.BtnClearTaskLog);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.TEST_TASK_LOG);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.label68);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.label67);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.BtnPLLReset);
            this.TEST_INTERFACE_GROUP.Controls.Add(this.TEST_CONTINUOUS_CHECK);
            this.TEST_INTERFACE_GROUP.ForeColor = System.Drawing.Color.Black;
            this.TEST_INTERFACE_GROUP.Location = new System.Drawing.Point(8, 280);
            this.TEST_INTERFACE_GROUP.Name = "TEST_INTERFACE_GROUP";
            this.TEST_INTERFACE_GROUP.Size = new System.Drawing.Size(1180, 303);
            this.TEST_INTERFACE_GROUP.TabIndex = 9;
            this.TEST_INTERFACE_GROUP.TabStop = false;
            this.TEST_INTERFACE_GROUP.Text = "TEST INTERFACE";
            // 
            // TEST_REGIST_NAME_COMB
            // 
            this.TEST_REGIST_NAME_COMB.FormattingEnabled = true;
            this.TEST_REGIST_NAME_COMB.Location = new System.Drawing.Point(697, 148);
            this.TEST_REGIST_NAME_COMB.Name = "TEST_REGIST_NAME_COMB";
            this.TEST_REGIST_NAME_COMB.Size = new System.Drawing.Size(292, 23);
            this.TEST_REGIST_NAME_COMB.TabIndex = 50;
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(578, 263);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(131, 15);
            this.label124.TabIndex = 49;
            this.label124.Text = "Value(Only AFE)";
            // 
            // TEST_REGIST_VALUE_TXT
            // 
            this.TEST_REGIST_VALUE_TXT.Location = new System.Drawing.Point(697, 254);
            this.TEST_REGIST_VALUE_TXT.Name = "TEST_REGIST_VALUE_TXT";
            this.TEST_REGIST_VALUE_TXT.Size = new System.Drawing.Size(169, 25);
            this.TEST_REGIST_VALUE_TXT.TabIndex = 48;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(615, 79);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(192, 15);
            this.label123.TabIndex = 47;
            this.label123.Text = "Search Register Address";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(585, 234);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(113, 15);
            this.label122.TabIndex = 46;
            this.label122.Text = "Address Value";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(585, 156);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(114, 15);
            this.label121.TabIndex = 45;
            this.label121.Text = "Register Name";
            // 
            // TEST_REGIST_ADDR_TXT
            // 
            this.TEST_REGIST_ADDR_TXT.Location = new System.Drawing.Point(697, 225);
            this.TEST_REGIST_ADDR_TXT.Name = "TEST_REGIST_ADDR_TXT";
            this.TEST_REGIST_ADDR_TXT.Size = new System.Drawing.Size(169, 25);
            this.TEST_REGIST_ADDR_TXT.TabIndex = 44;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(585, 120);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(107, 15);
            this.label120.TabIndex = 42;
            this.label120.Text = "Register Area";
            // 
            // TEST_REGIST_AREA_COMB
            // 
            this.TEST_REGIST_AREA_COMB.FormattingEnabled = true;
            this.TEST_REGIST_AREA_COMB.Items.AddRange(new object[] {
            "RTC",
            "Acquisition",
            "Analog",
            "AFE5809"});
            this.TEST_REGIST_AREA_COMB.Location = new System.Drawing.Point(697, 112);
            this.TEST_REGIST_AREA_COMB.Name = "TEST_REGIST_AREA_COMB";
            this.TEST_REGIST_AREA_COMB.Size = new System.Drawing.Size(121, 23);
            this.TEST_REGIST_AREA_COMB.TabIndex = 41;
            this.TEST_REGIST_AREA_COMB.SelectedIndexChanged += new System.EventHandler(this.SearchRegisterAreaIndexChanged);
            // 
            // BtnTestRegistSearch
            // 
            this.BtnTestRegistSearch.Location = new System.Drawing.Point(697, 184);
            this.BtnTestRegistSearch.Name = "BtnTestRegistSearch";
            this.BtnTestRegistSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnTestRegistSearch.TabIndex = 40;
            this.BtnTestRegistSearch.Text = "Search";
            this.BtnTestRegistSearch.UseVisualStyleBackColor = true;
            this.BtnTestRegistSearch.Click += new System.EventHandler(this.SerachRegisterBtn);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Location = new System.Drawing.Point(572, 25);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(28, 15);
            this.label55.TabIndex = 39;
            this.label55.Text = "ms";
            // 
            // TEST_DELAY_TXT
            // 
            this.TEST_DELAY_TXT.Location = new System.Drawing.Point(515, 23);
            this.TEST_DELAY_TXT.Multiline = true;
            this.TEST_DELAY_TXT.Name = "TEST_DELAY_TXT";
            this.TEST_DELAY_TXT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TEST_DELAY_TXT.Size = new System.Drawing.Size(52, 18);
            this.TEST_DELAY_TXT.TabIndex = 38;
            this.TEST_DELAY_TXT.Text = "500";
            this.TEST_DELAY_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TEST_DELAY_TXT.TextChanged += new System.EventHandler(this.HostDelayTextUpdate);
            // 
            // TEST_DELAY_TRACK
            // 
            this.TEST_DELAY_TRACK.AutoSize = false;
            this.TEST_DELAY_TRACK.BackColor = System.Drawing.Color.Khaki;
            this.TEST_DELAY_TRACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TEST_DELAY_TRACK.LargeChange = 100;
            this.TEST_DELAY_TRACK.Location = new System.Drawing.Point(246, 15);
            this.TEST_DELAY_TRACK.Maximum = 1000;
            this.TEST_DELAY_TRACK.Minimum = 1;
            this.TEST_DELAY_TRACK.Name = "TEST_DELAY_TRACK";
            this.TEST_DELAY_TRACK.Size = new System.Drawing.Size(263, 36);
            this.TEST_DELAY_TRACK.SmallChange = 50;
            this.TEST_DELAY_TRACK.TabIndex = 37;
            this.TEST_DELAY_TRACK.TickFrequency = 50;
            this.TEST_DELAY_TRACK.Value = 500;
            this.TEST_DELAY_TRACK.Scroll += new System.EventHandler(this.HostDelayUpdate);
            // 
            // BtnClearTaskLog
            // 
            this.BtnClearTaskLog.Location = new System.Drawing.Point(8, 276);
            this.BtnClearTaskLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnClearTaskLog.Name = "BtnClearTaskLog";
            this.BtnClearTaskLog.Size = new System.Drawing.Size(124, 22);
            this.BtnClearTaskLog.TabIndex = 36;
            this.BtnClearTaskLog.Text = "Clear task log";
            this.BtnClearTaskLog.UseVisualStyleBackColor = true;
            this.BtnClearTaskLog.Click += new System.EventHandler(this.TaskLogClear);
            // 
            // TEST_TASK_LOG
            // 
            this.TEST_TASK_LOG.Location = new System.Drawing.Point(6, 66);
            this.TEST_TASK_LOG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TEST_TASK_LOG.Name = "TEST_TASK_LOG";
            this.TEST_TASK_LOG.Size = new System.Drawing.Size(561, 209);
            this.TEST_TASK_LOG.TabIndex = 35;
            this.TEST_TASK_LOG.Text = "";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(4, 52);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(89, 15);
            this.label68.TabIndex = 34;
            this.label68.Text = "TASK_LOG";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.ForeColor = System.Drawing.Color.Black;
            this.label67.Location = new System.Drawing.Point(160, 26);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(89, 15);
            this.label67.TabIndex = 33;
            this.label67.Text = "Delay Time";
            // 
            // BtnPLLReset
            // 
            this.BtnPLLReset.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnPLLReset.Location = new System.Drawing.Point(1055, 274);
            this.BtnPLLReset.Name = "BtnPLLReset";
            this.BtnPLLReset.Size = new System.Drawing.Size(119, 23);
            this.BtnPLLReset.TabIndex = 12;
            this.BtnPLLReset.Text = "PLL Reset";
            this.BtnPLLReset.UseVisualStyleBackColor = true;
            this.BtnPLLReset.Click += new System.EventHandler(this.ResetButtonClick);
            // 
            // TEST_CONTINUOUS_CHECK
            // 
            this.TEST_CONTINUOUS_CHECK.AutoSize = true;
            this.TEST_CONTINUOUS_CHECK.Location = new System.Drawing.Point(11, 24);
            this.TEST_CONTINUOUS_CHECK.Name = "TEST_CONTINUOUS_CHECK";
            this.TEST_CONTINUOUS_CHECK.Size = new System.Drawing.Size(132, 19);
            this.TEST_CONTINUOUS_CHECK.TabIndex = 13;
            this.TEST_CONTINUOUS_CHECK.Text = "CONTINUOUS";
            this.TEST_CONTINUOUS_CHECK.UseVisualStyleBackColor = true;
            // 
            // AFE_HOST_GROUP
            // 
            this.AFE_HOST_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AFE_HOST_GROUP.Controls.Add(this.AFE_SEL_FPGA);
            this.AFE_HOST_GROUP.Controls.Add(this.ADC_DIG_SEL_GROUP);
            this.AFE_HOST_GROUP.Controls.Add(this.label49);
            this.AFE_HOST_GROUP.Controls.Add(this.AFE_SEL_COMB);
            this.AFE_HOST_GROUP.Controls.Add(this.label48);
            this.AFE_HOST_GROUP.Controls.Add(this.AFE_ADDR_TXT);
            this.AFE_HOST_GROUP.Controls.Add(this.BtnAfeHostRead);
            this.AFE_HOST_GROUP.Controls.Add(this.label47);
            this.AFE_HOST_GROUP.Controls.Add(this.BtnAfeHostWrite);
            this.AFE_HOST_GROUP.Controls.Add(this.AFE_WDATA_TXT);
            this.AFE_HOST_GROUP.Controls.Add(this.AFE_RDATA_TXT);
            this.AFE_HOST_GROUP.Controls.Add(this.label46);
            this.AFE_HOST_GROUP.Location = new System.Drawing.Point(867, 15);
            this.AFE_HOST_GROUP.Name = "AFE_HOST_GROUP";
            this.AFE_HOST_GROUP.Size = new System.Drawing.Size(321, 259);
            this.AFE_HOST_GROUP.TabIndex = 11;
            this.AFE_HOST_GROUP.TabStop = false;
            this.AFE_HOST_GROUP.Text = "AFE5809 Host Test";
            // 
            // AFE_SEL_FPGA
            // 
            this.AFE_SEL_FPGA.Location = new System.Drawing.Point(6, 196);
            this.AFE_SEL_FPGA.Name = "AFE_SEL_FPGA";
            this.AFE_SEL_FPGA.Size = new System.Drawing.Size(297, 25);
            this.AFE_SEL_FPGA.TabIndex = 18;
            this.AFE_SEL_FPGA.Text = "Ana Board1, FPGA1, AFE0 ADC";
            this.AFE_SEL_FPGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ADC_DIG_SEL_GROUP
            // 
            this.ADC_DIG_SEL_GROUP.BackColor = System.Drawing.Color.Red;
            this.ADC_DIG_SEL_GROUP.Controls.Add(this.RBtnAdcVca);
            this.ADC_DIG_SEL_GROUP.Controls.Add(this.RBtnDig);
            this.ADC_DIG_SEL_GROUP.Location = new System.Drawing.Point(7, 114);
            this.ADC_DIG_SEL_GROUP.Name = "ADC_DIG_SEL_GROUP";
            this.ADC_DIG_SEL_GROUP.Size = new System.Drawing.Size(133, 21);
            this.ADC_DIG_SEL_GROUP.TabIndex = 23;
            // 
            // RBtnAdcVca
            // 
            this.RBtnAdcVca.AutoSize = true;
            this.RBtnAdcVca.Checked = true;
            this.RBtnAdcVca.Location = new System.Drawing.Point(3, 4);
            this.RBtnAdcVca.Name = "RBtnAdcVca";
            this.RBtnAdcVca.Size = new System.Drawing.Size(60, 19);
            this.RBtnAdcVca.TabIndex = 25;
            this.RBtnAdcVca.TabStop = true;
            this.RBtnAdcVca.Text = "ADC";
            this.RBtnAdcVca.UseVisualStyleBackColor = true;
            this.RBtnAdcVca.CheckedChanged += new System.EventHandler(this.RBtnAdcVca_CheckedChanged);
            // 
            // RBtnDig
            // 
            this.RBtnDig.AutoSize = true;
            this.RBtnDig.Location = new System.Drawing.Point(77, 4);
            this.RBtnDig.Name = "RBtnDig";
            this.RBtnDig.Size = new System.Drawing.Size(55, 19);
            this.RBtnDig.TabIndex = 26;
            this.RBtnDig.Text = "DIG";
            this.RBtnDig.UseVisualStyleBackColor = true;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(156, 120);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(102, 15);
            this.label49.TabIndex = 24;
            this.label49.Text = "AFE SELECT";
            // 
            // AFE_SEL_COMB
            // 
            this.AFE_SEL_COMB.FormattingEnabled = true;
            this.AFE_SEL_COMB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.AFE_SEL_COMB.Location = new System.Drawing.Point(252, 114);
            this.AFE_SEL_COMB.Name = "AFE_SEL_COMB";
            this.AFE_SEL_COMB.Size = new System.Drawing.Size(52, 23);
            this.AFE_SEL_COMB.TabIndex = 23;
            this.AFE_SEL_COMB.Text = "0";
            this.AFE_SEL_COMB.SelectedIndexChanged += new System.EventHandler(this.AfeSelectCombChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.ForeColor = System.Drawing.Color.Black;
            this.label48.Location = new System.Drawing.Point(6, 28);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(111, 15);
            this.label48.TabIndex = 13;
            this.label48.Text = "Address(Hex)";
            // 
            // AFE_ADDR_TXT
            // 
            this.AFE_ADDR_TXT.Location = new System.Drawing.Point(125, 19);
            this.AFE_ADDR_TXT.Name = "AFE_ADDR_TXT";
            this.AFE_ADDR_TXT.Size = new System.Drawing.Size(180, 25);
            this.AFE_ADDR_TXT.TabIndex = 14;
            this.AFE_ADDR_TXT.Text = "0x";
            this.AFE_ADDR_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnAfeHostRead
            // 
            this.BtnAfeHostRead.Location = new System.Drawing.Point(171, 231);
            this.BtnAfeHostRead.Name = "BtnAfeHostRead";
            this.BtnAfeHostRead.Size = new System.Drawing.Size(132, 22);
            this.BtnAfeHostRead.TabIndex = 20;
            this.BtnAfeHostRead.Text = "READ";
            this.BtnAfeHostRead.UseVisualStyleBackColor = true;
            this.BtnAfeHostRead.Click += new System.EventHandler(this.BtnAfeHostRead_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.ForeColor = System.Drawing.Color.Black;
            this.label47.Location = new System.Drawing.Point(6, 55);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(129, 15);
            this.label47.TabIndex = 15;
            this.label47.Text = "Write Data(Hex)";
            // 
            // BtnAfeHostWrite
            // 
            this.BtnAfeHostWrite.Location = new System.Drawing.Point(6, 231);
            this.BtnAfeHostWrite.Name = "BtnAfeHostWrite";
            this.BtnAfeHostWrite.Size = new System.Drawing.Size(134, 22);
            this.BtnAfeHostWrite.TabIndex = 19;
            this.BtnAfeHostWrite.Text = "WRITE";
            this.BtnAfeHostWrite.UseVisualStyleBackColor = true;
            this.BtnAfeHostWrite.Click += new System.EventHandler(this.BtnAfeHostWrite_Click);
            // 
            // AFE_WDATA_TXT
            // 
            this.AFE_WDATA_TXT.Location = new System.Drawing.Point(125, 46);
            this.AFE_WDATA_TXT.Name = "AFE_WDATA_TXT";
            this.AFE_WDATA_TXT.Size = new System.Drawing.Size(180, 25);
            this.AFE_WDATA_TXT.TabIndex = 16;
            this.AFE_WDATA_TXT.Text = "0x";
            this.AFE_WDATA_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AFE_RDATA_TXT
            // 
            this.AFE_RDATA_TXT.Location = new System.Drawing.Point(125, 73);
            this.AFE_RDATA_TXT.Name = "AFE_RDATA_TXT";
            this.AFE_RDATA_TXT.Size = new System.Drawing.Size(180, 25);
            this.AFE_RDATA_TXT.TabIndex = 18;
            this.AFE_RDATA_TXT.Text = "0x";
            this.AFE_RDATA_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.ForeColor = System.Drawing.Color.Black;
            this.label46.Location = new System.Drawing.Point(6, 82);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(129, 15);
            this.label46.TabIndex = 17;
            this.label46.Text = "Read Data(Hex)";
            // 
            // ANA_HOST_GROUP
            // 
            this.ANA_HOST_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ANA_HOST_GROUP.Controls.Add(this.ANA_SEL_FPGA);
            this.ANA_HOST_GROUP.Controls.Add(this.ANA_FPGA_SEL_GROUP);
            this.ANA_HOST_GROUP.Controls.Add(this.BtnAnaHostRead);
            this.ANA_HOST_GROUP.Controls.Add(this.ANA_BOARD_SEL_GROUP);
            this.ANA_HOST_GROUP.Controls.Add(this.BtnAnaHostWrite);
            this.ANA_HOST_GROUP.Controls.Add(this.ANA_RDATA_TXT);
            this.ANA_HOST_GROUP.Controls.Add(this.label13);
            this.ANA_HOST_GROUP.Controls.Add(this.ANA_WDATA_TXT);
            this.ANA_HOST_GROUP.Controls.Add(this.label14);
            this.ANA_HOST_GROUP.Controls.Add(this.ANA_ADDR_TXT);
            this.ANA_HOST_GROUP.Controls.Add(this.label15);
            this.ANA_HOST_GROUP.ForeColor = System.Drawing.Color.Black;
            this.ANA_HOST_GROUP.Location = new System.Drawing.Point(580, 15);
            this.ANA_HOST_GROUP.Name = "ANA_HOST_GROUP";
            this.ANA_HOST_GROUP.Size = new System.Drawing.Size(280, 259);
            this.ANA_HOST_GROUP.TabIndex = 10;
            this.ANA_HOST_GROUP.TabStop = false;
            this.ANA_HOST_GROUP.Text = "Analog Host Test";
            // 
            // ANA_SEL_FPGA
            // 
            this.ANA_SEL_FPGA.Location = new System.Drawing.Point(8, 195);
            this.ANA_SEL_FPGA.Name = "ANA_SEL_FPGA";
            this.ANA_SEL_FPGA.Size = new System.Drawing.Size(253, 25);
            this.ANA_SEL_FPGA.TabIndex = 17;
            this.ANA_SEL_FPGA.Text = "Ana Board1, FPGA1";
            this.ANA_SEL_FPGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ANA_FPGA_SEL_GROUP
            // 
            this.ANA_FPGA_SEL_GROUP.Controls.Add(this.RBtnAnaFpga2);
            this.ANA_FPGA_SEL_GROUP.Controls.Add(this.RBtnAnaFpga1);
            this.ANA_FPGA_SEL_GROUP.Location = new System.Drawing.Point(8, 149);
            this.ANA_FPGA_SEL_GROUP.Name = "ANA_FPGA_SEL_GROUP";
            this.ANA_FPGA_SEL_GROUP.Size = new System.Drawing.Size(253, 39);
            this.ANA_FPGA_SEL_GROUP.TabIndex = 17;
            this.ANA_FPGA_SEL_GROUP.TabStop = false;
            this.ANA_FPGA_SEL_GROUP.Text = "Ana FPGA Select";
            // 
            // RBtnAnaFpga2
            // 
            this.RBtnAnaFpga2.AutoSize = true;
            this.RBtnAnaFpga2.Location = new System.Drawing.Point(174, 17);
            this.RBtnAnaFpga2.Name = "RBtnAnaFpga2";
            this.RBtnAnaFpga2.Size = new System.Drawing.Size(37, 19);
            this.RBtnAnaFpga2.TabIndex = 10;
            this.RBtnAnaFpga2.Text = "2";
            this.RBtnAnaFpga2.UseVisualStyleBackColor = true;
            this.RBtnAnaFpga2.CheckedChanged += new System.EventHandler(this.RBtnAnaFpga2_CheckedChanged);
            // 
            // RBtnAnaFpga1
            // 
            this.RBtnAnaFpga1.AutoSize = true;
            this.RBtnAnaFpga1.Checked = true;
            this.RBtnAnaFpga1.Location = new System.Drawing.Point(48, 17);
            this.RBtnAnaFpga1.Name = "RBtnAnaFpga1";
            this.RBtnAnaFpga1.Size = new System.Drawing.Size(37, 19);
            this.RBtnAnaFpga1.TabIndex = 9;
            this.RBtnAnaFpga1.TabStop = true;
            this.RBtnAnaFpga1.Text = "1";
            this.RBtnAnaFpga1.UseVisualStyleBackColor = true;
            // 
            // BtnAnaHostRead
            // 
            this.BtnAnaHostRead.Location = new System.Drawing.Point(149, 231);
            this.BtnAnaHostRead.Name = "BtnAnaHostRead";
            this.BtnAnaHostRead.Size = new System.Drawing.Size(114, 22);
            this.BtnAnaHostRead.TabIndex = 8;
            this.BtnAnaHostRead.Text = "READ";
            this.BtnAnaHostRead.UseVisualStyleBackColor = true;
            this.BtnAnaHostRead.Click += new System.EventHandler(this.BtnAnaHostRead_Click);
            // 
            // ANA_BOARD_SEL_GROUP
            // 
            this.ANA_BOARD_SEL_GROUP.Controls.Add(this.RBtnAnaBoard2);
            this.ANA_BOARD_SEL_GROUP.Controls.Add(this.RBtnAnaBoard1);
            this.ANA_BOARD_SEL_GROUP.Location = new System.Drawing.Point(8, 105);
            this.ANA_BOARD_SEL_GROUP.Name = "ANA_BOARD_SEL_GROUP";
            this.ANA_BOARD_SEL_GROUP.Size = new System.Drawing.Size(253, 38);
            this.ANA_BOARD_SEL_GROUP.TabIndex = 16;
            this.ANA_BOARD_SEL_GROUP.TabStop = false;
            this.ANA_BOARD_SEL_GROUP.Text = "Ana Board Select";
            // 
            // RBtnAnaBoard2
            // 
            this.RBtnAnaBoard2.AutoSize = true;
            this.RBtnAnaBoard2.Location = new System.Drawing.Point(174, 16);
            this.RBtnAnaBoard2.Name = "RBtnAnaBoard2";
            this.RBtnAnaBoard2.Size = new System.Drawing.Size(37, 19);
            this.RBtnAnaBoard2.TabIndex = 13;
            this.RBtnAnaBoard2.Text = "2";
            this.RBtnAnaBoard2.UseVisualStyleBackColor = true;
            this.RBtnAnaBoard2.CheckedChanged += new System.EventHandler(this.RBtnAnaBoard2_CheckedChanged);
            // 
            // RBtnAnaBoard1
            // 
            this.RBtnAnaBoard1.AutoSize = true;
            this.RBtnAnaBoard1.Checked = true;
            this.RBtnAnaBoard1.Location = new System.Drawing.Point(48, 16);
            this.RBtnAnaBoard1.Name = "RBtnAnaBoard1";
            this.RBtnAnaBoard1.Size = new System.Drawing.Size(37, 19);
            this.RBtnAnaBoard1.TabIndex = 12;
            this.RBtnAnaBoard1.TabStop = true;
            this.RBtnAnaBoard1.Text = "1";
            this.RBtnAnaBoard1.UseVisualStyleBackColor = true;
            // 
            // BtnAnaHostWrite
            // 
            this.BtnAnaHostWrite.Location = new System.Drawing.Point(8, 231);
            this.BtnAnaHostWrite.Name = "BtnAnaHostWrite";
            this.BtnAnaHostWrite.Size = new System.Drawing.Size(119, 22);
            this.BtnAnaHostWrite.TabIndex = 7;
            this.BtnAnaHostWrite.Text = "WRITE";
            this.BtnAnaHostWrite.UseVisualStyleBackColor = true;
            this.BtnAnaHostWrite.Click += new System.EventHandler(this.BtnAnaHostWrite_Click);
            // 
            // ANA_RDATA_TXT
            // 
            this.ANA_RDATA_TXT.Location = new System.Drawing.Point(125, 73);
            this.ANA_RDATA_TXT.Name = "ANA_RDATA_TXT";
            this.ANA_RDATA_TXT.Size = new System.Drawing.Size(136, 25);
            this.ANA_RDATA_TXT.TabIndex = 6;
            this.ANA_RDATA_TXT.Text = "0x";
            this.ANA_RDATA_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "Read Data(Hex)";
            // 
            // ANA_WDATA_TXT
            // 
            this.ANA_WDATA_TXT.Location = new System.Drawing.Point(125, 46);
            this.ANA_WDATA_TXT.Name = "ANA_WDATA_TXT";
            this.ANA_WDATA_TXT.Size = new System.Drawing.Size(136, 25);
            this.ANA_WDATA_TXT.TabIndex = 4;
            this.ANA_WDATA_TXT.Text = "0x";
            this.ANA_WDATA_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(6, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Write Data(Hex)";
            // 
            // ANA_ADDR_TXT
            // 
            this.ANA_ADDR_TXT.Location = new System.Drawing.Point(125, 19);
            this.ANA_ADDR_TXT.Name = "ANA_ADDR_TXT";
            this.ANA_ADDR_TXT.Size = new System.Drawing.Size(136, 25);
            this.ANA_ADDR_TXT.TabIndex = 2;
            this.ANA_ADDR_TXT.Text = "0x80000001";
            this.ANA_ADDR_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Address(Hex)";
            // 
            // ACQ_HOST_GROUP
            // 
            this.ACQ_HOST_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ACQ_HOST_GROUP.Controls.Add(this.ACQ_SEL_FPGA);
            this.ACQ_HOST_GROUP.Controls.Add(this.ACQ_FPGA_SEL_GROUP);
            this.ACQ_HOST_GROUP.Controls.Add(this.ACQ_BOARD_SEL_GROUP);
            this.ACQ_HOST_GROUP.Controls.Add(this.BtnAcqHostRead);
            this.ACQ_HOST_GROUP.Controls.Add(this.BtnAcqHostWrite);
            this.ACQ_HOST_GROUP.Controls.Add(this.ACQ_RDATA_TXT);
            this.ACQ_HOST_GROUP.Controls.Add(this.label10);
            this.ACQ_HOST_GROUP.Controls.Add(this.ACQ_WDATA_TXT);
            this.ACQ_HOST_GROUP.Controls.Add(this.label11);
            this.ACQ_HOST_GROUP.Controls.Add(this.ACQ_ADDR_TXT);
            this.ACQ_HOST_GROUP.Controls.Add(this.label12);
            this.ACQ_HOST_GROUP.ForeColor = System.Drawing.Color.Black;
            this.ACQ_HOST_GROUP.Location = new System.Drawing.Point(294, 15);
            this.ACQ_HOST_GROUP.Name = "ACQ_HOST_GROUP";
            this.ACQ_HOST_GROUP.Size = new System.Drawing.Size(280, 259);
            this.ACQ_HOST_GROUP.TabIndex = 9;
            this.ACQ_HOST_GROUP.TabStop = false;
            this.ACQ_HOST_GROUP.Text = "Acquisition Host Test";
            // 
            // ACQ_SEL_FPGA
            // 
            this.ACQ_SEL_FPGA.Location = new System.Drawing.Point(8, 195);
            this.ACQ_SEL_FPGA.Name = "ACQ_SEL_FPGA";
            this.ACQ_SEL_FPGA.Size = new System.Drawing.Size(253, 25);
            this.ACQ_SEL_FPGA.TabIndex = 16;
            this.ACQ_SEL_FPGA.Text = "Acq Board1, FPGA1";
            this.ACQ_SEL_FPGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ACQ_FPGA_SEL_GROUP
            // 
            this.ACQ_FPGA_SEL_GROUP.Controls.Add(this.RBtnAcqFpga2);
            this.ACQ_FPGA_SEL_GROUP.Controls.Add(this.RBtnAcqFpga1);
            this.ACQ_FPGA_SEL_GROUP.Location = new System.Drawing.Point(8, 147);
            this.ACQ_FPGA_SEL_GROUP.Name = "ACQ_FPGA_SEL_GROUP";
            this.ACQ_FPGA_SEL_GROUP.Size = new System.Drawing.Size(253, 39);
            this.ACQ_FPGA_SEL_GROUP.TabIndex = 15;
            this.ACQ_FPGA_SEL_GROUP.TabStop = false;
            this.ACQ_FPGA_SEL_GROUP.Text = "Acq FPGA Select";
            // 
            // RBtnAcqFpga2
            // 
            this.RBtnAcqFpga2.AutoSize = true;
            this.RBtnAcqFpga2.Location = new System.Drawing.Point(174, 17);
            this.RBtnAcqFpga2.Name = "RBtnAcqFpga2";
            this.RBtnAcqFpga2.Size = new System.Drawing.Size(37, 19);
            this.RBtnAcqFpga2.TabIndex = 10;
            this.RBtnAcqFpga2.Text = "2";
            this.RBtnAcqFpga2.UseVisualStyleBackColor = true;
            this.RBtnAcqFpga2.CheckedChanged += new System.EventHandler(this.RBtnAcqFpga2_CheckedChanged);
            // 
            // RBtnAcqFpga1
            // 
            this.RBtnAcqFpga1.AutoSize = true;
            this.RBtnAcqFpga1.Checked = true;
            this.RBtnAcqFpga1.Location = new System.Drawing.Point(48, 17);
            this.RBtnAcqFpga1.Name = "RBtnAcqFpga1";
            this.RBtnAcqFpga1.Size = new System.Drawing.Size(37, 19);
            this.RBtnAcqFpga1.TabIndex = 9;
            this.RBtnAcqFpga1.TabStop = true;
            this.RBtnAcqFpga1.Text = "1";
            this.RBtnAcqFpga1.UseVisualStyleBackColor = true;
            // 
            // ACQ_BOARD_SEL_GROUP
            // 
            this.ACQ_BOARD_SEL_GROUP.Controls.Add(this.RBtnAcqBoard2);
            this.ACQ_BOARD_SEL_GROUP.Controls.Add(this.RBtnAcqBoard1);
            this.ACQ_BOARD_SEL_GROUP.Location = new System.Drawing.Point(8, 103);
            this.ACQ_BOARD_SEL_GROUP.Name = "ACQ_BOARD_SEL_GROUP";
            this.ACQ_BOARD_SEL_GROUP.Size = new System.Drawing.Size(253, 38);
            this.ACQ_BOARD_SEL_GROUP.TabIndex = 14;
            this.ACQ_BOARD_SEL_GROUP.TabStop = false;
            this.ACQ_BOARD_SEL_GROUP.Text = "Acq Board Select";
            // 
            // RBtnAcqBoard2
            // 
            this.RBtnAcqBoard2.AutoSize = true;
            this.RBtnAcqBoard2.Location = new System.Drawing.Point(174, 16);
            this.RBtnAcqBoard2.Name = "RBtnAcqBoard2";
            this.RBtnAcqBoard2.Size = new System.Drawing.Size(37, 19);
            this.RBtnAcqBoard2.TabIndex = 13;
            this.RBtnAcqBoard2.Text = "2";
            this.RBtnAcqBoard2.UseVisualStyleBackColor = true;
            this.RBtnAcqBoard2.CheckedChanged += new System.EventHandler(this.RBtnAcqBoard2_CheckedChanged);
            // 
            // RBtnAcqBoard1
            // 
            this.RBtnAcqBoard1.AutoSize = true;
            this.RBtnAcqBoard1.Checked = true;
            this.RBtnAcqBoard1.Location = new System.Drawing.Point(48, 16);
            this.RBtnAcqBoard1.Name = "RBtnAcqBoard1";
            this.RBtnAcqBoard1.Size = new System.Drawing.Size(37, 19);
            this.RBtnAcqBoard1.TabIndex = 12;
            this.RBtnAcqBoard1.TabStop = true;
            this.RBtnAcqBoard1.Text = "1";
            this.RBtnAcqBoard1.UseVisualStyleBackColor = true;
            // 
            // BtnAcqHostRead
            // 
            this.BtnAcqHostRead.Location = new System.Drawing.Point(147, 231);
            this.BtnAcqHostRead.Name = "BtnAcqHostRead";
            this.BtnAcqHostRead.Size = new System.Drawing.Size(114, 22);
            this.BtnAcqHostRead.TabIndex = 8;
            this.BtnAcqHostRead.Text = "READ";
            this.BtnAcqHostRead.UseVisualStyleBackColor = true;
            this.BtnAcqHostRead.Click += new System.EventHandler(this.BtnAcqHostRead_Click);
            // 
            // BtnAcqHostWrite
            // 
            this.BtnAcqHostWrite.Location = new System.Drawing.Point(6, 231);
            this.BtnAcqHostWrite.Name = "BtnAcqHostWrite";
            this.BtnAcqHostWrite.Size = new System.Drawing.Size(119, 22);
            this.BtnAcqHostWrite.TabIndex = 7;
            this.BtnAcqHostWrite.Text = "WRITE";
            this.BtnAcqHostWrite.UseVisualStyleBackColor = true;
            this.BtnAcqHostWrite.Click += new System.EventHandler(this.BtnAcqHostWrite_Click);
            // 
            // ACQ_RDATA_TXT
            // 
            this.ACQ_RDATA_TXT.Location = new System.Drawing.Point(125, 73);
            this.ACQ_RDATA_TXT.Name = "ACQ_RDATA_TXT";
            this.ACQ_RDATA_TXT.Size = new System.Drawing.Size(136, 25);
            this.ACQ_RDATA_TXT.TabIndex = 6;
            this.ACQ_RDATA_TXT.Text = "0x";
            this.ACQ_RDATA_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Read Data(Hex)";
            // 
            // ACQ_WDATA_TXT
            // 
            this.ACQ_WDATA_TXT.Location = new System.Drawing.Point(125, 46);
            this.ACQ_WDATA_TXT.Name = "ACQ_WDATA_TXT";
            this.ACQ_WDATA_TXT.Size = new System.Drawing.Size(136, 25);
            this.ACQ_WDATA_TXT.TabIndex = 4;
            this.ACQ_WDATA_TXT.Text = "0x";
            this.ACQ_WDATA_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Write Data(Hex)";
            // 
            // ACQ_ADDR_TXT
            // 
            this.ACQ_ADDR_TXT.Location = new System.Drawing.Point(125, 19);
            this.ACQ_ADDR_TXT.Name = "ACQ_ADDR_TXT";
            this.ACQ_ADDR_TXT.Size = new System.Drawing.Size(136, 25);
            this.ACQ_ADDR_TXT.TabIndex = 2;
            this.ACQ_ADDR_TXT.Text = "0x10000006";
            this.ACQ_ADDR_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Address(Hex)";
            // 
            // RTC_HOST_GROUP
            // 
            this.RTC_HOST_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RTC_HOST_GROUP.Controls.Add(this.BtnRtcHostRead);
            this.RTC_HOST_GROUP.Controls.Add(this.BtnRtcHostWrite);
            this.RTC_HOST_GROUP.Controls.Add(this.RTC_RDATA_TXT);
            this.RTC_HOST_GROUP.Controls.Add(this.label9);
            this.RTC_HOST_GROUP.Controls.Add(this.RTC_WDATA_TXT);
            this.RTC_HOST_GROUP.Controls.Add(this.label8);
            this.RTC_HOST_GROUP.Controls.Add(this.RTC_ADDR_TXT);
            this.RTC_HOST_GROUP.Controls.Add(this.label6);
            this.RTC_HOST_GROUP.ForeColor = System.Drawing.Color.Black;
            this.RTC_HOST_GROUP.Location = new System.Drawing.Point(8, 15);
            this.RTC_HOST_GROUP.Name = "RTC_HOST_GROUP";
            this.RTC_HOST_GROUP.Size = new System.Drawing.Size(280, 259);
            this.RTC_HOST_GROUP.TabIndex = 0;
            this.RTC_HOST_GROUP.TabStop = false;
            this.RTC_HOST_GROUP.Text = "RTC Host Test";
            // 
            // BtnRtcHostRead
            // 
            this.BtnRtcHostRead.Location = new System.Drawing.Point(147, 231);
            this.BtnRtcHostRead.Name = "BtnRtcHostRead";
            this.BtnRtcHostRead.Size = new System.Drawing.Size(114, 22);
            this.BtnRtcHostRead.TabIndex = 8;
            this.BtnRtcHostRead.Text = "READ";
            this.BtnRtcHostRead.UseVisualStyleBackColor = true;
            this.BtnRtcHostRead.Click += new System.EventHandler(this.BtnRtcHostRead_Click);
            // 
            // BtnRtcHostWrite
            // 
            this.BtnRtcHostWrite.Location = new System.Drawing.Point(6, 231);
            this.BtnRtcHostWrite.Name = "BtnRtcHostWrite";
            this.BtnRtcHostWrite.Size = new System.Drawing.Size(119, 22);
            this.BtnRtcHostWrite.TabIndex = 7;
            this.BtnRtcHostWrite.Text = "WRITE";
            this.BtnRtcHostWrite.UseVisualStyleBackColor = true;
            this.BtnRtcHostWrite.Click += new System.EventHandler(this.BtnRtcHostWrite_Click);
            // 
            // RTC_RDATA_TXT
            // 
            this.RTC_RDATA_TXT.Location = new System.Drawing.Point(125, 73);
            this.RTC_RDATA_TXT.Name = "RTC_RDATA_TXT";
            this.RTC_RDATA_TXT.Size = new System.Drawing.Size(136, 25);
            this.RTC_RDATA_TXT.TabIndex = 6;
            this.RTC_RDATA_TXT.Text = "0x";
            this.RTC_RDATA_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Read Data(Hex)";
            // 
            // RTC_WDATA_TXT
            // 
            this.RTC_WDATA_TXT.Location = new System.Drawing.Point(125, 46);
            this.RTC_WDATA_TXT.Name = "RTC_WDATA_TXT";
            this.RTC_WDATA_TXT.Size = new System.Drawing.Size(136, 25);
            this.RTC_WDATA_TXT.TabIndex = 4;
            this.RTC_WDATA_TXT.Text = "0x";
            this.RTC_WDATA_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Write Data(Hex)";
            // 
            // RTC_ADDR_TXT
            // 
            this.RTC_ADDR_TXT.Location = new System.Drawing.Point(125, 19);
            this.RTC_ADDR_TXT.Name = "RTC_ADDR_TXT";
            this.RTC_ADDR_TXT.Size = new System.Drawing.Size(136, 25);
            this.RTC_ADDR_TXT.TabIndex = 2;
            this.RTC_ADDR_TXT.Text = "0x0000";
            this.RTC_ADDR_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Address(Hex)";
            // 
            // SYS_TEST_TAB
            // 
            this.SYS_TEST_TAB.Controls.Add(this.SYS_CONFIG_GROUP);
            this.SYS_TEST_TAB.Controls.Add(this.ACQ_REGIST_GROUP);
            this.SYS_TEST_TAB.Controls.Add(this.ANA_CONFIG_GROUP);
            this.SYS_TEST_TAB.Controls.Add(this.TX_PULSE_GROUP);
            this.SYS_TEST_TAB.Controls.Add(this.ATGC_GROUP);
            this.SYS_TEST_TAB.Controls.Add(this.TEST_START_GROUP);
            this.SYS_TEST_TAB.Controls.Add(this.RTC_REGIST_GROUP);
            this.SYS_TEST_TAB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SYS_TEST_TAB.ForeColor = System.Drawing.Color.Black;
            this.SYS_TEST_TAB.Location = new System.Drawing.Point(4, 44);
            this.SYS_TEST_TAB.Name = "SYS_TEST_TAB";
            this.SYS_TEST_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.SYS_TEST_TAB.Size = new System.Drawing.Size(1346, 591);
            this.SYS_TEST_TAB.TabIndex = 0;
            this.SYS_TEST_TAB.Text = "System Test";
            this.SYS_TEST_TAB.UseVisualStyleBackColor = true;
            // 
            // SYS_CONFIG_GROUP
            // 
            this.SYS_CONFIG_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SYS_CONFIG_GROUP.Controls.Add(this.SYS_CHANNEL_TXT);
            this.SYS_CONFIG_GROUP.Controls.Add(this.SYS_CHANNEL_LABEL);
            this.SYS_CONFIG_GROUP.Controls.Add(this.SYS_TX_PULSE_BURST_TXT);
            this.SYS_CONFIG_GROUP.Controls.Add(this.SYS_TX_PULSE_BURST_LABEL);
            this.SYS_CONFIG_GROUP.Controls.Add(this.SYS_STEER_ANGLE_TXT);
            this.SYS_CONFIG_GROUP.Controls.Add(this.SYS_STEER_ANGLE_LABEL);
            this.SYS_CONFIG_GROUP.Controls.Add(this.SYS_TX_FREQ_TXT);
            this.SYS_CONFIG_GROUP.Controls.Add(this.SYS_TX_FREQ_LABEL);
            this.SYS_CONFIG_GROUP.Controls.Add(this.SYS_PRF_COUNT_TXT);
            this.SYS_CONFIG_GROUP.Controls.Add(this.SYS_PRF_COUNT_LABEL);
            this.SYS_CONFIG_GROUP.Controls.Add(this.SYS_FRAME_COUNT_TXT);
            this.SYS_CONFIG_GROUP.Controls.Add(this.SYS_FRAME_COUNT_LABEL);
            this.SYS_CONFIG_GROUP.Controls.Add(this.SYS_VIEW_DEPTH_TXT);
            this.SYS_CONFIG_GROUP.Controls.Add(this.SYS_VIEW_DEPTH_LABEL);
            this.SYS_CONFIG_GROUP.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SYS_CONFIG_GROUP.ForeColor = System.Drawing.Color.Red;
            this.SYS_CONFIG_GROUP.Location = new System.Drawing.Point(6, 9);
            this.SYS_CONFIG_GROUP.Name = "SYS_CONFIG_GROUP";
            this.SYS_CONFIG_GROUP.Size = new System.Drawing.Size(228, 574);
            this.SYS_CONFIG_GROUP.TabIndex = 3;
            this.SYS_CONFIG_GROUP.TabStop = false;
            this.SYS_CONFIG_GROUP.Text = "SYSTEM Configuration";
            // 
            // SYS_CHANNEL_TXT
            // 
            this.SYS_CHANNEL_TXT.Location = new System.Drawing.Point(152, 31);
            this.SYS_CHANNEL_TXT.Name = "SYS_CHANNEL_TXT";
            this.SYS_CHANNEL_TXT.Size = new System.Drawing.Size(67, 25);
            this.SYS_CHANNEL_TXT.TabIndex = 23;
            this.SYS_CHANNEL_TXT.Text = "128";
            this.SYS_CHANNEL_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SYS_CHANNEL_TXT.TextChanged += new System.EventHandler(this.SysChannelTextChanged);
            // 
            // SYS_CHANNEL_LABEL
            // 
            this.SYS_CHANNEL_LABEL.AutoSize = true;
            this.SYS_CHANNEL_LABEL.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SYS_CHANNEL_LABEL.ForeColor = System.Drawing.Color.Black;
            this.SYS_CHANNEL_LABEL.Location = new System.Drawing.Point(6, 40);
            this.SYS_CHANNEL_LABEL.Name = "SYS_CHANNEL_LABEL";
            this.SYS_CHANNEL_LABEL.Size = new System.Drawing.Size(133, 15);
            this.SYS_CHANNEL_LABEL.TabIndex = 22;
            this.SYS_CHANNEL_LABEL.Text = "SYSTEM CHANNEL";
            // 
            // SYS_TX_PULSE_BURST_TXT
            // 
            this.SYS_TX_PULSE_BURST_TXT.Location = new System.Drawing.Point(152, 166);
            this.SYS_TX_PULSE_BURST_TXT.Name = "SYS_TX_PULSE_BURST_TXT";
            this.SYS_TX_PULSE_BURST_TXT.Size = new System.Drawing.Size(67, 25);
            this.SYS_TX_PULSE_BURST_TXT.TabIndex = 21;
            this.SYS_TX_PULSE_BURST_TXT.Text = "1";
            this.SYS_TX_PULSE_BURST_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SYS_TX_PULSE_BURST_TXT.TextChanged += new System.EventHandler(this.SysTxConfigTextChanged);
            // 
            // SYS_TX_PULSE_BURST_LABEL
            // 
            this.SYS_TX_PULSE_BURST_LABEL.AutoSize = true;
            this.SYS_TX_PULSE_BURST_LABEL.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SYS_TX_PULSE_BURST_LABEL.ForeColor = System.Drawing.Color.Black;
            this.SYS_TX_PULSE_BURST_LABEL.Location = new System.Drawing.Point(6, 175);
            this.SYS_TX_PULSE_BURST_LABEL.Name = "SYS_TX_PULSE_BURST_LABEL";
            this.SYS_TX_PULSE_BURST_LABEL.Size = new System.Drawing.Size(133, 15);
            this.SYS_TX_PULSE_BURST_LABEL.TabIndex = 20;
            this.SYS_TX_PULSE_BURST_LABEL.Text = "Tx Pulse Burst";
            // 
            // SYS_STEER_ANGLE_TXT
            // 
            this.SYS_STEER_ANGLE_TXT.Location = new System.Drawing.Point(152, 193);
            this.SYS_STEER_ANGLE_TXT.Name = "SYS_STEER_ANGLE_TXT";
            this.SYS_STEER_ANGLE_TXT.Size = new System.Drawing.Size(67, 25);
            this.SYS_STEER_ANGLE_TXT.TabIndex = 19;
            this.SYS_STEER_ANGLE_TXT.Text = "0";
            this.SYS_STEER_ANGLE_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SYS_STEER_ANGLE_TXT.TextChanged += new System.EventHandler(this.SysChannelTextChanged);
            // 
            // SYS_STEER_ANGLE_LABEL
            // 
            this.SYS_STEER_ANGLE_LABEL.AutoSize = true;
            this.SYS_STEER_ANGLE_LABEL.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SYS_STEER_ANGLE_LABEL.ForeColor = System.Drawing.Color.Black;
            this.SYS_STEER_ANGLE_LABEL.Location = new System.Drawing.Point(6, 202);
            this.SYS_STEER_ANGLE_LABEL.Name = "SYS_STEER_ANGLE_LABEL";
            this.SYS_STEER_ANGLE_LABEL.Size = new System.Drawing.Size(133, 15);
            this.SYS_STEER_ANGLE_LABEL.TabIndex = 18;
            this.SYS_STEER_ANGLE_LABEL.Text = "TX Steer Angle";
            // 
            // SYS_TX_FREQ_TXT
            // 
            this.SYS_TX_FREQ_TXT.Location = new System.Drawing.Point(152, 139);
            this.SYS_TX_FREQ_TXT.Name = "SYS_TX_FREQ_TXT";
            this.SYS_TX_FREQ_TXT.Size = new System.Drawing.Size(67, 25);
            this.SYS_TX_FREQ_TXT.TabIndex = 17;
            this.SYS_TX_FREQ_TXT.Text = "5";
            this.SYS_TX_FREQ_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SYS_TX_FREQ_TXT.TextChanged += new System.EventHandler(this.SysTxConfigTextChanged);
            // 
            // SYS_TX_FREQ_LABEL
            // 
            this.SYS_TX_FREQ_LABEL.AutoSize = true;
            this.SYS_TX_FREQ_LABEL.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SYS_TX_FREQ_LABEL.ForeColor = System.Drawing.Color.Black;
            this.SYS_TX_FREQ_LABEL.Location = new System.Drawing.Point(6, 148);
            this.SYS_TX_FREQ_LABEL.Name = "SYS_TX_FREQ_LABEL";
            this.SYS_TX_FREQ_LABEL.Size = new System.Drawing.Size(160, 15);
            this.SYS_TX_FREQ_LABEL.TabIndex = 16;
            this.SYS_TX_FREQ_LABEL.Text = "Tx Frequency(Mhz)";
            // 
            // SYS_PRF_COUNT_TXT
            // 
            this.SYS_PRF_COUNT_TXT.Location = new System.Drawing.Point(152, 112);
            this.SYS_PRF_COUNT_TXT.Name = "SYS_PRF_COUNT_TXT";
            this.SYS_PRF_COUNT_TXT.Size = new System.Drawing.Size(67, 25);
            this.SYS_PRF_COUNT_TXT.TabIndex = 15;
            this.SYS_PRF_COUNT_TXT.Text = "5";
            this.SYS_PRF_COUNT_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SYS_PRF_COUNT_TXT.TextChanged += new System.EventHandler(this.SysConfigTextChanged);
            // 
            // SYS_PRF_COUNT_LABEL
            // 
            this.SYS_PRF_COUNT_LABEL.AutoSize = true;
            this.SYS_PRF_COUNT_LABEL.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SYS_PRF_COUNT_LABEL.ForeColor = System.Drawing.Color.Black;
            this.SYS_PRF_COUNT_LABEL.Location = new System.Drawing.Point(6, 121);
            this.SYS_PRF_COUNT_LABEL.Name = "SYS_PRF_COUNT_LABEL";
            this.SYS_PRF_COUNT_LABEL.Size = new System.Drawing.Size(88, 15);
            this.SYS_PRF_COUNT_LABEL.TabIndex = 14;
            this.SYS_PRF_COUNT_LABEL.Text = "Prf Count";
            // 
            // SYS_FRAME_COUNT_TXT
            // 
            this.SYS_FRAME_COUNT_TXT.Location = new System.Drawing.Point(152, 85);
            this.SYS_FRAME_COUNT_TXT.Name = "SYS_FRAME_COUNT_TXT";
            this.SYS_FRAME_COUNT_TXT.Size = new System.Drawing.Size(67, 25);
            this.SYS_FRAME_COUNT_TXT.TabIndex = 13;
            this.SYS_FRAME_COUNT_TXT.Text = "1";
            this.SYS_FRAME_COUNT_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SYS_FRAME_COUNT_TXT.TextChanged += new System.EventHandler(this.SysConfigTextChanged);
            // 
            // SYS_FRAME_COUNT_LABEL
            // 
            this.SYS_FRAME_COUNT_LABEL.AutoSize = true;
            this.SYS_FRAME_COUNT_LABEL.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SYS_FRAME_COUNT_LABEL.ForeColor = System.Drawing.Color.Black;
            this.SYS_FRAME_COUNT_LABEL.Location = new System.Drawing.Point(6, 94);
            this.SYS_FRAME_COUNT_LABEL.Name = "SYS_FRAME_COUNT_LABEL";
            this.SYS_FRAME_COUNT_LABEL.Size = new System.Drawing.Size(106, 15);
            this.SYS_FRAME_COUNT_LABEL.TabIndex = 12;
            this.SYS_FRAME_COUNT_LABEL.Text = "Frame Count";
            // 
            // SYS_VIEW_DEPTH_TXT
            // 
            this.SYS_VIEW_DEPTH_TXT.Location = new System.Drawing.Point(152, 58);
            this.SYS_VIEW_DEPTH_TXT.Name = "SYS_VIEW_DEPTH_TXT";
            this.SYS_VIEW_DEPTH_TXT.Size = new System.Drawing.Size(67, 25);
            this.SYS_VIEW_DEPTH_TXT.TabIndex = 11;
            this.SYS_VIEW_DEPTH_TXT.Text = "5";
            this.SYS_VIEW_DEPTH_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SYS_VIEW_DEPTH_TXT.TextChanged += new System.EventHandler(this.SysConfigTextChanged);
            // 
            // SYS_VIEW_DEPTH_LABEL
            // 
            this.SYS_VIEW_DEPTH_LABEL.AutoSize = true;
            this.SYS_VIEW_DEPTH_LABEL.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SYS_VIEW_DEPTH_LABEL.ForeColor = System.Drawing.Color.Black;
            this.SYS_VIEW_DEPTH_LABEL.Location = new System.Drawing.Point(6, 67);
            this.SYS_VIEW_DEPTH_LABEL.Name = "SYS_VIEW_DEPTH_LABEL";
            this.SYS_VIEW_DEPTH_LABEL.Size = new System.Drawing.Size(133, 15);
            this.SYS_VIEW_DEPTH_LABEL.TabIndex = 10;
            this.SYS_VIEW_DEPTH_LABEL.Text = "View Depth(Cm)";
            // 
            // ACQ_REGIST_GROUP
            // 
            this.ACQ_REGIST_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ACQ_REGIST_GROUP.Controls.Add(this.ACQ_TEST_PATTERN_COMB);
            this.ACQ_REGIST_GROUP.Controls.Add(this.ACQ_BtnPlot);
            this.ACQ_REGIST_GROUP.Controls.Add(this.ACQ_TEST_PATTERN_CHECK);
            this.ACQ_REGIST_GROUP.Controls.Add(this.C_R_ACQ_RX_LENGTH);
            this.ACQ_REGIST_GROUP.Controls.Add(this.label21);
            this.ACQ_REGIST_GROUP.Controls.Add(this.C_R_ACQ_RX_START);
            this.ACQ_REGIST_GROUP.Controls.Add(this.label20);
            this.ACQ_REGIST_GROUP.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ACQ_REGIST_GROUP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ACQ_REGIST_GROUP.Location = new System.Drawing.Point(1121, 468);
            this.ACQ_REGIST_GROUP.Name = "ACQ_REGIST_GROUP";
            this.ACQ_REGIST_GROUP.Size = new System.Drawing.Size(216, 119);
            this.ACQ_REGIST_GROUP.TabIndex = 4;
            this.ACQ_REGIST_GROUP.TabStop = false;
            this.ACQ_REGIST_GROUP.Text = "Acqusition Register";
            // 
            // ACQ_TEST_PATTERN_COMB
            // 
            this.ACQ_TEST_PATTERN_COMB.FormattingEnabled = true;
            this.ACQ_TEST_PATTERN_COMB.Items.AddRange(new object[] {
            "1",
            "2"});
            this.ACQ_TEST_PATTERN_COMB.Location = new System.Drawing.Point(129, 70);
            this.ACQ_TEST_PATTERN_COMB.Name = "ACQ_TEST_PATTERN_COMB";
            this.ACQ_TEST_PATTERN_COMB.Size = new System.Drawing.Size(67, 23);
            this.ACQ_TEST_PATTERN_COMB.TabIndex = 27;
            this.ACQ_TEST_PATTERN_COMB.Text = "1";
            // 
            // ACQ_BtnPlot
            // 
            this.ACQ_BtnPlot.ForeColor = System.Drawing.Color.Black;
            this.ACQ_BtnPlot.Location = new System.Drawing.Point(13, 92);
            this.ACQ_BtnPlot.Name = "ACQ_BtnPlot";
            this.ACQ_BtnPlot.Size = new System.Drawing.Size(181, 23);
            this.ACQ_BtnPlot.TabIndex = 17;
            this.ACQ_BtnPlot.Text = "Plot";
            this.ACQ_BtnPlot.UseVisualStyleBackColor = true;
            this.ACQ_BtnPlot.Click += new System.EventHandler(this.BtnPlotClick);
            // 
            // ACQ_TEST_PATTERN_CHECK
            // 
            this.ACQ_TEST_PATTERN_CHECK.AutoSize = true;
            this.ACQ_TEST_PATTERN_CHECK.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ACQ_TEST_PATTERN_CHECK.ForeColor = System.Drawing.Color.Black;
            this.ACQ_TEST_PATTERN_CHECK.Location = new System.Drawing.Point(13, 75);
            this.ACQ_TEST_PATTERN_CHECK.Name = "ACQ_TEST_PATTERN_CHECK";
            this.ACQ_TEST_PATTERN_CHECK.Size = new System.Drawing.Size(137, 19);
            this.ACQ_TEST_PATTERN_CHECK.TabIndex = 16;
            this.ACQ_TEST_PATTERN_CHECK.Text = "TEST_PATTERN";
            this.ACQ_TEST_PATTERN_CHECK.UseVisualStyleBackColor = true;
            this.ACQ_TEST_PATTERN_CHECK.CheckedChanged += new System.EventHandler(this.AcqTestPatternCheckedChanged);
            // 
            // C_R_ACQ_RX_LENGTH
            // 
            this.C_R_ACQ_RX_LENGTH.Location = new System.Drawing.Point(129, 43);
            this.C_R_ACQ_RX_LENGTH.Name = "C_R_ACQ_RX_LENGTH";
            this.C_R_ACQ_RX_LENGTH.Size = new System.Drawing.Size(67, 25);
            this.C_R_ACQ_RX_LENGTH.TabIndex = 13;
            this.C_R_ACQ_RX_LENGTH.Text = "256";
            this.C_R_ACQ_RX_LENGTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(11, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 14);
            this.label21.TabIndex = 12;
            this.label21.Text = "C_R_RX_LENGTH";
            // 
            // C_R_ACQ_RX_START
            // 
            this.C_R_ACQ_RX_START.Location = new System.Drawing.Point(129, 16);
            this.C_R_ACQ_RX_START.Name = "C_R_ACQ_RX_START";
            this.C_R_ACQ_RX_START.Size = new System.Drawing.Size(67, 25);
            this.C_R_ACQ_RX_START.TabIndex = 11;
            this.C_R_ACQ_RX_START.Text = "256";
            this.C_R_ACQ_RX_START.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(11, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 14);
            this.label20.TabIndex = 10;
            this.label20.Text = "C_R_RX_START";
            // 
            // ANA_CONFIG_GROUP
            // 
            this.ANA_CONFIG_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ANA_CONFIG_GROUP.Controls.Add(this.label51);
            this.ANA_CONFIG_GROUP.Controls.Add(this.ANA_MAX14808_CC_COMB);
            this.ANA_CONFIG_GROUP.Controls.Add(this.label50);
            this.ANA_CONFIG_GROUP.Controls.Add(this.ANA_MAX14808_MODE_COMB);
            this.ANA_CONFIG_GROUP.Controls.Add(this.ANA_AFE_PATTERN_CHECK);
            this.ANA_CONFIG_GROUP.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ANA_CONFIG_GROUP.ForeColor = System.Drawing.Color.Teal;
            this.ANA_CONFIG_GROUP.Location = new System.Drawing.Point(240, 468);
            this.ANA_CONFIG_GROUP.Name = "ANA_CONFIG_GROUP";
            this.ANA_CONFIG_GROUP.Size = new System.Drawing.Size(452, 118);
            this.ANA_CONFIG_GROUP.TabIndex = 5;
            this.ANA_CONFIG_GROUP.TabStop = false;
            this.ANA_CONFIG_GROUP.Text = "Analog Component Setup";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label51.ForeColor = System.Drawing.Color.Black;
            this.label51.Location = new System.Drawing.Point(62, 85);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(106, 15);
            this.label51.TabIndex = 26;
            this.label51.Text = "MAX14808 CC";
            // 
            // ANA_MAX14808_CC_COMB
            // 
            this.ANA_MAX14808_CC_COMB.FormattingEnabled = true;
            this.ANA_MAX14808_CC_COMB.Items.AddRange(new object[] {
            "00",
            "01",
            "10",
            "11"});
            this.ANA_MAX14808_CC_COMB.Location = new System.Drawing.Point(7, 77);
            this.ANA_MAX14808_CC_COMB.Name = "ANA_MAX14808_CC_COMB";
            this.ANA_MAX14808_CC_COMB.Size = new System.Drawing.Size(49, 23);
            this.ANA_MAX14808_CC_COMB.TabIndex = 25;
            this.ANA_MAX14808_CC_COMB.Text = "11";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label50.ForeColor = System.Drawing.Color.Black;
            this.label50.Location = new System.Drawing.Point(62, 58);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(124, 15);
            this.label50.TabIndex = 24;
            this.label50.Text = "MAX14808 MODE";
            // 
            // ANA_MAX14808_MODE_COMB
            // 
            this.ANA_MAX14808_MODE_COMB.FormattingEnabled = true;
            this.ANA_MAX14808_MODE_COMB.Items.AddRange(new object[] {
            "00",
            "01",
            "10",
            "11"});
            this.ANA_MAX14808_MODE_COMB.Location = new System.Drawing.Point(7, 50);
            this.ANA_MAX14808_MODE_COMB.Name = "ANA_MAX14808_MODE_COMB";
            this.ANA_MAX14808_MODE_COMB.Size = new System.Drawing.Size(49, 23);
            this.ANA_MAX14808_MODE_COMB.TabIndex = 1;
            this.ANA_MAX14808_MODE_COMB.Text = "01";
            // 
            // ANA_AFE_PATTERN_CHECK
            // 
            this.ANA_AFE_PATTERN_CHECK.AutoSize = true;
            this.ANA_AFE_PATTERN_CHECK.ForeColor = System.Drawing.Color.Black;
            this.ANA_AFE_PATTERN_CHECK.Location = new System.Drawing.Point(7, 23);
            this.ANA_AFE_PATTERN_CHECK.Name = "ANA_AFE_PATTERN_CHECK";
            this.ANA_AFE_PATTERN_CHECK.Size = new System.Drawing.Size(215, 19);
            this.ANA_AFE_PATTERN_CHECK.TabIndex = 0;
            this.ANA_AFE_PATTERN_CHECK.Text = "AFE5809 TEST PATTERN";
            this.ANA_AFE_PATTERN_CHECK.UseVisualStyleBackColor = true;
            this.ANA_AFE_PATTERN_CHECK.CheckedChanged += new System.EventHandler(this.AfeTestPatternCheckedChanged);
            // 
            // TX_PULSE_GROUP
            // 
            this.TX_PULSE_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TX_PULSE_GROUP.Controls.Add(this.TX_PULSE_MASK_CHECK);
            this.TX_PULSE_GROUP.Controls.Add(this.label44);
            this.TX_PULSE_GROUP.Controls.Add(this.C_R_TX_B_TX_PS7);
            this.TX_PULSE_GROUP.Controls.Add(this.C_R_TX_B_TX_PS6);
            this.TX_PULSE_GROUP.Controls.Add(this.C_R_TX_B_TX_PS5);
            this.TX_PULSE_GROUP.Controls.Add(this.C_R_TX_B_TX_PS4);
            this.TX_PULSE_GROUP.Controls.Add(this.C_R_TX_B_TX_PS3);
            this.TX_PULSE_GROUP.Controls.Add(this.C_R_TX_B_TX_PS2);
            this.TX_PULSE_GROUP.Controls.Add(this.C_R_TX_B_TX_PS1);
            this.TX_PULSE_GROUP.Controls.Add(this.C_R_TX_B_TX_PS0);
            this.TX_PULSE_GROUP.Controls.Add(this.C_R_TX_B_TX_PC);
            this.TX_PULSE_GROUP.Controls.Add(this.label40);
            this.TX_PULSE_GROUP.Controls.Add(this.label41);
            this.TX_PULSE_GROUP.Controls.Add(this.label42);
            this.TX_PULSE_GROUP.Controls.Add(this.label43);
            this.TX_PULSE_GROUP.Controls.Add(this.label38);
            this.TX_PULSE_GROUP.Controls.Add(this.label39);
            this.TX_PULSE_GROUP.Controls.Add(this.label37);
            this.TX_PULSE_GROUP.Controls.Add(this.label36);
            this.TX_PULSE_GROUP.Controls.Add(this.label35);
            this.TX_PULSE_GROUP.Controls.Add(this.TX_DELAY_RICHTXT);
            this.TX_PULSE_GROUP.Controls.Add(this.TX_PULSE_GRAPH);
            this.TX_PULSE_GROUP.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TX_PULSE_GROUP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TX_PULSE_GROUP.Location = new System.Drawing.Point(698, 6);
            this.TX_PULSE_GROUP.Name = "TX_PULSE_GROUP";
            this.TX_PULSE_GROUP.Size = new System.Drawing.Size(417, 456);
            this.TX_PULSE_GROUP.TabIndex = 3;
            this.TX_PULSE_GROUP.TabStop = false;
            this.TX_PULSE_GROUP.Text = "TX Pulse";
            // 
            // TX_PULSE_MASK_CHECK
            // 
            this.TX_PULSE_MASK_CHECK.AutoSize = true;
            this.TX_PULSE_MASK_CHECK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TX_PULSE_MASK_CHECK.Font = new System.Drawing.Font("굴림체", 8.25F);
            this.TX_PULSE_MASK_CHECK.ForeColor = System.Drawing.Color.Black;
            this.TX_PULSE_MASK_CHECK.Location = new System.Drawing.Point(300, 435);
            this.TX_PULSE_MASK_CHECK.Name = "TX_PULSE_MASK_CHECK";
            this.TX_PULSE_MASK_CHECK.Size = new System.Drawing.Size(127, 18);
            this.TX_PULSE_MASK_CHECK.TabIndex = 18;
            this.TX_PULSE_MASK_CHECK.Text = "TX PULSER MASK";
            this.TX_PULSE_MASK_CHECK.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Location = new System.Drawing.Point(87, 236);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(97, 15);
            this.label44.TabIndex = 22;
            this.label44.Text = "<TX DELAY>";
            // 
            // C_R_TX_B_TX_PS7
            // 
            this.C_R_TX_B_TX_PS7.Location = new System.Drawing.Point(348, 411);
            this.C_R_TX_B_TX_PS7.Name = "C_R_TX_B_TX_PS7";
            this.C_R_TX_B_TX_PS7.Size = new System.Drawing.Size(60, 25);
            this.C_R_TX_B_TX_PS7.TabIndex = 44;
            this.C_R_TX_B_TX_PS7.Text = "0";
            this.C_R_TX_B_TX_PS7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // C_R_TX_B_TX_PS6
            // 
            this.C_R_TX_B_TX_PS6.Location = new System.Drawing.Point(348, 389);
            this.C_R_TX_B_TX_PS6.Name = "C_R_TX_B_TX_PS6";
            this.C_R_TX_B_TX_PS6.Size = new System.Drawing.Size(60, 25);
            this.C_R_TX_B_TX_PS6.TabIndex = 43;
            this.C_R_TX_B_TX_PS6.Text = "0";
            this.C_R_TX_B_TX_PS6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // C_R_TX_B_TX_PS5
            // 
            this.C_R_TX_B_TX_PS5.Location = new System.Drawing.Point(348, 368);
            this.C_R_TX_B_TX_PS5.Name = "C_R_TX_B_TX_PS5";
            this.C_R_TX_B_TX_PS5.Size = new System.Drawing.Size(60, 25);
            this.C_R_TX_B_TX_PS5.TabIndex = 42;
            this.C_R_TX_B_TX_PS5.Text = "0";
            this.C_R_TX_B_TX_PS5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // C_R_TX_B_TX_PS4
            // 
            this.C_R_TX_B_TX_PS4.Location = new System.Drawing.Point(348, 346);
            this.C_R_TX_B_TX_PS4.Name = "C_R_TX_B_TX_PS4";
            this.C_R_TX_B_TX_PS4.Size = new System.Drawing.Size(60, 25);
            this.C_R_TX_B_TX_PS4.TabIndex = 41;
            this.C_R_TX_B_TX_PS4.Text = "0";
            this.C_R_TX_B_TX_PS4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // C_R_TX_B_TX_PS3
            // 
            this.C_R_TX_B_TX_PS3.Location = new System.Drawing.Point(348, 325);
            this.C_R_TX_B_TX_PS3.Name = "C_R_TX_B_TX_PS3";
            this.C_R_TX_B_TX_PS3.Size = new System.Drawing.Size(60, 25);
            this.C_R_TX_B_TX_PS3.TabIndex = 40;
            this.C_R_TX_B_TX_PS3.Text = "0";
            this.C_R_TX_B_TX_PS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // C_R_TX_B_TX_PS2
            // 
            this.C_R_TX_B_TX_PS2.Location = new System.Drawing.Point(348, 306);
            this.C_R_TX_B_TX_PS2.Name = "C_R_TX_B_TX_PS2";
            this.C_R_TX_B_TX_PS2.Size = new System.Drawing.Size(60, 25);
            this.C_R_TX_B_TX_PS2.TabIndex = 39;
            this.C_R_TX_B_TX_PS2.Text = "0";
            this.C_R_TX_B_TX_PS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // C_R_TX_B_TX_PS1
            // 
            this.C_R_TX_B_TX_PS1.Location = new System.Drawing.Point(348, 285);
            this.C_R_TX_B_TX_PS1.Name = "C_R_TX_B_TX_PS1";
            this.C_R_TX_B_TX_PS1.Size = new System.Drawing.Size(60, 25);
            this.C_R_TX_B_TX_PS1.TabIndex = 38;
            this.C_R_TX_B_TX_PS1.Text = "0";
            this.C_R_TX_B_TX_PS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // C_R_TX_B_TX_PS0
            // 
            this.C_R_TX_B_TX_PS0.Location = new System.Drawing.Point(348, 263);
            this.C_R_TX_B_TX_PS0.Name = "C_R_TX_B_TX_PS0";
            this.C_R_TX_B_TX_PS0.Size = new System.Drawing.Size(60, 25);
            this.C_R_TX_B_TX_PS0.TabIndex = 37;
            this.C_R_TX_B_TX_PS0.Text = "0";
            this.C_R_TX_B_TX_PS0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // C_R_TX_B_TX_PC
            // 
            this.C_R_TX_B_TX_PC.Location = new System.Drawing.Point(348, 242);
            this.C_R_TX_B_TX_PC.Name = "C_R_TX_B_TX_PC";
            this.C_R_TX_B_TX_PC.Size = new System.Drawing.Size(60, 25);
            this.C_R_TX_B_TX_PC.TabIndex = 28;
            this.C_R_TX_B_TX_PC.Text = "0";
            this.C_R_TX_B_TX_PC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(247, 415);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(112, 14);
            this.label40.TabIndex = 36;
            this.label40.Text = "C_R_TX_B_TX_PS7";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(247, 393);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(112, 14);
            this.label41.TabIndex = 35;
            this.label41.Text = "C_R_TX_B_TX_PS6";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Location = new System.Drawing.Point(247, 372);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(112, 14);
            this.label42.TabIndex = 34;
            this.label42.Text = "C_R_TX_B_TX_PS5";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(247, 350);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(112, 14);
            this.label43.TabIndex = 33;
            this.label43.Text = "C_R_TX_B_TX_PS4";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(247, 329);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(112, 14);
            this.label38.TabIndex = 32;
            this.label38.Text = "C_R_TX_B_TX_PS3";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(247, 310);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(112, 14);
            this.label39.TabIndex = 31;
            this.label39.Text = "C_R_TX_B_TX_PS2";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(247, 289);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(112, 14);
            this.label37.TabIndex = 30;
            this.label37.Text = "C_R_TX_B_TX_PS1";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(247, 268);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(112, 14);
            this.label36.TabIndex = 29;
            this.label36.Text = "C_R_TX_B_TX_PS0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(247, 246);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(105, 14);
            this.label35.TabIndex = 28;
            this.label35.Text = "C_R_TX_B_TX_PC";
            // 
            // TX_DELAY_RICHTXT
            // 
            this.TX_DELAY_RICHTXT.Location = new System.Drawing.Point(6, 254);
            this.TX_DELAY_RICHTXT.Name = "TX_DELAY_RICHTXT";
            this.TX_DELAY_RICHTXT.Size = new System.Drawing.Size(235, 174);
            this.TX_DELAY_RICHTXT.TabIndex = 2;
            this.TX_DELAY_RICHTXT.Text = "";
            // 
            // TX_PULSE_GRAPH
            // 
            chartArea1.Name = "ChartArea1";
            this.TX_PULSE_GRAPH.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TX_PULSE_GRAPH.Legends.Add(legend1);
            this.TX_PULSE_GRAPH.Location = new System.Drawing.Point(6, 20);
            this.TX_PULSE_GRAPH.Name = "TX_PULSE_GRAPH";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Pulse";
            this.TX_PULSE_GRAPH.Series.Add(series1);
            this.TX_PULSE_GRAPH.Size = new System.Drawing.Size(405, 209);
            this.TX_PULSE_GRAPH.TabIndex = 1;
            this.TX_PULSE_GRAPH.Text = "chart2";
            // 
            // ATGC_GROUP
            // 
            this.ATGC_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ATGC_GROUP.Controls.Add(this.ATGC_MAX_DEPTH);
            this.ATGC_GROUP.Controls.Add(this.ATGC_MAX);
            this.ATGC_GROUP.Controls.Add(this.label23);
            this.ATGC_GROUP.Controls.Add(this.TGC_MAX_TRACK);
            this.ATGC_GROUP.Controls.Add(this.ATGC_MIN_DEPTH);
            this.ATGC_GROUP.Controls.Add(this.ATGC_MIN);
            this.ATGC_GROUP.Controls.Add(this.label22);
            this.ATGC_GROUP.Controls.Add(this.TGC_MIN_TRACK);
            this.ATGC_GROUP.Controls.Add(this.TGC_GRAPH);
            this.ATGC_GROUP.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ATGC_GROUP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ATGC_GROUP.Location = new System.Drawing.Point(240, 9);
            this.ATGC_GROUP.Name = "ATGC_GROUP";
            this.ATGC_GROUP.Size = new System.Drawing.Size(452, 453);
            this.ATGC_GROUP.TabIndex = 2;
            this.ATGC_GROUP.TabStop = false;
            this.ATGC_GROUP.Text = "ATGC ";
            // 
            // ATGC_MAX_DEPTH
            // 
            this.ATGC_MAX_DEPTH.Location = new System.Drawing.Point(345, 398);
            this.ATGC_MAX_DEPTH.Multiline = true;
            this.ATGC_MAX_DEPTH.Name = "ATGC_MAX_DEPTH";
            this.ATGC_MAX_DEPTH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ATGC_MAX_DEPTH.Size = new System.Drawing.Size(52, 36);
            this.ATGC_MAX_DEPTH.TabIndex = 23;
            this.ATGC_MAX_DEPTH.Text = "1";
            this.ATGC_MAX_DEPTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ATGC_MAX
            // 
            this.ATGC_MAX.Location = new System.Drawing.Point(18, 413);
            this.ATGC_MAX.Name = "ATGC_MAX";
            this.ATGC_MAX.Size = new System.Drawing.Size(52, 25);
            this.ATGC_MAX.TabIndex = 20;
            this.ATGC_MAX.Text = "1023";
            this.ATGC_MAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ATGC_MAX.TextChanged += new System.EventHandler(this.TGCTextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(16, 398);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 15);
            this.label23.TabIndex = 21;
            this.label23.Text = "TGC MAX";
            // 
            // TGC_MAX_TRACK
            // 
            this.TGC_MAX_TRACK.AutoSize = false;
            this.TGC_MAX_TRACK.BackColor = System.Drawing.Color.Khaki;
            this.TGC_MAX_TRACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TGC_MAX_TRACK.LargeChange = 1;
            this.TGC_MAX_TRACK.Location = new System.Drawing.Point(76, 398);
            this.TGC_MAX_TRACK.Maximum = 5;
            this.TGC_MAX_TRACK.Name = "TGC_MAX_TRACK";
            this.TGC_MAX_TRACK.Size = new System.Drawing.Size(263, 36);
            this.TGC_MAX_TRACK.TabIndex = 18;
            this.TGC_MAX_TRACK.Value = 1;
            this.TGC_MAX_TRACK.Scroll += new System.EventHandler(this.TGCTrackScroll);
            // 
            // ATGC_MIN_DEPTH
            // 
            this.ATGC_MIN_DEPTH.Location = new System.Drawing.Point(345, 353);
            this.ATGC_MIN_DEPTH.Multiline = true;
            this.ATGC_MIN_DEPTH.Name = "ATGC_MIN_DEPTH";
            this.ATGC_MIN_DEPTH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ATGC_MIN_DEPTH.Size = new System.Drawing.Size(52, 36);
            this.ATGC_MIN_DEPTH.TabIndex = 19;
            this.ATGC_MIN_DEPTH.Text = "0";
            this.ATGC_MIN_DEPTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ATGC_MIN
            // 
            this.ATGC_MIN.Location = new System.Drawing.Point(18, 368);
            this.ATGC_MIN.Name = "ATGC_MIN";
            this.ATGC_MIN.Size = new System.Drawing.Size(52, 25);
            this.ATGC_MIN.TabIndex = 18;
            this.ATGC_MIN.Text = "100";
            this.ATGC_MIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ATGC_MIN.TextChanged += new System.EventHandler(this.TGCTextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(16, 353);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 15);
            this.label22.TabIndex = 18;
            this.label22.Text = "TGC MIN";
            // 
            // TGC_MIN_TRACK
            // 
            this.TGC_MIN_TRACK.AutoSize = false;
            this.TGC_MIN_TRACK.BackColor = System.Drawing.Color.Khaki;
            this.TGC_MIN_TRACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TGC_MIN_TRACK.LargeChange = 1;
            this.TGC_MIN_TRACK.Location = new System.Drawing.Point(76, 353);
            this.TGC_MIN_TRACK.Maximum = 5;
            this.TGC_MIN_TRACK.Name = "TGC_MIN_TRACK";
            this.TGC_MIN_TRACK.Size = new System.Drawing.Size(263, 36);
            this.TGC_MIN_TRACK.TabIndex = 18;
            this.TGC_MIN_TRACK.Scroll += new System.EventHandler(this.TGCTrackScroll);
            // 
            // TGC_GRAPH
            // 
            chartArea2.Name = "ChartArea1";
            this.TGC_GRAPH.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.TGC_GRAPH.Legends.Add(legend2);
            this.TGC_GRAPH.Location = new System.Drawing.Point(6, 20);
            this.TGC_GRAPH.Name = "TGC_GRAPH";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "TGC Gain";
            this.TGC_GRAPH.Series.Add(series2);
            this.TGC_GRAPH.Size = new System.Drawing.Size(439, 309);
            this.TGC_GRAPH.TabIndex = 0;
            this.TGC_GRAPH.Text = "chart1";
            // 
            // TEST_START_GROUP
            // 
            this.TEST_START_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TEST_START_GROUP.Controls.Add(this.BtnRfDataRead);
            this.TEST_START_GROUP.Controls.Add(this.BtnTestDone);
            this.TEST_START_GROUP.Controls.Add(this.BtnSystemTestStart);
            this.TEST_START_GROUP.Controls.Add(this.RBtnNCon);
            this.TEST_START_GROUP.Controls.Add(this.RBtnCon);
            this.TEST_START_GROUP.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TEST_START_GROUP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TEST_START_GROUP.Location = new System.Drawing.Point(698, 468);
            this.TEST_START_GROUP.Name = "TEST_START_GROUP";
            this.TEST_START_GROUP.Size = new System.Drawing.Size(417, 119);
            this.TEST_START_GROUP.TabIndex = 1;
            this.TEST_START_GROUP.TabStop = false;
            this.TEST_START_GROUP.Text = "TEST START";
            // 
            // BtnRfDataRead
            // 
            this.BtnRfDataRead.ForeColor = System.Drawing.Color.Black;
            this.BtnRfDataRead.Location = new System.Drawing.Point(6, 90);
            this.BtnRfDataRead.Name = "BtnRfDataRead";
            this.BtnRfDataRead.Size = new System.Drawing.Size(405, 26);
            this.BtnRfDataRead.TabIndex = 4;
            this.BtnRfDataRead.Text = "RFDATA READ";
            this.BtnRfDataRead.UseVisualStyleBackColor = true;
            this.BtnRfDataRead.Click += new System.EventHandler(this.BtnRfDataReadClick);
            // 
            // BtnTestDone
            // 
            this.BtnTestDone.ForeColor = System.Drawing.Color.Black;
            this.BtnTestDone.Location = new System.Drawing.Point(6, 34);
            this.BtnTestDone.Name = "BtnTestDone";
            this.BtnTestDone.Size = new System.Drawing.Size(405, 26);
            this.BtnTestDone.TabIndex = 3;
            this.BtnTestDone.Text = "TEST DONE";
            this.BtnTestDone.UseVisualStyleBackColor = true;
            this.BtnTestDone.Click += new System.EventHandler(this.BtnTestDoneClick);
            // 
            // BtnSystemTestStart
            // 
            this.BtnSystemTestStart.ForeColor = System.Drawing.Color.Black;
            this.BtnSystemTestStart.Location = new System.Drawing.Point(6, 62);
            this.BtnSystemTestStart.Name = "BtnSystemTestStart";
            this.BtnSystemTestStart.Size = new System.Drawing.Size(405, 26);
            this.BtnSystemTestStart.TabIndex = 2;
            this.BtnSystemTestStart.Text = "START TEST";
            this.BtnSystemTestStart.UseVisualStyleBackColor = true;
            this.BtnSystemTestStart.Click += new System.EventHandler(this.BtnSystemTestStart_Click);
            // 
            // RBtnNCon
            // 
            this.RBtnNCon.AutoSize = true;
            this.RBtnNCon.Checked = true;
            this.RBtnNCon.ForeColor = System.Drawing.Color.Black;
            this.RBtnNCon.Location = new System.Drawing.Point(168, 12);
            this.RBtnNCon.Name = "RBtnNCon";
            this.RBtnNCon.Size = new System.Drawing.Size(235, 19);
            this.RBtnNCon.TabIndex = 1;
            this.RBtnNCon.TabStop = true;
            this.RBtnNCon.Text = "Not Continuous OFN, PRF";
            this.RBtnNCon.UseVisualStyleBackColor = true;
            // 
            // RBtnCon
            // 
            this.RBtnCon.AutoSize = true;
            this.RBtnCon.ForeColor = System.Drawing.Color.Black;
            this.RBtnCon.Location = new System.Drawing.Point(6, 13);
            this.RBtnCon.Name = "RBtnCon";
            this.RBtnCon.Size = new System.Drawing.Size(199, 19);
            this.RBtnCon.TabIndex = 0;
            this.RBtnCon.Text = "Continuous OFN, PRF";
            this.RBtnCon.UseVisualStyleBackColor = true;
            // 
            // RTC_REGIST_GROUP
            // 
            this.RTC_REGIST_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RTC_REGIST_GROUP.Controls.Add(this.C_R_RTC_TGC_INCR);
            this.RTC_REGIST_GROUP.Controls.Add(this.label32);
            this.RTC_REGIST_GROUP.Controls.Add(this.C_R_RTC_TGC_MAX);
            this.RTC_REGIST_GROUP.Controls.Add(this.label31);
            this.RTC_REGIST_GROUP.Controls.Add(this.C_R_RTC_TGC_MIN_COUNT);
            this.RTC_REGIST_GROUP.Controls.Add(this.label30);
            this.RTC_REGIST_GROUP.Controls.Add(this.C_R_RTC_TGC_MIN);
            this.RTC_REGIST_GROUP.Controls.Add(this.label29);
            this.RTC_REGIST_GROUP.Controls.Add(this.C_R_RTC_TGC_START);
            this.RTC_REGIST_GROUP.Controls.Add(this.label28);
            this.RTC_REGIST_GROUP.Controls.Add(this.C_R_RTC_TGC_CLOCK_MASK);
            this.RTC_REGIST_GROUP.Controls.Add(this.label27);
            this.RTC_REGIST_GROUP.Controls.Add(this.C_R_RTC_TGC_CTRL3);
            this.RTC_REGIST_GROUP.Controls.Add(this.label26);
            this.RTC_REGIST_GROUP.Controls.Add(this.C_R_RTC_TGC_SLEEP);
            this.RTC_REGIST_GROUP.Controls.Add(this.label25);
            this.RTC_REGIST_GROUP.Controls.Add(this.C_R_RTC_TGC_MODE);
            this.RTC_REGIST_GROUP.Controls.Add(this.label24);
            this.RTC_REGIST_GROUP.Controls.Add(this.C_R_RTC_OFN_DUMMY);
            this.RTC_REGIST_GROUP.Controls.Add(this.label5);
            this.RTC_REGIST_GROUP.Controls.Add(this.C_R_RTC_OFN_COUNT);
            this.RTC_REGIST_GROUP.Controls.Add(this.label4);
            this.RTC_REGIST_GROUP.Controls.Add(this.C_R_RTC_PRF_COUNT);
            this.RTC_REGIST_GROUP.Controls.Add(this.label3);
            this.RTC_REGIST_GROUP.Controls.Add(this.C_R_RTC_PRF_L_LENGTH);
            this.RTC_REGIST_GROUP.Controls.Add(this.label2);
            this.RTC_REGIST_GROUP.Controls.Add(this.C_R_RTC_PRF_H_LENGTH);
            this.RTC_REGIST_GROUP.Controls.Add(this.label1);
            this.RTC_REGIST_GROUP.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RTC_REGIST_GROUP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RTC_REGIST_GROUP.Location = new System.Drawing.Point(1121, 6);
            this.RTC_REGIST_GROUP.Name = "RTC_REGIST_GROUP";
            this.RTC_REGIST_GROUP.Size = new System.Drawing.Size(216, 456);
            this.RTC_REGIST_GROUP.TabIndex = 0;
            this.RTC_REGIST_GROUP.TabStop = false;
            this.RTC_REGIST_GROUP.Text = "RTC Register";
            // 
            // C_R_RTC_TGC_INCR
            // 
            this.C_R_RTC_TGC_INCR.Location = new System.Drawing.Point(134, 369);
            this.C_R_RTC_TGC_INCR.Name = "C_R_RTC_TGC_INCR";
            this.C_R_RTC_TGC_INCR.Size = new System.Drawing.Size(60, 25);
            this.C_R_RTC_TGC_INCR.TabIndex = 27;
            this.C_R_RTC_TGC_INCR.Text = "0";
            this.C_R_RTC_TGC_INCR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(14, 378);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(91, 14);
            this.label32.TabIndex = 26;
            this.label32.Text = "C_R_TGC_INCR";
            // 
            // C_R_RTC_TGC_MAX
            // 
            this.C_R_RTC_TGC_MAX.Location = new System.Drawing.Point(134, 342);
            this.C_R_RTC_TGC_MAX.Name = "C_R_RTC_TGC_MAX";
            this.C_R_RTC_TGC_MAX.Size = new System.Drawing.Size(60, 25);
            this.C_R_RTC_TGC_MAX.TabIndex = 25;
            this.C_R_RTC_TGC_MAX.Text = "0";
            this.C_R_RTC_TGC_MAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(14, 351);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(84, 14);
            this.label31.TabIndex = 24;
            this.label31.Text = "C_R_TGC_MAX";
            // 
            // C_R_RTC_TGC_MIN_COUNT
            // 
            this.C_R_RTC_TGC_MIN_COUNT.Location = new System.Drawing.Point(134, 315);
            this.C_R_RTC_TGC_MIN_COUNT.Name = "C_R_RTC_TGC_MIN_COUNT";
            this.C_R_RTC_TGC_MIN_COUNT.Size = new System.Drawing.Size(60, 25);
            this.C_R_RTC_TGC_MIN_COUNT.TabIndex = 23;
            this.C_R_RTC_TGC_MIN_COUNT.Text = "0";
            this.C_R_RTC_TGC_MIN_COUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(14, 324);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(126, 14);
            this.label30.TabIndex = 22;
            this.label30.Text = "C_R_TGC_MIN_COUNT";
            // 
            // C_R_RTC_TGC_MIN
            // 
            this.C_R_RTC_TGC_MIN.Location = new System.Drawing.Point(134, 288);
            this.C_R_RTC_TGC_MIN.Name = "C_R_RTC_TGC_MIN";
            this.C_R_RTC_TGC_MIN.Size = new System.Drawing.Size(60, 25);
            this.C_R_RTC_TGC_MIN.TabIndex = 21;
            this.C_R_RTC_TGC_MIN.Text = "0";
            this.C_R_RTC_TGC_MIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(14, 297);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(84, 14);
            this.label29.TabIndex = 20;
            this.label29.Text = "C_R_TGC_MIN";
            // 
            // C_R_RTC_TGC_START
            // 
            this.C_R_RTC_TGC_START.Location = new System.Drawing.Point(134, 261);
            this.C_R_RTC_TGC_START.Name = "C_R_RTC_TGC_START";
            this.C_R_RTC_TGC_START.Size = new System.Drawing.Size(60, 25);
            this.C_R_RTC_TGC_START.TabIndex = 19;
            this.C_R_RTC_TGC_START.Text = "256";
            this.C_R_RTC_TGC_START.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(14, 270);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(98, 14);
            this.label28.TabIndex = 18;
            this.label28.Text = "C_R_TGC_START";
            // 
            // C_R_RTC_TGC_CLOCK_MASK
            // 
            this.C_R_RTC_TGC_CLOCK_MASK.Location = new System.Drawing.Point(134, 234);
            this.C_R_RTC_TGC_CLOCK_MASK.Name = "C_R_RTC_TGC_CLOCK_MASK";
            this.C_R_RTC_TGC_CLOCK_MASK.Size = new System.Drawing.Size(60, 25);
            this.C_R_RTC_TGC_CLOCK_MASK.TabIndex = 17;
            this.C_R_RTC_TGC_CLOCK_MASK.Text = "1";
            this.C_R_RTC_TGC_CLOCK_MASK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(14, 243);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(133, 14);
            this.label27.TabIndex = 16;
            this.label27.Text = "C_R_TGC_CLOCK_MASK";
            // 
            // C_R_RTC_TGC_CTRL3
            // 
            this.C_R_RTC_TGC_CTRL3.Location = new System.Drawing.Point(134, 207);
            this.C_R_RTC_TGC_CTRL3.Name = "C_R_RTC_TGC_CTRL3";
            this.C_R_RTC_TGC_CTRL3.Size = new System.Drawing.Size(60, 25);
            this.C_R_RTC_TGC_CTRL3.TabIndex = 15;
            this.C_R_RTC_TGC_CTRL3.Text = "0";
            this.C_R_RTC_TGC_CTRL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(14, 216);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(98, 14);
            this.label26.TabIndex = 14;
            this.label26.Text = "C_R_TGC_CTRL3";
            // 
            // C_R_RTC_TGC_SLEEP
            // 
            this.C_R_RTC_TGC_SLEEP.Location = new System.Drawing.Point(134, 180);
            this.C_R_RTC_TGC_SLEEP.Name = "C_R_RTC_TGC_SLEEP";
            this.C_R_RTC_TGC_SLEEP.Size = new System.Drawing.Size(60, 25);
            this.C_R_RTC_TGC_SLEEP.TabIndex = 13;
            this.C_R_RTC_TGC_SLEEP.Text = "0";
            this.C_R_RTC_TGC_SLEEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(14, 189);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(98, 14);
            this.label25.TabIndex = 12;
            this.label25.Text = "C_R_TGC_SLEEP";
            // 
            // C_R_RTC_TGC_MODE
            // 
            this.C_R_RTC_TGC_MODE.Location = new System.Drawing.Point(134, 153);
            this.C_R_RTC_TGC_MODE.Name = "C_R_RTC_TGC_MODE";
            this.C_R_RTC_TGC_MODE.Size = new System.Drawing.Size(60, 25);
            this.C_R_RTC_TGC_MODE.TabIndex = 11;
            this.C_R_RTC_TGC_MODE.Text = "1";
            this.C_R_RTC_TGC_MODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(14, 162);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 14);
            this.label24.TabIndex = 10;
            this.label24.Text = "C_R_TGC_MODE";
            // 
            // C_R_RTC_OFN_DUMMY
            // 
            this.C_R_RTC_OFN_DUMMY.Location = new System.Drawing.Point(134, 126);
            this.C_R_RTC_OFN_DUMMY.Name = "C_R_RTC_OFN_DUMMY";
            this.C_R_RTC_OFN_DUMMY.Size = new System.Drawing.Size(60, 25);
            this.C_R_RTC_OFN_DUMMY.TabIndex = 9;
            this.C_R_RTC_OFN_DUMMY.Text = "3935";
            this.C_R_RTC_OFN_DUMMY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "C_R_OFN_DUMMY";
            // 
            // C_R_RTC_OFN_COUNT
            // 
            this.C_R_RTC_OFN_COUNT.Location = new System.Drawing.Point(134, 99);
            this.C_R_RTC_OFN_COUNT.Name = "C_R_RTC_OFN_COUNT";
            this.C_R_RTC_OFN_COUNT.Size = new System.Drawing.Size(60, 25);
            this.C_R_RTC_OFN_COUNT.TabIndex = 7;
            this.C_R_RTC_OFN_COUNT.Text = "1";
            this.C_R_RTC_OFN_COUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "C_R_OFN_COUNT";
            // 
            // C_R_RTC_PRF_COUNT
            // 
            this.C_R_RTC_PRF_COUNT.Location = new System.Drawing.Point(134, 72);
            this.C_R_RTC_PRF_COUNT.Name = "C_R_RTC_PRF_COUNT";
            this.C_R_RTC_PRF_COUNT.Size = new System.Drawing.Size(60, 25);
            this.C_R_RTC_PRF_COUNT.TabIndex = 5;
            this.C_R_RTC_PRF_COUNT.Text = "5";
            this.C_R_RTC_PRF_COUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "C_R_PRF_COUNT";
            // 
            // C_R_RTC_PRF_L_LENGTH
            // 
            this.C_R_RTC_PRF_L_LENGTH.Location = new System.Drawing.Point(134, 45);
            this.C_R_RTC_PRF_L_LENGTH.Name = "C_R_RTC_PRF_L_LENGTH";
            this.C_R_RTC_PRF_L_LENGTH.Size = new System.Drawing.Size(60, 25);
            this.C_R_RTC_PRF_L_LENGTH.TabIndex = 3;
            this.C_R_RTC_PRF_L_LENGTH.Text = "256";
            this.C_R_RTC_PRF_L_LENGTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "C_R_PRF_LOW_LENGTH";
            // 
            // C_R_RTC_PRF_H_LENGTH
            // 
            this.C_R_RTC_PRF_H_LENGTH.Location = new System.Drawing.Point(134, 18);
            this.C_R_RTC_PRF_H_LENGTH.Name = "C_R_RTC_PRF_H_LENGTH";
            this.C_R_RTC_PRF_H_LENGTH.Size = new System.Drawing.Size(60, 25);
            this.C_R_RTC_PRF_H_LENGTH.TabIndex = 1;
            this.C_R_RTC_PRF_H_LENGTH.Text = "4096";
            this.C_R_RTC_PRF_H_LENGTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림체", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "C_R_PRF_HIGH_LENGTH";
            // 
            // ANA_JIG_TEST_TAB
            // 
            this.ANA_JIG_TEST_TAB.Controls.Add(this.SYS_TEST_TAB);
            this.ANA_JIG_TEST_TAB.Controls.Add(this.POWER_SUPPLY_TAB);
            this.ANA_JIG_TEST_TAB.Controls.Add(this.HOST_TEST_TAB);
            this.ANA_JIG_TEST_TAB.Controls.Add(this.ACQ_XDMA_TAB);
            this.ANA_JIG_TEST_TAB.Controls.Add(this.COMPORT_TAB);
            this.ANA_JIG_TEST_TAB.Controls.Add(this.US_SCAN_TAB);
            this.ANA_JIG_TEST_TAB.Controls.Add(this.TGC_FIG_TAB);
            this.ANA_JIG_TEST_TAB.Controls.Add(this.AFE_MAP_TAB);
            this.ANA_JIG_TEST_TAB.Controls.Add(this.FILE_TAB);
            this.ANA_JIG_TEST_TAB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ANA_JIG_TEST_TAB.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ANA_JIG_TEST_TAB.ItemSize = new System.Drawing.Size(100, 40);
            this.ANA_JIG_TEST_TAB.Location = new System.Drawing.Point(1, 1);
            this.ANA_JIG_TEST_TAB.Name = "ANA_JIG_TEST_TAB";
            this.ANA_JIG_TEST_TAB.SelectedIndex = 0;
            this.ANA_JIG_TEST_TAB.Size = new System.Drawing.Size(1354, 639);
            this.ANA_JIG_TEST_TAB.TabIndex = 0;
            // 
            // POWER_SUPPLY_TAB
            // 
            this.POWER_SUPPLY_TAB.Controls.Add(this.RPC_CTR_GROUP);
            this.POWER_SUPPLY_TAB.Controls.Add(this.RPC_TEST_INTERFACE);
            this.POWER_SUPPLY_TAB.Controls.Add(this.RPC_HELP_GROUP);
            this.POWER_SUPPLY_TAB.Controls.Add(this.RPC_MONITOR_GROUP);
            this.POWER_SUPPLY_TAB.Controls.Add(this.RPC_SPI_GROUP);
            this.POWER_SUPPLY_TAB.Location = new System.Drawing.Point(4, 44);
            this.POWER_SUPPLY_TAB.Name = "POWER_SUPPLY_TAB";
            this.POWER_SUPPLY_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.POWER_SUPPLY_TAB.Size = new System.Drawing.Size(1346, 591);
            this.POWER_SUPPLY_TAB.TabIndex = 10;
            this.POWER_SUPPLY_TAB.Text = "HV Power Supply";
            this.POWER_SUPPLY_TAB.UseVisualStyleBackColor = true;
            // 
            // RPC_CTR_GROUP
            // 
            this.RPC_CTR_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RPC_CTR_GROUP.Controls.Add(this.btnGDPOff);
            this.RPC_CTR_GROUP.Controls.Add(this.btnGDPOn);
            this.RPC_CTR_GROUP.Controls.Add(this.label153);
            this.RPC_CTR_GROUP.Controls.Add(this.btnVTXOff);
            this.RPC_CTR_GROUP.Controls.Add(this.btnVTXOn);
            this.RPC_CTR_GROUP.Controls.Add(this.label136);
            this.RPC_CTR_GROUP.Controls.Add(this.RPC_VTX_TRACK);
            this.RPC_CTR_GROUP.Controls.Add(this.label152);
            this.RPC_CTR_GROUP.Controls.Add(this.RPC_VTX_TEXT);
            this.RPC_CTR_GROUP.Controls.Add(this.label151);
            this.RPC_CTR_GROUP.ForeColor = System.Drawing.Color.Black;
            this.RPC_CTR_GROUP.Location = new System.Drawing.Point(338, 281);
            this.RPC_CTR_GROUP.Name = "RPC_CTR_GROUP";
            this.RPC_CTR_GROUP.Size = new System.Drawing.Size(397, 301);
            this.RPC_CTR_GROUP.TabIndex = 10;
            this.RPC_CTR_GROUP.TabStop = false;
            this.RPC_CTR_GROUP.Text = "Voltage Control";
            // 
            // btnGDPOff
            // 
            this.btnGDPOff.Location = new System.Drawing.Point(211, 73);
            this.btnGDPOff.Name = "btnGDPOff";
            this.btnGDPOff.Size = new System.Drawing.Size(51, 22);
            this.btnGDPOff.TabIndex = 55;
            this.btnGDPOff.Text = "OFF";
            this.btnGDPOff.UseVisualStyleBackColor = true;
            this.btnGDPOff.Click += new System.EventHandler(this.btnGDPOff_Click);
            // 
            // btnGDPOn
            // 
            this.btnGDPOn.Location = new System.Drawing.Point(154, 73);
            this.btnGDPOn.Name = "btnGDPOn";
            this.btnGDPOn.Size = new System.Drawing.Size(51, 22);
            this.btnGDPOn.TabIndex = 54;
            this.btnGDPOn.Text = "ON";
            this.btnGDPOn.UseVisualStyleBackColor = true;
            this.btnGDPOn.Click += new System.EventHandler(this.btnGDPOn_Click);
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.ForeColor = System.Drawing.Color.Black;
            this.label153.Location = new System.Drawing.Point(165, 58);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(96, 15);
            this.label153.TabIndex = 53;
            this.label153.Text = "GDP Switch";
            // 
            // btnVTXOff
            // 
            this.btnVTXOff.Location = new System.Drawing.Point(72, 73);
            this.btnVTXOff.Name = "btnVTXOff";
            this.btnVTXOff.Size = new System.Drawing.Size(51, 22);
            this.btnVTXOff.TabIndex = 12;
            this.btnVTXOff.Text = "OFF";
            this.btnVTXOff.UseVisualStyleBackColor = true;
            this.btnVTXOff.Click += new System.EventHandler(this.btnVTXOff_Click);
            // 
            // btnVTXOn
            // 
            this.btnVTXOn.Location = new System.Drawing.Point(15, 73);
            this.btnVTXOn.Name = "btnVTXOn";
            this.btnVTXOn.Size = new System.Drawing.Size(51, 22);
            this.btnVTXOn.TabIndex = 11;
            this.btnVTXOn.Text = "ON";
            this.btnVTXOn.UseVisualStyleBackColor = true;
            this.btnVTXOn.Click += new System.EventHandler(this.btnVTXOn_Click);
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.ForeColor = System.Drawing.Color.Black;
            this.label136.Location = new System.Drawing.Point(26, 58);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(90, 15);
            this.label136.TabIndex = 1;
            this.label136.Text = "VTX Switch";
            // 
            // RPC_VTX_TRACK
            // 
            this.RPC_VTX_TRACK.AutoSize = false;
            this.RPC_VTX_TRACK.BackColor = System.Drawing.Color.Khaki;
            this.RPC_VTX_TRACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RPC_VTX_TRACK.LargeChange = 100;
            this.RPC_VTX_TRACK.Location = new System.Drawing.Point(16, 139);
            this.RPC_VTX_TRACK.Maximum = 1000;
            this.RPC_VTX_TRACK.Name = "RPC_VTX_TRACK";
            this.RPC_VTX_TRACK.Size = new System.Drawing.Size(227, 36);
            this.RPC_VTX_TRACK.SmallChange = 10;
            this.RPC_VTX_TRACK.TabIndex = 46;
            this.RPC_VTX_TRACK.TickFrequency = 50;
            this.RPC_VTX_TRACK.Scroll += new System.EventHandler(this.RPC_VTX_TRACK_Scroll);
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.ForeColor = System.Drawing.Color.Black;
            this.label152.Location = new System.Drawing.Point(14, 126);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(249, 15);
            this.label152.TabIndex = 45;
            this.label152.Text = "RPC VTX Control(10Volt/100ms)";
            // 
            // RPC_VTX_TEXT
            // 
            this.RPC_VTX_TEXT.Location = new System.Drawing.Point(246, 141);
            this.RPC_VTX_TEXT.Multiline = true;
            this.RPC_VTX_TEXT.Name = "RPC_VTX_TEXT";
            this.RPC_VTX_TEXT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RPC_VTX_TEXT.Size = new System.Drawing.Size(52, 18);
            this.RPC_VTX_TEXT.TabIndex = 47;
            this.RPC_VTX_TEXT.Text = "0";
            this.RPC_VTX_TEXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.ForeColor = System.Drawing.Color.Black;
            this.label151.Location = new System.Drawing.Point(265, 163);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(16, 15);
            this.label151.TabIndex = 48;
            this.label151.Text = "V";
            // 
            // RPC_TEST_INTERFACE
            // 
            this.RPC_TEST_INTERFACE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RPC_TEST_INTERFACE.Controls.Add(this.RPC_BTN_PROGRESS);
            this.RPC_TEST_INTERFACE.Controls.Add(this.label132);
            this.RPC_TEST_INTERFACE.Controls.Add(this.RPC_WR_DELAY_TXT);
            this.RPC_TEST_INTERFACE.Controls.Add(this.RPC_WR_DELAY_TRACK);
            this.RPC_TEST_INTERFACE.Controls.Add(this.label133);
            this.RPC_TEST_INTERFACE.Controls.Add(this.label137);
            this.RPC_TEST_INTERFACE.Controls.Add(this.RPC_BTN_DELAY_TXT);
            this.RPC_TEST_INTERFACE.Controls.Add(this.RPC_BTN_DELAY_TRACK);
            this.RPC_TEST_INTERFACE.Controls.Add(this.label139);
            this.RPC_TEST_INTERFACE.Controls.Add(this.SPI_CONTINUOUS_CHECK);
            this.RPC_TEST_INTERFACE.ForeColor = System.Drawing.Color.Black;
            this.RPC_TEST_INTERFACE.Location = new System.Drawing.Point(7, 281);
            this.RPC_TEST_INTERFACE.Name = "RPC_TEST_INTERFACE";
            this.RPC_TEST_INTERFACE.Size = new System.Drawing.Size(325, 302);
            this.RPC_TEST_INTERFACE.TabIndex = 11;
            this.RPC_TEST_INTERFACE.TabStop = false;
            this.RPC_TEST_INTERFACE.Text = "SPI TEST INTERFACE";
            // 
            // RPC_BTN_PROGRESS
            // 
            this.RPC_BTN_PROGRESS.AutoSize = true;
            this.RPC_BTN_PROGRESS.Location = new System.Drawing.Point(131, 25);
            this.RPC_BTN_PROGRESS.Name = "RPC_BTN_PROGRESS";
            this.RPC_BTN_PROGRESS.Size = new System.Drawing.Size(0, 15);
            this.RPC_BTN_PROGRESS.TabIndex = 44;
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.ForeColor = System.Drawing.Color.Black;
            this.label132.Location = new System.Drawing.Point(256, 163);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(28, 15);
            this.label132.TabIndex = 43;
            this.label132.Text = "ms";
            // 
            // RPC_WR_DELAY_TXT
            // 
            this.RPC_WR_DELAY_TXT.Location = new System.Drawing.Point(241, 139);
            this.RPC_WR_DELAY_TXT.Multiline = true;
            this.RPC_WR_DELAY_TXT.Name = "RPC_WR_DELAY_TXT";
            this.RPC_WR_DELAY_TXT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RPC_WR_DELAY_TXT.Size = new System.Drawing.Size(52, 18);
            this.RPC_WR_DELAY_TXT.TabIndex = 42;
            this.RPC_WR_DELAY_TXT.Text = "10";
            this.RPC_WR_DELAY_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RPC_WR_DELAY_TRACK
            // 
            this.RPC_WR_DELAY_TRACK.AutoSize = false;
            this.RPC_WR_DELAY_TRACK.BackColor = System.Drawing.Color.Khaki;
            this.RPC_WR_DELAY_TRACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RPC_WR_DELAY_TRACK.LargeChange = 100;
            this.RPC_WR_DELAY_TRACK.Location = new System.Drawing.Point(11, 139);
            this.RPC_WR_DELAY_TRACK.Maximum = 1000;
            this.RPC_WR_DELAY_TRACK.Minimum = 1;
            this.RPC_WR_DELAY_TRACK.Name = "RPC_WR_DELAY_TRACK";
            this.RPC_WR_DELAY_TRACK.Size = new System.Drawing.Size(227, 36);
            this.RPC_WR_DELAY_TRACK.SmallChange = 50;
            this.RPC_WR_DELAY_TRACK.TabIndex = 41;
            this.RPC_WR_DELAY_TRACK.TickFrequency = 50;
            this.RPC_WR_DELAY_TRACK.Value = 10;
            this.RPC_WR_DELAY_TRACK.Scroll += new System.EventHandler(this.RPC_WR_DELAY_TRACK_Scroll);
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.ForeColor = System.Drawing.Color.Black;
            this.label133.Location = new System.Drawing.Point(9, 124);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(177, 15);
            this.label133.TabIndex = 40;
            this.label133.Text = "RPC Read/Write Delay";
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.ForeColor = System.Drawing.Color.Black;
            this.label137.Location = new System.Drawing.Point(256, 97);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(28, 15);
            this.label137.TabIndex = 39;
            this.label137.Text = "ms";
            // 
            // RPC_BTN_DELAY_TXT
            // 
            this.RPC_BTN_DELAY_TXT.Location = new System.Drawing.Point(241, 73);
            this.RPC_BTN_DELAY_TXT.Multiline = true;
            this.RPC_BTN_DELAY_TXT.Name = "RPC_BTN_DELAY_TXT";
            this.RPC_BTN_DELAY_TXT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RPC_BTN_DELAY_TXT.Size = new System.Drawing.Size(52, 18);
            this.RPC_BTN_DELAY_TXT.TabIndex = 38;
            this.RPC_BTN_DELAY_TXT.Text = "10";
            this.RPC_BTN_DELAY_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RPC_BTN_DELAY_TRACK
            // 
            this.RPC_BTN_DELAY_TRACK.AutoSize = false;
            this.RPC_BTN_DELAY_TRACK.BackColor = System.Drawing.Color.Khaki;
            this.RPC_BTN_DELAY_TRACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RPC_BTN_DELAY_TRACK.LargeChange = 100;
            this.RPC_BTN_DELAY_TRACK.Location = new System.Drawing.Point(11, 71);
            this.RPC_BTN_DELAY_TRACK.Maximum = 1000;
            this.RPC_BTN_DELAY_TRACK.Minimum = 1;
            this.RPC_BTN_DELAY_TRACK.Name = "RPC_BTN_DELAY_TRACK";
            this.RPC_BTN_DELAY_TRACK.Size = new System.Drawing.Size(227, 36);
            this.RPC_BTN_DELAY_TRACK.SmallChange = 50;
            this.RPC_BTN_DELAY_TRACK.TabIndex = 37;
            this.RPC_BTN_DELAY_TRACK.TickFrequency = 50;
            this.RPC_BTN_DELAY_TRACK.Value = 10;
            this.RPC_BTN_DELAY_TRACK.Scroll += new System.EventHandler(this.RPC_BTN_DELAY_TRACK_Scroll);
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.ForeColor = System.Drawing.Color.Black;
            this.label139.Location = new System.Drawing.Point(9, 58);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(183, 15);
            this.label139.TabIndex = 33;
            this.label139.Text = "RPC Button Delay Time";
            // 
            // SPI_CONTINUOUS_CHECK
            // 
            this.SPI_CONTINUOUS_CHECK.AutoSize = true;
            this.SPI_CONTINUOUS_CHECK.Location = new System.Drawing.Point(11, 24);
            this.SPI_CONTINUOUS_CHECK.Name = "SPI_CONTINUOUS_CHECK";
            this.SPI_CONTINUOUS_CHECK.Size = new System.Drawing.Size(132, 19);
            this.SPI_CONTINUOUS_CHECK.TabIndex = 13;
            this.SPI_CONTINUOUS_CHECK.Text = "CONTINUOUS";
            this.SPI_CONTINUOUS_CHECK.UseVisualStyleBackColor = true;
            // 
            // RPC_HELP_GROUP
            // 
            this.RPC_HELP_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RPC_HELP_GROUP.Controls.Add(this.label118);
            this.RPC_HELP_GROUP.Controls.Add(this.label117);
            this.RPC_HELP_GROUP.Controls.Add(this.label116);
            this.RPC_HELP_GROUP.Controls.Add(this.label115);
            this.RPC_HELP_GROUP.Controls.Add(this.label114);
            this.RPC_HELP_GROUP.Controls.Add(this.label113);
            this.RPC_HELP_GROUP.Controls.Add(this.label112);
            this.RPC_HELP_GROUP.Controls.Add(this.label105);
            this.RPC_HELP_GROUP.Controls.Add(this.label111);
            this.RPC_HELP_GROUP.Controls.Add(this.label110);
            this.RPC_HELP_GROUP.Controls.Add(this.label109);
            this.RPC_HELP_GROUP.Controls.Add(this.label108);
            this.RPC_HELP_GROUP.Controls.Add(this.label107);
            this.RPC_HELP_GROUP.Controls.Add(this.label106);
            this.RPC_HELP_GROUP.Controls.Add(this.label103);
            this.RPC_HELP_GROUP.ForeColor = System.Drawing.Color.Black;
            this.RPC_HELP_GROUP.Location = new System.Drawing.Point(741, 7);
            this.RPC_HELP_GROUP.Name = "RPC_HELP_GROUP";
            this.RPC_HELP_GROUP.Size = new System.Drawing.Size(599, 575);
            this.RPC_HELP_GROUP.TabIndex = 10;
            this.RPC_HELP_GROUP.TabStop = false;
            this.RPC_HELP_GROUP.Text = "Help";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label118.ForeColor = System.Drawing.Color.Black;
            this.label118.Location = new System.Drawing.Point(55, 437);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(345, 15);
            this.label118.TabIndex = 16;
            this.label118.Text = "Data: 0x0000(Power check), 0x0001(Clock check)";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label117.ForeColor = System.Drawing.Color.Black;
            this.label117.Location = new System.Drawing.Point(55, 371);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(536, 15);
            this.label117.TabIndex = 15;
            this.label117.Text = "Data: 0~ 100.0V to 0x0000([dec]0) ~ 0x03E8([dec]1000) (Not to over 0x3FF)";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label116.ForeColor = System.Drawing.Color.Black;
            this.label116.Location = new System.Drawing.Point(55, 306);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(606, 15);
            this.label116.TabIndex = 14;
            this.label116.Text = "Data: 0x0008(GDNREG), 0x0009(VTXPREG), 0x000A(VTXNREG), 0x000F(VTX FET Temp)";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label115.ForeColor = System.Drawing.Color.Black;
            this.label115.Location = new System.Drawing.Point(55, 270);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(581, 15);
            this.label115.TabIndex = 13;
            this.label115.Text = "Data: 0x0004(Local 3.3V), 0x0005(Local 5.0V), 0x0006(GDNPRE), 0x0007(GDPREG)";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label114.ForeColor = System.Drawing.Color.Black;
            this.label114.Location = new System.Drawing.Point(55, 237);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(549, 15);
            this.label114.TabIndex = 12;
            this.label114.Text = "Data: 0x0000(RUS cur), 0x0001(RUS volt), 0x0002(RPC cur), 0x0003(RPC volt)";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label113.ForeColor = System.Drawing.Color.Black;
            this.label113.Location = new System.Drawing.Point(55, 168);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(657, 15);
            this.label113.TabIndex = 11;
            this.label113.Text = "Data: 0x0001(RUS), 0x0002(RPC), 0x0003(RUS,RPC),0x0004(GDP), 0x0008(VTX), 0x0010(" +
    "BL)";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label112.ForeColor = System.Drawing.Color.Black;
            this.label112.Location = new System.Drawing.Point(55, 99);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(607, 15);
            this.label112.TabIndex = 10;
            this.label112.Text = "Data: 0x0000(standby), 0x0001(remote), 0x0002(local), 0x0003(demo1), 0x0004(demo2" +
    ")";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label105.ForeColor = System.Drawing.Color.Black;
            this.label105.Location = new System.Drawing.Point(31, 467);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(147, 15);
            this.label105.TabIndex = 9;
            this.label105.Text = "SOFT_RST = 0x7F";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label111.ForeColor = System.Drawing.Color.Black;
            this.label111.Location = new System.Drawing.Point(31, 408);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(205, 15);
            this.label111.TabIndex = 8;
            this.label111.Text = "BUILT_SELF_TEST = 0x06";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label110.ForeColor = System.Drawing.Color.Black;
            this.label110.Location = new System.Drawing.Point(31, 343);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(213, 15);
            this.label110.TabIndex = 7;
            this.label110.Text = "SET_VTX_VOLTAGE = 0x05";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label109.ForeColor = System.Drawing.Color.Black;
            this.label109.Location = new System.Drawing.Point(31, 203);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(236, 15);
            this.label109.TabIndex = 6;
            this.label109.Text = "GET_MONITOR_VALUE = 0x04";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label108.ForeColor = System.Drawing.Color.Black;
            this.label108.Location = new System.Drawing.Point(31, 143);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(206, 15);
            this.label108.TabIndex = 5;
            this.label108.Text = "RST_SWITCH_OFF = 0x03";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label107.ForeColor = System.Drawing.Color.Black;
            this.label107.Location = new System.Drawing.Point(31, 131);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(197, 15);
            this.label107.TabIndex = 4;
            this.label107.Text = "SET_SWITCH_ON = 0x02";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label106.ForeColor = System.Drawing.Color.Black;
            this.label106.Location = new System.Drawing.Point(31, 72);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(233, 15);
            this.label106.TabIndex = 3;
            this.label106.Text = "CURRENT_MODE_SET = 0x01";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label103.ForeColor = System.Drawing.Color.Black;
            this.label103.Location = new System.Drawing.Point(6, 28);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(127, 15);
            this.label103.TabIndex = 1;
            this.label103.Text = "COMMAND LIST";
            // 
            // RPC_MONITOR_GROUP
            // 
            this.RPC_MONITOR_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RPC_MONITOR_GROUP.Controls.Add(this.label104);
            this.RPC_MONITOR_GROUP.ForeColor = System.Drawing.Color.Black;
            this.RPC_MONITOR_GROUP.Location = new System.Drawing.Point(338, 7);
            this.RPC_MONITOR_GROUP.Name = "RPC_MONITOR_GROUP";
            this.RPC_MONITOR_GROUP.Size = new System.Drawing.Size(397, 268);
            this.RPC_MONITOR_GROUP.TabIndex = 9;
            this.RPC_MONITOR_GROUP.TabStop = false;
            this.RPC_MONITOR_GROUP.Text = "Monitoring";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.ForeColor = System.Drawing.Color.Black;
            this.label104.Location = new System.Drawing.Point(6, 28);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(217, 15);
            this.label104.TabIndex = 1;
            this.label104.Text = "파워 모니터링 공간 개발계획";
            // 
            // RPC_SPI_GROUP
            // 
            this.RPC_SPI_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RPC_SPI_GROUP.Controls.Add(this.label119);
            this.RPC_SPI_GROUP.Controls.Add(this.SPI_RDATA_TXT);
            this.RPC_SPI_GROUP.Controls.Add(this.BtnRpcRead);
            this.RPC_SPI_GROUP.Controls.Add(this.BtnRpcWrite);
            this.RPC_SPI_GROUP.Controls.Add(this.SPI_COMMAND_TXT);
            this.RPC_SPI_GROUP.Controls.Add(this.label99);
            this.RPC_SPI_GROUP.Controls.Add(this.SPI_HDATA_TXT);
            this.RPC_SPI_GROUP.Controls.Add(this.label100);
            this.RPC_SPI_GROUP.Controls.Add(this.SPI_LDATA_TXT);
            this.RPC_SPI_GROUP.Controls.Add(this.label101);
            this.RPC_SPI_GROUP.ForeColor = System.Drawing.Color.Black;
            this.RPC_SPI_GROUP.Location = new System.Drawing.Point(7, 7);
            this.RPC_SPI_GROUP.Name = "RPC_SPI_GROUP";
            this.RPC_SPI_GROUP.Size = new System.Drawing.Size(325, 268);
            this.RPC_SPI_GROUP.TabIndex = 1;
            this.RPC_SPI_GROUP.TabStop = false;
            this.RPC_SPI_GROUP.Text = "RPC SPI Test";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.ForeColor = System.Drawing.Color.Black;
            this.label119.Location = new System.Drawing.Point(6, 82);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(138, 15);
            this.label119.TabIndex = 10;
            this.label119.Text = "Write LData(Hex)";
            // 
            // SPI_RDATA_TXT
            // 
            this.SPI_RDATA_TXT.Location = new System.Drawing.Point(125, 120);
            this.SPI_RDATA_TXT.Name = "SPI_RDATA_TXT";
            this.SPI_RDATA_TXT.Size = new System.Drawing.Size(194, 25);
            this.SPI_RDATA_TXT.TabIndex = 9;
            this.SPI_RDATA_TXT.Text = "0x";
            this.SPI_RDATA_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnRpcRead
            // 
            this.BtnRpcRead.Location = new System.Drawing.Point(179, 231);
            this.BtnRpcRead.Name = "BtnRpcRead";
            this.BtnRpcRead.Size = new System.Drawing.Size(114, 22);
            this.BtnRpcRead.TabIndex = 8;
            this.BtnRpcRead.Text = "READ";
            this.BtnRpcRead.UseVisualStyleBackColor = true;
            this.BtnRpcRead.Click += new System.EventHandler(this.BtnRpcSpiRead_Click);
            // 
            // BtnRpcWrite
            // 
            this.BtnRpcWrite.Location = new System.Drawing.Point(19, 231);
            this.BtnRpcWrite.Name = "BtnRpcWrite";
            this.BtnRpcWrite.Size = new System.Drawing.Size(119, 22);
            this.BtnRpcWrite.TabIndex = 7;
            this.BtnRpcWrite.Text = "WRITE";
            this.BtnRpcWrite.UseVisualStyleBackColor = true;
            this.BtnRpcWrite.Click += new System.EventHandler(this.BtnRpcSpiWrite_Click);
            // 
            // SPI_COMMAND_TXT
            // 
            this.SPI_COMMAND_TXT.Location = new System.Drawing.Point(125, 20);
            this.SPI_COMMAND_TXT.Name = "SPI_COMMAND_TXT";
            this.SPI_COMMAND_TXT.Size = new System.Drawing.Size(194, 25);
            this.SPI_COMMAND_TXT.TabIndex = 6;
            this.SPI_COMMAND_TXT.Text = "0x";
            this.SPI_COMMAND_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.ForeColor = System.Drawing.Color.Black;
            this.label99.Location = new System.Drawing.Point(5, 129);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(129, 15);
            this.label99.TabIndex = 5;
            this.label99.Text = "Read Data(Hex)";
            // 
            // SPI_HDATA_TXT
            // 
            this.SPI_HDATA_TXT.Location = new System.Drawing.Point(125, 46);
            this.SPI_HDATA_TXT.Name = "SPI_HDATA_TXT";
            this.SPI_HDATA_TXT.Size = new System.Drawing.Size(194, 25);
            this.SPI_HDATA_TXT.TabIndex = 4;
            this.SPI_HDATA_TXT.Text = "0x00";
            this.SPI_HDATA_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.ForeColor = System.Drawing.Color.Black;
            this.label100.Location = new System.Drawing.Point(6, 55);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(140, 15);
            this.label100.TabIndex = 3;
            this.label100.Text = "Write HData(Hex)";
            // 
            // SPI_LDATA_TXT
            // 
            this.SPI_LDATA_TXT.Location = new System.Drawing.Point(125, 73);
            this.SPI_LDATA_TXT.Name = "SPI_LDATA_TXT";
            this.SPI_LDATA_TXT.Size = new System.Drawing.Size(194, 25);
            this.SPI_LDATA_TXT.TabIndex = 2;
            this.SPI_LDATA_TXT.Text = "0x";
            this.SPI_LDATA_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.ForeColor = System.Drawing.Color.Black;
            this.label101.Location = new System.Drawing.Point(6, 28);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(132, 15);
            this.label101.TabIndex = 1;
            this.label101.Text = "COMMAND(Hex)";
            // 
            // ACQ_XDMA_TAB
            // 
            this.ACQ_XDMA_TAB.Controls.Add(this.ACQ_XDMA_GROUP);
            this.ACQ_XDMA_TAB.Controls.Add(this.ACQ_PCIE_GROUP);
            this.ACQ_XDMA_TAB.Location = new System.Drawing.Point(4, 44);
            this.ACQ_XDMA_TAB.Name = "ACQ_XDMA_TAB";
            this.ACQ_XDMA_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.ACQ_XDMA_TAB.Size = new System.Drawing.Size(1346, 591);
            this.ACQ_XDMA_TAB.TabIndex = 9;
            this.ACQ_XDMA_TAB.Text = "Acq xdma Test";
            this.ACQ_XDMA_TAB.UseVisualStyleBackColor = true;
            // 
            // ACQ_XDMA_GROUP
            // 
            this.ACQ_XDMA_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ACQ_XDMA_GROUP.Controls.Add(this.BtnAcqXdmaRead);
            this.ACQ_XDMA_GROUP.Controls.Add(this.BtnAcqXdmaWrite);
            this.ACQ_XDMA_GROUP.Controls.Add(this.ACQ_XDMA_RDATA_TXT);
            this.ACQ_XDMA_GROUP.Controls.Add(this.label94);
            this.ACQ_XDMA_GROUP.Controls.Add(this.ACQ_XDMA_WDATA_TXT);
            this.ACQ_XDMA_GROUP.Controls.Add(this.label97);
            this.ACQ_XDMA_GROUP.Controls.Add(this.ACQ_XDMA_ADDR_TXT);
            this.ACQ_XDMA_GROUP.Controls.Add(this.label98);
            this.ACQ_XDMA_GROUP.ForeColor = System.Drawing.Color.Black;
            this.ACQ_XDMA_GROUP.Location = new System.Drawing.Point(21, 175);
            this.ACQ_XDMA_GROUP.Name = "ACQ_XDMA_GROUP";
            this.ACQ_XDMA_GROUP.Size = new System.Drawing.Size(280, 171);
            this.ACQ_XDMA_GROUP.TabIndex = 12;
            this.ACQ_XDMA_GROUP.TabStop = false;
            this.ACQ_XDMA_GROUP.Text = "Acquisition ddr3 XDMA Test";
            // 
            // BtnAcqXdmaRead
            // 
            this.BtnAcqXdmaRead.Location = new System.Drawing.Point(147, 143);
            this.BtnAcqXdmaRead.Name = "BtnAcqXdmaRead";
            this.BtnAcqXdmaRead.Size = new System.Drawing.Size(114, 22);
            this.BtnAcqXdmaRead.TabIndex = 8;
            this.BtnAcqXdmaRead.Text = "READ";
            this.BtnAcqXdmaRead.UseVisualStyleBackColor = true;
            this.BtnAcqXdmaRead.Click += new System.EventHandler(this.BtnAcqDDR3Read);
            // 
            // BtnAcqXdmaWrite
            // 
            this.BtnAcqXdmaWrite.Location = new System.Drawing.Point(6, 143);
            this.BtnAcqXdmaWrite.Name = "BtnAcqXdmaWrite";
            this.BtnAcqXdmaWrite.Size = new System.Drawing.Size(119, 22);
            this.BtnAcqXdmaWrite.TabIndex = 7;
            this.BtnAcqXdmaWrite.Text = "WRITE";
            this.BtnAcqXdmaWrite.UseVisualStyleBackColor = true;
            this.BtnAcqXdmaWrite.Click += new System.EventHandler(this.BtnAcqDDR3Write);
            // 
            // ACQ_XDMA_RDATA_TXT
            // 
            this.ACQ_XDMA_RDATA_TXT.Location = new System.Drawing.Point(125, 73);
            this.ACQ_XDMA_RDATA_TXT.Name = "ACQ_XDMA_RDATA_TXT";
            this.ACQ_XDMA_RDATA_TXT.Size = new System.Drawing.Size(136, 25);
            this.ACQ_XDMA_RDATA_TXT.TabIndex = 6;
            this.ACQ_XDMA_RDATA_TXT.Text = "0x";
            this.ACQ_XDMA_RDATA_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.ForeColor = System.Drawing.Color.Black;
            this.label94.Location = new System.Drawing.Point(6, 82);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(129, 15);
            this.label94.TabIndex = 5;
            this.label94.Text = "Read Data(Hex)";
            // 
            // ACQ_XDMA_WDATA_TXT
            // 
            this.ACQ_XDMA_WDATA_TXT.Location = new System.Drawing.Point(125, 46);
            this.ACQ_XDMA_WDATA_TXT.Name = "ACQ_XDMA_WDATA_TXT";
            this.ACQ_XDMA_WDATA_TXT.Size = new System.Drawing.Size(136, 25);
            this.ACQ_XDMA_WDATA_TXT.TabIndex = 4;
            this.ACQ_XDMA_WDATA_TXT.Text = "0x";
            this.ACQ_XDMA_WDATA_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.ForeColor = System.Drawing.Color.Black;
            this.label97.Location = new System.Drawing.Point(6, 55);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(129, 15);
            this.label97.TabIndex = 3;
            this.label97.Text = "Write Data(Hex)";
            // 
            // ACQ_XDMA_ADDR_TXT
            // 
            this.ACQ_XDMA_ADDR_TXT.Location = new System.Drawing.Point(125, 19);
            this.ACQ_XDMA_ADDR_TXT.Name = "ACQ_XDMA_ADDR_TXT";
            this.ACQ_XDMA_ADDR_TXT.Size = new System.Drawing.Size(136, 25);
            this.ACQ_XDMA_ADDR_TXT.TabIndex = 2;
            this.ACQ_XDMA_ADDR_TXT.Text = "0x80000000";
            this.ACQ_XDMA_ADDR_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.ForeColor = System.Drawing.Color.Black;
            this.label98.Location = new System.Drawing.Point(6, 28);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(111, 15);
            this.label98.TabIndex = 1;
            this.label98.Text = "Address(Hex)";
            // 
            // ACQ_PCIE_GROUP
            // 
            this.ACQ_PCIE_GROUP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ACQ_PCIE_GROUP.Controls.Add(this.ACQ_FPGA_SEL_COMB);
            this.ACQ_PCIE_GROUP.Controls.Add(this.label93);
            this.ACQ_PCIE_GROUP.Controls.Add(this.label89);
            this.ACQ_PCIE_GROUP.Controls.Add(this.ACQ_XDMA_EN_CHECK);
            this.ACQ_PCIE_GROUP.Location = new System.Drawing.Point(21, 24);
            this.ACQ_PCIE_GROUP.Name = "ACQ_PCIE_GROUP";
            this.ACQ_PCIE_GROUP.Size = new System.Drawing.Size(381, 145);
            this.ACQ_PCIE_GROUP.TabIndex = 11;
            this.ACQ_PCIE_GROUP.TabStop = false;
            this.ACQ_PCIE_GROUP.Text = "PCIE DEVICE";
            // 
            // ACQ_FPGA_SEL_COMB
            // 
            this.ACQ_FPGA_SEL_COMB.FormattingEnabled = true;
            this.ACQ_FPGA_SEL_COMB.Items.AddRange(new object[] {
            "subsys_00072000",
            "subsys_00072001",
            "subsys_00072002",
            "subsys_00072003"});
            this.ACQ_FPGA_SEL_COMB.Location = new System.Drawing.Point(163, 89);
            this.ACQ_FPGA_SEL_COMB.Name = "ACQ_FPGA_SEL_COMB";
            this.ACQ_FPGA_SEL_COMB.Size = new System.Drawing.Size(121, 23);
            this.ACQ_FPGA_SEL_COMB.TabIndex = 5;
            this.ACQ_FPGA_SEL_COMB.Text = "subsys_00072000";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(27, 92);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(149, 15);
            this.label93.TabIndex = 4;
            this.label93.Text = "Aquisition FPGA ID";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(27, 49);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(272, 15);
            this.label89.TabIndex = 3;
            this.label89.Text = "(disable serial port communication)";
            // 
            // ACQ_XDMA_EN_CHECK
            // 
            this.ACQ_XDMA_EN_CHECK.AutoSize = true;
            this.ACQ_XDMA_EN_CHECK.Checked = true;
            this.ACQ_XDMA_EN_CHECK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ACQ_XDMA_EN_CHECK.Location = new System.Drawing.Point(29, 27);
            this.ACQ_XDMA_EN_CHECK.Name = "ACQ_XDMA_EN_CHECK";
            this.ACQ_XDMA_EN_CHECK.Size = new System.Drawing.Size(240, 19);
            this.ACQ_XDMA_EN_CHECK.TabIndex = 2;
            this.ACQ_XDMA_EN_CHECK.Text = "Enable PCIE Communication";
            this.ACQ_XDMA_EN_CHECK.UseVisualStyleBackColor = true;
            // 
            // US_SCAN_TAB
            // 
            this.US_SCAN_TAB.Controls.Add(this.label95);
            this.US_SCAN_TAB.Controls.Add(this.label96);
            this.US_SCAN_TAB.Controls.Add(this.label91);
            this.US_SCAN_TAB.Controls.Add(this.label92);
            this.US_SCAN_TAB.Controls.Add(this.label87);
            this.US_SCAN_TAB.Controls.Add(this.label88);
            this.US_SCAN_TAB.Controls.Add(this.label86);
            this.US_SCAN_TAB.Controls.Add(this.label85);
            this.US_SCAN_TAB.Controls.Add(this.US_FPS_DELAY_GROUP);
            this.US_SCAN_TAB.Controls.Add(this.US_FRAME);
            this.US_SCAN_TAB.Controls.Add(this.US_SCAN_GROUP);
            this.US_SCAN_TAB.Controls.Add(this.US_COLOR_GROUP);
            this.US_SCAN_TAB.Controls.Add(this.US_CF_GROUP);
            this.US_SCAN_TAB.Controls.Add(this.US_2D_GROUP);
            this.US_SCAN_TAB.Location = new System.Drawing.Point(4, 44);
            this.US_SCAN_TAB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_SCAN_TAB.Name = "US_SCAN_TAB";
            this.US_SCAN_TAB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_SCAN_TAB.Size = new System.Drawing.Size(1346, 591);
            this.US_SCAN_TAB.TabIndex = 7;
            this.US_SCAN_TAB.Text = "ULTRA SONIC";
            this.US_SCAN_TAB.UseVisualStyleBackColor = true;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(1119, 71);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(16, 15);
            this.label95.TabIndex = 23;
            this.label95.Text = "0";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(951, 71);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(106, 15);
            this.label96.TabIndex = 22;
            this.label96.Text = "BeamForming";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(1119, 19);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(16, 15);
            this.label91.TabIndex = 19;
            this.label91.Text = "0";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(950, 19);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(120, 15);
            this.label92.TabIndex = 18;
            this.label92.Text = "Load Image ms";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(1119, 39);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(16, 15);
            this.label87.TabIndex = 15;
            this.label87.Text = "0";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(950, 41);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(143, 15);
            this.label88.TabIndex = 14;
            this.label88.Text = "Image process ms";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(1119, 90);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(16, 15);
            this.label86.TabIndex = 13;
            this.label86.Text = "0";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(951, 90);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(149, 15);
            this.label85.TabIndex = 12;
            this.label85.Text = "Picture per second";
            // 
            // US_FPS_DELAY_GROUP
            // 
            this.US_FPS_DELAY_GROUP.Controls.Add(this.label83);
            this.US_FPS_DELAY_GROUP.Controls.Add(this.label82);
            this.US_FPS_DELAY_GROUP.Controls.Add(this.US_FRAME_DELAY_TRACK);
            this.US_FPS_DELAY_GROUP.Location = new System.Drawing.Point(962, 496);
            this.US_FPS_DELAY_GROUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_FPS_DELAY_GROUP.Name = "US_FPS_DELAY_GROUP";
            this.US_FPS_DELAY_GROUP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_FPS_DELAY_GROUP.Size = new System.Drawing.Size(379, 98);
            this.US_FPS_DELAY_GROUP.TabIndex = 4;
            this.US_FPS_DELAY_GROUP.TabStop = false;
            this.US_FPS_DELAY_GROUP.Text = "Frame Delay";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(327, 43);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(28, 15);
            this.label83.TabIndex = 2;
            this.label83.Text = "ms";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(300, 43);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(16, 15);
            this.label82.TabIndex = 1;
            this.label82.Text = "1";
            // 
            // US_FRAME_DELAY_TRACK
            // 
            this.US_FRAME_DELAY_TRACK.Location = new System.Drawing.Point(18, 29);
            this.US_FRAME_DELAY_TRACK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_FRAME_DELAY_TRACK.Maximum = 300;
            this.US_FRAME_DELAY_TRACK.Minimum = 1;
            this.US_FRAME_DELAY_TRACK.Name = "US_FRAME_DELAY_TRACK";
            this.US_FRAME_DELAY_TRACK.Size = new System.Drawing.Size(266, 56);
            this.US_FRAME_DELAY_TRACK.SmallChange = 50;
            this.US_FRAME_DELAY_TRACK.TabIndex = 0;
            this.US_FRAME_DELAY_TRACK.Value = 1;
            this.US_FRAME_DELAY_TRACK.Scroll += new System.EventHandler(this.FrameDelayUpdate);
            // 
            // US_FRAME
            // 
            this.US_FRAME.Location = new System.Drawing.Point(37, 3);
            this.US_FRAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_FRAME.Name = "US_FRAME";
            this.US_FRAME.Size = new System.Drawing.Size(896, 596);
            this.US_FRAME.TabIndex = 4;
            // 
            // US_SCAN_GROUP
            // 
            this.US_SCAN_GROUP.Controls.Add(this.BtnScanStart);
            this.US_SCAN_GROUP.Controls.Add(this.RANDOM_RADIO);
            this.US_SCAN_GROUP.Controls.Add(this.SIMUL_RADIO);
            this.US_SCAN_GROUP.Controls.Add(this.SCANNER_RADIO);
            this.US_SCAN_GROUP.Location = new System.Drawing.Point(962, 404);
            this.US_SCAN_GROUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_SCAN_GROUP.Name = "US_SCAN_GROUP";
            this.US_SCAN_GROUP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_SCAN_GROUP.Size = new System.Drawing.Size(379, 87);
            this.US_SCAN_GROUP.TabIndex = 2;
            this.US_SCAN_GROUP.TabStop = false;
            this.US_SCAN_GROUP.Text = "SCAN Mode";
            // 
            // BtnScanStart
            // 
            this.BtnScanStart.Location = new System.Drawing.Point(18, 28);
            this.BtnScanStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnScanStart.Name = "BtnScanStart";
            this.BtnScanStart.Size = new System.Drawing.Size(146, 43);
            this.BtnScanStart.TabIndex = 0;
            this.BtnScanStart.Text = "SCAN START";
            this.BtnScanStart.UseVisualStyleBackColor = true;
            this.BtnScanStart.Click += new System.EventHandler(this.BtnScanStart_Click);
            // 
            // RANDOM_RADIO
            // 
            this.RANDOM_RADIO.AutoSize = true;
            this.RANDOM_RADIO.Location = new System.Drawing.Point(289, 55);
            this.RANDOM_RADIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RANDOM_RADIO.Name = "RANDOM_RADIO";
            this.RANDOM_RADIO.Size = new System.Drawing.Size(88, 19);
            this.RANDOM_RADIO.TabIndex = 4;
            this.RANDOM_RADIO.TabStop = true;
            this.RANDOM_RADIO.Text = "Random";
            this.RANDOM_RADIO.UseVisualStyleBackColor = true;
            // 
            // SIMUL_RADIO
            // 
            this.SIMUL_RADIO.AutoSize = true;
            this.SIMUL_RADIO.Location = new System.Drawing.Point(191, 55);
            this.SIMUL_RADIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SIMUL_RADIO.Name = "SIMUL_RADIO";
            this.SIMUL_RADIO.Size = new System.Drawing.Size(105, 19);
            this.SIMUL_RADIO.TabIndex = 3;
            this.SIMUL_RADIO.TabStop = true;
            this.SIMUL_RADIO.Text = "Simulation";
            this.SIMUL_RADIO.UseVisualStyleBackColor = true;
            // 
            // SCANNER_RADIO
            // 
            this.SCANNER_RADIO.AutoSize = true;
            this.SCANNER_RADIO.Location = new System.Drawing.Point(191, 18);
            this.SCANNER_RADIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SCANNER_RADIO.Name = "SCANNER_RADIO";
            this.SCANNER_RADIO.Size = new System.Drawing.Size(89, 19);
            this.SCANNER_RADIO.TabIndex = 2;
            this.SCANNER_RADIO.TabStop = true;
            this.SCANNER_RADIO.Text = "Scanner";
            this.SCANNER_RADIO.UseVisualStyleBackColor = true;
            // 
            // US_COLOR_GROUP
            // 
            this.US_COLOR_GROUP.Controls.Add(this.PA_MODE_RADIO);
            this.US_COLOR_GROUP.Controls.Add(this.US_MODE_RADIO);
            this.US_COLOR_GROUP.Location = new System.Drawing.Point(1158, 313);
            this.US_COLOR_GROUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_COLOR_GROUP.Name = "US_COLOR_GROUP";
            this.US_COLOR_GROUP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_COLOR_GROUP.Size = new System.Drawing.Size(183, 86);
            this.US_COLOR_GROUP.TabIndex = 1;
            this.US_COLOR_GROUP.TabStop = false;
            this.US_COLOR_GROUP.Text = "ColorMode";
            // 
            // PA_MODE_RADIO
            // 
            this.PA_MODE_RADIO.AutoSize = true;
            this.PA_MODE_RADIO.Location = new System.Drawing.Point(18, 55);
            this.PA_MODE_RADIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PA_MODE_RADIO.Name = "PA_MODE_RADIO";
            this.PA_MODE_RADIO.Size = new System.Drawing.Size(141, 19);
            this.PA_MODE_RADIO.TabIndex = 1;
            this.PA_MODE_RADIO.TabStop = true;
            this.PA_MODE_RADIO.Text = "photo acoustic";
            this.PA_MODE_RADIO.UseVisualStyleBackColor = true;
            // 
            // US_MODE_RADIO
            // 
            this.US_MODE_RADIO.AutoSize = true;
            this.US_MODE_RADIO.Location = new System.Drawing.Point(18, 26);
            this.US_MODE_RADIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_MODE_RADIO.Name = "US_MODE_RADIO";
            this.US_MODE_RADIO.Size = new System.Drawing.Size(112, 19);
            this.US_MODE_RADIO.TabIndex = 0;
            this.US_MODE_RADIO.TabStop = true;
            this.US_MODE_RADIO.Text = "ultra sound";
            this.US_MODE_RADIO.UseVisualStyleBackColor = true;
            // 
            // US_CF_GROUP
            // 
            this.US_CF_GROUP.Controls.Add(this.label70);
            this.US_CF_GROUP.Controls.Add(this.label81);
            this.US_CF_GROUP.Controls.Add(this.label71);
            this.US_CF_GROUP.Controls.Add(this.label80);
            this.US_CF_GROUP.Controls.Add(this.label72);
            this.US_CF_GROUP.Controls.Add(this.label79);
            this.US_CF_GROUP.Controls.Add(this.label73);
            this.US_CF_GROUP.Controls.Add(this.label78);
            this.US_CF_GROUP.Controls.Add(this.label74);
            this.US_CF_GROUP.Controls.Add(this.label77);
            this.US_CF_GROUP.Controls.Add(this.label75);
            this.US_CF_GROUP.Controls.Add(this.label76);
            this.US_CF_GROUP.Location = new System.Drawing.Point(1158, 158);
            this.US_CF_GROUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_CF_GROUP.Name = "US_CF_GROUP";
            this.US_CF_GROUP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_CF_GROUP.Size = new System.Drawing.Size(183, 150);
            this.US_CF_GROUP.TabIndex = 1;
            this.US_CF_GROUP.TabStop = false;
            this.US_CF_GROUP.Text = "CF";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(104, 125);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(59, 15);
            this.label70.TabIndex = 23;
            this.label70.Text = "1.2kHz";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(15, 29);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(53, 15);
            this.label81.TabIndex = 12;
            this.label81.Text = "Power";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(104, 106);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(40, 15);
            this.label71.TabIndex = 22;
            this.label71.Text = "20.0";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(15, 48);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(39, 15);
            this.label80.TabIndex = 13;
            this.label80.Text = "Freq";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(104, 86);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(25, 15);
            this.label72.TabIndex = 21;
            this.label72.Text = "80";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(15, 67);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(41, 15);
            this.label79.TabIndex = 14;
            this.label79.Text = "Gain";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(104, 67);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(40, 15);
            this.label73.TabIndex = 20;
            this.label73.Text = "26.0";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(15, 86);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(31, 15);
            this.label78.TabIndex = 15;
            this.label78.Text = "WF";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(104, 48);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(31, 15);
            this.label74.TabIndex = 19;
            this.label74.Text = "6.0";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(15, 106);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(59, 15);
            this.label77.TabIndex = 16;
            this.label77.Text = "Persist";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(104, 29);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(43, 15);
            this.label75.TabIndex = 18;
            this.label75.Text = "60 %";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(15, 125);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(38, 15);
            this.label76.TabIndex = 17;
            this.label76.Text = "PRF";
            // 
            // US_2D_GROUP
            // 
            this.US_2D_GROUP.Controls.Add(this.label62);
            this.US_2D_GROUP.Controls.Add(this.label63);
            this.US_2D_GROUP.Controls.Add(this.label64);
            this.US_2D_GROUP.Controls.Add(this.label65);
            this.US_2D_GROUP.Controls.Add(this.label66);
            this.US_2D_GROUP.Controls.Add(this.label69);
            this.US_2D_GROUP.Controls.Add(this.label61);
            this.US_2D_GROUP.Controls.Add(this.label60);
            this.US_2D_GROUP.Controls.Add(this.label59);
            this.US_2D_GROUP.Controls.Add(this.label58);
            this.US_2D_GROUP.Controls.Add(this.label57);
            this.US_2D_GROUP.Controls.Add(this.label56);
            this.US_2D_GROUP.Location = new System.Drawing.Point(1158, 5);
            this.US_2D_GROUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_2D_GROUP.Name = "US_2D_GROUP";
            this.US_2D_GROUP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.US_2D_GROUP.Size = new System.Drawing.Size(183, 149);
            this.US_2D_GROUP.TabIndex = 0;
            this.US_2D_GROUP.TabStop = false;
            this.US_2D_GROUP.Text = "2D";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(104, 123);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(31, 15);
            this.label62.TabIndex = 11;
            this.label62.Text = "2.0";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(104, 104);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(40, 15);
            this.label63.TabIndex = 10;
            this.label63.Text = "20.0";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(104, 85);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(25, 15);
            this.label64.TabIndex = 9;
            this.label64.Text = "80";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(104, 66);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(25, 15);
            this.label65.TabIndex = 8;
            this.label65.Text = "32";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(104, 46);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(40, 15);
            this.label66.TabIndex = 7;
            this.label66.Text = "10.0";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(104, 27);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(43, 15);
            this.label69.TabIndex = 6;
            this.label69.Text = "80 %";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(15, 123);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(50, 15);
            this.label61.TabIndex = 5;
            this.label61.Text = "Depth";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(15, 104);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(21, 15);
            this.label60.TabIndex = 4;
            this.label60.Text = "Fr";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(15, 85);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(23, 15);
            this.label59.TabIndex = 3;
            this.label59.Text = "Dr";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(15, 66);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(41, 15);
            this.label58.TabIndex = 2;
            this.label58.Text = "Gain";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(15, 46);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(39, 15);
            this.label57.TabIndex = 1;
            this.label57.Text = "Freq";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(15, 27);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(53, 15);
            this.label56.TabIndex = 0;
            this.label56.Text = "Power";
            // 
            // TGC_FIG_TAB
            // 
            this.TGC_FIG_TAB.Controls.Add(this.TGC_TEST_GROUP);
            this.TGC_FIG_TAB.Location = new System.Drawing.Point(4, 44);
            this.TGC_FIG_TAB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TGC_FIG_TAB.Name = "TGC_FIG_TAB";
            this.TGC_FIG_TAB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TGC_FIG_TAB.Size = new System.Drawing.Size(1346, 591);
            this.TGC_FIG_TAB.TabIndex = 8;
            this.TGC_FIG_TAB.Text = "TGC Figure";
            this.TGC_FIG_TAB.UseVisualStyleBackColor = true;
            // 
            // TGC_TEST_GROUP
            // 
            this.TGC_TEST_GROUP.Controls.Add(this.TGC_ERROR_NAME);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC_ERROR_VALUE);
            this.TGC_TEST_GROUP.Controls.Add(this.BtnClearTestPlot);
            this.TGC_TEST_GROUP.Controls.Add(this.BtnSplinePlot);
            this.TGC_TEST_GROUP.Controls.Add(this.btnPchipPlot);
            this.TGC_TEST_GROUP.Controls.Add(this.HERMIT_OP_GROUP);
            this.TGC_TEST_GROUP.Controls.Add(this.label140);
            this.TGC_TEST_GROUP.Controls.Add(this.label141);
            this.TGC_TEST_GROUP.Controls.Add(this.label142);
            this.TGC_TEST_GROUP.Controls.Add(this.label143);
            this.TGC_TEST_GROUP.Controls.Add(this.label144);
            this.TGC_TEST_GROUP.Controls.Add(this.label145);
            this.TGC_TEST_GROUP.Controls.Add(this.label146);
            this.TGC_TEST_GROUP.Controls.Add(this.label147);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC8_GAIN);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC7_GAIN);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC6_GAIN);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC5_GAIN);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC4_GAIN);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC3_GAIN);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC2_GAIN);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC1_GAIN);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC8_DEPTH);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC7_DEPTH);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC6_DEPTH);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC5_DEPTH);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC4_DEPTH);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC3_DEPTH);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC2_DEPTH);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC1_DEPTH);
            this.TGC_TEST_GROUP.Controls.Add(this.label102);
            this.TGC_TEST_GROUP.Controls.Add(this.label125);
            this.TGC_TEST_GROUP.Controls.Add(this.label126);
            this.TGC_TEST_GROUP.Controls.Add(this.label127);
            this.TGC_TEST_GROUP.Controls.Add(this.label128);
            this.TGC_TEST_GROUP.Controls.Add(this.label129);
            this.TGC_TEST_GROUP.Controls.Add(this.label130);
            this.TGC_TEST_GROUP.Controls.Add(this.label131);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC_CURVE_SEL_GROUP);
            this.TGC_TEST_GROUP.Controls.Add(this.label45);
            this.TGC_TEST_GROUP.Controls.Add(this.label84);
            this.TGC_TEST_GROUP.Controls.Add(this.label33);
            this.TGC_TEST_GROUP.Controls.Add(this.label34);
            this.TGC_TEST_GROUP.Controls.Add(this.label18);
            this.TGC_TEST_GROUP.Controls.Add(this.label19);
            this.TGC_TEST_GROUP.Controls.Add(this.label17);
            this.TGC_TEST_GROUP.Controls.Add(this.label16);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC8_TRACK);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC7_TRACK);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC6_TRACK);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC5_TRACK);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC4_TRACK);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC3_TRACK);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC2_TRACK);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC1_TRACK);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC_STATE_STRIP);
            this.TGC_TEST_GROUP.Controls.Add(this.TGC_GRAPH_TEST);
            this.TGC_TEST_GROUP.Location = new System.Drawing.Point(6, 5);
            this.TGC_TEST_GROUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TGC_TEST_GROUP.Name = "TGC_TEST_GROUP";
            this.TGC_TEST_GROUP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TGC_TEST_GROUP.Size = new System.Drawing.Size(1335, 591);
            this.TGC_TEST_GROUP.TabIndex = 0;
            this.TGC_TEST_GROUP.TabStop = false;
            this.TGC_TEST_GROUP.Text = "TGC GRAPH TEST";
            // 
            // TGC_ERROR_NAME
            // 
            this.TGC_ERROR_NAME.AutoSize = true;
            this.TGC_ERROR_NAME.Enabled = false;
            this.TGC_ERROR_NAME.Location = new System.Drawing.Point(691, 133);
            this.TGC_ERROR_NAME.Name = "TGC_ERROR_NAME";
            this.TGC_ERROR_NAME.Size = new System.Drawing.Size(113, 15);
            this.TGC_ERROR_NAME.TabIndex = 81;
            this.TGC_ERROR_NAME.Text = "Error(E(x)^2):";
            // 
            // TGC_ERROR_VALUE
            // 
            this.TGC_ERROR_VALUE.AutoSize = true;
            this.TGC_ERROR_VALUE.Enabled = false;
            this.TGC_ERROR_VALUE.Location = new System.Drawing.Point(794, 133);
            this.TGC_ERROR_VALUE.Name = "TGC_ERROR_VALUE";
            this.TGC_ERROR_VALUE.Size = new System.Drawing.Size(16, 15);
            this.TGC_ERROR_VALUE.TabIndex = 80;
            this.TGC_ERROR_VALUE.Text = "0";
            // 
            // BtnClearTestPlot
            // 
            this.BtnClearTestPlot.Location = new System.Drawing.Point(711, 97);
            this.BtnClearTestPlot.Name = "BtnClearTestPlot";
            this.BtnClearTestPlot.Size = new System.Drawing.Size(113, 23);
            this.BtnClearTestPlot.TabIndex = 79;
            this.BtnClearTestPlot.Text = "Clear Test";
            this.BtnClearTestPlot.UseVisualStyleBackColor = true;
            this.BtnClearTestPlot.Click += new System.EventHandler(this.BtnClearTestPlot_Click);
            // 
            // BtnSplinePlot
            // 
            this.BtnSplinePlot.Location = new System.Drawing.Point(711, 39);
            this.BtnSplinePlot.Name = "BtnSplinePlot";
            this.BtnSplinePlot.Size = new System.Drawing.Size(113, 23);
            this.BtnSplinePlot.TabIndex = 78;
            this.BtnSplinePlot.Text = "Plot spline";
            this.BtnSplinePlot.UseVisualStyleBackColor = true;
            this.BtnSplinePlot.Click += new System.EventHandler(this.BtnSplinePlot_Click);
            // 
            // btnPchipPlot
            // 
            this.btnPchipPlot.Location = new System.Drawing.Point(711, 68);
            this.btnPchipPlot.Name = "btnPchipPlot";
            this.btnPchipPlot.Size = new System.Drawing.Size(113, 23);
            this.btnPchipPlot.TabIndex = 77;
            this.btnPchipPlot.Text = "Plot pchip";
            this.btnPchipPlot.UseVisualStyleBackColor = true;
            this.btnPchipPlot.Click += new System.EventHandler(this.btnPchipPlot_Click);
            // 
            // HERMIT_OP_GROUP
            // 
            this.HERMIT_OP_GROUP.Controls.Add(this.M_OP_FINIT_CHECK);
            this.HERMIT_OP_GROUP.Controls.Add(this.M_OP_MONO_CHECK);
            this.HERMIT_OP_GROUP.Enabled = false;
            this.HERMIT_OP_GROUP.Location = new System.Drawing.Point(846, 92);
            this.HERMIT_OP_GROUP.Name = "HERMIT_OP_GROUP";
            this.HERMIT_OP_GROUP.Size = new System.Drawing.Size(405, 53);
            this.HERMIT_OP_GROUP.TabIndex = 45;
            this.HERMIT_OP_GROUP.TabStop = false;
            this.HERMIT_OP_GROUP.Text = "Hermit Curve Option";
            // 
            // M_OP_FINIT_CHECK
            // 
            this.M_OP_FINIT_CHECK.AutoSize = true;
            this.M_OP_FINIT_CHECK.Checked = true;
            this.M_OP_FINIT_CHECK.Location = new System.Drawing.Point(49, 20);
            this.M_OP_FINIT_CHECK.Name = "M_OP_FINIT_CHECK";
            this.M_OP_FINIT_CHECK.Size = new System.Drawing.Size(164, 19);
            this.M_OP_FINIT_CHECK.TabIndex = 77;
            this.M_OP_FINIT_CHECK.TabStop = true;
            this.M_OP_FINIT_CHECK.Text = "m : finit difference";
            this.M_OP_FINIT_CHECK.UseVisualStyleBackColor = true;
            // 
            // M_OP_MONO_CHECK
            // 
            this.M_OP_MONO_CHECK.AutoSize = true;
            this.M_OP_MONO_CHECK.Location = new System.Drawing.Point(230, 20);
            this.M_OP_MONO_CHECK.Name = "M_OP_MONO_CHECK";
            this.M_OP_MONO_CHECK.Size = new System.Drawing.Size(132, 19);
            this.M_OP_MONO_CHECK.TabIndex = 78;
            this.M_OP_MONO_CHECK.Text = "m : monotone";
            this.M_OP_MONO_CHECK.UseVisualStyleBackColor = true;
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label140.ForeColor = System.Drawing.Color.Black;
            this.label140.Location = new System.Drawing.Point(1271, 513);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(43, 15);
            this.label140.TabIndex = 76;
            this.label140.Text = "GAIN";
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label141.ForeColor = System.Drawing.Color.Black;
            this.label141.Location = new System.Drawing.Point(1271, 462);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(43, 15);
            this.label141.TabIndex = 75;
            this.label141.Text = "GAIN";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label142.ForeColor = System.Drawing.Color.Black;
            this.label142.Location = new System.Drawing.Point(1271, 411);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(43, 15);
            this.label142.TabIndex = 74;
            this.label142.Text = "GAIN";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label143.ForeColor = System.Drawing.Color.Black;
            this.label143.Location = new System.Drawing.Point(1271, 360);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(43, 15);
            this.label143.TabIndex = 73;
            this.label143.Text = "GAIN";
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label144.ForeColor = System.Drawing.Color.Black;
            this.label144.Location = new System.Drawing.Point(1271, 309);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(43, 15);
            this.label144.TabIndex = 72;
            this.label144.Text = "GAIN";
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label145.ForeColor = System.Drawing.Color.Black;
            this.label145.Location = new System.Drawing.Point(1271, 258);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(43, 15);
            this.label145.TabIndex = 71;
            this.label145.Text = "GAIN";
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label146.ForeColor = System.Drawing.Color.Black;
            this.label146.Location = new System.Drawing.Point(1271, 207);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(43, 15);
            this.label146.TabIndex = 70;
            this.label146.Text = "GAIN";
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label147.ForeColor = System.Drawing.Color.Black;
            this.label147.Location = new System.Drawing.Point(1271, 156);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(43, 15);
            this.label147.TabIndex = 69;
            this.label147.Text = "GAIN";
            // 
            // TGC8_GAIN
            // 
            this.TGC8_GAIN.AutoSize = true;
            this.TGC8_GAIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TGC8_GAIN.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC8_GAIN.ForeColor = System.Drawing.Color.Black;
            this.TGC8_GAIN.Location = new System.Drawing.Point(1278, 528);
            this.TGC8_GAIN.Name = "TGC8_GAIN";
            this.TGC8_GAIN.Size = new System.Drawing.Size(36, 17);
            this.TGC8_GAIN.TabIndex = 68;
            this.TGC8_GAIN.Text = "100";
            // 
            // TGC7_GAIN
            // 
            this.TGC7_GAIN.AutoSize = true;
            this.TGC7_GAIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TGC7_GAIN.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC7_GAIN.ForeColor = System.Drawing.Color.Black;
            this.TGC7_GAIN.Location = new System.Drawing.Point(1278, 477);
            this.TGC7_GAIN.Name = "TGC7_GAIN";
            this.TGC7_GAIN.Size = new System.Drawing.Size(36, 17);
            this.TGC7_GAIN.TabIndex = 67;
            this.TGC7_GAIN.Text = "100";
            // 
            // TGC6_GAIN
            // 
            this.TGC6_GAIN.AutoSize = true;
            this.TGC6_GAIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TGC6_GAIN.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC6_GAIN.ForeColor = System.Drawing.Color.Black;
            this.TGC6_GAIN.Location = new System.Drawing.Point(1278, 426);
            this.TGC6_GAIN.Name = "TGC6_GAIN";
            this.TGC6_GAIN.Size = new System.Drawing.Size(36, 17);
            this.TGC6_GAIN.TabIndex = 66;
            this.TGC6_GAIN.Text = "100";
            // 
            // TGC5_GAIN
            // 
            this.TGC5_GAIN.AutoSize = true;
            this.TGC5_GAIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TGC5_GAIN.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC5_GAIN.ForeColor = System.Drawing.Color.Black;
            this.TGC5_GAIN.Location = new System.Drawing.Point(1278, 375);
            this.TGC5_GAIN.Name = "TGC5_GAIN";
            this.TGC5_GAIN.Size = new System.Drawing.Size(36, 17);
            this.TGC5_GAIN.TabIndex = 65;
            this.TGC5_GAIN.Text = "100";
            // 
            // TGC4_GAIN
            // 
            this.TGC4_GAIN.AutoSize = true;
            this.TGC4_GAIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TGC4_GAIN.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC4_GAIN.ForeColor = System.Drawing.Color.Black;
            this.TGC4_GAIN.Location = new System.Drawing.Point(1278, 324);
            this.TGC4_GAIN.Name = "TGC4_GAIN";
            this.TGC4_GAIN.Size = new System.Drawing.Size(36, 17);
            this.TGC4_GAIN.TabIndex = 64;
            this.TGC4_GAIN.Text = "100";
            // 
            // TGC3_GAIN
            // 
            this.TGC3_GAIN.AutoSize = true;
            this.TGC3_GAIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TGC3_GAIN.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC3_GAIN.ForeColor = System.Drawing.Color.Black;
            this.TGC3_GAIN.Location = new System.Drawing.Point(1278, 273);
            this.TGC3_GAIN.Name = "TGC3_GAIN";
            this.TGC3_GAIN.Size = new System.Drawing.Size(36, 17);
            this.TGC3_GAIN.TabIndex = 63;
            this.TGC3_GAIN.Text = "100";
            // 
            // TGC2_GAIN
            // 
            this.TGC2_GAIN.AutoSize = true;
            this.TGC2_GAIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TGC2_GAIN.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC2_GAIN.ForeColor = System.Drawing.Color.Black;
            this.TGC2_GAIN.Location = new System.Drawing.Point(1278, 222);
            this.TGC2_GAIN.Name = "TGC2_GAIN";
            this.TGC2_GAIN.Size = new System.Drawing.Size(36, 17);
            this.TGC2_GAIN.TabIndex = 62;
            this.TGC2_GAIN.Text = "100";
            // 
            // TGC1_GAIN
            // 
            this.TGC1_GAIN.AutoSize = true;
            this.TGC1_GAIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TGC1_GAIN.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC1_GAIN.ForeColor = System.Drawing.Color.Black;
            this.TGC1_GAIN.Location = new System.Drawing.Point(1278, 171);
            this.TGC1_GAIN.Name = "TGC1_GAIN";
            this.TGC1_GAIN.Size = new System.Drawing.Size(36, 17);
            this.TGC1_GAIN.TabIndex = 61;
            this.TGC1_GAIN.Text = "100";
            // 
            // TGC8_DEPTH
            // 
            this.TGC8_DEPTH.AutoSize = true;
            this.TGC8_DEPTH.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC8_DEPTH.ForeColor = System.Drawing.Color.Black;
            this.TGC8_DEPTH.Location = new System.Drawing.Point(776, 546);
            this.TGC8_DEPTH.Name = "TGC8_DEPTH";
            this.TGC8_DEPTH.Size = new System.Drawing.Size(16, 15);
            this.TGC8_DEPTH.TabIndex = 60;
            this.TGC8_DEPTH.Text = "0";
            // 
            // TGC7_DEPTH
            // 
            this.TGC7_DEPTH.AutoSize = true;
            this.TGC7_DEPTH.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC7_DEPTH.ForeColor = System.Drawing.Color.Black;
            this.TGC7_DEPTH.Location = new System.Drawing.Point(776, 495);
            this.TGC7_DEPTH.Name = "TGC7_DEPTH";
            this.TGC7_DEPTH.Size = new System.Drawing.Size(16, 15);
            this.TGC7_DEPTH.TabIndex = 59;
            this.TGC7_DEPTH.Text = "0";
            // 
            // TGC6_DEPTH
            // 
            this.TGC6_DEPTH.AutoSize = true;
            this.TGC6_DEPTH.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC6_DEPTH.ForeColor = System.Drawing.Color.Black;
            this.TGC6_DEPTH.Location = new System.Drawing.Point(776, 444);
            this.TGC6_DEPTH.Name = "TGC6_DEPTH";
            this.TGC6_DEPTH.Size = new System.Drawing.Size(16, 15);
            this.TGC6_DEPTH.TabIndex = 58;
            this.TGC6_DEPTH.Text = "0";
            // 
            // TGC5_DEPTH
            // 
            this.TGC5_DEPTH.AutoSize = true;
            this.TGC5_DEPTH.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC5_DEPTH.ForeColor = System.Drawing.Color.Black;
            this.TGC5_DEPTH.Location = new System.Drawing.Point(776, 393);
            this.TGC5_DEPTH.Name = "TGC5_DEPTH";
            this.TGC5_DEPTH.Size = new System.Drawing.Size(16, 15);
            this.TGC5_DEPTH.TabIndex = 57;
            this.TGC5_DEPTH.Text = "0";
            // 
            // TGC4_DEPTH
            // 
            this.TGC4_DEPTH.AutoSize = true;
            this.TGC4_DEPTH.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC4_DEPTH.ForeColor = System.Drawing.Color.Black;
            this.TGC4_DEPTH.Location = new System.Drawing.Point(776, 342);
            this.TGC4_DEPTH.Name = "TGC4_DEPTH";
            this.TGC4_DEPTH.Size = new System.Drawing.Size(16, 15);
            this.TGC4_DEPTH.TabIndex = 56;
            this.TGC4_DEPTH.Text = "0";
            // 
            // TGC3_DEPTH
            // 
            this.TGC3_DEPTH.AutoSize = true;
            this.TGC3_DEPTH.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC3_DEPTH.ForeColor = System.Drawing.Color.Black;
            this.TGC3_DEPTH.Location = new System.Drawing.Point(776, 291);
            this.TGC3_DEPTH.Name = "TGC3_DEPTH";
            this.TGC3_DEPTH.Size = new System.Drawing.Size(16, 15);
            this.TGC3_DEPTH.TabIndex = 55;
            this.TGC3_DEPTH.Text = "0";
            // 
            // TGC2_DEPTH
            // 
            this.TGC2_DEPTH.AutoSize = true;
            this.TGC2_DEPTH.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC2_DEPTH.ForeColor = System.Drawing.Color.Black;
            this.TGC2_DEPTH.Location = new System.Drawing.Point(776, 240);
            this.TGC2_DEPTH.Name = "TGC2_DEPTH";
            this.TGC2_DEPTH.Size = new System.Drawing.Size(16, 15);
            this.TGC2_DEPTH.TabIndex = 54;
            this.TGC2_DEPTH.Text = "0";
            // 
            // TGC1_DEPTH
            // 
            this.TGC1_DEPTH.AutoSize = true;
            this.TGC1_DEPTH.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TGC1_DEPTH.ForeColor = System.Drawing.Color.Black;
            this.TGC1_DEPTH.Location = new System.Drawing.Point(776, 189);
            this.TGC1_DEPTH.Name = "TGC1_DEPTH";
            this.TGC1_DEPTH.Size = new System.Drawing.Size(16, 15);
            this.TGC1_DEPTH.TabIndex = 53;
            this.TGC1_DEPTH.Text = "0";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label102.ForeColor = System.Drawing.Color.Black;
            this.label102.Location = new System.Drawing.Point(695, 546);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(97, 15);
            this.label102.TabIndex = 52;
            this.label102.Text = "depth[cm]:";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label125.ForeColor = System.Drawing.Color.Black;
            this.label125.Location = new System.Drawing.Point(695, 495);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(97, 15);
            this.label125.TabIndex = 51;
            this.label125.Text = "depth[cm]:";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label126.ForeColor = System.Drawing.Color.Black;
            this.label126.Location = new System.Drawing.Point(695, 444);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(97, 15);
            this.label126.TabIndex = 50;
            this.label126.Text = "depth[cm]:";
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label127.ForeColor = System.Drawing.Color.Black;
            this.label127.Location = new System.Drawing.Point(695, 393);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(97, 15);
            this.label127.TabIndex = 49;
            this.label127.Text = "depth[cm]:";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label128.ForeColor = System.Drawing.Color.Black;
            this.label128.Location = new System.Drawing.Point(695, 342);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(97, 15);
            this.label128.TabIndex = 48;
            this.label128.Text = "depth[cm]:";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label129.ForeColor = System.Drawing.Color.Black;
            this.label129.Location = new System.Drawing.Point(695, 291);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(97, 15);
            this.label129.TabIndex = 47;
            this.label129.Text = "depth[cm]:";
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label130.ForeColor = System.Drawing.Color.Black;
            this.label130.Location = new System.Drawing.Point(695, 240);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(97, 15);
            this.label130.TabIndex = 46;
            this.label130.Text = "depth[cm]:";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label131.ForeColor = System.Drawing.Color.Black;
            this.label131.Location = new System.Drawing.Point(695, 189);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(97, 15);
            this.label131.TabIndex = 45;
            this.label131.Text = "depth[cm]:";
            // 
            // TGC_CURVE_SEL_GROUP
            // 
            this.TGC_CURVE_SEL_GROUP.Controls.Add(this.CMROM_SPLINE_RADIO);
            this.TGC_CURVE_SEL_GROUP.Controls.Add(this.HERMIT_SPLINE_RADIO);
            this.TGC_CURVE_SEL_GROUP.Controls.Add(this.CSHARP_CURVE_RADIO);
            this.TGC_CURVE_SEL_GROUP.Controls.Add(this.CUBIC_SPLINE_RADIO);
            this.TGC_CURVE_SEL_GROUP.Location = new System.Drawing.Point(845, 19);
            this.TGC_CURVE_SEL_GROUP.Name = "TGC_CURVE_SEL_GROUP";
            this.TGC_CURVE_SEL_GROUP.Size = new System.Drawing.Size(406, 67);
            this.TGC_CURVE_SEL_GROUP.TabIndex = 44;
            this.TGC_CURVE_SEL_GROUP.TabStop = false;
            this.TGC_CURVE_SEL_GROUP.Text = "TGC_CURVE";
            // 
            // HERMIT_SPLINE_RADIO
            // 
            this.HERMIT_SPLINE_RADIO.AutoSize = true;
            this.HERMIT_SPLINE_RADIO.Location = new System.Drawing.Point(231, 42);
            this.HERMIT_SPLINE_RADIO.Name = "HERMIT_SPLINE_RADIO";
            this.HERMIT_SPLINE_RADIO.Size = new System.Drawing.Size(176, 19);
            this.HERMIT_SPLINE_RADIO.TabIndex = 3;
            this.HERMIT_SPLINE_RADIO.Text = "Cubic Hermit 보간법";
            this.HERMIT_SPLINE_RADIO.UseVisualStyleBackColor = true;
            this.HERMIT_SPLINE_RADIO.CheckedChanged += new System.EventHandler(this.CUBIC_HERMIT_SPLINE_CheckedChanged);
            // 
            // CSHARP_CURVE_RADIO
            // 
            this.CSHARP_CURVE_RADIO.AutoSize = true;
            this.CSHARP_CURVE_RADIO.Checked = true;
            this.CSHARP_CURVE_RADIO.Location = new System.Drawing.Point(50, 20);
            this.CSHARP_CURVE_RADIO.Name = "CSHARP_CURVE_RADIO";
            this.CSHARP_CURVE_RADIO.Size = new System.Drawing.Size(183, 19);
            this.CSHARP_CURVE_RADIO.TabIndex = 2;
            this.CSHARP_CURVE_RADIO.TabStop = true;
            this.CSHARP_CURVE_RADIO.Text = "CSharp Spline Curve";
            this.CSHARP_CURVE_RADIO.UseVisualStyleBackColor = true;
            // 
            // CUBIC_SPLINE_RADIO
            // 
            this.CUBIC_SPLINE_RADIO.AutoSize = true;
            this.CUBIC_SPLINE_RADIO.Location = new System.Drawing.Point(231, 20);
            this.CUBIC_SPLINE_RADIO.Name = "CUBIC_SPLINE_RADIO";
            this.CUBIC_SPLINE_RADIO.Size = new System.Drawing.Size(176, 19);
            this.CUBIC_SPLINE_RADIO.TabIndex = 0;
            this.CUBIC_SPLINE_RADIO.Text = "Cubic Spline 보간법";
            this.CUBIC_SPLINE_RADIO.UseVisualStyleBackColor = true;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label45.ForeColor = System.Drawing.Color.Black;
            this.label45.Location = new System.Drawing.Point(770, 528);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(52, 15);
            this.label45.TabIndex = 42;
            this.label45.Text = "TGC 8";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label84.ForeColor = System.Drawing.Color.Black;
            this.label84.Location = new System.Drawing.Point(770, 477);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(52, 15);
            this.label84.TabIndex = 39;
            this.label84.Text = "TGC 7";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(770, 426);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(52, 15);
            this.label33.TabIndex = 36;
            this.label33.Text = "TGC 6";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(770, 375);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(52, 15);
            this.label34.TabIndex = 33;
            this.label34.Text = "TGC 5";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(770, 324);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 15);
            this.label18.TabIndex = 30;
            this.label18.Text = "TGC 4";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(770, 273);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 15);
            this.label19.TabIndex = 27;
            this.label19.Text = "TGC 3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(770, 222);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 24;
            this.label17.Text = "TGC 2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(770, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 15);
            this.label16.TabIndex = 21;
            this.label16.Text = "TGC 1";
            // 
            // TGC8_TRACK
            // 
            this.TGC8_TRACK.LargeChange = 10;
            this.TGC8_TRACK.Location = new System.Drawing.Point(830, 513);
            this.TGC8_TRACK.Maximum = 100;
            this.TGC8_TRACK.Name = "TGC8_TRACK";
            this.TGC8_TRACK.Size = new System.Drawing.Size(435, 56);
            this.TGC8_TRACK.SmallChange = 10;
            this.TGC8_TRACK.TabIndex = 16;
            this.TGC8_TRACK.Scroll += new System.EventHandler(this.TGC8_TRACK_Scroll);
            // 
            // TGC7_TRACK
            // 
            this.TGC7_TRACK.LargeChange = 10;
            this.TGC7_TRACK.Location = new System.Drawing.Point(830, 462);
            this.TGC7_TRACK.Maximum = 100;
            this.TGC7_TRACK.Name = "TGC7_TRACK";
            this.TGC7_TRACK.Size = new System.Drawing.Size(435, 56);
            this.TGC7_TRACK.TabIndex = 15;
            this.TGC7_TRACK.Scroll += new System.EventHandler(this.TGC7_TRACK_Scroll);
            // 
            // TGC6_TRACK
            // 
            this.TGC6_TRACK.LargeChange = 10;
            this.TGC6_TRACK.Location = new System.Drawing.Point(830, 411);
            this.TGC6_TRACK.Maximum = 100;
            this.TGC6_TRACK.Name = "TGC6_TRACK";
            this.TGC6_TRACK.Size = new System.Drawing.Size(435, 56);
            this.TGC6_TRACK.TabIndex = 14;
            this.TGC6_TRACK.Scroll += new System.EventHandler(this.TGC6_TRACK_Scroll);
            // 
            // TGC5_TRACK
            // 
            this.TGC5_TRACK.LargeChange = 10;
            this.TGC5_TRACK.Location = new System.Drawing.Point(830, 360);
            this.TGC5_TRACK.Maximum = 100;
            this.TGC5_TRACK.Name = "TGC5_TRACK";
            this.TGC5_TRACK.Size = new System.Drawing.Size(435, 56);
            this.TGC5_TRACK.TabIndex = 13;
            this.TGC5_TRACK.Scroll += new System.EventHandler(this.TGC5_TRACK_Scroll);
            // 
            // TGC4_TRACK
            // 
            this.TGC4_TRACK.LargeChange = 10;
            this.TGC4_TRACK.Location = new System.Drawing.Point(830, 309);
            this.TGC4_TRACK.Maximum = 100;
            this.TGC4_TRACK.Name = "TGC4_TRACK";
            this.TGC4_TRACK.Size = new System.Drawing.Size(435, 56);
            this.TGC4_TRACK.TabIndex = 12;
            this.TGC4_TRACK.Scroll += new System.EventHandler(this.TGC4_TRACK_Scroll);
            // 
            // TGC3_TRACK
            // 
            this.TGC3_TRACK.LargeChange = 10;
            this.TGC3_TRACK.Location = new System.Drawing.Point(830, 258);
            this.TGC3_TRACK.Maximum = 100;
            this.TGC3_TRACK.Name = "TGC3_TRACK";
            this.TGC3_TRACK.Size = new System.Drawing.Size(435, 56);
            this.TGC3_TRACK.TabIndex = 11;
            this.TGC3_TRACK.Scroll += new System.EventHandler(this.TGC3_TRACK_Scroll);
            // 
            // TGC2_TRACK
            // 
            this.TGC2_TRACK.LargeChange = 10;
            this.TGC2_TRACK.Location = new System.Drawing.Point(830, 207);
            this.TGC2_TRACK.Maximum = 100;
            this.TGC2_TRACK.Name = "TGC2_TRACK";
            this.TGC2_TRACK.Size = new System.Drawing.Size(435, 56);
            this.TGC2_TRACK.TabIndex = 10;
            this.TGC2_TRACK.Scroll += new System.EventHandler(this.TGC2_TRACK_Scroll);
            // 
            // TGC1_TRACK
            // 
            this.TGC1_TRACK.LargeChange = 10;
            this.TGC1_TRACK.Location = new System.Drawing.Point(830, 156);
            this.TGC1_TRACK.Maximum = 100;
            this.TGC1_TRACK.Name = "TGC1_TRACK";
            this.TGC1_TRACK.Size = new System.Drawing.Size(435, 56);
            this.TGC1_TRACK.TabIndex = 9;
            this.TGC1_TRACK.Scroll += new System.EventHandler(this.TGC1_TRACK_Scroll);
            // 
            // TGC_STATE_STRIP
            // 
            this.TGC_STATE_STRIP.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TGC_STATE_STRIP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TGC_XY_POINT_LABEL,
            this.TGC_CURVE_POINT_LABEL});
            this.TGC_STATE_STRIP.Location = new System.Drawing.Point(3, 563);
            this.TGC_STATE_STRIP.Name = "TGC_STATE_STRIP";
            this.TGC_STATE_STRIP.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.TGC_STATE_STRIP.Size = new System.Drawing.Size(1329, 26);
            this.TGC_STATE_STRIP.TabIndex = 8;
            this.TGC_STATE_STRIP.Text = "statusStrip1";
            // 
            // TGC_XY_POINT_LABEL
            // 
            this.TGC_XY_POINT_LABEL.Name = "TGC_XY_POINT_LABEL";
            this.TGC_XY_POINT_LABEL.Size = new System.Drawing.Size(53, 20);
            this.TGC_XY_POINT_LABEL.Text = "xycord";
            // 
            // TGC_CURVE_POINT_LABEL
            // 
            this.TGC_CURVE_POINT_LABEL.Name = "TGC_CURVE_POINT_LABEL";
            this.TGC_CURVE_POINT_LABEL.Size = new System.Drawing.Size(101, 20);
            this.TGC_CURVE_POINT_LABEL.Text = "curve_xy_cord";
            // 
            // TGC_GRAPH_TEST
            // 
            chartArea3.Name = "ChartArea1";
            this.TGC_GRAPH_TEST.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.TGC_GRAPH_TEST.Legends.Add(legend3);
            this.TGC_GRAPH_TEST.Location = new System.Drawing.Point(14, 53);
            this.TGC_GRAPH_TEST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TGC_GRAPH_TEST.Name = "TGC_GRAPH_TEST";
            this.TGC_GRAPH_TEST.Size = new System.Drawing.Size(676, 508);
            this.TGC_GRAPH_TEST.TabIndex = 0;
            this.TGC_GRAPH_TEST.Text = "chart3";
            this.TGC_GRAPH_TEST.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart3_MouseMove);
            // 
            // COM_PANEL
            // 
            this.COM_PANEL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.COM_PANEL.Controls.Add(this.COM_RPC_IMG);
            this.COM_PANEL.Controls.Add(this.label148);
            this.COM_PANEL.Controls.Add(this.COM_ANA_IMG4);
            this.COM_PANEL.Controls.Add(this.COM_ANA_IMG2);
            this.COM_PANEL.Controls.Add(this.COM_ANA_IMG3);
            this.COM_PANEL.Controls.Add(this.COM_ANA_IMG1);
            this.COM_PANEL.Controls.Add(this.label138);
            this.COM_PANEL.Controls.Add(this.COM_ACQ_IMG4);
            this.COM_PANEL.Controls.Add(this.COM_ACQ_IMG2);
            this.COM_PANEL.Controls.Add(this.COM_ACQ_IMG3);
            this.COM_PANEL.Controls.Add(this.COM_ACQ_IMG1);
            this.COM_PANEL.Controls.Add(this.COM_RTC_IMG);
            this.COM_PANEL.Controls.Add(this.label135);
            this.COM_PANEL.Controls.Add(this.label134);
            this.COM_PANEL.Location = new System.Drawing.Point(1232, 1);
            this.COM_PANEL.Name = "COM_PANEL";
            this.COM_PANEL.Size = new System.Drawing.Size(419, 44);
            this.COM_PANEL.TabIndex = 2;
            // 
            // COM_RPC_IMG
            // 
            this.COM_RPC_IMG.BackColor = System.Drawing.Color.Transparent;
            this.COM_RPC_IMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.COM_RPC_IMG.Location = new System.Drawing.Point(12, 21);
            this.COM_RPC_IMG.Name = "COM_RPC_IMG";
            this.COM_RPC_IMG.Size = new System.Drawing.Size(26, 23);
            this.COM_RPC_IMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.COM_RPC_IMG.TabIndex = 20;
            this.COM_RPC_IMG.TabStop = false;
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label148.Location = new System.Drawing.Point(9, 3);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(49, 20);
            this.label148.TabIndex = 19;
            this.label148.Text = "RPC";
            // 
            // COM_ANA_IMG4
            // 
            this.COM_ANA_IMG4.BackColor = System.Drawing.Color.Transparent;
            this.COM_ANA_IMG4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.COM_ANA_IMG4.Location = new System.Drawing.Point(381, 21);
            this.COM_ANA_IMG4.Name = "COM_ANA_IMG4";
            this.COM_ANA_IMG4.Size = new System.Drawing.Size(26, 23);
            this.COM_ANA_IMG4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.COM_ANA_IMG4.TabIndex = 18;
            this.COM_ANA_IMG4.TabStop = false;
            // 
            // COM_ANA_IMG2
            // 
            this.COM_ANA_IMG2.BackColor = System.Drawing.Color.Transparent;
            this.COM_ANA_IMG2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.COM_ANA_IMG2.Location = new System.Drawing.Point(314, 21);
            this.COM_ANA_IMG2.Name = "COM_ANA_IMG2";
            this.COM_ANA_IMG2.Size = new System.Drawing.Size(26, 23);
            this.COM_ANA_IMG2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.COM_ANA_IMG2.TabIndex = 17;
            this.COM_ANA_IMG2.TabStop = false;
            // 
            // COM_ANA_IMG3
            // 
            this.COM_ANA_IMG3.BackColor = System.Drawing.Color.Transparent;
            this.COM_ANA_IMG3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.COM_ANA_IMG3.Location = new System.Drawing.Point(349, 21);
            this.COM_ANA_IMG3.Name = "COM_ANA_IMG3";
            this.COM_ANA_IMG3.Size = new System.Drawing.Size(26, 23);
            this.COM_ANA_IMG3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.COM_ANA_IMG3.TabIndex = 16;
            this.COM_ANA_IMG3.TabStop = false;
            // 
            // COM_ANA_IMG1
            // 
            this.COM_ANA_IMG1.BackColor = System.Drawing.Color.Transparent;
            this.COM_ANA_IMG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.COM_ANA_IMG1.Location = new System.Drawing.Point(282, 21);
            this.COM_ANA_IMG1.Name = "COM_ANA_IMG1";
            this.COM_ANA_IMG1.Size = new System.Drawing.Size(26, 23);
            this.COM_ANA_IMG1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.COM_ANA_IMG1.TabIndex = 15;
            this.COM_ANA_IMG1.TabStop = false;
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label138.Location = new System.Drawing.Point(279, 3);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(150, 20);
            this.label138.TabIndex = 14;
            this.label138.Text = "Communication";
            // 
            // COM_ACQ_IMG4
            // 
            this.COM_ACQ_IMG4.BackColor = System.Drawing.Color.Transparent;
            this.COM_ACQ_IMG4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.COM_ACQ_IMG4.Location = new System.Drawing.Point(227, 21);
            this.COM_ACQ_IMG4.Name = "COM_ACQ_IMG4";
            this.COM_ACQ_IMG4.Size = new System.Drawing.Size(26, 23);
            this.COM_ACQ_IMG4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.COM_ACQ_IMG4.TabIndex = 13;
            this.COM_ACQ_IMG4.TabStop = false;
            // 
            // COM_ACQ_IMG2
            // 
            this.COM_ACQ_IMG2.BackColor = System.Drawing.Color.Transparent;
            this.COM_ACQ_IMG2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.COM_ACQ_IMG2.Location = new System.Drawing.Point(161, 21);
            this.COM_ACQ_IMG2.Name = "COM_ACQ_IMG2";
            this.COM_ACQ_IMG2.Size = new System.Drawing.Size(26, 23);
            this.COM_ACQ_IMG2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.COM_ACQ_IMG2.TabIndex = 11;
            this.COM_ACQ_IMG2.TabStop = false;
            // 
            // COM_ACQ_IMG3
            // 
            this.COM_ACQ_IMG3.BackColor = System.Drawing.Color.Transparent;
            this.COM_ACQ_IMG3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.COM_ACQ_IMG3.Location = new System.Drawing.Point(195, 21);
            this.COM_ACQ_IMG3.Name = "COM_ACQ_IMG3";
            this.COM_ACQ_IMG3.Size = new System.Drawing.Size(26, 23);
            this.COM_ACQ_IMG3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.COM_ACQ_IMG3.TabIndex = 9;
            this.COM_ACQ_IMG3.TabStop = false;
            // 
            // COM_ACQ_IMG1
            // 
            this.COM_ACQ_IMG1.BackColor = System.Drawing.Color.Transparent;
            this.COM_ACQ_IMG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.COM_ACQ_IMG1.Location = new System.Drawing.Point(129, 21);
            this.COM_ACQ_IMG1.Name = "COM_ACQ_IMG1";
            this.COM_ACQ_IMG1.Size = new System.Drawing.Size(26, 23);
            this.COM_ACQ_IMG1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.COM_ACQ_IMG1.TabIndex = 7;
            this.COM_ACQ_IMG1.TabStop = false;
            // 
            // COM_RTC_IMG
            // 
            this.COM_RTC_IMG.BackColor = System.Drawing.Color.Transparent;
            this.COM_RTC_IMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.COM_RTC_IMG.Location = new System.Drawing.Point(64, 21);
            this.COM_RTC_IMG.Name = "COM_RTC_IMG";
            this.COM_RTC_IMG.Size = new System.Drawing.Size(26, 23);
            this.COM_RTC_IMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.COM_RTC_IMG.TabIndex = 6;
            this.COM_RTC_IMG.TabStop = false;
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label135.Location = new System.Drawing.Point(142, 3);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(110, 20);
            this.label135.TabIndex = 3;
            this.label135.Text = "Acquisition";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label134.Location = new System.Drawing.Point(61, 3);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(49, 20);
            this.label134.TabIndex = 1;
            this.label134.Text = "RTC";
            // 
            // CMROM_SPLINE_RADIO
            // 
            this.CMROM_SPLINE_RADIO.AutoSize = true;
            this.CMROM_SPLINE_RADIO.Location = new System.Drawing.Point(50, 45);
            this.CMROM_SPLINE_RADIO.Name = "CMROM_SPLINE_RADIO";
            this.CMROM_SPLINE_RADIO.Size = new System.Drawing.Size(169, 19);
            this.CMROM_SPLINE_RADIO.TabIndex = 4;
            this.CMROM_SPLINE_RADIO.TabStop = true;
            this.CMROM_SPLINE_RADIO.Text = "CatmullRom 보간법";
            this.CMROM_SPLINE_RADIO.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1663, 639);
            this.Controls.Add(this.COM_PANEL);
            this.Controls.Add(this.ANA_JIG_TEST_TAB);
            this.Controls.Add(this.debug_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "MainForm";
            this.Text = "Analog Jig Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPaint);
            this.AFE_MAP_TAB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AFE_REGIST_MAP_GRID)).EndInit();
            this.FILE_TAB.ResumeLayout(false);
            this.FILE_COMMON_GROUP.ResumeLayout(false);
            this.FILE_COMMON_GROUP.PerformLayout();
            this.COMPORT_TAB.ResumeLayout(false);
            this.COMPORT_TAB.PerformLayout();
            this.COMPORT_GROUP.ResumeLayout(false);
            this.COMPORT_GROUP.PerformLayout();
            this.HOST_TEST_TAB.ResumeLayout(false);
            this.TEST_INTERFACE_GROUP.ResumeLayout(false);
            this.TEST_INTERFACE_GROUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEST_DELAY_TRACK)).EndInit();
            this.AFE_HOST_GROUP.ResumeLayout(false);
            this.AFE_HOST_GROUP.PerformLayout();
            this.ADC_DIG_SEL_GROUP.ResumeLayout(false);
            this.ADC_DIG_SEL_GROUP.PerformLayout();
            this.ANA_HOST_GROUP.ResumeLayout(false);
            this.ANA_HOST_GROUP.PerformLayout();
            this.ANA_FPGA_SEL_GROUP.ResumeLayout(false);
            this.ANA_FPGA_SEL_GROUP.PerformLayout();
            this.ANA_BOARD_SEL_GROUP.ResumeLayout(false);
            this.ANA_BOARD_SEL_GROUP.PerformLayout();
            this.ACQ_HOST_GROUP.ResumeLayout(false);
            this.ACQ_HOST_GROUP.PerformLayout();
            this.ACQ_FPGA_SEL_GROUP.ResumeLayout(false);
            this.ACQ_FPGA_SEL_GROUP.PerformLayout();
            this.ACQ_BOARD_SEL_GROUP.ResumeLayout(false);
            this.ACQ_BOARD_SEL_GROUP.PerformLayout();
            this.RTC_HOST_GROUP.ResumeLayout(false);
            this.RTC_HOST_GROUP.PerformLayout();
            this.SYS_TEST_TAB.ResumeLayout(false);
            this.SYS_CONFIG_GROUP.ResumeLayout(false);
            this.SYS_CONFIG_GROUP.PerformLayout();
            this.ACQ_REGIST_GROUP.ResumeLayout(false);
            this.ACQ_REGIST_GROUP.PerformLayout();
            this.ANA_CONFIG_GROUP.ResumeLayout(false);
            this.ANA_CONFIG_GROUP.PerformLayout();
            this.TX_PULSE_GROUP.ResumeLayout(false);
            this.TX_PULSE_GROUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TX_PULSE_GRAPH)).EndInit();
            this.ATGC_GROUP.ResumeLayout(false);
            this.ATGC_GROUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TGC_MAX_TRACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC_MIN_TRACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC_GRAPH)).EndInit();
            this.TEST_START_GROUP.ResumeLayout(false);
            this.TEST_START_GROUP.PerformLayout();
            this.RTC_REGIST_GROUP.ResumeLayout(false);
            this.RTC_REGIST_GROUP.PerformLayout();
            this.ANA_JIG_TEST_TAB.ResumeLayout(false);
            this.POWER_SUPPLY_TAB.ResumeLayout(false);
            this.RPC_CTR_GROUP.ResumeLayout(false);
            this.RPC_CTR_GROUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_VTX_TRACK)).EndInit();
            this.RPC_TEST_INTERFACE.ResumeLayout(false);
            this.RPC_TEST_INTERFACE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_WR_DELAY_TRACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_BTN_DELAY_TRACK)).EndInit();
            this.RPC_HELP_GROUP.ResumeLayout(false);
            this.RPC_HELP_GROUP.PerformLayout();
            this.RPC_MONITOR_GROUP.ResumeLayout(false);
            this.RPC_MONITOR_GROUP.PerformLayout();
            this.RPC_SPI_GROUP.ResumeLayout(false);
            this.RPC_SPI_GROUP.PerformLayout();
            this.ACQ_XDMA_TAB.ResumeLayout(false);
            this.ACQ_XDMA_GROUP.ResumeLayout(false);
            this.ACQ_XDMA_GROUP.PerformLayout();
            this.ACQ_PCIE_GROUP.ResumeLayout(false);
            this.ACQ_PCIE_GROUP.PerformLayout();
            this.US_SCAN_TAB.ResumeLayout(false);
            this.US_SCAN_TAB.PerformLayout();
            this.US_FPS_DELAY_GROUP.ResumeLayout(false);
            this.US_FPS_DELAY_GROUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.US_FRAME_DELAY_TRACK)).EndInit();
            this.US_SCAN_GROUP.ResumeLayout(false);
            this.US_SCAN_GROUP.PerformLayout();
            this.US_COLOR_GROUP.ResumeLayout(false);
            this.US_COLOR_GROUP.PerformLayout();
            this.US_CF_GROUP.ResumeLayout(false);
            this.US_CF_GROUP.PerformLayout();
            this.US_2D_GROUP.ResumeLayout(false);
            this.US_2D_GROUP.PerformLayout();
            this.TGC_FIG_TAB.ResumeLayout(false);
            this.TGC_TEST_GROUP.ResumeLayout(false);
            this.TGC_TEST_GROUP.PerformLayout();
            this.HERMIT_OP_GROUP.ResumeLayout(false);
            this.HERMIT_OP_GROUP.PerformLayout();
            this.TGC_CURVE_SEL_GROUP.ResumeLayout(false);
            this.TGC_CURVE_SEL_GROUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TGC8_TRACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC7_TRACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC6_TRACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC5_TRACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC4_TRACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC3_TRACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC2_TRACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TGC1_TRACK)).EndInit();
            this.TGC_STATE_STRIP.ResumeLayout(false);
            this.TGC_STATE_STRIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TGC_GRAPH_TEST)).EndInit();
            this.COM_PANEL.ResumeLayout(false);
            this.COM_PANEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COM_RPC_IMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ANA_IMG4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ANA_IMG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ANA_IMG3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ANA_IMG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ACQ_IMG4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ACQ_IMG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ACQ_IMG3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_ACQ_IMG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM_RTC_IMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.IO.Ports.SerialPort serialMaster;
        private System.Windows.Forms.TabPage AFE_MAP_TAB;
        private System.Windows.Forms.TabPage FILE_TAB;
        private System.Windows.Forms.GroupBox FILE_COMMON_GROUP;
        private System.Windows.Forms.Button BtnFolderOpen;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox FILE_LOCATION_TXT;
        private System.Windows.Forms.TextBox FILE_VERSION_TXT;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        public System.Windows.Forms.TabPage COMPORT_TAB;
        public System.Windows.Forms.RichTextBox COMPORT_RICH;
        public System.Windows.Forms.ComboBox SerialComboBox;
        public System.Windows.Forms.GroupBox COMPORT_GROUP;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TabPage HOST_TEST_TAB;
        private System.Windows.Forms.GroupBox TEST_INTERFACE_GROUP;
        private System.Windows.Forms.Button BtnClearTaskLog;
        private System.Windows.Forms.RichTextBox TEST_TASK_LOG;
        private System.Windows.Forms.Label label68;
        public System.Windows.Forms.Label label67;
        private System.Windows.Forms.Button BtnPLLReset;
        private System.Windows.Forms.CheckBox TEST_CONTINUOUS_CHECK;
        private System.Windows.Forms.GroupBox AFE_HOST_GROUP;
        private System.Windows.Forms.Panel ADC_DIG_SEL_GROUP;
        private System.Windows.Forms.RadioButton RBtnAdcVca;
        private System.Windows.Forms.RadioButton RBtnDig;
        public System.Windows.Forms.Label label49;
        private System.Windows.Forms.ComboBox AFE_SEL_COMB;
        public System.Windows.Forms.Label label48;
        public System.Windows.Forms.TextBox AFE_ADDR_TXT;
        private System.Windows.Forms.Button BtnAfeHostRead;
        public System.Windows.Forms.Label label47;
        private System.Windows.Forms.Button BtnAfeHostWrite;
        public System.Windows.Forms.TextBox AFE_WDATA_TXT;
        public System.Windows.Forms.TextBox AFE_RDATA_TXT;
        public System.Windows.Forms.Label label46;
        private System.Windows.Forms.GroupBox ANA_HOST_GROUP;
        private System.Windows.Forms.Button BtnAnaHostRead;
        private System.Windows.Forms.Button BtnAnaHostWrite;
        public System.Windows.Forms.TextBox ANA_RDATA_TXT;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox ANA_WDATA_TXT;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox ANA_ADDR_TXT;
        public System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox ACQ_HOST_GROUP;
        private System.Windows.Forms.RadioButton RBtnAcqFpga2;
        private System.Windows.Forms.RadioButton RBtnAcqFpga1;
        private System.Windows.Forms.Button BtnAcqHostRead;
        private System.Windows.Forms.Button BtnAcqHostWrite;
        public System.Windows.Forms.TextBox ACQ_RDATA_TXT;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox ACQ_WDATA_TXT;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox ACQ_ADDR_TXT;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox RTC_HOST_GROUP;
        private System.Windows.Forms.Button BtnRtcHostRead;
        private System.Windows.Forms.Button BtnRtcHostWrite;
        public System.Windows.Forms.TextBox RTC_RDATA_TXT;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox RTC_WDATA_TXT;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox RTC_ADDR_TXT;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TabPage SYS_TEST_TAB;
        public System.Windows.Forms.GroupBox SYS_CONFIG_GROUP;
        public System.Windows.Forms.TextBox SYS_CHANNEL_TXT;
        public System.Windows.Forms.Label SYS_CHANNEL_LABEL;
        public System.Windows.Forms.TextBox SYS_TX_PULSE_BURST_TXT;
        public System.Windows.Forms.Label SYS_TX_PULSE_BURST_LABEL;
        public System.Windows.Forms.TextBox SYS_STEER_ANGLE_TXT;
        public System.Windows.Forms.Label SYS_STEER_ANGLE_LABEL;
        public System.Windows.Forms.TextBox SYS_TX_FREQ_TXT;
        public System.Windows.Forms.Label SYS_TX_FREQ_LABEL;
        public System.Windows.Forms.TextBox SYS_PRF_COUNT_TXT;
        public System.Windows.Forms.Label SYS_PRF_COUNT_LABEL;
        public System.Windows.Forms.TextBox SYS_FRAME_COUNT_TXT;
        public System.Windows.Forms.Label SYS_FRAME_COUNT_LABEL;
        public System.Windows.Forms.TextBox SYS_VIEW_DEPTH_TXT;
        public System.Windows.Forms.Label SYS_VIEW_DEPTH_LABEL;
        public System.Windows.Forms.GroupBox ACQ_REGIST_GROUP;
        private System.Windows.Forms.ComboBox ACQ_TEST_PATTERN_COMB;
        private System.Windows.Forms.Button ACQ_BtnPlot;
        private System.Windows.Forms.CheckBox ACQ_TEST_PATTERN_CHECK;
        public System.Windows.Forms.TextBox C_R_ACQ_RX_LENGTH;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox C_R_ACQ_RX_START;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.GroupBox ANA_CONFIG_GROUP;
        public System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox ANA_MAX14808_CC_COMB;
        public System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox ANA_MAX14808_MODE_COMB;
        private System.Windows.Forms.CheckBox ANA_AFE_PATTERN_CHECK;
        public System.Windows.Forms.GroupBox TX_PULSE_GROUP;
        private System.Windows.Forms.CheckBox TX_PULSE_MASK_CHECK;
        public System.Windows.Forms.Label label44;
        public System.Windows.Forms.TextBox C_R_TX_B_TX_PS7;
        public System.Windows.Forms.TextBox C_R_TX_B_TX_PS6;
        public System.Windows.Forms.TextBox C_R_TX_B_TX_PS5;
        public System.Windows.Forms.TextBox C_R_TX_B_TX_PS4;
        public System.Windows.Forms.TextBox C_R_TX_B_TX_PS3;
        public System.Windows.Forms.TextBox C_R_TX_B_TX_PS2;
        public System.Windows.Forms.TextBox C_R_TX_B_TX_PS1;
        public System.Windows.Forms.TextBox C_R_TX_B_TX_PS0;
        public System.Windows.Forms.TextBox C_R_TX_B_TX_PC;
        public System.Windows.Forms.Label label40;
        public System.Windows.Forms.Label label41;
        public System.Windows.Forms.Label label42;
        public System.Windows.Forms.Label label43;
        public System.Windows.Forms.Label label38;
        public System.Windows.Forms.Label label39;
        public System.Windows.Forms.Label label37;
        public System.Windows.Forms.Label label36;
        public System.Windows.Forms.Label label35;
        private System.Windows.Forms.RichTextBox TX_DELAY_RICHTXT;
        private System.Windows.Forms.DataVisualization.Charting.Chart TX_PULSE_GRAPH;
        public System.Windows.Forms.GroupBox ATGC_GROUP;
        public System.Windows.Forms.TextBox ATGC_MAX_DEPTH;
        public System.Windows.Forms.TextBox ATGC_MAX;
        public System.Windows.Forms.Label label23;
        private System.Windows.Forms.TrackBar TGC_MAX_TRACK;
        public System.Windows.Forms.TextBox ATGC_MIN_DEPTH;
        public System.Windows.Forms.TextBox ATGC_MIN;
        public System.Windows.Forms.Label label22;
        private System.Windows.Forms.TrackBar TGC_MIN_TRACK;
        private System.Windows.Forms.DataVisualization.Charting.Chart TGC_GRAPH;
        public System.Windows.Forms.GroupBox TEST_START_GROUP;
        public System.Windows.Forms.Button BtnRfDataRead;
        public System.Windows.Forms.Button BtnTestDone;
        public System.Windows.Forms.Button BtnSystemTestStart;
        public System.Windows.Forms.RadioButton RBtnNCon;
        public System.Windows.Forms.RadioButton RBtnCon;
        public System.Windows.Forms.GroupBox RTC_REGIST_GROUP;
        public System.Windows.Forms.TextBox C_R_RTC_TGC_INCR;
        public System.Windows.Forms.Label label32;
        public System.Windows.Forms.TextBox C_R_RTC_TGC_MAX;
        public System.Windows.Forms.Label label31;
        public System.Windows.Forms.TextBox C_R_RTC_TGC_MIN_COUNT;
        public System.Windows.Forms.Label label30;
        public System.Windows.Forms.TextBox C_R_RTC_TGC_MIN;
        public System.Windows.Forms.Label label29;
        public System.Windows.Forms.TextBox C_R_RTC_TGC_START;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.TextBox C_R_RTC_TGC_CLOCK_MASK;
        public System.Windows.Forms.Label label27;
        public System.Windows.Forms.TextBox C_R_RTC_TGC_CTRL3;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.TextBox C_R_RTC_TGC_SLEEP;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.TextBox C_R_RTC_TGC_MODE;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.TextBox C_R_RTC_OFN_DUMMY;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox C_R_RTC_OFN_COUNT;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox C_R_RTC_PRF_COUNT;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox C_R_RTC_PRF_L_LENGTH;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox C_R_RTC_PRF_H_LENGTH;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabControl ANA_JIG_TEST_TAB;
        public System.Windows.Forms.TextBox TEST_DELAY_TXT;
        public System.Windows.Forms.Label label55;
        private System.Windows.Forms.DataGridView AFE_REGIST_MAP_GRID;
        private System.Windows.Forms.TabPage TGC_FIG_TAB;
        private System.Windows.Forms.GroupBox TGC_TEST_GROUP;
        private System.Windows.Forms.DataVisualization.Charting.Chart TGC_GRAPH_TEST;
        private System.Windows.Forms.Button BtnClearOutBuffer;
        private System.Windows.Forms.Button BtnClearInBuffer;
        public System.Windows.Forms.TextBox debug_text;
        private System.Windows.Forms.TabPage US_SCAN_TAB;
        public System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.GroupBox US_FPS_DELAY_GROUP;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.TrackBar US_FRAME_DELAY_TRACK;
        private System.Windows.Forms.Panel US_FRAME;
        private System.Windows.Forms.Button BtnScanStart;
        private System.Windows.Forms.GroupBox US_SCAN_GROUP;
        private System.Windows.Forms.RadioButton RANDOM_RADIO;
        private System.Windows.Forms.RadioButton SIMUL_RADIO;
        private System.Windows.Forms.RadioButton SCANNER_RADIO;
        private System.Windows.Forms.GroupBox US_COLOR_GROUP;
        private System.Windows.Forms.RadioButton PA_MODE_RADIO;
        private System.Windows.Forms.RadioButton US_MODE_RADIO;
        private System.Windows.Forms.GroupBox US_CF_GROUP;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.GroupBox US_2D_GROUP;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.RadioButton RBtnAcqBoard2;
        private System.Windows.Forms.RadioButton RBtnAcqBoard1;
        private System.Windows.Forms.GroupBox ACQ_BOARD_SEL_GROUP;
        private System.Windows.Forms.GroupBox ACQ_FPGA_SEL_GROUP;
        private System.Windows.Forms.GroupBox ANA_FPGA_SEL_GROUP;
        private System.Windows.Forms.RadioButton RBtnAnaFpga2;
        private System.Windows.Forms.RadioButton RBtnAnaFpga1;
        private System.Windows.Forms.GroupBox ANA_BOARD_SEL_GROUP;
        private System.Windows.Forms.RadioButton RBtnAnaBoard2;
        private System.Windows.Forms.RadioButton RBtnAnaBoard1;
        private System.Windows.Forms.TextBox AFE_SEL_FPGA;
        private System.Windows.Forms.TextBox ANA_SEL_FPGA;
        private System.Windows.Forms.TextBox ACQ_SEL_FPGA;
        private System.Windows.Forms.TabPage ACQ_XDMA_TAB;
        private System.Windows.Forms.GroupBox ACQ_XDMA_GROUP;
        private System.Windows.Forms.Button BtnAcqXdmaRead;
        private System.Windows.Forms.Button BtnAcqXdmaWrite;
        public System.Windows.Forms.TextBox ACQ_XDMA_RDATA_TXT;
        public System.Windows.Forms.Label label94;
        public System.Windows.Forms.TextBox ACQ_XDMA_WDATA_TXT;
        public System.Windows.Forms.Label label97;
        public System.Windows.Forms.TextBox ACQ_XDMA_ADDR_TXT;
        public System.Windows.Forms.Label label98;
        public System.Windows.Forms.GroupBox ACQ_PCIE_GROUP;
        public System.Windows.Forms.ComboBox ACQ_FPGA_SEL_COMB;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label89;
        public System.Windows.Forms.CheckBox ACQ_XDMA_EN_CHECK;
        private System.Windows.Forms.TabPage POWER_SUPPLY_TAB;
        private System.Windows.Forms.GroupBox RPC_SPI_GROUP;
        private System.Windows.Forms.Button BtnRpcRead;
        private System.Windows.Forms.Button BtnRpcWrite;
        public System.Windows.Forms.TextBox SPI_COMMAND_TXT;
        public System.Windows.Forms.Label label99;
        public System.Windows.Forms.TextBox SPI_HDATA_TXT;
        public System.Windows.Forms.Label label100;
        public System.Windows.Forms.TextBox SPI_LDATA_TXT;
        public System.Windows.Forms.Label label101;
        private System.Windows.Forms.GroupBox RPC_MONITOR_GROUP;
        public System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label FILE_VERSION_LABEL;
        private System.Windows.Forms.GroupBox RPC_HELP_GROUP;
        public System.Windows.Forms.Label label103;
        public System.Windows.Forms.Label label111;
        public System.Windows.Forms.Label label110;
        public System.Windows.Forms.Label label109;
        public System.Windows.Forms.Label label108;
        public System.Windows.Forms.Label label107;
        public System.Windows.Forms.Label label106;
        public System.Windows.Forms.Label label105;
        public System.Windows.Forms.Label label112;
        public System.Windows.Forms.Label label113;
        public System.Windows.Forms.Label label114;
        public System.Windows.Forms.Label label115;
        public System.Windows.Forms.Label label116;
        public System.Windows.Forms.Label label117;
        public System.Windows.Forms.Label label118;
        public System.Windows.Forms.TextBox SPI_RDATA_TXT;
        public System.Windows.Forms.Label label119;
        private System.Windows.Forms.Button BtnTestRegistSearch;
        private System.Windows.Forms.ComboBox TEST_REGIST_AREA_COMB;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.TextBox TEST_REGIST_ADDR_TXT;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.TextBox TEST_REGIST_VALUE_TXT;
        private System.Windows.Forms.ComboBox TEST_REGIST_NAME_COMB;
        private System.Windows.Forms.TrackBar TGC8_TRACK;
        private System.Windows.Forms.TrackBar TGC7_TRACK;
        private System.Windows.Forms.TrackBar TGC6_TRACK;
        private System.Windows.Forms.TrackBar TGC5_TRACK;
        private System.Windows.Forms.TrackBar TGC4_TRACK;
        private System.Windows.Forms.TrackBar TGC3_TRACK;
        private System.Windows.Forms.TrackBar TGC2_TRACK;
        private System.Windows.Forms.TrackBar TGC1_TRACK;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label45;
        public System.Windows.Forms.Label label84;
        public System.Windows.Forms.Label label33;
        public System.Windows.Forms.Label label34;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox TGC_CURVE_SEL_GROUP;
        private System.Windows.Forms.RadioButton CUBIC_SPLINE_RADIO;
        public System.Windows.Forms.Label label102;
        public System.Windows.Forms.Label label125;
        public System.Windows.Forms.Label label126;
        public System.Windows.Forms.Label label127;
        public System.Windows.Forms.Label label128;
        public System.Windows.Forms.Label label129;
        public System.Windows.Forms.Label label130;
        public System.Windows.Forms.Label label131;
        public System.Windows.Forms.Label TGC8_DEPTH;
        public System.Windows.Forms.Label TGC7_DEPTH;
        public System.Windows.Forms.Label TGC6_DEPTH;
        public System.Windows.Forms.Label TGC5_DEPTH;
        public System.Windows.Forms.Label TGC4_DEPTH;
        public System.Windows.Forms.Label TGC3_DEPTH;
        public System.Windows.Forms.Label TGC2_DEPTH;
        public System.Windows.Forms.Label TGC1_DEPTH;
        public System.Windows.Forms.Label TGC8_GAIN;
        public System.Windows.Forms.Label TGC7_GAIN;
        public System.Windows.Forms.Label TGC6_GAIN;
        public System.Windows.Forms.Label TGC5_GAIN;
        public System.Windows.Forms.Label TGC4_GAIN;
        public System.Windows.Forms.Label TGC3_GAIN;
        public System.Windows.Forms.Label TGC2_GAIN;
        public System.Windows.Forms.Label TGC1_GAIN;
        public System.Windows.Forms.Label label140;
        public System.Windows.Forms.Label label141;
        public System.Windows.Forms.Label label142;
        public System.Windows.Forms.Label label143;
        public System.Windows.Forms.Label label144;
        public System.Windows.Forms.Label label145;
        public System.Windows.Forms.Label label146;
        public System.Windows.Forms.Label label147;
        private System.Windows.Forms.RadioButton CSHARP_CURVE_RADIO;
        private System.Windows.Forms.RadioButton HERMIT_SPLINE_RADIO;
        private System.Windows.Forms.GroupBox HERMIT_OP_GROUP;
        private System.Windows.Forms.RadioButton M_OP_FINIT_CHECK;
        private System.Windows.Forms.RadioButton M_OP_MONO_CHECK;
        public System.Windows.Forms.TrackBar TEST_DELAY_TRACK;
        private System.Windows.Forms.GroupBox RPC_TEST_INTERFACE;
        public System.Windows.Forms.Label label137;
        public System.Windows.Forms.TextBox RPC_BTN_DELAY_TXT;
        public System.Windows.Forms.TrackBar RPC_BTN_DELAY_TRACK;
        public System.Windows.Forms.Label label139;
        private System.Windows.Forms.CheckBox SPI_CONTINUOUS_CHECK;
        public System.Windows.Forms.Label label132;
        public System.Windows.Forms.TextBox RPC_WR_DELAY_TXT;
        public System.Windows.Forms.TrackBar RPC_WR_DELAY_TRACK;
        public System.Windows.Forms.Label label133;
        private System.Windows.Forms.Label RPC_BTN_PROGRESS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel COM_PANEL;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.PictureBox COM_ACQ_IMG1;
        private System.Windows.Forms.PictureBox COM_RTC_IMG;
        private System.Windows.Forms.PictureBox COM_ACQ_IMG3;
        private System.Windows.Forms.PictureBox COM_ACQ_IMG4;
        private System.Windows.Forms.PictureBox COM_ACQ_IMG2;
        private System.Windows.Forms.PictureBox COM_ANA_IMG4;
        private System.Windows.Forms.PictureBox COM_ANA_IMG2;
        private System.Windows.Forms.PictureBox COM_ANA_IMG3;
        private System.Windows.Forms.PictureBox COM_ANA_IMG1;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.PictureBox COM_RPC_IMG;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.Button btnPchipPlot;
        private System.Windows.Forms.Button BtnSplinePlot;
        private System.Windows.Forms.Button BtnClearTestPlot;
        private System.Windows.Forms.Label TGC_ERROR_VALUE;
        private System.Windows.Forms.Label TGC_ERROR_NAME;
        private System.Windows.Forms.StatusStrip TGC_STATE_STRIP;
        private System.Windows.Forms.ToolStripStatusLabel TGC_XY_POINT_LABEL;
        private System.Windows.Forms.ToolStripStatusLabel TGC_CURVE_POINT_LABEL;
        private System.Windows.Forms.GroupBox RPC_CTR_GROUP;
        public System.Windows.Forms.Label label136;
        public System.Windows.Forms.TrackBar RPC_VTX_TRACK;
        public System.Windows.Forms.Label label152;
        public System.Windows.Forms.TextBox RPC_VTX_TEXT;
        public System.Windows.Forms.Label label151;
        private System.Windows.Forms.Button btnVTXOff;
        private System.Windows.Forms.Button btnVTXOn;
        private System.Windows.Forms.Button btnGDPOff;
        private System.Windows.Forms.Button btnGDPOn;
        public System.Windows.Forms.Label label153;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton CMROM_SPLINE_RADIO;
    }
}

