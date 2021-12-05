using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDPF
{
    public partial class Form1 : Form
    {
        private SignalChartProcessing signalChartProcessing;
        private SpectreChartProcessing spectreChartProcessing;
        public Form1()
        {
            
            InitializeComponent();
            InitListBox();
            signalChartProcessing = new SignalChartProcessing(chart1, tlpGraphParams, tlpSignalParams);
            spectreChartProcessing = new SpectreChartProcessing(chart2, signalChartProcessing);
        }

        private void InitListBox()
        {
            List<Signal> signals = Signal.GetDefaultSignals();
            foreach (var signal in signals) lbSignals.Items.Add(signal);
        }

        private void lbSignals_SelectedIndexChanged(object sender, EventArgs e)
        {
            signalChartProcessing.SetSignal((Signal)lbSignals.SelectedItem);
            signalChartProcessing.Show();
        }

        private void cSignal_Click(object sender, EventArgs e)
        {
            signalChartProcessing.Show();
        }

        private void bDFTA_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            spectreChartProcessing.ShowAmplitudeSpectre();
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            lTS.Text = ts.TotalSeconds.ToString();
        }

        private void bDFTP_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            spectreChartProcessing.ShowPhaseSpectre();
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            lTS.Text = ts.TotalSeconds.ToString();
        }

        private void bFTFA_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            spectreChartProcessing.ShowFastAmplitudeSpectre();
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            lTS.Text = ts.TotalSeconds.ToString();
        }



        private void bFFTP_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            spectreChartProcessing.ShowFastPhaseSpectre();
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            lTS.Text = ts.TotalSeconds.ToString();
        }
    }
}
