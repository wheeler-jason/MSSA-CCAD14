using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1._2
{
    public interface ICalculator
    {
        public double Add(double value1, double value2);
        public double Subtract(double value1, double value2);
        public double Multiply(double value1, double value2);
        public double Divide(double value1, double value2);
    }
}
