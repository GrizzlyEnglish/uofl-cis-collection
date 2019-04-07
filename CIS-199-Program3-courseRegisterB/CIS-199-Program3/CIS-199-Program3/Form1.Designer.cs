namespace CIS_199_Program3
{
    partial class regForm
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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.gradeBox = new System.Windows.Forms.ComboBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.regDate = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.regTime = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 13);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(13, 39);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(135, 20);
            this.nameInput.TabIndex = 1;
            this.nameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gradeBox
            // 
            this.gradeBox.FormattingEnabled = true;
            this.gradeBox.Location = new System.Drawing.Point(154, 39);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(121, 21);
            this.gradeBox.TabIndex = 2;
            this.gradeBox.SelectedIndexChanged += new System.EventHandler(this.gradeBox_SelectedIndexChanged);
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(154, 12);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(36, 13);
            this.gradeLabel.TabIndex = 3;
            this.gradeLabel.Text = "Grade";
            // 
            // regDate
            // 
            this.regDate.AutoSize = true;
            this.regDate.Location = new System.Drawing.Point(10, 100);
            this.regDate.Name = "regDate";
            this.regDate.Size = new System.Drawing.Size(92, 13);
            this.regDate.TabIndex = 4;
            this.regDate.Text = "Registration Date:";
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(13, 130);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(262, 23);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regTime
            // 
            this.regTime.AutoSize = true;
            this.regTime.Location = new System.Drawing.Point(13, 176);
            this.regTime.Name = "regTime";
            this.regTime.Size = new System.Drawing.Size(92, 13);
            this.regTime.TabIndex = 6;
            this.regTime.Text = "Registartion Time:";
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(9, 213);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(262, 23);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.regTime);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.regDate);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.lastNameLabel);
            this.Name = "regForm";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.regForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.ComboBox gradeBox;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label regDate;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label regTime;
        private System.Windows.Forms.Label timeLabel;
    }
}

