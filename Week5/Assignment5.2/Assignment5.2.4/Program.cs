namespace Assignment5._2._4
{
    /*
     * Write a program in C# Sharp to check 
     * whether a given string is Palindrome 
     * or not using recursion.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to test if it's a palindrome: ");
            string word = Console.ReadLine();

            if(IsPalindrome(word))
            {
                Console.WriteLine($"{word} is a palindrome");
            } else
            {
                Console.WriteLine($"{word} is not a palindrome");
            }
            
        }

        public static bool IsPalindrome(string str)
        {
            if (str.Length < 2)
            {
                return true;
            }

            if (str[0] != str[str.Length - 1])
            {
                return false;
            }

            return IsPalindrome(str.Substring(1, str.Length - 2));
        }
    }
}
