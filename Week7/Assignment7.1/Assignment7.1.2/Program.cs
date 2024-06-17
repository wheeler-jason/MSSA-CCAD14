namespace Assignment7._1._2
{
    /* You are given two strings word1 and word2. 
     * Merge the strings by adding letters in alternating order, 
     * starting with word1. If a string is longer than the other, 
     * append the additional letters onto the end of the merged string.
     * Return the merged string.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static string MergeAlternately(string word1, string word2)
        {
            string result = "";
            int i = 0;
            while (i < word1.Length && i < word2.Length)
            {
                result += word1[i];
                result += word2[i];
                i++;
            }

            // only one of these while loops will execute
            // depending on which string is longer
            while (i < word1.Length)
            {
                result += word1[i];
                i++;
            }
            while (i < word2.Length)
            {
                result += word2[i];
                i++;
            }
            return result;
        }
    }
}
