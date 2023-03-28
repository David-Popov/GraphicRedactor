using GraphicRedactor.Classes;
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

        Bitmap bitmap;
        private Graphics g;
        List<Shape> listOfShapes = new List<Shape>();
        Pen pen = new Pen(Color.Black, 5);
        Shape shape = new Elipse();
        bool isDrawing = false;
        Point start;
        Point end;
        string type = "rectangle";
        bool isSelecting = false;


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            shape = CreateNewShape(type);
            shape.Color = pen.Color;
            start.X = e.X;
            start.Y = e.Y;
            shape.StartLocation = start;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Refresh();
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
            isDrawing = false;
            end.X = e.X;
            end.Y = e.Y;
            shape.EndLocation = end;
            shape.Draw(g, pen);
            listOfShapes.Add(shape);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            SelectShape(p);
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gs = e.Graphics;

            if (isDrawing)
            {
                shape.Draw(gs, pen);
            }
            if (isSelecting)
            {
                DrawShapes();
            }


        }

        public void DrawShapes()
        {
            for (int i = 0; i < listOfShapes.Count; i++)
            {
                listOfShapes[i].Draw(g, new Pen(listOfShapes[i].Color));
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

        private void DrawTextBtn_Click(object sender, EventArgs e)
        {

        }

        private void Line_Click(object sender, EventArgs e)
        {
            type = "line";
        }

        public void SelectShape(Point point)
        {
            for (int i = 0; i < listOfShapes.Count; i++)
            {
                if (listOfShapes[i].ContainsPoint(point))
                {
                    listOfShapes[i].Color = Color.Red;
                    pen.Color = shape.Color;
                    break;
                }
            }

            pictureBox1.Invalidate();
        }

        private Shape CreateNewShape(string type)
        {
            Shape createdShape = null;

            switch (type)
            {
                case "rectangle":
                    createdShape = new RectangleCl();
                    break;
                case "elipse":
                    createdShape = new Elipse();
                    break;
                case "line":
                    createdShape = new Line();
                    break;
                case "text":
                    createdShape = new TextCl(textBox1.Text, new SolidBrush(Color.Black), new Font("Arial", 30));
                    break;
                default: return createdShape;
            }

            return createdShape;
        }

        private void ColorPickerBtn_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            pen.Color = dlg.Color;
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            isSelecting = true;
        }
    }
}