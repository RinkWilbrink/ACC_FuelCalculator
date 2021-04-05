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
            int LapCount = (int)Math.Round((RaceLengthInSeconds / AvgLapTimeSec) + 0.5f, 0);
            label_LapsValue.Text = string.Format("{0}", LapCount);

            int LitersNecesairyForRace = (int)Math.Round((LapCount * FuelPerLap) + 0.5f, 0);
            label_FuelNeededValue.Text = string.Format("{0}", LitersNecesairyForRace);
        }

        #endregion

        private void AvgFuelUsageInputField_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumberField_LapTimeMinutes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DropBox_SelectedCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(DropBox_SelectedCar.Items.Count > 1)
            //{
            //    for (int i = 0; i < DropBox_SelectedCar.Items.Count; i++)
            //    {
            //        DropBox_SelectedCar.SetItemChecked(i, false);
            //    }
            //}

            //for (int ix = 0; ix < DropBox_SelectedCar.Items.Count; ++ix)
            //{
            //    if (ix != e.Index) DropBox_SelectedCar.SetItemChecked(ix, false);
            //}

            //if (e.NewValue == CheckState.Checked && DropBox_SelectedCar.CheckedItems.Count > 0)
            //{
            //    DropBox_SelectedCar.ItemCheck -= DropBox_SelectedCar_SelectedIndexChanged;
            //    DropBox_SelectedCar.SetItemChecked(DropBox_SelectedCar.CheckedIndices[0], false);
            //    DropBox_SelectedCar.ItemCheck += DropBox_SelectedCar_SelectedIndexChanged;
            //}
        }
    }
}
