namespace Assignment1._4
{
    internal class Program
    {
        struct Point
        {
            public double x, y;

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            // Testing the CompareX function:
            // insert different X values into the points to test different conditions

            Point p1 = new Point(4.0, 4.0);
            Point p2 = new Point(4.0, 5.0);
            CompareX(p1, p2);

        }

        static void CompareX(Point p1, Point p2)
        {
            if(p1.x == p2.x) 
            { 
                Console.WriteLine("Both points have equal X values");
            }
            else if (p1.x > p2.x)
            {
                Console.WriteLine("p1 is farther to the right");
            }
            else 
            {
                Console.WriteLine("p2 is farther to the right");
            }
        }
    }
}
