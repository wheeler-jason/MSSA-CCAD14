namespace Assignment1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the shape area calculator thingy!\n");
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            string operation = "";
            while (true)
            {
                Console.WriteLine("Select your desired operation below:");
                Console.WriteLine("Enter 'T' to calculate the area of a triangle");
                Console.WriteLine("Enter 'S' to calculate the area of a square");
                Console.WriteLine("Enter 'R' to calculate the area of a rectangle");
                Console.WriteLine("Enter 'X' to exit the program\n");
                operation = Console.ReadLine();
                Console.WriteLine();
                if (operation == "X" || operation == "x") break;

                switch (operation)
                {
                    case "T":
                    case "t":
                        Console.WriteLine("\nWhat is the base length of the triangle?\n");
                        double baseLength = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nWhat is the height of the triangle?\n");
                        double height = Convert.ToDouble(Console.ReadLine());
                        CalculateTriangleArea(baseLength, height);
                        break;
                    case "S":
                    case "s":
                        Console.WriteLine("\nWhat is the length of a side of the square?\n");
                        double sideLength = Convert.ToDouble(Console.ReadLine());
                        CalculateSquareArea(sideLength);
                        break;
                    case "R":
                    case "r":
                        Console.WriteLine("\nWhat is the length of the rectangle?\n");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nWhat is the width of the rectangle?\n");
                        double width = Convert.ToDouble(Console.ReadLine());
                        CalculateRectangleArea(length, width);
                        break;
                    default:
                        Console.WriteLine("\nInvalid operation\n");
                        break;
                }
            }
        }

        static void CalculateTriangleArea(double baseLength, double height)
        {
            Console.WriteLine($"\nThe area of the triangle is {0.5 * baseLength * height}\n");
        }

        static void CalculateSquareArea(double sideLength)
        {
            Console.WriteLine($"\nThe area of the square is {sideLength * sideLength}\n");
        }

        static void CalculateRectangleArea(double length, double width)
        {
            Console.WriteLine($"\nThe area of the rectangle is {length * width} \n");
        }
    }
}
