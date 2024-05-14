namespace Assignment2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 2.2");
            Console.WriteLine("Would you like to calculate the area of a circle or a square?");
            Console.WriteLine("Enter 1 for circle");
            Console.WriteLine("Enter 2 for square");

            // Implement error handling when reading user input
            try
            {
                int userShape = Convert.ToInt32(Console.ReadLine());
                while (!(userShape == 1 || userShape == 2))
                {
                    Console.WriteLine("Invalid input. Please enter 1 or 2.");
                    userShape = Convert.ToInt32(Console.ReadLine());
                }
               
                // User wants to calculate the area of a circle
                if (userShape == 1)
                {
                    Console.WriteLine("You chose to calculate the area of a: circle");
                    Console.WriteLine("What is the radius of the circle?");
                    Console.WriteLine("Enter a whole number or decimal as the radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(radius);
                    double circleArea = circle.CalculateShapeArea();
                    Console.WriteLine($"The area of a circle with a radius of {radius} is: {circleArea:F2}.");

                }
                // User wants to calculate the area of a square
                else
                {
                    Console.WriteLine("You chose to calculate the area of a: square");
                    Console.WriteLine("What is the length of one of the sides?");
                    Console.WriteLine("Enter a whole number or decimal as the side length: ");
                    double sideLength = Convert.ToDouble(Console.ReadLine());
                    Square square = new Square(sideLength);
                    double squareArea = square.CalculateShapeArea();
                    Console.WriteLine($"The area of a square with a side length of {sideLength} is: {squareArea:F2}.");
                }    
            }
            catch(Exception e) 
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}
