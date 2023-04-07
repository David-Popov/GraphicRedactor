﻿using System;
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
        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(this.Color),this.StartLocation.X,this.StartLocation.Y,this.Width, this.Height);
            g.DrawRectangle(new Pen(this.BorderColor,5), this.StartLocation.X, this.StartLocation.Y, this.Width, this.Height);
        }
    }
}
