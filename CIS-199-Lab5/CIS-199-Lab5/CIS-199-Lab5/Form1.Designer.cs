namespace CIS_199_Lab5
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
            this.fromInput = new System.Windows.Forms.TextBox();
            this.toInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doRadio = new System.Windows.Forms.RadioButton();
            this.forRadio = new System.Windows.Forms.RadioButton();
            this.whileRadio = new System.Windows.Forms.RadioButton();
            this.runBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.countList = new System.Windows.Forms.ListView();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromInput
            // 
            this.fromInput.Location = new System.Drawing.Point(13, 25);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(100, 20);
            this.fromInput.TabIndex = 0;
            // 
            // toInput
            // 
            this.toInput.Location = new System.Drawing.Point(13, 83);
            this.toInput.Name = "toInput";
            this.toInput.Size = new System.Drawing.Size(100, 20);
            this.toInput.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.doRadio);
            this.groupBox1.Controls.Add(this.forRadio);
            this.groupBox1.Controls.Add(this.whileRadio);
            this.groupBox1.Location = new System.Drawing.Point(13, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loops";
            // 
            // doRadio
            // 
            this.doRadio.AutoSize = true;
            this.doRadio.Location = new System.Drawing.Point(7, 100);
            this.doRadio.Name = "doRadio";
            this.doRadio.Size = new System.Drawing.Size(64, 17);
            this.doRadio.TabIndex = 2;
            this.doRadio.TabStop = true;
            this.doRadio.Text = "do-while";
            this.doRadio.UseVisualStyleBackColor = true;
            // 
            // forRadio
            // 
            this.forRadio.AutoSize = true;
            this.forRadio.Location = new System.Drawing.Point(7, 66);
            this.forRadio.Name = "forRadio";
            this.forRadio.Size = new System.Drawing.Size(37, 17);
            this.forRadio.TabIndex = 1;
            this.forRadio.TabStop = true;
            this.forRadio.Text = "for";
            this.forRadio.UseVisualStyleBackColor = true;
            // 
            // whileRadio
            // 
            this.whileRadio.AutoSize = true;
            this.whileRadio.Location = new System.Drawing.Point(7, 30);
            this.whileRadio.Name = "whileRadio";
            this.whileRadio.Size = new System.Drawing.Size(49, 17);
            this.whileRadio.TabIndex = 0;
            this.whileRadio.TabStop = true;
            this.whileRadio.Text = "while";
            this.whileRadio.UseVisualStyleBackColor = true;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(13, 264);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(100, 23);
            this.runBtn.TabIndex = 3;
            this.runBtn.Text = "Run Loop";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(13, 307);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear List";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // countList
            // 
            this.countList.Location = new System.Drawing.Point(134, 25);
            this.countList.Name = "countList";
            this.countList.Size = new System.Drawing.Size(179, 111);
            this.countList.TabIndex = 5;
            this.countList.UseCompatibleStateImageBehavior = false;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(13, 6);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 13);
            this.fromLabel.TabIndex = 6;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(13, 64);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 7;
            this.toLabel.Text = "To:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(134, 148);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 173);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 342);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.countList);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toInput);
            this.Controls.Add(this.fromInput);
            this.Name = "Form1";
            this.Text = "LoopForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fromInput;
        private System.Windows.Forms.TextBox toInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton doRadio;
        private System.Windows.Forms.RadioButton forRadio;
        private System.Windows.Forms.RadioButton whileRadio;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ListView countList;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.ListBox listBox1;
    }
}

