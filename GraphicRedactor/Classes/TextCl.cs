using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Classes
{
    public class TextCl : Shape
    {
        public string Input { get; set; }
        SolidBrush brush;
        Font font;
        public TextCl()
        {
            
        }
        public TextCl(string input, SolidBrush brush, Font font)
        {
            Input = input;
            this.brush = brush;
            this.font = font;
        }

        public override void Draw(Graphics g, Pen p)
        {
            g.DrawString(Input,this.font,this.brush,this.StartLocation);
        }
    }
}
