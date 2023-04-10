using GraphicRedactor.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicRedactor.Tools
{
    public class Tool
    {
        private Graphics g { get; set; }
        private readonly PictureBox pictureBox1;
        private Pen pen;
        public Tool(Graphics g, PictureBox pictureBox1, Pen pen)
        {
            this.g = g;
            this.pictureBox1 = pictureBox1;
            this.pen = pen;
        }
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
        public void RerenderShape(List<Shape> list)
        {
            if (list.Count == 0)
            {
                g.Clear(pictureBox1.BackColor);
                pictureBox1.Invalidate();
            }
            else
            {
                g.Clear(pictureBox1.BackColor);
                foreach (Shape shape in list)
                {
                    shape.Draw(g);
                }
                pictureBox1.Invalidate();
            }
        }

        public List<Shape> UndoOperation(Stack<List<Shape>>undoStack, Stack<List<Shape>> redoStack, List<Shape> list,PictureBox pictureBox1) 
        {

            redoStack.Push(undoStack.Pop());
            if (undoStack.Count == 0)
            {
                g.Clear(pictureBox1.BackColor);
                list.Clear();
                pictureBox1.Invalidate();
                return list;
            }
            list = undoStack.Peek();
            pictureBox1.Invalidate();
            return list;
        }

        public List<Shape> RedoOperation(Stack<List<Shape>> undoStack, Stack<List<Shape>> redoStack, List<Shape> list, PictureBox pictureBox1)
        {
            undoStack.Push(new List<Shape>(list));
            if (redoStack.Count == 0)
            {
                list.Clear();
                return list;
            }
            list = redoStack.Pop();
            pictureBox1.Invalidate();
            return list;
        }

        public void Serialize(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.ShapeType = shape.GetType().Name.ToString();
            }
            var json = JsonConvert.SerializeObject(shapes);
            File.WriteAllText(@"D:\\SaveShapes.json", json);
        }

        public List<Shape> Deserialize(string filename)
        {
            if (filename == "") return null;
            var json = File.ReadAllText(@$"{filename}");
            var deserializedShapes = JsonConvert.DeserializeObject<List<DeserializedObject>>(json);
            var listOfShapes = new List<Shape>();
            Shape createdShape;
            foreach (var shape in deserializedShapes)
            {
                if (shape.ShapeType == typeof(RectangleCl).Name.ToString())
                {
                    createdShape = new RectangleCl()
                    {
                        Color = shape.Color,
                        Width = shape.Width,
                        Height = shape.Height,
                        ShapeType = shape.ShapeType,
                        StartLocation = shape.StartLocation,
                        EndLocation = shape.EndLocation,
                        BorderColor = shape.BorderColor,
                        IsFocused = shape.IsFocused,
                        PreviousColor = shape.PreviousColor,
                    };
                    listOfShapes.Add(createdShape);
                }
                else if (shape.ShapeType == typeof(Elipse).Name.ToString())
                {
                    createdShape = new Elipse()
                    {
                        Color = shape.Color,
                        Width = shape.Width,
                        Height = shape.Height,
                        ShapeType = shape.ShapeType,
                        StartLocation = shape.StartLocation,
                        EndLocation = shape.EndLocation,
                        BorderColor = shape.BorderColor,
                        IsFocused = shape.IsFocused,
                        PreviousColor = shape.PreviousColor,
                    };
                    listOfShapes.Add(createdShape);
                }
                else if (shape.ShapeType == typeof(Line).Name.ToString())
                {
                    createdShape = new Line()
                    {
                        Color = shape.Color,
                        Width = shape.Width,
                        Height = shape.Height,
                        ShapeType = shape.ShapeType,
                        StartLocation = shape.StartLocation,
                        EndLocation = shape.EndLocation,
                        BorderColor = shape.BorderColor,
                        IsFocused = shape.IsFocused,
                        PreviousColor = shape.PreviousColor,
                    };
                    listOfShapes.Add(createdShape);
                }
            }
            if (listOfShapes.Count > 0)
            {
                return listOfShapes;
            }
            else
            {
                return new List<Shape>();
            }
        }
    }
}
