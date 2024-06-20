using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7._3
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
