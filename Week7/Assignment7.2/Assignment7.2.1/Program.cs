namespace Assignment7._2._1
{
    /*
     * Implement shell sort on an unsorted array of numbers.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateRandomArray(100);
            Console.WriteLine("Unsorted Array:");
            PrintArray(numbers);
            ShellSort(numbers);
            Console.WriteLine("Sorted Array:");
            PrintArray(numbers);
        }

        public static void ShellSort(int[] array)
        {
            int n = array.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = temp;
                }
            }
        }

        // Generates an array of random integers of size n 
        // with numbers in the range of [0-99]
        public static int[] GenerateRandomArray(int n)
        {
            Random random = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 100);
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }


}
