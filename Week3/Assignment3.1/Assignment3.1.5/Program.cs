namespace Assignment3._1._5
{
    /*
     * Write a function which takes an array as input 
     * and finds the first occurrence of 2 consecutive 1s 
     * and changes their value to 0.
     * For e.g: 
     * Input : [0,2,1,1,9,1,1]
     * Output: [0,2,0,0,9,1,1]
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sampleArray = [0, 2, 1, 1, 9, 1, 1];
            Console.WriteLine("Input: ");
            foreach (int i in sampleArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            ReplaceOnes(sampleArray);

            Console.WriteLine("Output: ");
            foreach (int i in sampleArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // Replaces the first occurrence of
        // two consecutive 1s with 0s.
        // Since int[] is a reference type, we do not
        // need to return anything. Changes to the integer
        // array will be reflected in the outside scope.
        public static void ReplaceOnes(int[] nums)
        {
            // Make sure you keep i < nums.Length-1 since
            // you would go out of bounds on the last loop
            // when referencing nums[i+1]
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == 1)
                {
                    if (nums[i+1] == 1)
                    {
                        nums[i] = 0;
                        nums[i+1] = 0;
                        break;
                    }
                }
            }
        }
    }
}
