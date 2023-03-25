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

        Bitmap bitmap;
        private Graphics g;
        List<Shape> listOfShapes = new List<Shape>();
        Pen pen = new Pen(Color.Black, 5);
        Shape shape = new Elipse();
        bool isDrawing = false;
        Point start;
        Point end;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            start = new Point(e.X, e.Y);
            end = new Point(e.X, e.Y);
            shape.StartLocation = start;
            shape.EndLocation = end;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Refresh();
            end.X = e.X;
            end.Y = e.Y;
            shape.Width = end.X - this.start.X;
            shape.Height = end.Y - this.start.Y;
            shape.EndLocation = end;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            end.X = e.X;
            end.Y = e.Y;
            shape.EndLocation = end;
            shape.Draw(g, pen);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

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
            shape = new Elipse();
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            shape = new RectangleCl();
        }

        private void DrawTextBtn_Click(object sender, EventArgs e)
        {
            shape = new TextCl(textBox1.Text);
        }

        private void Line_Click(object sender, EventArgs e)
        {
            shape = new Line();
        }
    }
}