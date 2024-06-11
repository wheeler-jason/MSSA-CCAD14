namespace Assignment6._2._2
{
    /* Leetcode #238 Product of Array Except Self
     * Given an integer array nums, return an array answer such that 
     * answer[i] is equal to the product of all the elements of nums except nums[i].
     * The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
     * You must write an algorithm that runs in O(n) time and without using the division operation.
     * 
     * Example 1:
     * Input: nums = [1,2,3,4]
     * Output: [24,12,8,6]
     * 
     * Example 2:
     * Input: nums = [-1,1,0,-3,3]
     * Output: [0,0,9,0,0]
     */
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] prefix = new int[nums.Length];
            int[] suffix = new int[nums.Length];
            int[] answer = new int[nums.Length];

            // Populate the prefix array
            int product = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                prefix[i] = product;
                product *= nums[i];
            }

            // Populate the suffix array
            product = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                suffix[i] = product;
                product *= nums[i];
            }

            // Populate the answer array
            for (int i = 0; i < nums.Length; i++)
            {
                answer[i] = prefix[i] * suffix[i];
            }

            return answer;
        }
    }
}
