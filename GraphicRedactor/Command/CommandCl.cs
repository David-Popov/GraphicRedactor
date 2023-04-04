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
        public void ColorSelectedShape(List<Shape> shapes,Graphics g)
        {
            var selectedShape = shapes.Where(x => x.IsFocused == true || x.Color == Color.Red).FirstOrDefault();
            if (selectedShape == null)
            {
                return;
            }
            selectedShape.Draw(g, new Pen(selectedShape.Color));
        }

        public Shape CopyShape()
        {
            return null;
        }

        public List<Shape> DeleteShape(List<Shape> shapes)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].IsFocused == true)
                {
                    shapes.Remove(shapes[i]);
                    break;
                }
                else
                {
                    continue;
                }
            }
            return shapes;
        }

        public void Fill(Shape shape)
        {
            throw new NotImplementedException();
        }

        public void MoveShape()
        {
        }

        public void SelectShape(Point point, List<Shape> shapes)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].IsFocused == true)
                {
                    shapes[i].Color = Color.Black;
                    shapes[i].IsFocused = false;
                }
            }
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].ContainsPoint(point))
                {
                    shapes[i].Color = Color.Red;
                    shapes[i].IsFocused = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            
        }
    }
}
