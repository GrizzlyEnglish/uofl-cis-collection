namespace Lab2
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
            this.titleInput = new System.Windows.Forms.TextBox();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.middleNameInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.formatOneBtn = new System.Windows.Forms.Button();
            this.formatTwoBtn = new System.Windows.Forms.Button();
            this.formatThreeBtn = new System.Windows.Forms.Button();
            this.formatFourBtn = new System.Windows.Forms.Button();
            this.formatFiveBtn = new System.Windows.Forms.Button();
            this.formatSixBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(377, 26);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(146, 20);
            this.titleInput.TabIndex = 0;
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(377, 78);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(146, 20);
            this.firstNameInput.TabIndex = 1;
            // 
            // middleNameInput
            // 
            this.middleNameInput.Location = new System.Drawing.Point(377, 133);
            this.middleNameInput.Name = "middleNameInput";
            this.middleNameInput.Size = new System.Drawing.Size(146, 20);
            this.middleNameInput.TabIndex = 2;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(377, 185);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(146, 20);
            this.lastNameInput.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(275, 81);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(264, 136);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(69, 13);
            this.middleNameLabel.TabIndex = 5;
            this.middleNameLabel.Text = "Middle Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(275, 188);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(264, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(73, 13);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Preferred Title";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 275);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(520, 49);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Output";
            // 
            // formatOneBtn
            // 
            this.formatOneBtn.Location = new System.Drawing.Point(12, 356);
            this.formatOneBtn.Name = "formatOneBtn";
            this.formatOneBtn.Size = new System.Drawing.Size(75, 23);
            this.formatOneBtn.TabIndex = 10;
            this.formatOneBtn.Text = "Format 1";
            this.formatOneBtn.UseVisualStyleBackColor = true;
            this.formatOneBtn.Click += new System.EventHandler(this.formatOneBtn_Click);
            // 
            // formatTwoBtn
            // 
            this.formatTwoBtn.Location = new System.Drawing.Point(162, 356);
            this.formatTwoBtn.Name = "formatTwoBtn";
            this.formatTwoBtn.Size = new System.Drawing.Size(75, 23);
            this.formatTwoBtn.TabIndex = 11;
            this.formatTwoBtn.Text = "Format 2";
            this.formatTwoBtn.UseVisualStyleBackColor = true;
            this.formatTwoBtn.Click += new System.EventHandler(this.formatTwoBtn_Click);
            // 
            // formatThreeBtn
            // 
            this.formatThreeBtn.Location = new System.Drawing.Point(311, 356);
            this.formatThreeBtn.Name = "formatThreeBtn";
            this.formatThreeBtn.Size = new System.Drawing.Size(75, 23);
            this.formatThreeBtn.TabIndex = 12;
            this.formatThreeBtn.Text = "Format 3";
            this.formatThreeBtn.UseVisualStyleBackColor = true;
            this.formatThreeBtn.Click += new System.EventHandler(this.formatThreeBtn_Click);
            // 
            // formatFourBtn
            // 
            this.formatFourBtn.Location = new System.Drawing.Point(448, 356);
            this.formatFourBtn.Name = "formatFourBtn";
            this.formatFourBtn.Size = new System.Drawing.Size(75, 23);
            this.formatFourBtn.TabIndex = 13;
            this.formatFourBtn.Text = "Format 4";
            this.formatFourBtn.UseVisualStyleBackColor = true;
            this.formatFourBtn.Click += new System.EventHandler(this.formatFourBtn_Click);
            // 
            // formatFiveBtn
            // 
            this.formatFiveBtn.Location = new System.Drawing.Point(81, 407);
            this.formatFiveBtn.Name = "formatFiveBtn";
            this.formatFiveBtn.Size = new System.Drawing.Size(75, 23);
            this.formatFiveBtn.TabIndex = 14;
            this.formatFiveBtn.Text = "Format 5";
            this.formatFiveBtn.UseVisualStyleBackColor = true;
            this.formatFiveBtn.Click += new System.EventHandler(this.formatFiveBtn_Click);
            // 
            // formatSixBtn
            // 
            this.formatSixBtn.Location = new System.Drawing.Point(377, 407);
            this.formatSixBtn.Name = "formatSixBtn";
            this.formatSixBtn.Size = new System.Drawing.Size(75, 23);
            this.formatSixBtn.TabIndex = 15;
            this.formatSixBtn.Text = "Format 6";
            this.formatSixBtn.UseVisualStyleBackColor = true;
            this.formatSixBtn.Click += new System.EventHandler(this.formatSixBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 475);
            this.Controls.Add(this.formatSixBtn);
            this.Controls.Add(this.formatFiveBtn);
            this.Controls.Add(this.formatFourBtn);
            this.Controls.Add(this.formatThreeBtn);
            this.Controls.Add(this.formatTwoBtn);
            this.Controls.Add(this.formatOneBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.middleNameInput);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.titleInput);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox middleNameInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button formatOneBtn;
        private System.Windows.Forms.Button formatTwoBtn;
        private System.Windows.Forms.Button formatThreeBtn;
        private System.Windows.Forms.Button formatFourBtn;
        private System.Windows.Forms.Button formatFiveBtn;
        private System.Windows.Forms.Button formatSixBtn;
    }
}

