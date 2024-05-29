using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2
{
    public class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }

        public override string ToString()
        {
            return $"{StudentId}, {Name}, {GPA}";
        }
    }
}
