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
        }

        // Buttons and Input field

        private void CalculateFuelButton_Click(object sender, EventArgs e)
        {
            Label_FuelUsageHeader.Text = NumberField_AvgFuelUsage.Value.ToString();
        }

        private void AvgFuelUsageInputField_ValueChanged(object sender, EventArgs e)
        {
        }

        // ---------------------------------------------------------------

        #region Custom Methods and Functions

        private void CalculateFuel(float FuelPerLap, float RaceLengthInMinutes, float AvgLapTime)
        {

        }

        #endregion

        #region Useless

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        #endregion
    }
}
