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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            Rectangle = new Button();
            Elipse = new Button();
            Line = new Button();
            ColorPickerBtn = new Button();
            SelectBtn = new Button();
            DeleteBtn = new Button();
            Undo = new Button();
            Redo = new Button();
            panel1 = new Panel();
            SerializeBtn = new Button();
            MoveBtn = new Button();
            pictureBox2 = new PictureBox();
            FillBtn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            DeserializeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Location = new Point(261, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1517, 719);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // Rectangle
            // 
            Rectangle.BackColor = SystemColors.ButtonHighlight;
            Rectangle.Cursor = Cursors.Hand;
            Rectangle.FlatStyle = FlatStyle.Flat;
            Rectangle.ForeColor = SystemColors.ActiveCaptionText;
            Rectangle.Location = new Point(55, 197);
            Rectangle.Margin = new Padding(0);
            Rectangle.Name = "Rectangle";
            Rectangle.Size = new Size(150, 40);
            Rectangle.TabIndex = 2;
            Rectangle.Text = "Rectangle";
            Rectangle.UseVisualStyleBackColor = false;
            Rectangle.Click += Rectangle_Click;
            // 
            // Elipse
            // 
            Elipse.BackColor = SystemColors.ButtonHighlight;
            Elipse.Cursor = Cursors.Hand;
            Elipse.FlatStyle = FlatStyle.Flat;
            Elipse.ForeColor = SystemColors.ActiveCaptionText;
            Elipse.Location = new Point(55, 237);
            Elipse.Margin = new Padding(0);
            Elipse.Name = "Elipse";
            Elipse.Size = new Size(150, 40);
            Elipse.TabIndex = 2;
            Elipse.Text = "Elipse";
            Elipse.UseVisualStyleBackColor = false;
            Elipse.Click += Elipse_Click;
            // 
            // Line
            // 
            Line.BackColor = SystemColors.ButtonHighlight;
            Line.Cursor = Cursors.Hand;
            Line.FlatStyle = FlatStyle.Flat;
            Line.ForeColor = SystemColors.ActiveCaptionText;
            Line.Location = new Point(55, 277);
            Line.Margin = new Padding(0);
            Line.Name = "Line";
            Line.Size = new Size(150, 40);
            Line.TabIndex = 2;
            Line.Text = "Line";
            Line.UseVisualStyleBackColor = false;
            Line.Click += Line_Click;
            // 
            // ColorPickerBtn
            // 
            ColorPickerBtn.BackColor = SystemColors.ButtonHighlight;
            ColorPickerBtn.Cursor = Cursors.Hand;
            ColorPickerBtn.FlatStyle = FlatStyle.Flat;
            ColorPickerBtn.ForeColor = SystemColors.ActiveCaptionText;
            ColorPickerBtn.Location = new Point(55, 317);
            ColorPickerBtn.Margin = new Padding(0);
            ColorPickerBtn.Name = "ColorPickerBtn";
            ColorPickerBtn.Size = new Size(150, 40);
            ColorPickerBtn.TabIndex = 6;
            ColorPickerBtn.Text = "ColorPicker";
            ColorPickerBtn.UseVisualStyleBackColor = false;
            ColorPickerBtn.Click += ColorPickerBtn_Click;
            // 
            // SelectBtn
            // 
            SelectBtn.BackColor = SystemColors.ButtonHighlight;
            SelectBtn.Cursor = Cursors.Hand;
            SelectBtn.FlatStyle = FlatStyle.Flat;
            SelectBtn.ForeColor = SystemColors.ActiveCaptionText;
            SelectBtn.Location = new Point(55, 357);
            SelectBtn.Margin = new Padding(0);
            SelectBtn.Name = "SelectBtn";
            SelectBtn.Size = new Size(150, 40);
            SelectBtn.TabIndex = 7;
            SelectBtn.Text = "Select";
            SelectBtn.UseVisualStyleBackColor = false;
            SelectBtn.Click += SelectBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = SystemColors.ButtonHighlight;
            DeleteBtn.Cursor = Cursors.Hand;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.ForeColor = SystemColors.ActiveCaptionText;
            DeleteBtn.Location = new Point(55, 397);
            DeleteBtn.Margin = new Padding(0);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(150, 40);
            DeleteBtn.TabIndex = 8;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Undo
            // 
            Undo.BackColor = SystemColors.ButtonHighlight;
            Undo.Cursor = Cursors.Hand;
            Undo.FlatStyle = FlatStyle.Flat;
            Undo.ForeColor = SystemColors.ActiveCaptionText;
            Undo.Location = new Point(55, 437);
            Undo.Margin = new Padding(0);
            Undo.Name = "Undo";
            Undo.Size = new Size(150, 40);
            Undo.TabIndex = 9;
            Undo.Text = "Undo";
            Undo.UseVisualStyleBackColor = false;
            Undo.Click += Undo_Click;
            // 
            // Redo
            // 
            Redo.BackColor = SystemColors.ButtonHighlight;
            Redo.Cursor = Cursors.Hand;
            Redo.FlatStyle = FlatStyle.Flat;
            Redo.ForeColor = SystemColors.ActiveCaptionText;
            Redo.Location = new Point(55, 477);
            Redo.Margin = new Padding(0);
            Redo.Name = "Redo";
            Redo.Size = new Size(150, 40);
            Redo.TabIndex = 10;
            Redo.Text = "Redo";
            Redo.UseVisualStyleBackColor = false;
            Redo.Click += Redo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(DeserializeBtn);
            panel1.Controls.Add(SerializeBtn);
            panel1.Controls.Add(MoveBtn);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Rectangle);
            panel1.Controls.Add(Line);
            panel1.Controls.Add(Elipse);
            panel1.Controls.Add(FillBtn);
            panel1.Controls.Add(ColorPickerBtn);
            panel1.Controls.Add(Redo);
            panel1.Controls.Add(SelectBtn);
            panel1.Controls.Add(Undo);
            panel1.Controls.Add(DeleteBtn);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 869);
            panel1.TabIndex = 12;
            // 
            // SerializeBtn
            // 
            SerializeBtn.BackColor = SystemColors.ButtonHighlight;
            SerializeBtn.Cursor = Cursors.Hand;
            SerializeBtn.FlatStyle = FlatStyle.Flat;
            SerializeBtn.ForeColor = SystemColors.ActiveCaptionText;
            SerializeBtn.Location = new Point(55, 597);
            SerializeBtn.Margin = new Padding(0);
            SerializeBtn.Name = "SerializeBtn";
            SerializeBtn.Size = new Size(150, 40);
            SerializeBtn.TabIndex = 14;
            SerializeBtn.Text = "Serialize";
            SerializeBtn.UseVisualStyleBackColor = false;
            SerializeBtn.Click += SerializeBtn_Click;
            // 
            // MoveBtn
            // 
            MoveBtn.BackColor = SystemColors.ButtonHighlight;
            MoveBtn.Cursor = Cursors.Hand;
            MoveBtn.FlatStyle = FlatStyle.Flat;
            MoveBtn.ForeColor = SystemColors.ActiveCaptionText;
            MoveBtn.Location = new Point(55, 557);
            MoveBtn.Margin = new Padding(0);
            MoveBtn.Name = "MoveBtn";
            MoveBtn.Size = new Size(150, 40);
            MoveBtn.TabIndex = 13;
            MoveBtn.Text = "Move";
            MoveBtn.UseVisualStyleBackColor = false;
            MoveBtn.Click += MoveBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.pen_1_;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(258, 145);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // FillBtn
            // 
            FillBtn.BackColor = SystemColors.ButtonHighlight;
            FillBtn.Cursor = Cursors.Hand;
            FillBtn.FlatStyle = FlatStyle.Flat;
            FillBtn.ForeColor = SystemColors.ActiveCaptionText;
            FillBtn.Location = new Point(55, 517);
            FillBtn.Margin = new Padding(0);
            FillBtn.Name = "FillBtn";
            FillBtn.Size = new Size(150, 40);
            FillBtn.TabIndex = 11;
            FillBtn.Text = "Fill";
            FillBtn.UseVisualStyleBackColor = false;
            FillBtn.Click += FillBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(258, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1520, 59);
            panel2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(566, 5);
            label1.Name = "label1";
            label1.Size = new Size(289, 46);
            label1.TabIndex = 0;
            label1.Text = "David Studios";
            // 
            // panel3
            // 
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(258, 779);
            panel3.Name = "panel3";
            panel3.Size = new Size(1520, 90);
            panel3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 10);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 0;
            label2.Text = "X:  ; Y:";
            // 
            // DeserializeBtn
            // 
            DeserializeBtn.BackColor = SystemColors.ButtonHighlight;
            DeserializeBtn.Cursor = Cursors.Hand;
            DeserializeBtn.FlatStyle = FlatStyle.Flat;
            DeserializeBtn.ForeColor = SystemColors.ActiveCaptionText;
            DeserializeBtn.Location = new Point(55, 637);
            DeserializeBtn.Margin = new Padding(0);
            DeserializeBtn.Name = "DeserializeBtn";
            DeserializeBtn.Size = new Size(150, 40);
            DeserializeBtn.TabIndex = 15;
            DeserializeBtn.Text = "Deserialize";
            DeserializeBtn.UseVisualStyleBackColor = false;
            DeserializeBtn.Click += DeserializeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1778, 869);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "David's Redactor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Rectangle;
        private Button Elipse;
        private Button Line;
        private Button ColorPickerBtn;
        private Button SelectBtn;
        private Button DeleteBtn;
        private Button Undo;
        private Button Redo;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Button MoveBtn;
        private Button FillBtn;
        private Button SerializeBtn;
        private Button DeserializeBtn;
    }
}