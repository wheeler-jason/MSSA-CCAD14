namespace Assignment6._1._3
{
    /*
     * Given an integer array nums, move all 0's to the end of it 
     * while maintaining the relative order of the non-zero elements.
     * 
     * Note that you must do this in-place without making a copy of the array.
     * 
     * Example 1:
     * Input: nums = [0,1,0,3,12]
     * Output: [1,3,12,0,0]
     * 
     * Example 2:
     * Input: nums = [0]
     * Output: [0]
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] nums1 = [0, 1, 0, 3, 12];
            MoveZeroes(nums1);

            foreach (int i in nums1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();


            int[] nums2 = [0];
            MoveZeroes(nums2);

            foreach (int i in nums2)
            {
                Console.Write($"{i} ");
            }

        }

        public static void MoveZeroes(int[] nums)
        {
            int swapIndex = 0;
            int currentIndex = 0;

            while (currentIndex < nums.Length)
            {
                // if we hit a non-zero element, we swap it with the one at the swapIndex 
                // the element at the swapIndex will be the first 0 in the array
                if (nums[currentIndex] != 0)
                {
                    int temp = nums[currentIndex];
                    nums[currentIndex] = nums[swapIndex];
                    nums[swapIndex] = temp;
                    swapIndex++;
                }

                currentIndex++;
            }
        }
    }
}
