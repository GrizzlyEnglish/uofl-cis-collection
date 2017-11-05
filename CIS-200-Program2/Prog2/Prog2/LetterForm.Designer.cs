namespace UPVApp
{
    partial class LetterForm
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
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.originBox = new System.Windows.Forms.ComboBox();
            this.destinationBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fixedCostInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.originErr = new System.Windows.Forms.Label();
            this.destinationErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.createBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.createBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(32, 226);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 16;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(175, 226);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // originBox
            // 
            this.originBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originBox.FormattingEnabled = true;
            this.originBox.Location = new System.Drawing.Point(32, 59);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(218, 21);
            this.originBox.TabIndex = 18;
            // 
            // destinationBox
            // 
            this.destinationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.Location = new System.Drawing.Point(32, 114);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(218, 21);
            this.destinationBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Origin Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Destination Address";
            // 
            // fixedCostInput
            // 
            this.fixedCostInput.Location = new System.Drawing.Point(32, 164);
            this.fixedCostInput.Name = "fixedCostInput";
            this.fixedCostInput.Size = new System.Drawing.Size(218, 20);
            this.fixedCostInput.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fixed Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Create Letter";
            // 
            // originErr
            // 
            this.originErr.AutoSize = true;
            this.originErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originErr.ForeColor = System.Drawing.Color.Red;
            this.originErr.Location = new System.Drawing.Point(105, 38);
            this.originErr.Name = "originErr";
            this.originErr.Size = new System.Drawing.Size(13, 15);
            this.originErr.TabIndex = 25;
            this.originErr.Text = "*";
            this.originErr.Visible = false;
            // 
            // destinationErr
            // 
            this.destinationErr.AutoSize = true;
            this.destinationErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationErr.ForeColor = System.Drawing.Color.Red;
            this.destinationErr.Location = new System.Drawing.Point(130, 96);
            this.destinationErr.Name = "destinationErr";
            this.destinationErr.Size = new System.Drawing.Size(13, 15);
            this.destinationErr.TabIndex = 26;
            this.destinationErr.Text = "*";
            this.destinationErr.Visible = false;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.destinationErr);
            this.Controls.Add(this.originErr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fixedCostInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.originBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createBtn);
            this.Name = "LetterForm";
            this.Text = "Create Letter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox originBox;
        private System.Windows.Forms.ComboBox destinationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fixedCostInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label originErr;
        private System.Windows.Forms.Label destinationErr;
    }
}