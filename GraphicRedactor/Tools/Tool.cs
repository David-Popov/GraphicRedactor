using GraphicRedactor.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Tools
{
    public class Tool : ITool
    {
        public Shape CreateNewShape(string type)
        {
            Shape createdShape = null;

            switch (type.ToLower())
            {
                case "rectangle":
                    createdShape = new RectangleCl();
                    break;
                case "elipse":
                    createdShape = new Elipse();
                    break;
                case "line":
                    createdShape = new Line();
                    break;
                default: return createdShape = new RectangleCl();
            }

            return createdShape;
        }
    }
}
