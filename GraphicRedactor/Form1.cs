using GraphicRedactor.Classes;

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

        string shapeType = "rectangle";
        Bitmap bitmap;
        private Graphics g;
        List<Shape> listOfShapes = new List<Shape>();
        Pen pen = new Pen(Color.Black, 5);
        Shape shape = new Elipse();
        bool isDrawing = false;
        Point start;
        Point end;
        Color color;
        bool isSelecting = false;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isSelecting) { return; }
            isDrawing = true;
            shape = CreateNewShape(shapeType);
            start.X = e.X;
            start.Y = e.Y;
            //end.X = e.X;
            //end.Y = e.Y;
            shape.StartLocation = start;
            shape.Color = color;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                pictureBox1.Refresh();
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
            if (isSelecting) {
                return;
            }
            end.X = e.X;
            end.Y = e.Y;
            shape.Width = end.X - this.start.X;
            shape.Height = end.Y - this.start.Y;
            shape.EndLocation = end;
            label1.Text = shape.Width.ToString();
            label2.Text = shape.Height.ToString();
            shape.Draw(g, pen);
            isDrawing = false;
            listOfShapes.Add(shape);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (isSelecting)
            {
                foreach (var shape in listOfShapes)
                {
                    if (shape.StartLocation.X == e.X || shape.StartLocation.Y == e.Y || shape.EndLocation.X == e.X || shape.EndLocation.Y == e.Y)
                    {
                        shape.Color = Color.Red;
                        pen.Color = shape.Color;
                       // pictureBox1.Image = null;
                        shape.Draw(g, pen);
                        pen.Color = Color.Black;
                    }
                }
                isSelecting = false;
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gs = e.Graphics;
            if (isDrawing)
            {
                shape.Draw(gs, pen);
            }
        }

        private void Elipse_Click(object sender, EventArgs e)
        {
            shapeType = "elipse";
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            shapeType = "rectangle";

        }

        private void DrawTextBtn_Click(object sender, EventArgs e)
        {
            shapeType = "text";
            //FontFamily fontFamily = new FontFamily("Arial");
            //Font font = new Font(
            //   fontFamily,
            //   16,
            //   FontStyle.Regular,
            //   GraphicsUnit.Pixel);
            //var brush = new SolidBrush(Color.Black);

            //shape = new TextCl(textBox1.Text, brush, font);
        }

        private void Line_Click(object sender, EventArgs e)
        {
            shapeType = "line";

        }

        private void ColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            pen.Color = dlg.Color;
            color = dlg.Color;
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            isDrawing = false;
            isSelecting = true;
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
                    createdShape = new TextCl(textBox1.Text,new SolidBrush(Color.Black),new Font("Arial",30));
                    break;
                    default: return createdShape;
            }

            return createdShape;
        }
    }
}