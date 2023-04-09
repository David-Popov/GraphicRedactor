using GraphicRedactor.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicRedactor.Tools
{
    public class Tool
    {
        private Graphics g { get; set; }
        private readonly PictureBox pictureBox1;
        private Pen pen;
        public Tool(Graphics g, PictureBox pictureBox1, Pen pen)
        {
            this.g = g;
            this.pictureBox1 = pictureBox1;
            this.pen = pen;
        }
        public Shape CreateNewShape(string type)
        {
            Shape createdShape = null;

            switch (type.ToLower())
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
                default: return createdShape = new RectangleCl();
            }

            return createdShape;
        }
        public void RerenderShape(List<Shape> list)
        {
            if (list.Count == 0)
            {
                g.Clear(pictureBox1.BackColor);
                pictureBox1.Invalidate();
            }
            else
            {
                g.Clear(pictureBox1.BackColor);
                foreach (Shape shape in list)
                {
                    shape.Draw(g);
                }
                pictureBox1.Invalidate();
            }
        }

        public List<Shape> UndoOperation(Stack<List<Shape>>undoStack, Stack<List<Shape>> redoStack, List<Shape> list,PictureBox pictureBox1) 
        {

            redoStack.Push(undoStack.Pop());
            if (undoStack.Count == 0)
            {
                g.Clear(pictureBox1.BackColor);
                list.Clear();
                pictureBox1.Invalidate();
                return list;
            }
            list = undoStack.Peek();
            pictureBox1.Invalidate();
            return list;
        }

        public List<Shape> RedoOperation(Stack<List<Shape>> undoStack, Stack<List<Shape>> redoStack, List<Shape> list, PictureBox pictureBox1)
        {
            undoStack.Push(new List<Shape>(list));
            if (redoStack.Count == 0)
            {
                list.Clear();
                return list;
            }
            list = redoStack.Pop();
            pictureBox1.Invalidate();
            return list;
        }
    }
}
