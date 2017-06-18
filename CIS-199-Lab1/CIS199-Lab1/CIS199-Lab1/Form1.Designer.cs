namespace CIS199_Lab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hobbiesBtn = new System.Windows.Forms.Button();
            this.booksBtn = new System.Windows.Forms.Button();
            this.moviesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "C1695";
            // 
            // hobbiesBtn
            // 
            this.hobbiesBtn.Location = new System.Drawing.Point(13, 201);
            this.hobbiesBtn.Name = "hobbiesBtn";
            this.hobbiesBtn.Size = new System.Drawing.Size(75, 23);
            this.hobbiesBtn.TabIndex = 2;
            this.hobbiesBtn.Text = "Hobbies";
            this.hobbiesBtn.UseVisualStyleBackColor = true;
            this.hobbiesBtn.Click += new System.EventHandler(this.hobbiesBtn_Click);
            // 
            // booksBtn
            // 
            this.booksBtn.Location = new System.Drawing.Point(106, 201);
            this.booksBtn.Name = "booksBtn";
            this.booksBtn.Size = new System.Drawing.Size(75, 23);
            this.booksBtn.TabIndex = 3;
            this.booksBtn.Text = "Book";
            this.booksBtn.UseVisualStyleBackColor = true;
            this.booksBtn.Click += new System.EventHandler(this.booksBtn_Click);
            // 
            // moviesBtn
            // 
            this.moviesBtn.Location = new System.Drawing.Point(197, 201);
            this.moviesBtn.Name = "moviesBtn";
            this.moviesBtn.Size = new System.Drawing.Size(75, 23);
            this.moviesBtn.TabIndex = 4;
            this.moviesBtn.Text = "Movie";
            this.moviesBtn.UseVisualStyleBackColor = true;
            this.moviesBtn.Click += new System.EventHandler(this.moviesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.moviesBtn);
            this.Controls.Add(this.booksBtn);
            this.Controls.Add(this.hobbiesBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Lab1Form";
            this.Text = "Lab 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hobbiesBtn;
        private System.Windows.Forms.Button booksBtn;
        private System.Windows.Forms.Button moviesBtn;
    }
}

