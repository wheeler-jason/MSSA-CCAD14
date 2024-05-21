using System.Numerics;

namespace Assignment3._2._4
{
    /*
     * Write a function that takes 4 numbers as input 
     * to calculate the total and average.
     * Make use of params array to pass arguments and out 
     * parameters to return both total and average to main method.
     * Test Data:
     * Enter the First number: 10
     * Enter the Second number: 15
     * Enter the third number: 20
     * Enter the fourth number: 30
     */
    enum Iteration
    {
        First,
        Second,
        Third,
        Fourth
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {

            int total = 0;
            double average = 0;
            int[] nums = new int[4];

            for (int i = 0; i < nums.Length; i++)
            {
                Iteration iteration = (Iteration)i;
                Console.WriteLine($"Enter the {iteration} number: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            sumAndAverage(nums, out total, out average);

            Console.WriteLine($"The total (sum) of the numbers you entered is: {total}");
            Console.WriteLine($"The average of the numbers you entered is: {average}");
        }

        public static void sumAndAverage(int[] nums, out int total, out double average)
        {
            total = nums.Sum(); 
            average = nums.Average();
        }
    }
}
