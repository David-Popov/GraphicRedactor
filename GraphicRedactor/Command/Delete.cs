using GraphicRedactor.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Command
{
    public class Delete : CommandCl
    {
        public override List<Shape> DeleteShape(List<Shape> shapes,Stack<List<Shape>>undoStack)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].IsFocused == true)
                {
                    shapes.Remove(shapes[i]);
                    undoStack.Push(new List<Shape>(shapes));
                    break;
                }
                else
                {
                    continue;
                }
            }
            return shapes;
        }
    }
}
