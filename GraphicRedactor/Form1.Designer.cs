﻿namespace GraphicRedactor
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
            pictureBox1 = new PictureBox();
            Rectangle = new Button();
            Elipse = new Button();
            DrawTextBtn = new Button();
            textBox1 = new TextBox();
            Line = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(841, 548);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // Rectangle
            // 
            Rectangle.Location = new Point(875, 12);
            Rectangle.Name = "Rectangle";
            Rectangle.Size = new Size(75, 23);
            Rectangle.TabIndex = 1;
            Rectangle.Text = "Rectangle";
            Rectangle.UseVisualStyleBackColor = true;
            Rectangle.Click += Rectangle_Click;
            // 
            // Elipse
            // 
            Elipse.Location = new Point(875, 41);
            Elipse.Name = "Elipse";
            Elipse.Size = new Size(75, 23);
            Elipse.TabIndex = 2;
            Elipse.Text = "Elipse";
            Elipse.UseVisualStyleBackColor = true;
            Elipse.Click += Elipse_Click;
            // 
            // DrawTextBtn
            // 
            DrawTextBtn.Location = new Point(875, 125);
            DrawTextBtn.Name = "DrawTextBtn";
            DrawTextBtn.Size = new Size(75, 23);
            DrawTextBtn.TabIndex = 3;
            DrawTextBtn.Text = "Text";
            DrawTextBtn.UseVisualStyleBackColor = true;
            DrawTextBtn.Click += DrawTextBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(861, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // Line
            // 
            Line.Location = new Point(875, 70);
            Line.Name = "Line";
            Line.Size = new Size(75, 23);
            Line.TabIndex = 5;
            Line.Text = "Line";
            Line.UseVisualStyleBackColor = true;
            Line.Click += Line_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(Line);
            Controls.Add(textBox1);
            Controls.Add(DrawTextBtn);
            Controls.Add(Elipse);
            Controls.Add(Rectangle);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Rectangle;
        private Button Elipse;
        private Button DrawTextBtn;
        private TextBox textBox1;
        private Button Line;
    }
}