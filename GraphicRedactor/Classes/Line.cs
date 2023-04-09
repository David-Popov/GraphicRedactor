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
        public override void Draw(Graphics g)
        {
            g.DrawLine(new Pen(this.Color,8),this.StartLocation,this.EndLocation);
        }

        public override Shape CloneShape()
        {
            var shapeCopy = new Line();
            shapeCopy.Color = this.Color;
            shapeCopy.BorderColor = this.BorderColor;
            shapeCopy.IsFocused = this.IsFocused;
            shapeCopy.Width = this.Width;
            shapeCopy.Height = this.Height;
            shapeCopy.EndLocation = this.EndLocation;
            shapeCopy.StartLocation = this.StartLocation;
            return shapeCopy;
        }
    }
}
