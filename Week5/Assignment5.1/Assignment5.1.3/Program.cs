namespace Assignment5._1._3
{
    /*
     * Given an integer array nums, 
     * return true if any value appears at least 
     * twice in the array, and return false if every element is distinct.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] ints = { 1, 2, 3, 4, 1 };
            bool result = ContainsDuplicates(ints);
            Console.WriteLine(result);
        }

        public static bool ContainsDuplicates(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int i in arr)
            {
                if (set.Contains(i))
                    return true;

                set.Add(i);
            }
            return false;
        }
    }
}
