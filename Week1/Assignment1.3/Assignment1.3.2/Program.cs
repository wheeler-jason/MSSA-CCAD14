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

            // Read elements into the array
            int[] numArray = new int[arraySize];
            Console.WriteLine($"Input {arraySize} numbers into the array:\n");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"element - {i} : ");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            // Display array contents before reversing it
            Console.WriteLine("\nThe values stored in the array are: ");
            foreach (int i in numArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Reverse the array
            int temp;
            for (int i = 0;i < arraySize/2; i++)
            {
                temp = numArray[i];
                numArray[i] = numArray[arraySize - i - 1];
                numArray[arraySize - i - 1] = temp;
            }

            // Display the array contents after reversing it
            Console.WriteLine("\nThe values stored in the reversed array are: ");
            foreach (int i in numArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
