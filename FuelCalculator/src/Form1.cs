using System;
using System.Windows.Forms;

namespace ACC_FuelCalculator
{
    public partial class ACC_FC_Window : Form
    {
        // Variables

        public ACC_FC_Window()
        {
            InitializeComponent();
        }

        // on Load / Start Functions
        private void Form1_Load(object sender, EventArgs e)
        {
            NumberField_AvgFuelUsage.DecimalPlaces = 2;
            NumberField_AvgFuelUsage.Increment = 0.01M;

            NumberField_LapTimeSeconds.Minimum = 0;
            NumberField_LapTimeSeconds.Maximum = 59;
            //
            NumberField_LapTimeMinutes.Minimum = 0;
            NumberField_LapTimeMinutes.Maximum = 10;

            NumberField_RaceLengthInMinutes.Maximum = 9999;

            NumberField_TotalFuelSize.Minimum = 10;
            NumberField_TotalFuelSize.Maximum = 130;
        }

        private void CalculateFuelButton_Click(object sender, EventArgs e)
        {
            float FuelPerLap = (float)NumberField_AvgFuelUsage.Value;
            float RaceLenghtToSeconds = (float)NumberField_RaceLengthInMinutes.Value * 60;
            float laptimeInSeconds = ((float)NumberField_LapTimeMinutes.Value * 60) + (float)NumberField_LapTimeSeconds.Value;

            CalculateFuel(FuelPerLap, RaceLenghtToSeconds, laptimeInSeconds);
        }

        private void CalculateFuel(float FuelPerLap, float RaceLengthInSeconds, float AvgLapTimeSec)
        {
            int LapCount = (int)Math.Round((RaceLengthInSeconds / AvgLapTimeSec) + 0.5f, 0);
            Label_LapsValue.Text = string.Format("{0}", LapCount);

            int LitersNecesairyForRace = (int)Math.Round((LapCount * FuelPerLap) + 0.5f, 0);
            Label_FuelNeededValue.Text = string.Format("{0}", LitersNecesairyForRace);

            float refuelCount = (float)Math.Round((float)NumberField_TotalFuelSize.Value / FuelPerLap, 1);

            Label_PitstopsNeededValue.Text = string.Format("{0}", Math.Round(((float)LapCount / (float)refuelCount) - 0.5f, 0));
        }

        bool AvgFuelUsage_selectByMouse = false;
        private void NumberField_AvgFuelUsage_Enter(object sender, EventArgs e)
        {
            NumericUpDown curBox = sender as NumericUpDown;
            curBox.Select();
            curBox.Select(0, curBox.Text.Length);
            if (MouseButtons == MouseButtons.Left)
            {
                AvgFuelUsage_selectByMouse = true;
            }
        }

        private void NumberField_AvgFuelUsage_MouseDown(object sender, MouseEventArgs e)
        {
            NumericUpDown curBox = sender as NumericUpDown;
            if (AvgFuelUsage_selectByMouse)
            {
                curBox.Select(0, curBox.Text.Length);
                AvgFuelUsage_selectByMouse = false;
            }
        }
    }
}
