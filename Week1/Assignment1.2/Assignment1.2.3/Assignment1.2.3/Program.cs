namespace Assignment1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string operation = "";
            int result = 0;

            while (true)
            {
                Console.WriteLine("Welcome to Console Calculator 1.0");
                Console.WriteLine("Enter 'A' to add two numbers");
                Console.WriteLine("Enter 'S' to subtract two numbers");
                Console.WriteLine("Enter 'X' to exit the program");
                operation = Console.ReadLine();
                if (operation == "x" || operation == "X") { break; }

                Console.WriteLine("\nEnter the first number you would like to operate on: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter the second number you would like to operate on: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case "A":
                    case "a":
                        result = addTwoNums(num1, num2);
                        Console.WriteLine($"\n{num1} + {num2} = {result}\n");
                        break;
                    case "S":
                    case "s":
                        result = subtractTwoNums(num1, num2);
                        Console.WriteLine($"\n{num1} - {num2} = {result}\n");
                        break;
                    case "X":
                    case "x":
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine();
            }
        }

        static int addTwoNums(int num1, int num2)
        {
            return num1 + num2;
        }

        static int subtractTwoNums(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
