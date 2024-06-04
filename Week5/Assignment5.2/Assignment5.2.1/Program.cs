namespace Assignment5._2._1
{
    /*
     * Given a string s consisting of words and spaces, 
     * return the length of the last word in the string. 
     * A word is a maximal substring consisting 
     * of non-space characters only.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastWordLength("Hello World!"));
        }

        public static int GetLastWordLength(string s)
        {
            int result = 0;
            int i = s.Length - 1;
            while (i >= 0 && s[i] != ' ') 
            {
                result++;
                i--;
            }

            return result;
        }
    }
}
