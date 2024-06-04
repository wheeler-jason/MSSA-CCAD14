namespace Assignment5._2._2
{
    /*
     * Write a program in C# Sharp to print the 
     * first n natural number using recursion.
     * Test Data :
     * How many numbers to print : 10
     * Expected Output :
     * 1 2 3 4 5 6 7 8 9 10
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers to print: ");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintNaturalNumbers_Recursive(n);
        }

        public static void PrintNaturalNumbers_Recursive(int n)
        {
            if (n < 1)
            {
                return;
            }

            PrintNaturalNumbers_Recursive(n - 1);

            Console.Write(n + " ");
        }
    }
}
