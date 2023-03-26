using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Classes
{
    public abstract class Shape
    {
        public Point StartLocation { get; set; }
        public Point EndLocation { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Color Color { get; set; }
        public abstract void Draw(Graphics g, Pen p);
    }
}
