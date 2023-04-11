
namespace ACC_FuelCalculator
{
    partial class ACC_FC_Window
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACC_FC_Window));
            this.Button_CalculateFuel = new System.Windows.Forms.Button();
            this.NumberField_TotalFuelSize = new System.Windows.Forms.NumericUpDown();
            this.NumberField_RaceLengthInMinutes = new System.Windows.Forms.NumericUpDown();
            this.NumberField_LapTimeSeconds = new System.Windows.Forms.NumericUpDown();
            this.NumberField_AvgFuelUsage = new System.Windows.Forms.NumericUpDown();
            this.NumberField_LapTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.Label_MaxFuelCap = new System.Windows.Forms.Label();
            this.Label_LapsValue = new System.Windows.Forms.Label();
            this.Label_PitstopsNeededValue = new System.Windows.Forms.Label();
            this.Label_FuelNeededValue = new System.Windows.Forms.Label();
            this.Label_LapsHeader = new System.Windows.Forms.Label();
            this.Label_PitstopHeader = new System.Windows.Forms.Label();
            this.Label_FuelNeededHeader = new System.Windows.Forms.Label();
            this.Label_LapTimeSeconds = new System.Windows.Forms.Label();
            this.Label_FuelUsageInLiters = new System.Windows.Forms.Label();
            this.Label_LapTimeMinutes = new System.Windows.Forms.Label();
            this.Label_RaceLengthHeader = new System.Windows.Forms.Label();
            this.Label_LapTimeHeader = new System.Windows.Forms.Label();
            this.Label_FuelUsageHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_TotalFuelSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_RaceLengthInMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_LapTimeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_AvgFuelUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_LapTimeMinutes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_CalculateFuel
            // 
            resources.ApplyResources(this.Button_CalculateFuel, "Button_CalculateFuel");
            this.Button_CalculateFuel.Name = "Button_CalculateFuel";
            this.Button_CalculateFuel.UseVisualStyleBackColor = true;
            this.Button_CalculateFuel.Click += new System.EventHandler(this.CalculateFuelButton_Click);
            // 
            // NumberField_TotalFuelSize
            // 
            resources.ApplyResources(this.NumberField_TotalFuelSize, "NumberField_TotalFuelSize");
            this.NumberField_TotalFuelSize.Name = "NumberField_TotalFuelSize";
            // 
            // NumberField_RaceLengthInMinutes
            // 
            this.NumberField_RaceLengthInMinutes.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.NumberField_RaceLengthInMinutes, "NumberField_RaceLengthInMinutes");
            this.NumberField_RaceLengthInMinutes.Name = "NumberField_RaceLengthInMinutes";
            this.NumberField_RaceLengthInMinutes.Enter += new System.EventHandler(this.NumberField_AvgFuelUsage_Enter);
            this.NumberField_RaceLengthInMinutes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumberField_AvgFuelUsage_MouseDown);
            // 
            // NumberField_LapTimeSeconds
            // 
            this.NumberField_LapTimeSeconds.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.NumberField_LapTimeSeconds, "NumberField_LapTimeSeconds");
            this.NumberField_LapTimeSeconds.Name = "NumberField_LapTimeSeconds";
            this.NumberField_LapTimeSeconds.Enter += new System.EventHandler(this.NumberField_AvgFuelUsage_Enter);
            this.NumberField_LapTimeSeconds.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumberField_AvgFuelUsage_MouseDown);
            // 
            // NumberField_AvgFuelUsage
            // 
            this.NumberField_AvgFuelUsage.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.NumberField_AvgFuelUsage, "NumberField_AvgFuelUsage");
            this.NumberField_AvgFuelUsage.Name = "NumberField_AvgFuelUsage";
            this.NumberField_AvgFuelUsage.Enter += new System.EventHandler(this.NumberField_AvgFuelUsage_Enter);
            this.NumberField_AvgFuelUsage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumberField_AvgFuelUsage_MouseDown);
            // 
            // NumberField_LapTimeMinutes
            // 
            this.NumberField_LapTimeMinutes.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.NumberField_LapTimeMinutes, "NumberField_LapTimeMinutes");
            this.NumberField_LapTimeMinutes.Name = "NumberField_LapTimeMinutes";
            this.NumberField_LapTimeMinutes.Enter += new System.EventHandler(this.NumberField_AvgFuelUsage_Enter);
            this.NumberField_LapTimeMinutes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumberField_AvgFuelUsage_MouseDown);
            // 
            // Label_MaxFuelCap
            // 
            resources.ApplyResources(this.Label_MaxFuelCap, "Label_MaxFuelCap");
            this.Label_MaxFuelCap.Name = "Label_MaxFuelCap";
            // 
            // Label_LapsValue
            // 
            resources.ApplyResources(this.Label_LapsValue, "Label_LapsValue");
            this.Label_LapsValue.Name = "Label_LapsValue";
            // 
            // Label_PitstopsNeededValue
            // 
            resources.ApplyResources(this.Label_PitstopsNeededValue, "Label_PitstopsNeededValue");
            this.Label_PitstopsNeededValue.Name = "Label_PitstopsNeededValue";
            // 
            // Label_FuelNeededValue
            // 
            resources.ApplyResources(this.Label_FuelNeededValue, "Label_FuelNeededValue");
            this.Label_FuelNeededValue.Name = "Label_FuelNeededValue";
            // 
            // Label_LapsHeader
            // 
            resources.ApplyResources(this.Label_LapsHeader, "Label_LapsHeader");
            this.Label_LapsHeader.Name = "Label_LapsHeader";
            // 
            // Label_PitstopHeader
            // 
            resources.ApplyResources(this.Label_PitstopHeader, "Label_PitstopHeader");
            this.Label_PitstopHeader.Name = "Label_PitstopHeader";
            // 
            // Label_FuelNeededHeader
            // 
            resources.ApplyResources(this.Label_FuelNeededHeader, "Label_FuelNeededHeader");
            this.Label_FuelNeededHeader.Name = "Label_FuelNeededHeader";
            // 
            // Label_LapTimeSeconds
            // 
            resources.ApplyResources(this.Label_LapTimeSeconds, "Label_LapTimeSeconds");
            this.Label_LapTimeSeconds.Name = "Label_LapTimeSeconds";
            // 
            // Label_FuelUsageInLiters
            // 
            resources.ApplyResources(this.Label_FuelUsageInLiters, "Label_FuelUsageInLiters");
            this.Label_FuelUsageInLiters.Name = "Label_FuelUsageInLiters";
            // 
            // Label_LapTimeMinutes
            // 
            this.Label_LapTimeMinutes.CausesValidation = false;
            resources.ApplyResources(this.Label_LapTimeMinutes, "Label_LapTimeMinutes");
            this.Label_LapTimeMinutes.Name = "Label_LapTimeMinutes";
            // 
            // Label_RaceLengthHeader
            // 
            resources.ApplyResources(this.Label_RaceLengthHeader, "Label_RaceLengthHeader");
            this.Label_RaceLengthHeader.Name = "Label_RaceLengthHeader";
            // 
            // Label_LapTimeHeader
            // 
            resources.ApplyResources(this.Label_LapTimeHeader, "Label_LapTimeHeader");
            this.Label_LapTimeHeader.Name = "Label_LapTimeHeader";
            // 
            // Label_FuelUsageHeader
            // 
            resources.ApplyResources(this.Label_FuelUsageHeader, "Label_FuelUsageHeader");
            this.Label_FuelUsageHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_FuelUsageHeader.Name = "Label_FuelUsageHeader";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_MaxFuelCap);
            this.panel1.Controls.Add(this.Label_FuelUsageHeader);
            this.panel1.Controls.Add(this.Label_LapTimeHeader);
            this.panel1.Controls.Add(this.Label_LapTimeMinutes);
            this.panel1.Controls.Add(this.Label_LapTimeSeconds);
            this.panel1.Controls.Add(this.Label_RaceLengthHeader);
            this.panel1.Controls.Add(this.Label_FuelUsageInLiters);
            this.panel1.Controls.Add(this.Label_FuelNeededHeader);
            this.panel1.Controls.Add(this.Label_FuelNeededValue);
            this.panel1.Controls.Add(this.Label_LapsHeader);
            this.panel1.Controls.Add(this.Label_LapsValue);
            this.panel1.Controls.Add(this.Label_PitstopHeader);
            this.panel1.Controls.Add(this.Label_PitstopsNeededValue);
            this.panel1.Controls.Add(this.NumberField_AvgFuelUsage);
            this.panel1.Controls.Add(this.NumberField_LapTimeMinutes);
            this.panel1.Controls.Add(this.NumberField_LapTimeSeconds);
            this.panel1.Controls.Add(this.NumberField_RaceLengthInMinutes);
            this.panel1.Controls.Add(this.NumberField_TotalFuelSize);
            this.panel1.Controls.Add(this.Button_CalculateFuel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ACC_FC_Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ACC_FC_Window";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_TotalFuelSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_RaceLengthInMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_LapTimeSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_AvgFuelUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_LapTimeMinutes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        // Labels
        private System.Windows.Forms.Label Label_MaxFuelCap;
        private System.Windows.Forms.Label Label_FuelUsageHeader;
        private System.Windows.Forms.Label Label_LapTimeHeader;
        private System.Windows.Forms.Label Label_LapTimeMinutes;
        private System.Windows.Forms.Label Label_LapTimeSeconds;
        private System.Windows.Forms.Label Label_RaceLengthHeader;
        private System.Windows.Forms.Label Label_FuelUsageInLiters;

        // Calculation Results
        private System.Windows.Forms.Label Label_FuelNeededHeader;
        private System.Windows.Forms.Label Label_FuelNeededValue;
        // Final Data
        private System.Windows.Forms.Label Label_LapsHeader;
        private System.Windows.Forms.Label Label_LapsValue;
        private System.Windows.Forms.Label Label_PitstopHeader;
        private System.Windows.Forms.Label Label_PitstopsNeededValue;

        // Input fields
        private System.Windows.Forms.NumericUpDown NumberField_AvgFuelUsage;
        private System.Windows.Forms.NumericUpDown NumberField_LapTimeMinutes;
        private System.Windows.Forms.NumericUpDown NumberField_LapTimeSeconds;
        private System.Windows.Forms.NumericUpDown NumberField_RaceLengthInMinutes;
        private System.Windows.Forms.NumericUpDown NumberField_TotalFuelSize;

        // Random
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Button_CalculateFuel;
    }
}

