namespace Assignment8._1
{
    internal class Program
    {
        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[low]; 
            int i = low; 

            for (int j = low + 1; j <= high; j++)
            {
                if (array[j] < pivot) 
                {
                    i++; 
                    Swap(array, i, j); 
                }
            }

            // Swap the pivot element into the correct place
            Swap(array, low, i);

            // Return the index of the pivot element
            return i;
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);

                // Print partitions for demo purposes
                Console.Write($"Pivot: {array[pivotIndex]}, Partitions: ");
                PrintPartition(array, low, pivotIndex - 1);
                Console.Write(" | ");
                PrintPartition(array, pivotIndex + 1, high);
                Console.WriteLine();

                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        public static void Main(string[] args)
        {
            int[] data = { 6, 10, 13, 5, 8, 3, 2, 11 };
            int size = data.Length;

            Console.WriteLine("Unsorted Array:");
            Console.WriteLine(string.Join(" ", data));
            Console.WriteLine();

            Console.WriteLine("Visualizing the Partition() method:\n");
            QuickSort(data, 0, size - 1);
            Console.WriteLine();

            Console.WriteLine("Sorted Array in Ascending Order:");
            Console.WriteLine(string.Join(" ", data));
        }

        static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        public static void PrintPartition(int[] array, int start, int end)
        {
            Console.Write("[");
            for(int i = start; i <= end; i++)
            {
                Console.Write($" {array[i]} ");
            }
            Console.Write("]");
        }
    }
}
