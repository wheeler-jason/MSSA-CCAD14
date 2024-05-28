namespace Challenge3._1
{
    /*
     * Given a string, write a method that checks if it is a palindrome
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to test if it is a palindrome: ");
            string str = Console.ReadLine();

            if (IsPalindrome(str))
            {
                Console.WriteLine($"'{str}' is a palindrome");
            }
            else
            {
                Console.WriteLine($"'{str}' is NOT a palindrome");
            }
            
        }

        public static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length/2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
