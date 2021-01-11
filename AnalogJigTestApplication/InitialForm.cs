using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogJigTestApplication
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
            progressBar.Step = 10;
            progressBar.Style = ProgressBarStyle.Continuous;
            progressLabel.Text = "Loading...";
        }

        public void CalculateProcessBar(string labelData, int accPercent)
        {
            progressLabel.Text = labelData;
            progressLabel.Update();
            progressBar.Step = accPercent;
            progressBar.PerformStep();
        }
        
    }

    
}
