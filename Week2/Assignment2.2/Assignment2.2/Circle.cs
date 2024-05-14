using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    internal class Circle : Shape
    {
        public double _circleRadius;
        public double CircleRadius 
        { 
            get
            {
                return _circleRadius;
            }
            
            set
            {
                _circleRadius = value;
            }
         }

        public Circle(double circleRadius)
        {
            _circleRadius= circleRadius;
        }

        public override double CalculateShapeArea()
        {
            return Math.PI * CircleRadius * CircleRadius;
        }
    }
}
