using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments.DAQmx;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace _8ChannelOscilloscope_FiniteSamples
{ 
    public partial class Form1 : Form
    {
        private NationalInstruments.DAQmx.Task myTask; 

        double maxV;
        double minV;
        int sampleRate;
        int numOfChannels;
        int A2D_MAXRATE = 250000;
        decimal MAXTIME = 9;
        int ChanSampleRateMAX;
        AnalogMultiChannelReader reader;
        double[,] data;

        string[] voltageRanges = { "+/- 10V", "+/- 5V", "+/- 1V", "+/- 0.2V" };
        string[] termConfig = { "NRSE", "RSE", "Differential" };


        public Form1()
        {
            InitializeComponent();
            NumUD_HighChan.Minimum = 0;
            NumUD_LowChan.Minimum = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            //Try Catch #1 is ONLY used for chart initialization
            try 
            {
                //Minimum x = 0
                cht_Data.ChartAreas[0].AxisX.Minimum = 0;

                // change font of NUMBERS on x axis
                cht_Data.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Mongolian Baiti", 14, FontStyle.Bold);
                cht_Data.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Mongolian Baiti", 14, FontStyle.Bold);

                //Chart axis titles/fonts
                cht_Data.ChartAreas[0].AxisX.Title = "Time (s)";
                cht_Data.ChartAreas[0].AxisY.Title = "Voltage (V)";
                cht_Data.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Mongolian Baiti", 14, FontStyle.Bold);
                cht_Data.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Mongolian Baiti", 14, FontStyle.Bold);
            }
            catch (Exception ex1) 
            {
            
            }
            try //Setup CBX defaults, items
            {   
                //Sample Rate default value
                NumUD_ChanSampRate.Value = 200;
                NumUD_SampPerChan.Value = 1000;

                //ComboBoxes
                Cbx_Device.DropDownStyle= ComboBoxStyle.DropDownList; //Non-Editable
                Cbx_Device.Items.AddRange(DaqSystem.Local.Devices); //Auto populated cbx with Device names
                if (Cbx_Device.Items.Count > 0) { Cbx_Device.SelectedIndex = 0; }
                Cbx_TerminalConfig.DropDownStyle= ComboBoxStyle.DropDownList; //Non Editable (NRSE/RSE/Differential)
                Cbx_TerminalConfig.Items.AddRange(termConfig);
                if (Cbx_TerminalConfig.Items.Count > 0) { Cbx_TerminalConfig.SelectedIndex = 0; }
                Cbx_VoltageRange.DropDownStyle= ComboBoxStyle.DropDownList; //Non Editable (±0.2 V, ±1 V, ±5 V, ±10 V)
                Cbx_VoltageRange.Items.AddRange(voltageRanges);
                if (Cbx_VoltageRange.Items.Count > 0) { Cbx_VoltageRange.SelectedIndex = 0; }

                //Numeric Drop Down Default values and 
                NumUD_HighChan.Value = 7;
                NumUD_LowChan.Value = 0;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("There was an issue in the form load", ex.Message);
            }
        }

        private void Cbx_Device_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbx_TerminalConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbx_TerminalConfig.SelectedIndex == 2) //0-7 channels if differential
            {
                NumUD_HighChan.Maximum = 7;
                NumUD_LowChan.Maximum = 7;

                if (NumUD_LowChan.Value > NumUD_LowChan.Maximum) //Coerces value for Channels if index is changed
                { NumUD_LowChan.Value = NumUD_LowChan.Maximum; }
                if (NumUD_HighChan.Value > NumUD_HighChan.Maximum) //Coerces value for Channels if index is changed
                { NumUD_HighChan.Value = NumUD_HighChan.Maximum; }
            }
            else // 0-15 channels if not Differential
            {
                NumUD_HighChan.Maximum = 15;
                NumUD_LowChan.Maximum = 15;
            }
        }

        private void Cbx_VoltageRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbx_VoltageRange.SelectedIndex == 0)
            {
                cht_Data.ChartAreas[0].AxisY.Maximum = 10;
                cht_Data.ChartAreas[0].AxisY.Minimum = -10;
            }
            if (Cbx_VoltageRange.SelectedIndex == 1)
            {
                cht_Data.ChartAreas[0].AxisY.Maximum = 5;
                cht_Data.ChartAreas[0].AxisY.Minimum = -5;
            }
            if (Cbx_VoltageRange.SelectedIndex == 2)
            {
                cht_Data.ChartAreas[0].AxisY.Maximum = 1;
                cht_Data.ChartAreas[0].AxisY.Minimum = -1;
            }
            if (Cbx_VoltageRange.SelectedIndex == 3)
            {
                cht_Data.ChartAreas[0].AxisY.Maximum = 0.2;
                cht_Data.ChartAreas[0].AxisY.Minimum = -0.2;
            }
        }

        private void NumUD_ChanSampRate_ValueChanged(object sender, EventArgs e)
        {
            AD_SampleRate();
            AcquisitionTime();
        }

        private void NumUD_SampPerChan_ValueChanged(object sender, EventArgs e)
        {
            AcquisitionTime();
        }

        private void NumUD_LowChan_ValueChanged(object sender, EventArgs e)
        {
            if (NumUD_LowChan.Value > NumUD_HighChan.Value) //Coerces value for Channels if index is changed
            { NumUD_LowChan.Value = NumUD_HighChan.Value; }

            if (Cbx_TerminalConfig.SelectedIndex == 2) //0-7 channels if differential
            {
                NumUD_LowChan.Maximum = 7;
                if (NumUD_LowChan.Value > NumUD_LowChan.Maximum) //Coerces value for Channels if index is changed
                { NumUD_LowChan.Value = NumUD_LowChan.Maximum; }
            }
            else // 0-15 channels if not Differential
            {
                NumUD_LowChan.Maximum = 15;
            }
            AD_SampleRate();
        }

        private void NumUD_HighChan_ValueChanged(object sender, EventArgs e)
        {
            if (NumUD_LowChan.Value > NumUD_HighChan.Value) //Coercing value (Low NOT greater than High)
            { NumUD_LowChan.Value = NumUD_HighChan.Value; }

            if (Cbx_TerminalConfig.SelectedIndex == 2) //0-7 channels if differential
            {
                NumUD_HighChan.Maximum = 7;
                if (NumUD_HighChan.Value > NumUD_HighChan.Maximum) //Coerces value for Channels if index is changed
                { NumUD_HighChan.Value = NumUD_HighChan.Maximum; }
            }
            else // 0-15 channels if not Differential
            {
                NumUD_HighChan.Maximum = 15;
            }

            AD_SampleRate();
        }

        private void btn_Acquire_Click(object sender, EventArgs e)
        {
            DisableControls();

            try
            {
                int highChan = (int)NumUD_HighChan.Value;
                int lowChan = (int)NumUD_LowChan.Value;
                string DeviceName = Cbx_Device.SelectedItem.ToString();

                //Setting max and min values required for AIChannel configuration
                if (Cbx_VoltageRange.SelectedIndex == 0) { maxV = 10; minV = -10; }
                if (Cbx_VoltageRange.SelectedIndex == 1) { maxV = 5; minV = -5; }
                if (Cbx_VoltageRange.SelectedIndex == 2) { maxV = 1; minV = -1; }
                if (Cbx_VoltageRange.SelectedIndex == 3) { maxV = 0.2; minV = -0.2; }

                myTask = new NationalInstruments.DAQmx.Task();

                //Looping through low-high channels to create channels
                for (int i = lowChan; i <= highChan; i++)
                {
                    string DevChan = $"{DeviceName}/ai{i}";
                    if (Cbx_TerminalConfig.SelectedIndex == 0) { myTask.AIChannels.CreateVoltageChannel(DevChan, "", AITerminalConfiguration.Nrse, minV, maxV, AIVoltageUnits.Volts); }
                    if (Cbx_TerminalConfig.SelectedIndex == 1) { myTask.AIChannels.CreateVoltageChannel(DevChan, "", AITerminalConfiguration.Rse, minV, maxV, AIVoltageUnits.Volts); }
                    if (Cbx_TerminalConfig.SelectedIndex == 2) { myTask.AIChannels.CreateVoltageChannel(DevChan, "", AITerminalConfiguration.Differential, minV, maxV, AIVoltageUnits.Volts); }
                }

                //Timing Specs
                myTask.Timing.ConfigureSampleClock("", (Double)NumUD_ChanSampRate.Value, SampleClockActiveEdge.Rising, SampleQuantityMode.FiniteSamples, (int)NumUD_SampPerChan.Value);

                //Verify the task (Needed for timing)
                //myTask.Control(TaskAction.Verify);
                reader = new AnalogMultiChannelReader(myTask.Stream);
                reader.BeginReadMultiSample((int)NumUD_SampPerChan.Value, new AsyncCallback(callback), null);

            }
            catch (Exception ex)
            {
                // MessageBox.Show("There is an issue acquiring data", ex.Message);
            }

        }

        private void callback(IAsyncResult ar)
        {
            data = reader.EndReadMultiSample(ar);
            plotdata();
            EnableControls();

            //Dispose of task after each plotting
            myTask?.Dispose();
        }

        private void btn_ClearChart_Click(object sender, EventArgs e)
        {
            //cht_Data.Series.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myTask != null) //Dispose of task after each plotting
            { myTask.Dispose(); }
        }

        private void AD_SampleRate()
        { 
            numOfChannels = ((int)NumUD_HighChan.Value - (int)NumUD_LowChan.Value) + 1;
            int maxSampleRate = A2D_MAXRATE / numOfChannels;
            sampleRate = numOfChannels * (int)NumUD_ChanSampRate.Value;

            if (sampleRate > maxSampleRate)
            {
                NumUD_ChanSampRate.Value = (decimal)maxSampleRate;
                MessageBox.Show($"Please input a value for sample rate less than {maxSampleRate}.");
            }
            lbl_ADrate.Text = sampleRate.ToString();
        }

        private void AcquisitionTime() 
        {

            decimal Time;
            ChanSampleRateMAX = (int)(NumUD_SampPerChan.Value / MAXTIME);
            int SampPerChanMAX = (int)(MAXTIME * NumUD_ChanSampRate.Value);
            Time = NumUD_SampPerChan.Value / NumUD_ChanSampRate.Value;

            if (Time > MAXTIME)
            {   NumUD_SampPerChan.Value = SampPerChanMAX;
                NumUD_ChanSampRate.Value = (decimal)ChanSampleRateMAX;
               //MessageBox.Show($"Please input a value for the Channel Sample rate that is less than {ChanSampleRateMAX}. Time cannot exceed 9 seconds");
            }

            else
            { lbl_AcqTime.Text = Time.ToString(); }
        }

        private void plotdata()
        {
            try
            {
                int rowsChannelsData;
                int colsVoltageData;

                rowsChannelsData = data.GetLength(0); //Gets # of channels
                colsVoltageData = data.GetLength(1); //Gets length of data

                //Add series to chart and set chart types
                for (int j = 0; j < rowsChannelsData; j++)
                {
                    cht_Data.Series.Add("Channel" + j.ToString());
                    cht_Data.Series["Channel" + j.ToString()].ChartType = SeriesChartType.Spline;
                }

                for (int i = 0; i < rowsChannelsData; i++)
                {
                    for (int j = 0; j < colsVoltageData; j++)
                    {
                        double time = j / (double)NumUD_ChanSampRate.Value;
                        cht_Data.Series["Channel" + i.ToString()].Points.AddXY(time, data[i, j]);
                    }
                }
            }
            catch (Exception ex2)
            { MessageBox.Show("There was an issue plotting new data. Clear the chart."); }
        }

        private void DisableControls()
        {
            Cbx_Device.Enabled = false;
            Cbx_TerminalConfig.Enabled = false;
            Cbx_VoltageRange.Enabled = false;
            NumUD_ChanSampRate.Enabled = false;
            NumUD_SampPerChan.Enabled = false;
            NumUD_HighChan.Enabled = false;
            NumUD_LowChan.Enabled = false;  
            btn_Acquire.Enabled = false;
            btn_ClearChart.Enabled = false;
        }
        private void EnableControls()
        {
            Cbx_Device.Enabled = true;
            Cbx_TerminalConfig.Enabled = true;
            Cbx_VoltageRange.Enabled = true;
            NumUD_ChanSampRate.Enabled = true;
            NumUD_SampPerChan.Enabled = true;
            NumUD_HighChan.Enabled = true;
            NumUD_LowChan.Enabled = true;
            btn_Acquire.Enabled = true;
            btn_ClearChart.Enabled = true;
        }

        private void mnu_Acquire_Click(object sender, EventArgs e)
        {
            DisableControls();

            try
            {
                int highChan = (int)NumUD_HighChan.Value;
                int lowChan = (int)NumUD_LowChan.Value;
                string DeviceName = Cbx_Device.SelectedItem.ToString();

                //Setting max and min values required for AIChannel configuration
                if (Cbx_VoltageRange.SelectedIndex == 0) { maxV = 10; minV = -10; }
                if (Cbx_VoltageRange.SelectedIndex == 1) { maxV = 5; minV = -5; }
                if (Cbx_VoltageRange.SelectedIndex == 2) { maxV = 1; minV = -1; }
                if (Cbx_VoltageRange.SelectedIndex == 3) { maxV = 0.2; minV = -0.2; }

                myTask = new NationalInstruments.DAQmx.Task();

                //Looping through low-high channels to create channels
                for (int i = lowChan; i <= highChan; i++)
                {
                    string DevChan = $"{DeviceName}/ai{i}";
                    if (Cbx_TerminalConfig.SelectedIndex == 0) 
                    { myTask.AIChannels.CreateVoltageChannel(DevChan, "", AITerminalConfiguration.Nrse, minV, maxV, AIVoltageUnits.Volts); }
                    if (Cbx_TerminalConfig.SelectedIndex == 1) 
                    { myTask.AIChannels.CreateVoltageChannel(DevChan, "", AITerminalConfiguration.Rse, minV, maxV, AIVoltageUnits.Volts); }
                    if (Cbx_TerminalConfig.SelectedIndex == 2) 
                    { myTask.AIChannels.CreateVoltageChannel(DevChan, "", AITerminalConfiguration.Differential, minV, maxV, AIVoltageUnits.Volts); }
                }

                //Timing Specs
                myTask.Timing.ConfigureSampleClock("", (Double)NumUD_ChanSampRate.Value, SampleClockActiveEdge.Rising, 
                    SampleQuantityMode.FiniteSamples, (int)NumUD_SampPerChan.Value);
                reader = new AnalogMultiChannelReader(myTask.Stream);
                reader.BeginReadMultiSample((int)NumUD_SampPerChan.Value, new AsyncCallback(callback), null);

            }
            catch (Exception ex)
            {
                // MessageBox.Show("There is an issue acquiring data", ex.Message);
            }
        }

        private void mnu_Clear_Click(object sender, EventArgs e)
        {
            cht_Data.Series.Clear();
        }

        private void mnu_Help_Click(object sender, EventArgs e)
        {

        }
    }
}
