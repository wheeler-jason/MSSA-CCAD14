namespace Assignment5._1._2
{
    /*
     * Write a recursive function to 
     * calculate the sum of the individual 
     * digits of a given number.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumAllDigits(123));
        }

        public static int SumAllDigits(int n)
        {
            int lastDigit = n % 10;
            int numMinusLastDigit = n / 10;
            
            // base case
            if (numMinusLastDigit == 0) 
                return lastDigit;
            
            return lastDigit + SumAllDigits(numMinusLastDigit);
        }
    }
}
