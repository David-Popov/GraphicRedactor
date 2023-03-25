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
        public TextCl(string input)
        {
            Input = input;
        }

        public override void Draw(Graphics g, Pen p)
        {
            var brush = new SolidBrush(Color.Black);
            g.DrawString(Input,new Font("Arial",50),brush,this.StartLocation);
        }
    }
}
