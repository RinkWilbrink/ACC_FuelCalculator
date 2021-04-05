
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACC_FC_Window));
            this.CalculateFuelButton = new System.Windows.Forms.Button();
            this.Label_FuelUsageHeader = new System.Windows.Forms.Label();
            this.NumberField_AvgFuelUsage = new System.Windows.Forms.NumericUpDown();
            this.NumberField_LapTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.label_LapTimeHeader = new System.Windows.Forms.Label();
            this.Label_LapTimeMinutes = new System.Windows.Forms.Label();
            this.Label_LapTimeSeconds = new System.Windows.Forms.Label();
            this.NumberField_LapTimeSeconds = new System.Windows.Forms.NumericUpDown();
            this.NumberField_RaceLength = new System.Windows.Forms.NumericUpDown();
            this.Label_RaceLengthHeader = new System.Windows.Forms.Label();
            this.Label_FuelUsageInLiters = new System.Windows.Forms.Label();
            this.label_FuelNeededHeader = new System.Windows.Forms.Label();
            this.label_FuelNeededValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_AvgFuelUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_LapTimeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_LapTimeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_RaceLength)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculateFuelButton
            // 
            resources.ApplyResources(this.CalculateFuelButton, "CalculateFuelButton");
            this.CalculateFuelButton.Name = "CalculateFuelButton";
            this.CalculateFuelButton.UseVisualStyleBackColor = true;
            this.CalculateFuelButton.Click += new System.EventHandler(this.CalculateFuelButton_Click);
            // 
            // Label_FuelUsageHeader
            // 
            resources.ApplyResources(this.Label_FuelUsageHeader, "Label_FuelUsageHeader");
            this.Label_FuelUsageHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_FuelUsageHeader.Name = "Label_FuelUsageHeader";
            this.Label_FuelUsageHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumberField_AvgFuelUsage
            // 
            this.NumberField_AvgFuelUsage.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.NumberField_AvgFuelUsage, "NumberField_AvgFuelUsage");
            this.NumberField_AvgFuelUsage.Name = "NumberField_AvgFuelUsage";
            this.NumberField_AvgFuelUsage.ValueChanged += new System.EventHandler(this.AvgFuelUsageInputField_ValueChanged);
            // 
            // NumberField_LapTimeMinutes
            // 
            this.NumberField_LapTimeMinutes.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.NumberField_LapTimeMinutes, "NumberField_LapTimeMinutes");
            this.NumberField_LapTimeMinutes.Name = "NumberField_LapTimeMinutes";
            // 
            // label_LapTimeHeader
            // 
            resources.ApplyResources(this.label_LapTimeHeader, "label_LapTimeHeader");
            this.label_LapTimeHeader.Name = "label_LapTimeHeader";
            this.label_LapTimeHeader.Click += new System.EventHandler(this.label2_Click);
            // 
            // Label_LapTimeMinutes
            // 
            resources.ApplyResources(this.Label_LapTimeMinutes, "Label_LapTimeMinutes");
            this.Label_LapTimeMinutes.Name = "Label_LapTimeMinutes";
            // 
            // Label_LapTimeSeconds
            // 
            resources.ApplyResources(this.Label_LapTimeSeconds, "Label_LapTimeSeconds");
            this.Label_LapTimeSeconds.Name = "Label_LapTimeSeconds";
            // 
            // NumberField_LapTimeSeconds
            // 
            this.NumberField_LapTimeSeconds.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.NumberField_LapTimeSeconds, "NumberField_LapTimeSeconds");
            this.NumberField_LapTimeSeconds.Name = "NumberField_LapTimeSeconds";
            // 
            // NumberField_RaceLength
            // 
            this.NumberField_RaceLength.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.NumberField_RaceLength, "NumberField_RaceLength");
            this.NumberField_RaceLength.Name = "NumberField_RaceLength";
            // 
            // Label_RaceLengthHeader
            // 
            resources.ApplyResources(this.Label_RaceLengthHeader, "Label_RaceLengthHeader");
            this.Label_RaceLengthHeader.Name = "Label_RaceLengthHeader";
            this.Label_RaceLengthHeader.Click += new System.EventHandler(this.label2_Click);
            // 
            // Label_FuelUsageInLiters
            // 
            resources.ApplyResources(this.Label_FuelUsageInLiters, "Label_FuelUsageInLiters");
            this.Label_FuelUsageInLiters.Name = "Label_FuelUsageInLiters";
            // 
            // label_FuelNeededHeader
            // 
            resources.ApplyResources(this.label_FuelNeededHeader, "label_FuelNeededHeader");
            this.label_FuelNeededHeader.Name = "label_FuelNeededHeader";
            // 
            // label_FuelNeededValue
            // 
            resources.ApplyResources(this.label_FuelNeededValue, "label_FuelNeededValue");
            this.label_FuelNeededValue.Name = "label_FuelNeededValue";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ACC_FC_Window
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_FuelNeededValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_FuelNeededHeader);
            this.Controls.Add(this.NumberField_RaceLength);
            this.Controls.Add(this.NumberField_LapTimeSeconds);
            this.Controls.Add(this.Label_LapTimeSeconds);
            this.Controls.Add(this.Label_FuelUsageInLiters);
            this.Controls.Add(this.Label_LapTimeMinutes);
            this.Controls.Add(this.Label_RaceLengthHeader);
            this.Controls.Add(this.label_LapTimeHeader);
            this.Controls.Add(this.NumberField_LapTimeMinutes);
            this.Controls.Add(this.NumberField_AvgFuelUsage);
            this.Controls.Add(this.Label_FuelUsageHeader);
            this.Controls.Add(this.CalculateFuelButton);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ACC_FC_Window";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_AvgFuelUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_LapTimeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_LapTimeSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberField_RaceLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateFuelButton;

        // Labels
        private System.Windows.Forms.Label Label_FuelUsageHeader;
        private System.Windows.Forms.Label label_LapTimeHeader;
        private System.Windows.Forms.Label Label_LapTimeMinutes;
        private System.Windows.Forms.Label Label_LapTimeSeconds;
        private System.Windows.Forms.Label Label_RaceLengthHeader;
        private System.Windows.Forms.Label Label_FuelUsageInLiters;

        // Calculation Results
        private System.Windows.Forms.Label label_FuelNeededHeader;
        private System.Windows.Forms.Label label_FuelNeededValue;

        // Input fields
        private System.Windows.Forms.NumericUpDown NumberField_AvgFuelUsage;
        private System.Windows.Forms.NumericUpDown NumberField_LapTimeMinutes;
        private System.Windows.Forms.NumericUpDown NumberField_LapTimeSeconds;
        private System.Windows.Forms.NumericUpDown NumberField_RaceLength;
        private System.Windows.Forms.Label label1;
    }
}

