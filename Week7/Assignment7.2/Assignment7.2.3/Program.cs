namespace Assignment7._2._3
{
    /*
     * Given two strings s and t, return true if t is an anagram of s, and false otherwise.
     * An Anagram is a word or phrase formed by rearranging the letters of 
     * a different word or phrase, typically using all the original letters exactly once.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test cases
            Console.WriteLine(IsAnagram("anagram", "nagaram")); // True
            Console.WriteLine(IsAnagram("rat", "car")); // False
            Console.WriteLine(IsAnagram("rat", "rat")); // True -- should duplicates count as anagrams?

        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            int[] count = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']++;
                count[t[i] - 'a']--;
            }

            foreach (int i in count)
            {
                if (i != 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
