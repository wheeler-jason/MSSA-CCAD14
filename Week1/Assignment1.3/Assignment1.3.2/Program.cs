namespace Assignment1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Reversal - Assignment 1.3.2\n");
            Console.WriteLine("How many numbers would you like to input into the array?\n");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Read elements into the original array
            int[] originalArray = new int[arraySize];
            Console.WriteLine($"Input {arraySize} numbers into the array:\n");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"element - {i} : ");
                originalArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            // Display array contents
            Console.WriteLine("\nThe values stored in the array are: ");
            foreach (int i in originalArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Reverse the array - not actually necessary based on problem statement
           

            // Display the array contents in reverse
            Console.WriteLine("\nThe values stored in the array in reverse are:");
            for (int i = arraySize-1; i >= 0; i--)
            {
                Console.Write(originalArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
