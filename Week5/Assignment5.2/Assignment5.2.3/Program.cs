namespace Assignment5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers to print: ");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintNaturalNumbersInReverse_Recursive(n);
        }

        public static void PrintNaturalNumbersInReverse_Recursive(int n)
        {
            if (n < 1)
            {
                return;
            }

            Console.Write(n + " ");

            PrintNaturalNumbersInReverse_Recursive(n - 1);
        }
    }
}
