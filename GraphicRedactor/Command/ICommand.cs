using GraphicRedactor.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Command
{
    public interface ICommand
    {
        public List<Shape> DeleteShape(List<Shape> shapes);
        public void SelectShape(Point point, List<Shape>shapes);
        public void MoveShape();
        public Shape CopyShape();
        public void ColorSelectedShape(List<Shape> shapes,Graphics g);
        public void Fill(Shape shape);
    }
}
