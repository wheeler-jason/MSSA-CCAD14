namespace Assignment10._2._1
{
    /*
     * Write a program in C# Sharp to find the positive numbers
     * from a list of numbers using where conditions in LINQ Query.
     * Input: { 2, -1, 3, -3, 10, -200}
     * Expected output: {2, 3, 10}
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the list of numbers
            int[] numbers = { 2, -1, 3, -3, 10, -200 };

            var positiveNumbersQuery = from num in numbers
                                       where num > 0
                                       select num;
 
            foreach (var num in positiveNumbersQuery)
            {
                Console.WriteLine(num);
            }
        }
    }
}
