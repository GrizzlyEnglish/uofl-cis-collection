namespace CIS199_Program4
{
    partial class PackageForm
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
            this.createGroup = new System.Windows.Forms.GroupBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.weightLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.originalLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.lengthInput = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.originInput = new System.Windows.Forms.TextBox();
            this.destinationInput = new System.Windows.Forms.TextBox();
            this.listGroup = new System.Windows.Forms.GroupBox();
            this.packageList = new System.Windows.Forms.ListBox();
            this.detailsBtn = new System.Windows.Forms.Button();
            this.sendToBtn = new System.Windows.Forms.Button();
            this.sendFromBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.createGroup.SuspendLayout();
            this.listGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // createGroup
            // 
            this.createGroup.Controls.Add(this.createBtn);
            this.createGroup.Controls.Add(this.weightLabel);
            this.createGroup.Controls.Add(this.destinationLabel);
            this.createGroup.Controls.Add(this.originalLabel);
            this.createGroup.Controls.Add(this.lengthLabel);
            this.createGroup.Controls.Add(this.heightLabel);
            this.createGroup.Controls.Add(this.weightInput);
            this.createGroup.Controls.Add(this.lengthInput);
            this.createGroup.Controls.Add(this.widthLabel);
            this.createGroup.Controls.Add(this.widthInput);
            this.createGroup.Controls.Add(this.heightInput);
            this.createGroup.Controls.Add(this.originInput);
            this.createGroup.Controls.Add(this.destinationInput);
            this.createGroup.Location = new System.Drawing.Point(12, 12);
            this.createGroup.Name = "createGroup";
            this.createGroup.Size = new System.Drawing.Size(253, 246);
            this.createGroup.TabIndex = 0;
            this.createGroup.TabStop = false;
            this.createGroup.Text = "Create Package";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(65, 203);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(111, 23);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Create Package";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(147, 142);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(41, 13);
            this.weightLabel.TabIndex = 11;
            this.weightLabel.Text = "Weight";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(147, 29);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(78, 13);
            this.destinationLabel.TabIndex = 7;
            this.destinationLabel.Text = "Destination Zip";
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.Location = new System.Drawing.Point(7, 29);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(52, 13);
            this.originalLabel.TabIndex = 6;
            this.originalLabel.Text = "Origin Zip";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(7, 142);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(40, 13);
            this.lengthLabel.TabIndex = 8;
            this.lengthLabel.Text = "Length";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(147, 86);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 10;
            this.heightLabel.Text = "Height";
            // 
            // weightInput
            // 
            this.weightInput.Location = new System.Drawing.Point(147, 158);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(100, 20);
            this.weightInput.TabIndex = 5;
            // 
            // lengthInput
            // 
            this.lengthInput.Location = new System.Drawing.Point(6, 158);
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(100, 20);
            this.lengthInput.TabIndex = 4;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(7, 86);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 9;
            this.widthLabel.Text = "Width";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(6, 102);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(100, 20);
            this.widthInput.TabIndex = 2;
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(147, 102);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(100, 20);
            this.heightInput.TabIndex = 3;
            // 
            // originInput
            // 
            this.originInput.Location = new System.Drawing.Point(6, 48);
            this.originInput.Name = "originInput";
            this.originInput.Size = new System.Drawing.Size(100, 20);
            this.originInput.TabIndex = 0;
            // 
            // destinationInput
            // 
            this.destinationInput.Location = new System.Drawing.Point(147, 48);
            this.destinationInput.Name = "destinationInput";
            this.destinationInput.Size = new System.Drawing.Size(100, 20);
            this.destinationInput.TabIndex = 1;
            // 
            // listGroup
            // 
            this.listGroup.Controls.Add(this.packageList);
            this.listGroup.Location = new System.Drawing.Point(272, 13);
            this.listGroup.Name = "listGroup";
            this.listGroup.Size = new System.Drawing.Size(238, 245);
            this.listGroup.TabIndex = 1;
            this.listGroup.TabStop = false;
            this.listGroup.Text = "Package List";
            // 
            // packageList
            // 
            this.packageList.FormattingEnabled = true;
            this.packageList.Location = new System.Drawing.Point(6, 19);
            this.packageList.Name = "packageList";
            this.packageList.Size = new System.Drawing.Size(226, 212);
            this.packageList.TabIndex = 0;
            // 
            // detailsBtn
            // 
            this.detailsBtn.Location = new System.Drawing.Point(517, 32);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(111, 23);
            this.detailsBtn.TabIndex = 0;
            this.detailsBtn.Text = "Package Details";
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // sendToBtn
            // 
            this.sendToBtn.Location = new System.Drawing.Point(517, 188);
            this.sendToBtn.Name = "sendToBtn";
            this.sendToBtn.Size = new System.Drawing.Size(111, 23);
            this.sendToBtn.TabIndex = 2;
            this.sendToBtn.Text = "Send To U of L";
            this.sendToBtn.UseVisualStyleBackColor = true;
            this.sendToBtn.Click += new System.EventHandler(this.sendToBtn_Click);
            // 
            // sendFromBtn
            // 
            this.sendFromBtn.Location = new System.Drawing.Point(516, 229);
            this.sendFromBtn.Name = "sendFromBtn";
            this.sendFromBtn.Size = new System.Drawing.Size(111, 23);
            this.sendFromBtn.TabIndex = 3;
            this.sendFromBtn.Text = "Send from U of L";
            this.sendFromBtn.UseVisualStyleBackColor = true;
            this.sendFromBtn.Click += new System.EventHandler(this.sendFromBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(517, 74);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(111, 23);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Trash Package";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // PackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 273);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.sendFromBtn);
            this.Controls.Add(this.sendToBtn);
            this.Controls.Add(this.detailsBtn);
            this.Controls.Add(this.listGroup);
            this.Controls.Add(this.createGroup);
            this.Name = "PackageForm";
            this.Text = "Form1";
            this.createGroup.ResumeLayout(false);
            this.createGroup.PerformLayout();
            this.listGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox createGroup;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox weightInput;
        private System.Windows.Forms.TextBox lengthInput;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.TextBox originInput;
        private System.Windows.Forms.TextBox destinationInput;
        private System.Windows.Forms.GroupBox listGroup;
        private System.Windows.Forms.Button detailsBtn;
        private System.Windows.Forms.Button sendToBtn;
        private System.Windows.Forms.Button sendFromBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ListBox packageList;
    }
}

