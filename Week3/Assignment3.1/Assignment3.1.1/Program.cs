using System.Text;

namespace Assignment3._1._1
{
    /*
     * Write a method that returns a string of even numbers greater than 0 and less than 100.
     * (Use StringBuilder class)
     * Expected input and output:
     * ReturnEvenNumbers() → 
     * "2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60 62 64 66 68 70 72 74 76 78 80 82 84 86 88 90 92 94 96 98"
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnEvenNumbers());
        }

        public static string ReturnEvenNumbers()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 2; i <= 98; i++)
            {
                // if this condition is true, then i is an even number
                if (i % 2 == 0)
                {
                    sb.Append($"{i} ");
                }
            }
            
            return sb.ToString();
        }
    }
}
