namespace CIS199_Lab3
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
            this.priceInput = new System.Windows.Forms.TextBox();
            this.tipOneCalced = new System.Windows.Forms.Label();
            this.tipTwoCalced = new System.Windows.Forms.Label();
            this.tipThreeCalced = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.tipOneLabel = new System.Windows.Forms.Label();
            this.tipTwoLabel = new System.Windows.Forms.Label();
            this.tipThreeLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(142, 13);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(126, 20);
            this.priceInput.TabIndex = 0;
            // 
            // tipOneCalced
            // 
            this.tipOneCalced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipOneCalced.Location = new System.Drawing.Point(142, 56);
            this.tipOneCalced.Name = "tipOneCalced";
            this.tipOneCalced.Size = new System.Drawing.Size(126, 23);
            this.tipOneCalced.TabIndex = 1;
            // 
            // tipTwoCalced
            // 
            this.tipTwoCalced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipTwoCalced.Location = new System.Drawing.Point(142, 110);
            this.tipTwoCalced.Name = "tipTwoCalced";
            this.tipTwoCalced.Size = new System.Drawing.Size(126, 23);
            this.tipTwoCalced.TabIndex = 2;
            // 
            // tipThreeCalced
            // 
            this.tipThreeCalced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipThreeCalced.Location = new System.Drawing.Point(142, 163);
            this.tipThreeCalced.Name = "tipThreeCalced";
            this.tipThreeCalced.Size = new System.Drawing.Size(126, 23);
            this.tipThreeCalced.TabIndex = 3;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(83, 226);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(114, 23);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.Text = "Calculate Tip";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // tipOneLabel
            // 
            this.tipOneLabel.AutoSize = true;
            this.tipOneLabel.Location = new System.Drawing.Point(80, 57);
            this.tipOneLabel.Name = "tipOneLabel";
            this.tipOneLabel.Size = new System.Drawing.Size(42, 13);
            this.tipOneLabel.TabIndex = 5;
            this.tipOneLabel.Text = "TipOne";
            // 
            // tipTwoLabel
            // 
            this.tipTwoLabel.AutoSize = true;
            this.tipTwoLabel.Location = new System.Drawing.Point(79, 111);
            this.tipTwoLabel.Name = "tipTwoLabel";
            this.tipTwoLabel.Size = new System.Drawing.Size(43, 13);
            this.tipTwoLabel.TabIndex = 6;
            this.tipTwoLabel.Text = "TipTwo";
            // 
            // tipThreeLabel
            // 
            this.tipThreeLabel.AutoSize = true;
            this.tipThreeLabel.Location = new System.Drawing.Point(72, 164);
            this.tipThreeLabel.Name = "tipThreeLabel";
            this.tipThreeLabel.Size = new System.Drawing.Size(50, 13);
            this.tipThreeLabel.TabIndex = 7;
            this.tipThreeLabel.Text = "TipThree";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(24, 16);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(98, 13);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Enter price of meal:";
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.tipThreeLabel);
            this.Controls.Add(this.tipTwoLabel);
            this.Controls.Add(this.tipOneLabel);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.tipThreeCalced);
            this.Controls.Add(this.tipTwoCalced);
            this.Controls.Add(this.tipOneCalced);
            this.Controls.Add(this.priceInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label tipOneCalced;
        private System.Windows.Forms.Label tipTwoCalced;
        private System.Windows.Forms.Label tipThreeCalced;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label tipOneLabel;
        private System.Windows.Forms.Label tipTwoLabel;
        private System.Windows.Forms.Label tipThreeLabel;
        private System.Windows.Forms.Label priceLabel;
    }
}

