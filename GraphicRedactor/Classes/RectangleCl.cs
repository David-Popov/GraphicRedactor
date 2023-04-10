using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Classes
{
    public class RectangleCl : Shape
    {
        public RectangleCl()
        {
            //this.ShapeType = typeof(RectangleCl).BaseType.Name.ToString();
        }
        public override bool ContainsPoint(Point point)
        {
            return point.X >= StartLocation.X && point.X <= EndLocation.X && point.Y >= StartLocation.Y && point.Y <= EndLocation.Y;
        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(this.Color),this.StartLocation.X,this.StartLocation.Y,this.Width, this.Height);
            g.DrawRectangle(new Pen(this.BorderColor,5), this.StartLocation.X, this.StartLocation.Y, this.Width, this.Height);
        }

        public override Shape CloneShape()
        {
            var shapeCopy = new RectangleCl();
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
