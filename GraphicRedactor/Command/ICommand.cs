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
        public List<Shape> DeleteShape(List<Shape> shapes, Stack<List<Shape>> undoStack);
        public void SelectShape(Point point, List<Shape>shapes);
        public Shape MoveShape(Shape shape,Point startingPoint);
        public void ColorSelectedShape(List<Shape> shapes,Graphics g,PictureBox pictureBox1);
        public List<Shape> Fill(List<Shape> list,Color color,Point point);
    }
}
