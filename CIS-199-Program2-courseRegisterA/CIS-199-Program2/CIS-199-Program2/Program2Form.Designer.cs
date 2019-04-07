namespace CIS150_Lab4
{
    partial class Program2Form
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
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.registarLabel = new System.Windows.Forms.Label();
            this.gradeBox = new System.Windows.Forms.ComboBox();
            this.subText = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleLabel.Location = new System.Drawing.Point(16, 183);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(256, 51);
            this.scheduleLabel.TabIndex = 0;
            this.scheduleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(12, 96);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(179, 20);
            this.lastNameInput.TabIndex = 1;
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(197, 96);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 20);
            this.acceptBtn.TabIndex = 3;
            this.acceptBtn.Text = "Schedule";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 77);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name";
            // 
            // registarLabel
            // 
            this.registarLabel.AutoSize = true;
            this.registarLabel.Location = new System.Drawing.Point(13, 170);
            this.registarLabel.Name = "registarLabel";
            this.registarLabel.Size = new System.Drawing.Size(123, 13);
            this.registarLabel.TabIndex = 7;
            this.registarLabel.Text = "Easliest Time to Register";
            // 
            // gradeBox
            // 
            this.gradeBox.FormattingEnabled = true;
            this.gradeBox.Location = new System.Drawing.Point(12, 28);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(179, 21);
            this.gradeBox.TabIndex = 9;
            // 
            // subText
            // 
            this.subText.AutoSize = true;
            this.subText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subText.Location = new System.Drawing.Point(10, 52);
            this.subText.Name = "subText";
            this.subText.Size = new System.Drawing.Size(112, 12);
            this.subText.TabIndex = 10;
            this.subText.Text = "(not including Spring 2017)";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(9, 9);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(36, 13);
            this.gradeLabel.TabIndex = 11;
            this.gradeLabel.Text = "Grade";
            // 
            // Program2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.subText);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.registarLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.scheduleLabel);
            this.Name = "Program2Form";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scheduleLabel;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label registarLabel;
        private System.Windows.Forms.ComboBox gradeBox;
        private System.Windows.Forms.Label subText;
        private System.Windows.Forms.Label gradeLabel;
    }
}

