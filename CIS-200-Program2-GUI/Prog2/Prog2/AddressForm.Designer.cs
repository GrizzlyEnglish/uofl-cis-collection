namespace UPVApp
{
    partial class AddressForm
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
            this.firstInput = new System.Windows.Forms.TextBox();
            this.lastInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addressLine1Input = new System.Windows.Forms.TextBox();
            this.addressLine2Input = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.zipInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.firstErr = new System.Windows.Forms.Label();
            this.lastErr = new System.Windows.Forms.Label();
            this.line1Err = new System.Windows.Forms.Label();
            this.line2Err = new System.Windows.Forms.Label();
            this.cityErr = new System.Windows.Forms.Label();
            this.stateErr = new System.Windows.Forms.Label();
            this.zipErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstInput
            // 
            this.firstInput.Location = new System.Drawing.Point(12, 63);
            this.firstInput.Name = "firstInput";
            this.firstInput.Size = new System.Drawing.Size(164, 20);
            this.firstInput.TabIndex = 0;
            // 
            // lastInput
            // 
            this.lastInput.Location = new System.Drawing.Point(182, 63);
            this.lastInput.Name = "lastInput";
            this.lastInput.Size = new System.Drawing.Size(152, 20);
            this.lastInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // addressLine1Input
            // 
            this.addressLine1Input.Location = new System.Drawing.Point(12, 102);
            this.addressLine1Input.Name = "addressLine1Input";
            this.addressLine1Input.Size = new System.Drawing.Size(206, 20);
            this.addressLine1Input.TabIndex = 4;
            // 
            // addressLine2Input
            // 
            this.addressLine2Input.Location = new System.Drawing.Point(224, 102);
            this.addressLine2Input.Name = "addressLine2Input";
            this.addressLine2Input.Size = new System.Drawing.Size(110, 20);
            this.addressLine2Input.TabIndex = 5;
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(11, 141);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(121, 20);
            this.cityInput.TabIndex = 6;
            // 
            // stateBox
            // 
            this.stateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateBox.FormattingEnabled = true;
            this.stateBox.Location = new System.Drawing.Point(139, 141);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(79, 21);
            this.stateBox.TabIndex = 7;
            // 
            // zipInput
            // 
            this.zipInput.Location = new System.Drawing.Point(224, 142);
            this.zipInput.Name = "zipInput";
            this.zipInput.Size = new System.Drawing.Size(110, 20);
            this.zipInput.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Line 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Zip";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Create New Address";
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.createBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.createBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(78, 194);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 15;
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
            this.cancelBtn.Location = new System.Drawing.Point(201, 194);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // firstErr
            // 
            this.firstErr.AutoSize = true;
            this.firstErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstErr.ForeColor = System.Drawing.Color.Red;
            this.firstErr.Location = new System.Drawing.Point(65, 42);
            this.firstErr.Name = "firstErr";
            this.firstErr.Size = new System.Drawing.Size(13, 15);
            this.firstErr.TabIndex = 17;
            this.firstErr.Text = "*";
            this.firstErr.Visible = false;
            // 
            // lastErr
            // 
            this.lastErr.AutoSize = true;
            this.lastErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastErr.ForeColor = System.Drawing.Color.Red;
            this.lastErr.Location = new System.Drawing.Point(233, 42);
            this.lastErr.Name = "lastErr";
            this.lastErr.Size = new System.Drawing.Size(13, 15);
            this.lastErr.TabIndex = 18;
            this.lastErr.Text = "*";
            this.lastErr.Visible = false;
            // 
            // line1Err
            // 
            this.line1Err.AutoSize = true;
            this.line1Err.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1Err.ForeColor = System.Drawing.Color.Red;
            this.line1Err.Location = new System.Drawing.Point(56, 84);
            this.line1Err.Name = "line1Err";
            this.line1Err.Size = new System.Drawing.Size(13, 15);
            this.line1Err.TabIndex = 19;
            this.line1Err.Text = "*";
            this.line1Err.Visible = false;
            // 
            // line2Err
            // 
            this.line2Err.AutoSize = true;
            this.line2Err.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line2Err.ForeColor = System.Drawing.Color.Red;
            this.line2Err.Location = new System.Drawing.Point(260, 84);
            this.line2Err.Name = "line2Err";
            this.line2Err.Size = new System.Drawing.Size(13, 15);
            this.line2Err.TabIndex = 20;
            this.line2Err.Text = "*";
            this.line2Err.Visible = false;
            // 
            // cityErr
            // 
            this.cityErr.AutoSize = true;
            this.cityErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityErr.ForeColor = System.Drawing.Color.Red;
            this.cityErr.Location = new System.Drawing.Point(32, 123);
            this.cityErr.Name = "cityErr";
            this.cityErr.Size = new System.Drawing.Size(13, 15);
            this.cityErr.TabIndex = 21;
            this.cityErr.Text = "*";
            this.cityErr.Visible = false;
            // 
            // stateErr
            // 
            this.stateErr.AutoSize = true;
            this.stateErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateErr.ForeColor = System.Drawing.Color.Red;
            this.stateErr.Location = new System.Drawing.Point(168, 123);
            this.stateErr.Name = "stateErr";
            this.stateErr.Size = new System.Drawing.Size(13, 15);
            this.stateErr.TabIndex = 22;
            this.stateErr.Text = "*";
            this.stateErr.Visible = false;
            // 
            // zipErr
            // 
            this.zipErr.AutoSize = true;
            this.zipErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipErr.ForeColor = System.Drawing.Color.Red;
            this.zipErr.Location = new System.Drawing.Point(243, 123);
            this.zipErr.Name = "zipErr";
            this.zipErr.Size = new System.Drawing.Size(13, 15);
            this.zipErr.TabIndex = 23;
            this.zipErr.Text = "*";
            this.zipErr.Visible = false;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 229);
            this.Controls.Add(this.zipErr);
            this.Controls.Add(this.stateErr);
            this.Controls.Add(this.cityErr);
            this.Controls.Add(this.line2Err);
            this.Controls.Add(this.line1Err);
            this.Controls.Add(this.lastErr);
            this.Controls.Add(this.firstErr);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zipInput);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.addressLine2Input);
            this.Controls.Add(this.addressLine1Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastInput);
            this.Controls.Add(this.firstInput);
            this.Name = "AddressForm";
            this.Text = "Address Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstInput;
        private System.Windows.Forms.TextBox lastInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressLine1Input;
        private System.Windows.Forms.TextBox addressLine2Input;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.ComboBox stateBox;
        private System.Windows.Forms.TextBox zipInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label firstErr;
        private System.Windows.Forms.Label lastErr;
        private System.Windows.Forms.Label line1Err;
        private System.Windows.Forms.Label line2Err;
        private System.Windows.Forms.Label cityErr;
        private System.Windows.Forms.Label stateErr;
        private System.Windows.Forms.Label zipErr;
    }
}