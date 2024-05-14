using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    internal class Square : Shape
    {
        double _sideLength;

        public double SideLength 
        { 
            get
            {
                return _sideLength;
            }
            set
            {
                _sideLength = value;
            }
        }

        public Square(double sideLength) 
        { 
            _sideLength = sideLength;
        }

        public override double CalculateShapeArea()
        {
            return SideLength * SideLength;
        }
    }
}
