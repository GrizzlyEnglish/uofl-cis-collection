namespace Prog2
{
    partial class AddressSelectorForm
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
            this.addressCBox = new System.Windows.Forms.ComboBox();
            this.editLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addressCBox
            // 
            this.addressCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressCBox.FormattingEnabled = true;
            this.addressCBox.Location = new System.Drawing.Point(13, 41);
            this.addressCBox.Name = "addressCBox";
            this.addressCBox.Size = new System.Drawing.Size(259, 21);
            this.addressCBox.TabIndex = 0;
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Location = new System.Drawing.Point(13, 22);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(72, 13);
            this.editLabel.TabIndex = 1;
            this.editLabel.Text = "Adress to Edit";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(41, 81);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(160, 81);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddressSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.addressCBox);
            this.Name = "AddressSelectorForm";
            this.Text = "Edit Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox addressCBox;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button cancelButton;
    }
}