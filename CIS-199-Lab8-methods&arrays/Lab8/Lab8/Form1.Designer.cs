namespace Lab8
{
    partial class transForm
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
            this.components = new System.ComponentModel.Container();
            this.outputLabel = new System.Windows.Forms.Label();
            this.monthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthNumLabel = new System.Windows.Forms.Label();
            this.monthNum = new System.Windows.Forms.TextBox();
            this.langGroup = new System.Windows.Forms.GroupBox();
            this.italianButton = new System.Windows.Forms.RadioButton();
            this.spanishButton = new System.Windows.Forms.RadioButton();
            this.englishButton = new System.Windows.Forms.RadioButton();
            this.translateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.monthBindingSource)).BeginInit();
            this.langGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(16, 201);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(154, 35);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthNumLabel
            // 
            this.monthNumLabel.AutoSize = true;
            this.monthNumLabel.Location = new System.Drawing.Point(13, 24);
            this.monthNumLabel.Name = "monthNumLabel";
            this.monthNumLabel.Size = new System.Drawing.Size(50, 13);
            this.monthNumLabel.TabIndex = 6;
            this.monthNumLabel.Text = "Month #:";
            // 
            // monthNum
            // 
            this.monthNum.Location = new System.Drawing.Point(70, 24);
            this.monthNum.Name = "monthNum";
            this.monthNum.Size = new System.Drawing.Size(100, 20);
            this.monthNum.TabIndex = 7;
            // 
            // langGroup
            // 
            this.langGroup.Controls.Add(this.italianButton);
            this.langGroup.Controls.Add(this.spanishButton);
            this.langGroup.Controls.Add(this.englishButton);
            this.langGroup.Location = new System.Drawing.Point(16, 57);
            this.langGroup.Name = "langGroup";
            this.langGroup.Size = new System.Drawing.Size(154, 123);
            this.langGroup.TabIndex = 8;
            this.langGroup.TabStop = false;
            this.langGroup.Text = "Choose Language";
            // 
            // italianButton
            // 
            this.italianButton.AutoSize = true;
            this.italianButton.Location = new System.Drawing.Point(6, 88);
            this.italianButton.Name = "italianButton";
            this.italianButton.Size = new System.Drawing.Size(53, 17);
            this.italianButton.TabIndex = 2;
            this.italianButton.TabStop = true;
            this.italianButton.Text = "Italian";
            this.italianButton.UseVisualStyleBackColor = true;
            // 
            // spanishButton
            // 
            this.spanishButton.AutoSize = true;
            this.spanishButton.Location = new System.Drawing.Point(6, 54);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(63, 17);
            this.spanishButton.TabIndex = 1;
            this.spanishButton.TabStop = true;
            this.spanishButton.Text = "Spanish";
            this.spanishButton.UseVisualStyleBackColor = true;
            // 
            // englishButton
            // 
            this.englishButton.AutoSize = true;
            this.englishButton.Location = new System.Drawing.Point(6, 19);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(59, 17);
            this.englishButton.TabIndex = 0;
            this.englishButton.TabStop = true;
            this.englishButton.Text = "English";
            this.englishButton.UseVisualStyleBackColor = true;
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(53, 257);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(75, 23);
            this.translateButton.TabIndex = 9;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // transForm
            // 
            this.AcceptButton = this.translateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 292);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.langGroup);
            this.Controls.Add(this.monthNum);
            this.Controls.Add(this.monthNumLabel);
            this.Controls.Add(this.outputLabel);
            this.Name = "transForm";
            this.Text = "Translator";
            this.Load += new System.EventHandler(this.transForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthBindingSource)).EndInit();
            this.langGroup.ResumeLayout(false);
            this.langGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.BindingSource monthBindingSource;
        private System.Windows.Forms.Label monthNumLabel;
        private System.Windows.Forms.TextBox monthNum;
        private System.Windows.Forms.GroupBox langGroup;
        private System.Windows.Forms.RadioButton italianButton;
        private System.Windows.Forms.RadioButton spanishButton;
        private System.Windows.Forms.RadioButton englishButton;
        private System.Windows.Forms.Button translateButton;
    }
}

