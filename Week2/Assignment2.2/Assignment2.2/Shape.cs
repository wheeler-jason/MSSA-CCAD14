using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    public enum ColorValues { Red, Blue, Green }

    internal abstract class Shape
    {
        public string ShapeId {  get; set; }
        public string ShapeName { get; set; }
        public string ShapeDescription { get; set; }
        public ColorValues ShapeColor { get; set; }

        public abstract double CalculateShapeArea();
    }
}
