namespace Challenge3._2
{
    /*
     * Sum digits in string
     * Given a string, write a method which returns 
     * sum of all digits in that string. Assume that 
     * string contains only single digits.
     * 
     * Expected input and output:
     * SumDigitsInString("1q2w3e") → 6 
     * SumDigitsInString("L0r3m.1p5um") → 9
     * SumDigitsInString("") → 0
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = SumDigitsInString("1q2w3e");
            Console.WriteLine($"1q2w3e: {result}");

            result = SumDigitsInString("L0r3m.1p5um");
            Console.WriteLine($"L0r3m.1p5um: {result}");

            result = SumDigitsInString("");
            Console.WriteLine($"\"\": {result}");
        }

        public static double SumDigitsInString(string input)
        {
            double result = 0;
            foreach (char c in input)
            {
                if(Char.IsDigit(c))
                {
                    result += Char.GetNumericValue(c);
                }
            }
            return result;
        }
    }
}
