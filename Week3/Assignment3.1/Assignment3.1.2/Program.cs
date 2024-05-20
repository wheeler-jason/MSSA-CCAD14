namespace Assignment3._1._2
{
    /*
     * Given a year as integer, 
     * write a method that checks if year is a leap year.
     * Expected input and output:
     * IfYearIsLeap(2016) → true IfYearIsLeap(2018) → false
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test cases
            Console.WriteLine(IfYearIsLeap(2024));
            Console.WriteLine(IfYearIsLeap(2000));
            Console.WriteLine(IfYearIsLeap(1700));
            Console.WriteLine(IfYearIsLeap(2023));
            Console.WriteLine(IfYearIsLeap(2018));
            Console.WriteLine(IfYearIsLeap(2016));
        }

        /*
         * In the modern Gregorian Calendar,
         * Every year that is exactly divisible by four 
         * is a leap year, except for years that are exactly 
         * divisible by 100, but these centurial years are 
         * leap years if they are exactly divisible by 400. 
         * For example, the years 1700, 1800, and 1900 are not 
         * leap years, but the years 1600 and 2000 are.
         */
        public static bool IfYearIsLeap(int year)
        {
            if(year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
