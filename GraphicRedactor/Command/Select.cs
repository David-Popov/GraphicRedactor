using GraphicRedactor.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Command
{
    public class Select : CommandCl
    {
        public override void ColorSelectedShape(List<Shape> shapes, Graphics g, PictureBox pictureBox1)
        {
            var selectedShape = shapes.Where(x => x.IsFocused == true || x.Color == Color.Red).FirstOrDefault();
            if (selectedShape == null)
            {
                return;
            }
            selectedShape.Draw(g);
            pictureBox1.Invalidate();
        }

        public override void SelectShape(Point point, List<Shape> shapes)
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
