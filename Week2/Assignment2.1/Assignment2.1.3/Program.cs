using System.ComponentModel;

namespace Assignment2._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 2.1.3");

            // Test the methods
            Console.WriteLine($"1 + 2 = {Maths.Add(1, 2)}");
            Console.WriteLine($"1.23 + 2.34 + 3.45 = {Maths.Add(1.23M, 2.34M, 3.45M)}");
            Console.WriteLine($"1.23 * 2.34 * 3.45 = {Maths.Multiply(1.23F, 2.34F, 3.45F)}");
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
