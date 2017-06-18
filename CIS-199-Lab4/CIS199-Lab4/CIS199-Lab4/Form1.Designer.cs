namespace CIS199_Lab4
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
            this.checkStudent = new System.Windows.Forms.Button();
            this.gpaInput = new System.Windows.Forms.TextBox();
            this.adminInput = new System.Windows.Forms.TextBox();
            this.gppaLabel = new System.Windows.Forms.Label();
            this.adminLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deniedAmount = new System.Windows.Forms.Label();
            this.accepetedAmount = new System.Windows.Forms.Label();
            this.entryStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkStudent
            // 
            this.checkStudent.Location = new System.Drawing.Point(96, 66);
            this.checkStudent.Name = "checkStudent";
            this.checkStudent.Size = new System.Drawing.Size(93, 23);
            this.checkStudent.TabIndex = 0;
            this.checkStudent.Text = "Check Student";
            this.checkStudent.UseVisualStyleBackColor = true;
            this.checkStudent.Click += new System.EventHandler(this.checkStudent_Click);
            // 
            // gpaInput
            // 
            this.gpaInput.Location = new System.Drawing.Point(12, 25);
            this.gpaInput.Name = "gpaInput";
            this.gpaInput.Size = new System.Drawing.Size(117, 20);
            this.gpaInput.TabIndex = 1;
            // 
            // adminInput
            // 
            this.adminInput.Location = new System.Drawing.Point(153, 25);
            this.adminInput.Name = "adminInput";
            this.adminInput.Size = new System.Drawing.Size(119, 20);
            this.adminInput.TabIndex = 2;
            // 
            // gppaLabel
            // 
            this.gppaLabel.AutoSize = true;
            this.gppaLabel.Location = new System.Drawing.Point(10, 9);
            this.gppaLabel.Name = "gppaLabel";
            this.gppaLabel.Size = new System.Drawing.Size(29, 13);
            this.gppaLabel.TabIndex = 3;
            this.gppaLabel.Text = "GPA";
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Location = new System.Drawing.Point(157, 9);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(109, 13);
            this.adminLabel.TabIndex = 4;
            this.adminLabel.Text = "Admission Test Score";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deniedAmount);
            this.groupBox1.Controls.Add(this.accepetedAmount);
            this.groupBox1.Controls.Add(this.entryStatus);
            this.groupBox1.Location = new System.Drawing.Point(13, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 145);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admissions";
            // 
            // deniedAmount
            // 
            this.deniedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deniedAmount.Location = new System.Drawing.Point(140, 103);
            this.deniedAmount.Name = "deniedAmount";
            this.deniedAmount.Size = new System.Drawing.Size(113, 23);
            this.deniedAmount.TabIndex = 2;
            this.deniedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accepetedAmount
            // 
            this.accepetedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accepetedAmount.Location = new System.Drawing.Point(7, 103);
            this.accepetedAmount.Name = "accepetedAmount";
            this.accepetedAmount.Size = new System.Drawing.Size(109, 23);
            this.accepetedAmount.TabIndex = 1;
            this.accepetedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entryStatus
            // 
            this.entryStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entryStatus.Location = new System.Drawing.Point(6, 36);
            this.entryStatus.Name = "entryStatus";
            this.entryStatus.Size = new System.Drawing.Size(247, 23);
            this.entryStatus.TabIndex = 0;
            this.entryStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.checkStudent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.gppaLabel);
            this.Controls.Add(this.adminInput);
            this.Controls.Add(this.gpaInput);
            this.Controls.Add(this.checkStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkStudent;
        private System.Windows.Forms.TextBox gpaInput;
        private System.Windows.Forms.TextBox adminInput;
        private System.Windows.Forms.Label gppaLabel;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label deniedAmount;
        private System.Windows.Forms.Label accepetedAmount;
        private System.Windows.Forms.Label entryStatus;
    }
}

