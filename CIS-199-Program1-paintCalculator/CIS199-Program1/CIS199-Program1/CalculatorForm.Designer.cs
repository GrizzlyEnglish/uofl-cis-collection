namespace CIS199_Program1
{
    partial class CalculatorForm
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
            this.inputGroup = new System.Windows.Forms.GroupBox();
            this.coatsInput = new System.Windows.Forms.NumericUpDown();
            this.pricePaintLabel = new System.Windows.Forms.Label();
            this.coatsLabel = new System.Windows.Forms.Label();
            this.wallSpaceLabel = new System.Windows.Forms.Label();
            this.paintPriceInput = new System.Windows.Forms.TextBox();
            this.wallSpaceInput = new System.Windows.Forms.TextBox();
            this.outputGroup = new System.Windows.Forms.GroupBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalLaborCostLabel = new System.Windows.Forms.Label();
            this.totalPaintCostLabel = new System.Windows.Forms.Label();
            this.totalHoursLabel = new System.Windows.Forms.Label();
            this.totalGallonsLabel = new System.Windows.Forms.Label();
            this.totalSqFtLabel = new System.Windows.Forms.Label();
            this.totalPriceOutput = new System.Windows.Forms.Label();
            this.totalLaborCostOutput = new System.Windows.Forms.Label();
            this.totalCostPaintOutput = new System.Windows.Forms.Label();
            this.totalHoursOutput = new System.Windows.Forms.Label();
            this.totalGallonsOutput = new System.Windows.Forms.Label();
            this.totalSqFtOutput = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coatsInput)).BeginInit();
            this.outputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.coatsInput);
            this.inputGroup.Controls.Add(this.pricePaintLabel);
            this.inputGroup.Controls.Add(this.coatsLabel);
            this.inputGroup.Controls.Add(this.wallSpaceLabel);
            this.inputGroup.Controls.Add(this.paintPriceInput);
            this.inputGroup.Controls.Add(this.wallSpaceInput);
            this.inputGroup.Location = new System.Drawing.Point(12, 12);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Size = new System.Drawing.Size(260, 193);
            this.inputGroup.TabIndex = 0;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Paint Input";
            // 
            // coatsInput
            // 
            this.coatsInput.Location = new System.Drawing.Point(6, 101);
            this.coatsInput.Name = "coatsInput";
            this.coatsInput.Size = new System.Drawing.Size(248, 20);
            this.coatsInput.TabIndex = 1;
            // 
            // pricePaintLabel
            // 
            this.pricePaintLabel.AutoSize = true;
            this.pricePaintLabel.Location = new System.Drawing.Point(6, 136);
            this.pricePaintLabel.Name = "pricePaintLabel";
            this.pricePaintLabel.Size = new System.Drawing.Size(120, 13);
            this.pricePaintLabel.TabIndex = 5;
            this.pricePaintLabel.Text = "Price of Paint - in dollars";
            // 
            // coatsLabel
            // 
            this.coatsLabel.AutoSize = true;
            this.coatsLabel.Location = new System.Drawing.Point(6, 84);
            this.coatsLabel.Name = "coatsLabel";
            this.coatsLabel.Size = new System.Drawing.Size(73, 13);
            this.coatsLabel.TabIndex = 4;
            this.coatsLabel.Text = "Coats of Paint";
            // 
            // wallSpaceLabel
            // 
            this.wallSpaceLabel.AutoSize = true;
            this.wallSpaceLabel.Location = new System.Drawing.Point(6, 29);
            this.wallSpaceLabel.Name = "wallSpaceLabel";
            this.wallSpaceLabel.Size = new System.Drawing.Size(135, 13);
            this.wallSpaceLabel.TabIndex = 3;
            this.wallSpaceLabel.Text = "Wall Space - in square feet";
            // 
            // paintPriceInput
            // 
            this.paintPriceInput.Location = new System.Drawing.Point(6, 156);
            this.paintPriceInput.Name = "paintPriceInput";
            this.paintPriceInput.Size = new System.Drawing.Size(248, 20);
            this.paintPriceInput.TabIndex = 2;
            // 
            // wallSpaceInput
            // 
            this.wallSpaceInput.Location = new System.Drawing.Point(6, 45);
            this.wallSpaceInput.Name = "wallSpaceInput";
            this.wallSpaceInput.Size = new System.Drawing.Size(248, 20);
            this.wallSpaceInput.TabIndex = 0;
            // 
            // outputGroup
            // 
            this.outputGroup.Controls.Add(this.totalPriceLabel);
            this.outputGroup.Controls.Add(this.totalLaborCostLabel);
            this.outputGroup.Controls.Add(this.totalPaintCostLabel);
            this.outputGroup.Controls.Add(this.totalHoursLabel);
            this.outputGroup.Controls.Add(this.totalGallonsLabel);
            this.outputGroup.Controls.Add(this.totalSqFtLabel);
            this.outputGroup.Controls.Add(this.totalPriceOutput);
            this.outputGroup.Controls.Add(this.totalLaborCostOutput);
            this.outputGroup.Controls.Add(this.totalCostPaintOutput);
            this.outputGroup.Controls.Add(this.totalHoursOutput);
            this.outputGroup.Controls.Add(this.totalGallonsOutput);
            this.outputGroup.Controls.Add(this.totalSqFtOutput);
            this.outputGroup.Location = new System.Drawing.Point(279, 13);
            this.outputGroup.Name = "outputGroup";
            this.outputGroup.Size = new System.Drawing.Size(289, 339);
            this.outputGroup.TabIndex = 2;
            this.outputGroup.TabStop = false;
            this.outputGroup.Text = "Paint Output";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(7, 296);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(58, 13);
            this.totalPriceLabel.TabIndex = 11;
            this.totalPriceLabel.Text = "Total Price";
            // 
            // totalLaborCostLabel
            // 
            this.totalLaborCostLabel.AutoSize = true;
            this.totalLaborCostLabel.Location = new System.Drawing.Point(7, 246);
            this.totalLaborCostLabel.Name = "totalLaborCostLabel";
            this.totalLaborCostLabel.Size = new System.Drawing.Size(97, 13);
            this.totalLaborCostLabel.TabIndex = 10;
            this.totalLaborCostLabel.Text = "Total Cost of Labor";
            // 
            // totalPaintCostLabel
            // 
            this.totalPaintCostLabel.AutoSize = true;
            this.totalPaintCostLabel.Location = new System.Drawing.Point(7, 193);
            this.totalPaintCostLabel.Name = "totalPaintCostLabel";
            this.totalPaintCostLabel.Size = new System.Drawing.Size(94, 13);
            this.totalPaintCostLabel.TabIndex = 9;
            this.totalPaintCostLabel.Text = "Total Cost of Paint";
            // 
            // totalHoursLabel
            // 
            this.totalHoursLabel.AutoSize = true;
            this.totalHoursLabel.Location = new System.Drawing.Point(7, 135);
            this.totalHoursLabel.Name = "totalHoursLabel";
            this.totalHoursLabel.Size = new System.Drawing.Size(62, 13);
            this.totalHoursLabel.TabIndex = 8;
            this.totalHoursLabel.Text = "Total Hours";
            // 
            // totalGallonsLabel
            // 
            this.totalGallonsLabel.AutoSize = true;
            this.totalGallonsLabel.Location = new System.Drawing.Point(6, 83);
            this.totalGallonsLabel.Name = "totalGallonsLabel";
            this.totalGallonsLabel.Size = new System.Drawing.Size(108, 13);
            this.totalGallonsLabel.TabIndex = 7;
            this.totalGallonsLabel.Text = "Total Gallons of Paint";
            // 
            // totalSqFtLabel
            // 
            this.totalSqFtLabel.AutoSize = true;
            this.totalSqFtLabel.Location = new System.Drawing.Point(7, 28);
            this.totalSqFtLabel.Name = "totalSqFtLabel";
            this.totalSqFtLabel.Size = new System.Drawing.Size(92, 13);
            this.totalSqFtLabel.TabIndex = 6;
            this.totalSqFtLabel.Text = "Total Square Feet";
            // 
            // totalPriceOutput
            // 
            this.totalPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutput.Location = new System.Drawing.Point(6, 309);
            this.totalPriceOutput.Name = "totalPriceOutput";
            this.totalPriceOutput.Size = new System.Drawing.Size(277, 23);
            this.totalPriceOutput.TabIndex = 5;
            // 
            // totalLaborCostOutput
            // 
            this.totalLaborCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLaborCostOutput.Location = new System.Drawing.Point(6, 259);
            this.totalLaborCostOutput.Name = "totalLaborCostOutput";
            this.totalLaborCostOutput.Size = new System.Drawing.Size(277, 23);
            this.totalLaborCostOutput.TabIndex = 4;
            // 
            // totalCostPaintOutput
            // 
            this.totalCostPaintOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostPaintOutput.Location = new System.Drawing.Point(6, 206);
            this.totalCostPaintOutput.Name = "totalCostPaintOutput";
            this.totalCostPaintOutput.Size = new System.Drawing.Size(277, 23);
            this.totalCostPaintOutput.TabIndex = 3;
            // 
            // totalHoursOutput
            // 
            this.totalHoursOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalHoursOutput.Location = new System.Drawing.Point(6, 152);
            this.totalHoursOutput.Name = "totalHoursOutput";
            this.totalHoursOutput.Size = new System.Drawing.Size(277, 23);
            this.totalHoursOutput.TabIndex = 2;
            // 
            // totalGallonsOutput
            // 
            this.totalGallonsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalGallonsOutput.Location = new System.Drawing.Point(6, 97);
            this.totalGallonsOutput.Name = "totalGallonsOutput";
            this.totalGallonsOutput.Size = new System.Drawing.Size(277, 23);
            this.totalGallonsOutput.TabIndex = 1;
            // 
            // totalSqFtOutput
            // 
            this.totalSqFtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSqFtOutput.Location = new System.Drawing.Point(6, 44);
            this.totalSqFtOutput.Name = "totalSqFtOutput";
            this.totalSqFtOutput.Size = new System.Drawing.Size(277, 23);
            this.totalSqFtOutput.TabIndex = 0;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(12, 322);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(117, 23);
            this.calcBtn.TabIndex = 1;
            this.calcBtn.Text = "Calculate Costs";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(145, 322);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(127, 23);
            this.settingsBtn.TabIndex = 2;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grade Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "C1695";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculatorForm
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.outputGroup);
            this.Controls.Add(this.inputGroup);
            this.Name = "CalculatorForm";
            this.Text = "Paint Application Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.inputGroup.ResumeLayout(false);
            this.inputGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coatsInput)).EndInit();
            this.outputGroup.ResumeLayout(false);
            this.outputGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroup;
        private System.Windows.Forms.NumericUpDown coatsInput;
        private System.Windows.Forms.Label pricePaintLabel;
        private System.Windows.Forms.Label coatsLabel;
        private System.Windows.Forms.Label wallSpaceLabel;
        private System.Windows.Forms.TextBox paintPriceInput;
        private System.Windows.Forms.GroupBox outputGroup;
        private System.Windows.Forms.Label totalHoursOutput;
        private System.Windows.Forms.Label totalGallonsOutput;
        private System.Windows.Forms.Label totalSqFtOutput;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label totalLaborCostLabel;
        private System.Windows.Forms.Label totalPaintCostLabel;
        private System.Windows.Forms.Label totalHoursLabel;
        private System.Windows.Forms.Label totalGallonsLabel;
        private System.Windows.Forms.Label totalSqFtLabel;
        private System.Windows.Forms.Label totalPriceOutput;
        private System.Windows.Forms.Label totalLaborCostOutput;
        private System.Windows.Forms.Label totalCostPaintOutput;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.TextBox wallSpaceInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

