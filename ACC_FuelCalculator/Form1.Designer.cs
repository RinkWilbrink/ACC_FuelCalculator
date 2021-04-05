
namespace ACC_FuelCalculator
{
    partial class Form1
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
            this.CalculateFuelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FuelUsageInputField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FuelUsageInputField)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.CalculateFuelButton.Location = new System.Drawing.Point(510, 245);
            this.CalculateFuelButton.Name = "button1";
            this.CalculateFuelButton.Size = new System.Drawing.Size(93, 37);
            this.CalculateFuelButton.TabIndex = 0;
            this.CalculateFuelButton.Text = "Calculate Fuel";
            this.CalculateFuelButton.UseVisualStyleBackColor = true;
            this.CalculateFuelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AVG Fuel Usage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown1
            // 
            this.FuelUsageInputField.Location = new System.Drawing.Point(124, 146);
            this.FuelUsageInputField.Name = "numericUpDown1";
            this.FuelUsageInputField.Size = new System.Drawing.Size(162, 20);
            this.FuelUsageInputField.TabIndex = 3;
            this.FuelUsageInputField.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FuelUsageInputField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateFuelButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FuelUsageInputField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateFuelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FuelUsageInputField;
    }
}

