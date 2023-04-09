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
        Stack<List<Shape>> undoStack = new Stack<List<Shape>>();
        Stack<List<Shape>> redoStack = new Stack<List<Shape>>();
        CommandCl command = new();
        Bitmap bitmap;
        Pen pen = new Pen(Color.Black, 10);
        Point start;
        Point end;
        private Graphics g;
        string type = "rectangle";
        bool isSelecting = false;
        bool isDrawing = false;
        bool isDeleting = false;
        bool isDoingUndoRedo = false;
        bool isFilling = false;
        bool isMoving = false;

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
            label2.Text = $"X: {e.X}; Y: {e.Y}";
            var selectedShape = listOfShapes.Where(x => x.IsFocused == true).FirstOrDefault();
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

        //Select Line is not working to be fixed !!!!!

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!SelectBtn.Focused && !FillBtn.Focused)
            {
                end.X = e.X;
                end.Y = e.Y;
                shape.EndLocation = end;
                shape.Draw(g);
                isDrawing = false;
                listOfShapes.Add(shape);
                undoStack.Push(new List<Shape>(listOfShapes));
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            Point p = new Point(e.X, e.Y);
            if (isSelecting)
            {
                command.SelectShape(p, listOfShapes);
                pictureBox1.Invalidate();
            }
            else if (isFilling)
            {
                listOfShapes = command.Fill(listOfShapes, pen.Color, p);
                undoStack.Push(new List<Shape>(listOfShapes));
                tool.RerenderShape(listOfShapes, g, pictureBox1, pen);
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gs = e.Graphics;

            if (isDrawing)
            {
                shape.Draw(gs);
            }
            else if (isSelecting)
            {
                command.ColorSelectedShape(listOfShapes, gs, pictureBox1);
            }
            else if (isDeleting)
            {
                tool.RerenderShape(listOfShapes, g, pictureBox1, pen);
                isDeleting = false;
            }
            else if (isDoingUndoRedo)
            {
                tool.RerenderShape(listOfShapes, g, pictureBox1, pen);
                isDoingUndoRedo = false;
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
            isDrawing = false;
            isSelecting = false;
            isDeleting = true;
            listOfShapes = command.DeleteShape(listOfShapes, undoStack);
            pictureBox1.Invalidate();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            isDoingUndoRedo = true;
            redoStack.Push(undoStack.Pop());
            if (undoStack.Count == 0)
            {
                g.Clear(pictureBox1.BackColor);
                pictureBox1.Invalidate();
                return;
            }
            listOfShapes = undoStack.Peek();
            pictureBox1.Invalidate();

        }

        private void Redo_Click(object sender, EventArgs e)
        {
            isDoingUndoRedo = true;
            undoStack.Push(new List<Shape>(listOfShapes));
            if (redoStack.Count == 0)
            {
                return;
            }
            listOfShapes = redoStack.Pop();
            pictureBox1.Invalidate();
        }

        private void FillBtn_Click(object sender, EventArgs e)
        {
            isDrawing = false;
            isSelecting = false;
            isFilling = true;
        }

        private void MoveBtn_Click(object sender, EventArgs e)
        {
            isMoving = true;
        }
    }
}