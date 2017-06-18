namespace CIS_199_Lab9
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.TextBox();
            this.monthInput = new System.Windows.Forms.TextBox();
            this.dayInput = new System.Windows.Forms.TextBox();
            this.yearInput = new System.Windows.Forms.TextBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthBtn = new System.Windows.Forms.Button();
            this.dayBtn = new System.Windows.Forms.Button();
            this.yearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(71, 15);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date:";
            // 
            // dateInput
            // 
            this.dateInput.Enabled = false;
            this.dateInput.Location = new System.Drawing.Point(110, 12);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(124, 20);
            this.dateInput.TabIndex = 1;
            // 
            // monthInput
            // 
            this.monthInput.Location = new System.Drawing.Point(62, 39);
            this.monthInput.Name = "monthInput";
            this.monthInput.Size = new System.Drawing.Size(116, 20);
            this.monthInput.TabIndex = 2;
            // 
            // dayInput
            // 
            this.dayInput.Location = new System.Drawing.Point(62, 70);
            this.dayInput.Name = "dayInput";
            this.dayInput.Size = new System.Drawing.Size(116, 20);
            this.dayInput.TabIndex = 3;
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(62, 101);
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(116, 20);
            this.yearInput.TabIndex = 4;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(19, 42);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(37, 13);
            this.monthLabel.TabIndex = 5;
            this.monthLabel.Text = "Month";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(27, 73);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(29, 13);
            this.dayLabel.TabIndex = 6;
            this.dayLabel.Text = "Day:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(24, 104);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Year:";
            // 
            // monthBtn
            // 
            this.monthBtn.Location = new System.Drawing.Point(184, 37);
            this.monthBtn.Name = "monthBtn";
            this.monthBtn.Size = new System.Drawing.Size(109, 23);
            this.monthBtn.TabIndex = 8;
            this.monthBtn.Text = "Update Month";
            this.monthBtn.UseVisualStyleBackColor = true;
            this.monthBtn.Click += new System.EventHandler(this.monthBtn_Click);
            // 
            // dayBtn
            // 
            this.dayBtn.Location = new System.Drawing.Point(184, 68);
            this.dayBtn.Name = "dayBtn";
            this.dayBtn.Size = new System.Drawing.Size(109, 23);
            this.dayBtn.TabIndex = 9;
            this.dayBtn.Text = "Update Day";
            this.dayBtn.UseVisualStyleBackColor = true;
            this.dayBtn.Click += new System.EventHandler(this.dayBtn_Click);
            // 
            // yearBtn
            // 
            this.yearBtn.Location = new System.Drawing.Point(184, 99);
            this.yearBtn.Name = "yearBtn";
            this.yearBtn.Size = new System.Drawing.Size(109, 23);
            this.yearBtn.TabIndex = 10;
            this.yearBtn.Text = "Update Year";
            this.yearBtn.UseVisualStyleBackColor = true;
            this.yearBtn.Click += new System.EventHandler(this.yearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 145);
            this.Controls.Add(this.yearBtn);
            this.Controls.Add(this.dayBtn);
            this.Controls.Add(this.monthBtn);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.yearInput);
            this.Controls.Add(this.dayInput);
            this.Controls.Add(this.monthInput);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.dateLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateInput;
        private System.Windows.Forms.TextBox monthInput;
        private System.Windows.Forms.TextBox dayInput;
        private System.Windows.Forms.TextBox yearInput;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button monthBtn;
        private System.Windows.Forms.Button dayBtn;
        private System.Windows.Forms.Button yearBtn;
    }
}

