using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Classes
{
    public class RectangleCl : Shape
    {
        public override bool ContainsPoint(Point point)
        {
            return point.X >= StartLocation.X && point.X <= EndLocation.X && point.Y >= StartLocation.Y && point.Y <= EndLocation.Y;
        }
        public override void Draw(Graphics g, Pen p)
        {
            g.DrawRectangle(p,this.StartLocation.X,this.StartLocation.Y,this.Width,this.Height);
        }
    }
}
