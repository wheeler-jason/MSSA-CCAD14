using System.ComponentModel;

namespace Assignment2._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 2.1.3");
        }
    }

    public static class Maths
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2, decimal num3)
        {
            return num1 + num2 + num3;
        }

        public static float Multiply(float num1, float num2) 
        { 
            return num1 * num2;
        }

        public static float Multiply(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }
    }
}
