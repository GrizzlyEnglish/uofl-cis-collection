namespace CIS_199_Lab7
{
    partial class Calculator
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
            this.futureTxt = new System.Windows.Forms.TextBox();
            this.airTxt = new System.Windows.Forms.TextBox();
            this.yearsTxt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.futureLabel = new System.Windows.Forms.Label();
            this.airLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.presentLabel = new System.Windows.Forms.Label();
            this.presentTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // futureTxt
            // 
            this.futureTxt.Location = new System.Drawing.Point(172, 27);
            this.futureTxt.Name = "futureTxt";
            this.futureTxt.Size = new System.Drawing.Size(100, 20);
            this.futureTxt.TabIndex = 0;
            // 
            // airTxt
            // 
            this.airTxt.Location = new System.Drawing.Point(172, 62);
            this.airTxt.Name = "airTxt";
            this.airTxt.Size = new System.Drawing.Size(100, 20);
            this.airTxt.TabIndex = 1;
            // 
            // yearsTxt
            // 
            this.yearsTxt.Location = new System.Drawing.Point(172, 97);
            this.yearsTxt.Name = "yearsTxt";
            this.yearsTxt.Size = new System.Drawing.Size(100, 20);
            this.yearsTxt.TabIndex = 2;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(102, 175);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // futureLabel
            // 
            this.futureLabel.AutoSize = true;
            this.futureLabel.Location = new System.Drawing.Point(12, 30);
            this.futureLabel.Name = "futureLabel";
            this.futureLabel.Size = new System.Drawing.Size(70, 13);
            this.futureLabel.TabIndex = 5;
            this.futureLabel.Text = "Future Value:";
            // 
            // airLabel
            // 
            this.airLabel.AutoSize = true;
            this.airLabel.Location = new System.Drawing.Point(12, 65);
            this.airLabel.Name = "airLabel";
            this.airLabel.Size = new System.Drawing.Size(107, 13);
            this.airLabel.TabIndex = 6;
            this.airLabel.Text = "Annual Interest Rate:";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(12, 100);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(59, 13);
            this.yearsLabel.TabIndex = 7;
            this.yearsLabel.Text = "# of Years:";
            // 
            // presentLabel
            // 
            this.presentLabel.AutoSize = true;
            this.presentLabel.Location = new System.Drawing.Point(12, 136);
            this.presentLabel.Name = "presentLabel";
            this.presentLabel.Size = new System.Drawing.Size(76, 13);
            this.presentLabel.TabIndex = 8;
            this.presentLabel.Text = "Present Value:";
            // 
            // presentTxt
            // 
            this.presentTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.presentTxt.Location = new System.Drawing.Point(172, 135);
            this.presentTxt.Name = "presentTxt";
            this.presentTxt.Size = new System.Drawing.Size(100, 23);
            this.presentTxt.TabIndex = 9;
            // 
            // Calculator
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.presentTxt);
            this.Controls.Add(this.presentLabel);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.airLabel);
            this.Controls.Add(this.futureLabel);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.yearsTxt);
            this.Controls.Add(this.airTxt);
            this.Controls.Add(this.futureTxt);
            this.Name = "Calculator";
            this.Text = "Lab 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox futureTxt;
        private System.Windows.Forms.TextBox airTxt;
        private System.Windows.Forms.TextBox yearsTxt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label futureLabel;
        private System.Windows.Forms.Label airLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.Label presentLabel;
        private System.Windows.Forms.Label presentTxt;
    }
}

