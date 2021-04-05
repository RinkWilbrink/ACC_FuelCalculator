﻿using System;
using System.Windows.Forms;

namespace ACC_FuelCalculator
{
    public enum CarSelection
    {
        // Aston Martin
        Aston_Martin_V12_Vantage_GT3_2013 = 0, Aston_Martin_V8_Vantage_GT3_2019 = 1,
        // Audi
        Audi_R8_LMS_2015 = 2, Audi_R8_LMS_Evo_2019 = 3,
        // Bentley
        Bentley_Continental_GT3_2015 = 4, Bentley_Continental_GT3_2018 = 5,
        // BMW
        BMW_M6_GT3_2017 = 6,
        // Jaguar
        Emil_Frey_Jaguar_G3_2012 = 7,
        // Ferrari
        Ferrari_488_GT3_2018 = 8, Ferrari_488_GT3_Evo_2020 = 9,
        // Honda
        Honda_NSX_GT3_2017 = 10, Honda_NSX_GT3_Evo_2019 = 11,
        // Lamborghini
        Lamborghini_Huracan_GT3_2015 = 12, Lamborghini_Huracan_GT3_Evo_2019 = 13, Lamborghini_Huracan_ST_2015 = 14,
        // Lexus
        Lexus_RC_F_GT3_2016 = 15,
        //McLaren
        McLaren_650S_GT3_2015 = 16, McLaren_720S_GT3_2019 = 17,
        // Mercedes
        Mercedess_AMG_GT3_2015 = 18, Mercedess_AMG_GT3_Evo_2020 = 19,
        // Nissan
        Nissan_GTR_Nismo_GT3_2015 = 20, Nissan_GTR_Nismo_GT3_2018 = 21,
        // Porsche
        Porsche_991_GT3_R_2018 = 22, Porsche_991_II_GT3_Cup_2017 = 23, Porsche_991_II_GT3_R_2019 = 24,
        // Reiter Engineering
        Reiter_Engineering_R_EX_GT3_2017 = 25
    }

    public partial class ACC_FC_Window : Form
    {
        // Variables
        public CarSelection carSelected = 0;
        private readonly int[] carFuelLoadsArray = new int[26]
        {
            // Aston Martin
            132, 120,
            // Audi
            120, 120,
            // Bentley
            132, 132,
            // BMW
            125,
            // Jaguar
            119,
            // Ferrari
            110, 110,
            // Honda
            120, 120,
            // Lamborghini
            102, 120, 120,
            // Lexus
            120,
            //McLaren
            125, 125,
            // Mercedes
            120, 120,
            // Nissan
            132, 132,
            // Porsche
            120, 100, 120,
            // Reiter Engineering
            130
        };

        public ACC_FC_Window()
        {
            InitializeComponent();
        }

        // on Load / Start Functions
        private void Form1_Load(object sender, EventArgs e)
        {
            NumberField_AvgFuelUsage.DecimalPlaces = 1;
            NumberField_AvgFuelUsage.Increment = 0.1M;

            NumberField_LapTimeSeconds.Maximum = 59;
            NumberField_LapTimeMinutes.Maximum = 2;

            listBox_CarSelector.SelectedIndex = 0;
        }

        // ---------------------------------------------------------------

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

            float temp = carFuelLoadsArray[listBox_CarSelector.SelectedIndex];

            int banaan = (int)Math.Round((temp / FuelPerLap) - 0.5f, 0);

            if(banaan > LapCount)
            {
                label_PitstopsNeededValue.Text = string.Format("1");
            }
            else
            {
                label_PitstopsNeededValue.Text = string.Format("0");
            }
            //label_PitstopsNeededValue.Text= string.Format("{0}", banaan);
        }

        #endregion

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label_SelectedCar.Text = string.Format("{0}", listBox_CarSelector.SelectedIndex);

            carSelected = (CarSelection)listBox_CarSelector.SelectedIndex;
        }
    }
}
