using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Classes
{
    public class Line : Shape
    {
        public override bool ContainsPoint(Point point)
        {
            return point.X >= StartLocation.X && point.X <= EndLocation.X && point.Y >= StartLocation.Y && point.Y <= EndLocation.Y;
        }
        public override void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p,this.StartLocation,this.EndLocation);
        }
    }
}
