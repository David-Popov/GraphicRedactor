using GraphicRedactor.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicRedactor.Tools
{
    public class Tool : ITool
    {
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

        public void OnDelete(List<Shape> list,Graphics g, PictureBox pictureBox1,Pen pen)
        {
            if (list.Count == 0)
            {
                g.Clear(pictureBox1.BackColor);
               // isDeleting = false;
                pictureBox1.Invalidate();
            }
            else
            {
                g.Clear(pictureBox1.BackColor);
                foreach (Shape shape in list)
                {
                    shape.Draw(g, pen);
                }
               // isDeleting = false;
                pictureBox1.Invalidate();
            }
        }
        public void OnUndoRedoOperation(Stack<List<Shape>> undoStack,Graphics g,PictureBox pictureBox1, Pen pen) 
        {
            if (undoStack.Count == 0)
            {
                return;
            }
            else
            {
                var list = undoStack.Peek();
                g.Clear(pictureBox1.BackColor);
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].Draw(g, pen);
                }
                pictureBox1.Invalidate();
            }
        }
    }
}
