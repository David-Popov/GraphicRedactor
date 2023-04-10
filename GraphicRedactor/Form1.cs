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
            tool = new(g, pictureBox1, pen);
        }

        Tool tool;
        Shape shape = new RectangleCl();
        List<Shape> listOfShapes = new List<Shape>();
        Stack<List<Shape>> undoStack = new Stack<List<Shape>>();
        Stack<List<Shape>> redoStack = new Stack<List<Shape>>();
        CommandCl command = new();
        Bitmap bitmap;
        Pen pen = new Pen(Color.Black, 10);
        Point start;
        Point end;
        Point point;
        private Graphics g;
        string type = "rectangle";
        bool isSelecting = false;
        bool isDrawing = false;
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
            else if (isMoving == true)
            {
                command = new MoveCommand();
                selectedShape = command.MoveShape(selectedShape, start);
                point = new Point(e.X, e.Y);
                pictureBox1.Invalidate();
            }
        }

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
                command = new SelectCommand();
                command.SelectShape(p, listOfShapes);
                pictureBox1.Invalidate();
            }
            else if (isFilling)
            {
                command = new FillCommand();
                listOfShapes = command.Fill(listOfShapes, pen.Color, p);
                undoStack.Push(new List<Shape>(listOfShapes));
                tool.RerenderShape(listOfShapes);
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
            command = new DeleteCommand();
            listOfShapes = command.DeleteShape(listOfShapes, undoStack);
            tool.RerenderShape(listOfShapes);
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            listOfShapes = tool.UndoOperation(undoStack, redoStack, listOfShapes, pictureBox1);
            if (listOfShapes.Count == 0 && redoStack.Count > 0)
            {
                g.Clear(pictureBox1.BackColor);
                Undo.Enabled = false;
                Redo.Enabled = true;
            }
            tool.RerenderShape(listOfShapes);
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            listOfShapes = tool.RedoOperation(undoStack, redoStack, listOfShapes, pictureBox1);
            if (redoStack.Count == 0)
            {
                g.Clear(pictureBox1.BackColor);
                Undo.Enabled = true;
                Redo.Enabled = false;
            }
            tool.RerenderShape(listOfShapes);
        }

        private void FillBtn_Click(object sender, EventArgs e)
        {
            isDrawing = false;
            isSelecting = false;
            isFilling = true;
        }

        private void MoveBtn_Click(object sender, EventArgs e)
        {
            isDrawing = false;
            isMoving = true;
        }

        private void SerializeBtn_Click(object sender, EventArgs e)
        {
            tool.Serialize(listOfShapes);
        }

        private void DeserializeBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            DialogResult result = folderBrowser.ShowDialog();
            string filePath = "";
            if (result == DialogResult.OK)
            {
                filePath = folderBrowser.FileName;
            }

            listOfShapes = tool.Deserialize(filePath);
            tool.RerenderShape(listOfShapes);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            listOfShapes.Clear();
            pictureBox1.Invalidate();
        }
    }
}