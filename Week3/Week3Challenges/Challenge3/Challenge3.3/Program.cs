using System;

namespace Challenge3._3
{
    /*
     * Given an array of integers nums and an integer target, 
     * return indices of the two numbers such that they add up to target.
     * You may assume that each input would have exactly one solution,
     * and you may not use the same element twice.
     * Input: nums = [2,7,11,15], target = 9
     * Output: [0,1]
     * Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int target = 9;
            int[] result = AddToTarget(nums, target);
            Console.WriteLine($"The indices whose values sum to the target are: {result[0]} and {result[1]}.");

        }

        public static int[] AddToTarget(int[] nums, int target) 
        {
            int index1 = 0;
            int index2 = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        index1 = i;
                        index2 = j;
                        break;
                    }
                }
            }

            return new int[] { index1, index2 };
        }

        public static int[] AddToTarget_Optimized(int[] nums, int target)
        {
            int index1 = 0;
            int index2 = 0;
            Dictionary<int, int> complementIndexPairs = new();

            for (int i = 0;i < nums.Length;i++)
            {
                int complement = target - nums[i];
                if(complementIndexPairs.ContainsKey(complement))
                {
                    index1 = complementIndexPairs[complement];
                    index2 = i;
                    break;
                } 
                else
                {
                    complementIndexPairs.Add(nums[i], i);
                }
            }

            return new int[] { index1, index2 };
        }
    }
}
