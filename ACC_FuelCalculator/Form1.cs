using System;
using System.Windows.Forms;

namespace ACC_FuelCalculator
{
    public partial class ACC_FC_Window : Form
    {
        public ACC_FC_Window()
        {
            InitializeComponent();
        }

        // on Load
        private void Form1_Load(object sender, EventArgs e)
        {
            NumberField_AvgFuelUsage.DecimalPlaces = 1;
            NumberField_AvgFuelUsage.Increment = 0.1M;

            NumberField_LapTimeSeconds.Maximum = 59;
            NumberField_LapTimeMinutes.Maximum = 2;
        }

        // Buttons and Input field

        private void CalculateFuelButton_Click(object sender, EventArgs e)
        {
            Label_FuelUsageHeader.Text = NumberField_AvgFuelUsage.Value.ToString();

            float FuelPerLap = (float)NumberField_AvgFuelUsage.Value;
            float RaceLenghtToSeconds = (float)NumberField_RaceLengthInMinutes.Value * 60;
            float laptimeInSeconds = ((float)NumberField_LapTimeMinutes.Value * 60) + (float)NumberField_LapTimeSeconds.Value;

            CalculateFuel(FuelPerLap, RaceLenghtToSeconds, laptimeInSeconds);
        }

        // ---------------------------------------------------------------

        #region Custom Methods and Functions

        private void CalculateFuel(float FuelPerLap, float RaceLengthInSeconds, float AvgLapTimeSec)
        {

        }

        #endregion

        private void AvgFuelUsageInputField_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumberField_LapTimeMinutes_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
