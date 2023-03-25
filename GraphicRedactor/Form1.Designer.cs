namespace GraphicRedactor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Elipse = new System.Windows.Forms.Button();
            this.DrawTextBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(841, 548);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(868, 14);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(75, 23);
            this.Rectangle.TabIndex = 1;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Elipse
            // 
            this.Elipse.Location = new System.Drawing.Point(871, 49);
            this.Elipse.Name = "Elipse";
            this.Elipse.Size = new System.Drawing.Size(75, 23);
            this.Elipse.TabIndex = 2;
            this.Elipse.Text = "Elipse";
            this.Elipse.UseVisualStyleBackColor = true;
            this.Elipse.Click += new System.EventHandler(this.Elipse_Click);
            // 
            // DrawTextBtn
            // 
            this.DrawTextBtn.Location = new System.Drawing.Point(875, 87);
            this.DrawTextBtn.Name = "DrawTextBtn";
            this.DrawTextBtn.Size = new System.Drawing.Size(75, 23);
            this.DrawTextBtn.TabIndex = 3;
            this.DrawTextBtn.Text = "Text";
            this.DrawTextBtn.UseVisualStyleBackColor = true;
            this.DrawTextBtn.Click += new System.EventHandler(this.DrawTextBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(868, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DrawTextBtn);
            this.Controls.Add(this.Elipse);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button Rectangle;
        private Button Elipse;
        private Button DrawTextBtn;
        private TextBox textBox1;
    }
}