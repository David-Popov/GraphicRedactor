using GraphicRedactor.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Command
{
    public class FillCommand : CommandCl
    {
        public override List<Shape> Fill(List<Shape> shapes, Color color, Point point)
        {
            var newList = new List<Shape>(shapes);

            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].ContainsPoint(point))
                {
                    var shapeCopy = shapes[i].CloneShape();
                    shapeCopy.Color = color;
                    newList.Remove(shapes[i]);
                    newList.Add(shapeCopy);
                    break;
                }
            }
            return newList;
        }
    }
}
