namespace Assignment3._1._4
{
    /*
     * Write a C# Sharp program to accept a coordinate point 
     * in an XY coordinate system and determine in which 
     * quadrant the coordinate point lies.
     * Test Data :
     * Input the value for X coordinate :7
     * Input the value for Y coordinate :9
     * Expected Output :
     * The coordinate point (7,9) lies in the First quadrant.
     */
    enum Quadrant
    {
        None,
        First,
        Second,
        Third,
        Fourth
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the value for X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value for Y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the {DetermineQuadrant(x,y)} quadrant.");
        }
        public static Quadrant DetermineQuadrant(int x, int y)
        {
            if(IsPositive(x) && IsPositive(y))
            {
                return Quadrant.First;
            }
            if (IsNegative(x) && IsPositive(y))
            {
                return Quadrant.Second;
            }
            if (IsNegative(x) && IsNegative(y))
            {
                return Quadrant.Third;
            }
            if (IsPositive(x) && IsNegative(y))
            {
                return Quadrant.Fourth;
            }
            return Quadrant.None;
        }
        public static bool IsNegative(int value)
        {
            return value < 0;
        }
        public static bool IsPositive(int value)
        {
            return value > 0;
        }
    }
}
