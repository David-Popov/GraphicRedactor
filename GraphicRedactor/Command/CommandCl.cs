using GraphicRedactor.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicRedactor.Command
{
    public class CommandCl : ICommand
    {
        public virtual void ColorSelectedShape(List<Shape> shapes, Graphics g, PictureBox pictureBox1)
        {
            var selectedShape = shapes.Where(x => x.IsFocused == true || x.Color == Color.Red).FirstOrDefault();
            if (selectedShape == null)
            {
                return;
            }
            selectedShape.Draw(g);
        }
        public virtual List<Shape> DeleteShape(List<Shape> shapes, Stack<List<Shape>> undoStack)
        {
            //for (int i = 0; i < shapes.Count; i++)
            //{
            //    if (shapes[i].IsFocused == true)
            //    {
            //        shapes[i].IsFocused = false;
            //        shapes[i].BorderColor = Color.Gray;
            //        undoStack.Push(new List<Shape>(shapes));
            //        shapes.Remove(shapes[i]);
            //        undoStack.Push(new List<Shape>(shapes));
            //        break;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            return shapes;
        }
        public virtual void SelectShape(Point point, List<Shape> shapes)
        {
            //for (int i = 0; i < shapes.Count; i++)
            //{
            //    if (shapes[i].IsFocused == true)
            //    {

            //        shapes[i].Color = shapes[i].PreviousColor;
            //        shapes[i].BorderColor = Color.Gray;
            //        shapes[i].IsFocused = false;
            //    }

            //}
            //for (int i = 0; i < shapes.Count; i++)
            //{
            //    if (shapes[i].ContainsPoint(point))
            //    {
            //        if (shapes[i].GetType() == typeof(Line))
            //        {
            //            shapes[i].PreviousColor = shapes[i].Color;
            //            shapes[i].Color = Color.Red;
            //            shapes[i].IsFocused = true;
            //            break;
            //        }
            //        else
            //        {
            //            shapes[i].PreviousColor = shapes[i].Color;
            //            shapes[i].BorderColor = Color.Red;
            //            shapes[i].IsFocused = true;
            //            break;

            //        }
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}

        }
        public virtual List<Shape> Fill(List<Shape> shapes, Color color, Point point)
        {
            //var newList = new List<Shape>(shapes);

            //for (int i = 0; i < shapes.Count; i++)
            //{
            //    if (shapes[i].ContainsPoint(point))
            //    {
            //        var shapeCopy = shapes[i].CloneShape();
            //        shapeCopy.Color = color;
            //        newList.Remove(shapes[i]);
            //        newList.Add(shapeCopy);
            //        //var shapeCopy = shapes[i];
            //        //shapes.Remove(shapes[i]);
            //        //shapes.Add(shapeCopy);
            //        break;
            //    }
            //}
            return shapes;
        }
        public void MoveShape()
        {
        }

    }
}
