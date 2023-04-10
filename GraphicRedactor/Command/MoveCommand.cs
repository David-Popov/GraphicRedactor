using GraphicRedactor.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Command
{
    public class MoveCommand : CommandCl
    {
        public override Shape MoveShape(Shape shape, Point Point)
        {
            shape.StartLocation = new Point(shape.StartLocation.X + (shape.StartLocation.X - Point.X),shape.StartLocation.Y + (shape.StartLocation.Y - Point.Y));
            return shape;
        }
    }
}
