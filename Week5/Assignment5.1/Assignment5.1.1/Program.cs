namespace Assignment5._1._1
{
    /*
     * Given an integer x, 
     * return true if x is a palindrome, 
     * and false otherwise.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment5.1.1");
        }

        public static bool IsPalindrome_Optimal(int x)
        {
            string str = x.ToString();

            int indexFront = 0;
            int indexBack = str.Length - 1;

            while (indexFront < indexBack)
            {
                if (str[indexFront] != str[indexBack])
                    return false;

                indexFront++;
                indexBack--;
            }

            return true;
        }

        public static bool IsPalindrome_Reverse(int x)
        {
            string str = x.ToString();
            string strReversed = str.Reverse().ToString();
            return str == strReversed;
        }

        public static bool IsPalindrome_Recursive(int x)
        {
            string str = x.ToString();
          
            // base case
            if(str.Length <= 1)
                return true;

            // comparison
            if (str[0] != str[str.Length-1]) 
                return false;

            // recursive function call
            return IsPalindrome_Recursive(Convert.ToInt32(str.Substring(1, str.Length-2)));

        }
    }
}
