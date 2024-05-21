namespace Assignment3._2._3
{
    /*
     * Create a console application to overload “+” and “-“ operator
     * for adding the areas of 2 circles and getting their 
     * area difference respectively.
     */

    class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public static double operator +(Circle circle1, Circle circle2)
        {
            return circle1.CalculateArea() + circle2.CalculateArea();
        }

        public static double operator -(Circle circle1, Circle circle2)
        {
            return circle1.CalculateArea() - circle2.CalculateArea();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(1.2);
            Circle circle2 = new Circle(3.4);


            Console.WriteLine($"The area of circle1 is {circle1.CalculateArea()}");
            Console.WriteLine($"The area of circle2 is {circle2.CalculateArea()}");

            // use the overloaded '+' operator
            Console.WriteLine($"The area of circle1 + circle2 is {circle1 + circle2}");
            
            // use the overloaded '-' operator
            Console.WriteLine($"The area of circle1 - circle2 is {circle1 - circle2}");
        }
    }
}
