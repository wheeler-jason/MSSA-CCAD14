namespace Assignment5._3._2
{
    /*
     * You are climbing a staircase. It takes n steps to reach the top.
     * Each time you can either climb 1 or 2 steps. 
     * In how many distinct ways can you climb to the top?
     * Example 1:
     * Input: n = 2
     * Output: 2
     * Explanation: There are two ways to climb to the top.
     * 1. 1 step + 1 step
     * 2. 2 steps
     * Example 2:
     * Input: n = 3
     * Output: 3
     * Explanation: There are three ways to climb to the top.
     * 1. 1 step + 1 step + 1 step
     * 2. 1 step + 2 steps
     * 3. 2 steps + 1 step
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of steps:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Number of distinct ways to climb to the top: {ClimbStairs(n)}");
        }

        public static int ClimbStairs(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            // Initialize the base cases
            int[] result = new int[n+1];
            result[0] = 1;
            result[1] = 1;

            // Fill the result array
            for (int i = 2; i <= n; i++)
            {
                result[i] = result[i-1] + result[i-2];
            }

            return result[n];
        }
    }
}
