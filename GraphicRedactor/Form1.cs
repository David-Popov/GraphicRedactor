using GraphicRedactor.Classes;
using GraphicRedactor.Command;
using GraphicRedactor.Tools;
using System.Drawing;

namespace GraphicRedactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }

        Tool tool = new();
        Shape shape = new RectangleCl();
        List<Shape> listOfShapes = new List<Shape>();
        CommandCl command = new();
        Bitmap bitmap;
        Pen pen = new Pen(Color.Black, 5);
        Point start;
        Point end;
        private Graphics g;
        string type = "rectangle";
        bool isSelecting = false;
        bool isDrawing = false;
        bool isDeleting = false;


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            shape = tool.CreateNewShape(type);
            shape.Color = pen.Color;
            start.X = e.X;
            start.Y = e.Y;
            shape.StartLocation = start;

        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                end.X = e.X;
                end.Y = e.Y;
                shape.Width = end.X - this.start.X;
                shape.Height = end.Y - this.start.Y;
                shape.EndLocation = end;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!SelectBtn.Focused) {
                end.X = e.X;
                end.Y = e.Y;
                shape.EndLocation = end;
                shape.Draw(g, pen);
                isDrawing = false;
                listOfShapes.Add(shape);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            Point p = new Point(e.X, e.Y);
            command.SelectShape(p, listOfShapes);
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gs = e.Graphics;

            if (isDrawing)
            {
                shape.Draw(gs, pen);
            }
            else if (isSelecting)
            {
                command.ColorSelectedShape(listOfShapes, gs);
            }
            else if (isDeleting)
            {
                if (listOfShapes.Count == 0)
                {
                    pictureBox1.Image = null;
                    pictureBox1.Update();
                    isDeleting = false;
                }
                else
                {
                    g.Clear(pictureBox1.BackColor);
                    foreach (Shape shape in listOfShapes)
                    {
                        shape.Draw(g, pen);
                    }
                    isDeleting = false;
                    pictureBox1.Invalidate();
                }
            }
        }

        private void Elipse_Click(object sender, EventArgs e)
        {
            type = "elipse";
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            type = "rectangle";
        }

        private void Line_Click(object sender, EventArgs e)
        {
            type = "line";
        }

        private void ColorPickerBtn_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            pen.Color = dlg.Color;
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            isDrawing = false;
            isSelecting = true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            isSelecting = false;
            isDeleting = true;
            listOfShapes = command.DeleteShape(listOfShapes);
            pictureBox1.Invalidate();
        }
    }
}