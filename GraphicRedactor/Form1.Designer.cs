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
            pictureBox1 = new PictureBox();
            Rectangle = new Button();
            Elipse = new Button();
            DrawTextBtn = new Button();
            textBox1 = new TextBox();
            Line = new Button();
            ColorPickerBtn = new Button();
            SelectBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1083, 731);
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
            Rectangle.Location = new Point(1148, 3);
            Rectangle.Margin = new Padding(3, 4, 3, 4);
            Rectangle.Name = "Rectangle";
            Rectangle.Size = new Size(86, 31);
            Rectangle.TabIndex = 1;
            Rectangle.Text = "Rectangle";
            Rectangle.UseVisualStyleBackColor = true;
            Rectangle.Click += Rectangle_Click;
            // 
            // Elipse
            // 
            Elipse.Location = new Point(1148, 42);
            Elipse.Margin = new Padding(3, 4, 3, 4);
            Elipse.Name = "Elipse";
            Elipse.Size = new Size(86, 31);
            Elipse.TabIndex = 2;
            Elipse.Text = "Elipse";
            Elipse.UseVisualStyleBackColor = true;
            Elipse.Click += Elipse_Click;
            // 
            // DrawTextBtn
            // 
            DrawTextBtn.Location = new Point(1148, 120);
            DrawTextBtn.Margin = new Padding(3, 4, 3, 4);
            DrawTextBtn.Name = "DrawTextBtn";
            DrawTextBtn.Size = new Size(86, 31);
            DrawTextBtn.TabIndex = 3;
            DrawTextBtn.Text = "Text";
            DrawTextBtn.UseVisualStyleBackColor = true;
            DrawTextBtn.Click += DrawTextBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1120, 159);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 4;
            // 
            // Line
            // 
            Line.Location = new Point(1148, 81);
            Line.Margin = new Padding(3, 4, 3, 4);
            Line.Name = "Line";
            Line.Size = new Size(86, 31);
            Line.TabIndex = 5;
            Line.Text = "Line";
            Line.UseVisualStyleBackColor = true;
            Line.Click += Line_Click;
            // 
            // ColorPickerBtn
            // 
            ColorPickerBtn.Location = new Point(1140, 193);
            ColorPickerBtn.Name = "ColorPickerBtn";
            ColorPickerBtn.Size = new Size(94, 29);
            ColorPickerBtn.TabIndex = 6;
            ColorPickerBtn.Text = "ColorPicker";
            ColorPickerBtn.UseVisualStyleBackColor = true;
            ColorPickerBtn.Click += ColorPickerBtn_Click;
            // 
            // SelectBtn
            // 
            SelectBtn.Location = new Point(1148, 237);
            SelectBtn.Name = "SelectBtn";
            SelectBtn.Size = new Size(94, 29);
            SelectBtn.TabIndex = 7;
            SelectBtn.Text = "Select";
            SelectBtn.UseVisualStyleBackColor = true;
            SelectBtn.Click += SelectBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 737);
            Controls.Add(SelectBtn);
            Controls.Add(ColorPickerBtn);
            Controls.Add(Line);
            Controls.Add(textBox1);
            Controls.Add(DrawTextBtn);
            Controls.Add(Elipse);
            Controls.Add(Rectangle);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button ColorPickerBtn;
        private Button SelectBtn;
    }
}