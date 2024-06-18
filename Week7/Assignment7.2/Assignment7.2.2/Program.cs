namespace Assignment7._2._2
{
    /*
     * Given a string s, reverse only all the vowels in the string and return it.
     * The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear 
     * in both lower and upper cases, more than once.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before reversal: ");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("After reversal: ");
            Console.WriteLine(ReverseVowels("Hello, World!"));
        }

        public static string ReverseVowels(string s)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] str = s.ToCharArray();
            
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (vowels.Contains(str[left]) && vowels.Contains(str[right]))
                {
                    char temp = str[left];
                    str[left] = str[right];
                    str[right] = temp;
                    left++;
                    right--;
                }
                else if (vowels.Contains(str[left]))
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return new string(str);
        }
    }
}
