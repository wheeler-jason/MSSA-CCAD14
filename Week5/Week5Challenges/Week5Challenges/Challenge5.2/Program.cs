namespace Challenge5._2
{
    /*
     * Given an array nums containing n distinct numbers 
     * in the range [0, n], return the only number in the
     * range that is missing from the array.
     * 
     * Example 1:
     * 
     * Input: nums = [3,0,1]
     * 
     * Output: 2
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMissingNumber(new int[] {0,1}));
        }

        public static int FindMissingNumber(int[] nums)
        {
            int n = nums.Length;
            
            HashSet<int> hs = new HashSet<int>();
            foreach (int i in nums)
            {
                hs.Add(i);
            }

            for (int i = 0; i <= n; i++)
            {
                if (!hs.Contains(i))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
