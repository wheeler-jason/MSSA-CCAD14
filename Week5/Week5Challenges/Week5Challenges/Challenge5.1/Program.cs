namespace Challenge5._1
{
    /*
     * Given a non-empty array of integers nums, 
     * every element appears twice except for one. 
     * Find that single one.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [0,0,1,2,2,3,4,5,4,3];
            Console.WriteLine(FindTheOne(nums));

        }

        public static int FindTheOne(int[] nums)
        {

            // Count the occurrence of each element in the nums array
            Dictionary<int,int> counts = new Dictionary<int,int>();
            foreach (int i in nums)
            {
                if (counts.ContainsKey(i))
                {
                    counts[i]++;
                } 
                else
                {
                    counts.Add(i, 1);
                }
            }

            // Return the element that occurred only once in the nums array
            foreach (int i in counts.Keys)
            {
                if (counts[i] == 1)
                {
                    return i;
                }
            }

            // if we get here, something went wrong
            return -1;
        }
    }
}
