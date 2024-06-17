namespace Assignment7._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] examScores = GenerateRandomArray(100);
            Console.WriteLine("Unsorted Array:");
            PrintArray(examScores);
            SelectionSort(examScores);
            Console.WriteLine("Sorted Array:");
            PrintArray(examScores);

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

        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = array[minIndex];
                    array[minIndex] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
}
