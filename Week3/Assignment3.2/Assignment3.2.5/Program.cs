using System;

namespace Assignment3._2._5
{
    /*
     * Create a function that finds the index of a given item in the array
     * 
     * Examples:
     * Search([1, 5, 3], 5) ➞ 1
     * Search([9, 8, 3], 3) ➞ 2
     * Search([1, 2, 3], 4) ➞ -1
     * 
     * Notes:
     * If the item is not present, return -1.
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Here are the contents of the array: ");
            Console.Write("[ ");
            for(int i = 0; i < numArray.Length; i++)
            {
                // if it is the last iteration, don't print the comma separator
                if(i == (numArray.Length - 1))
                {
                    Console.Write(numArray[i]);
                }
                else
                {
                    Console.Write(numArray[i] + ", ");
                }
            }
            Console.Write(" ]");
            Console.WriteLine();

            int index = GetIndex(numArray, 3);
            Console.WriteLine($"The index of 3 in the array is: {index}");
            
            // returns -1 since 36 is not in the array
            index = GetIndex(numArray, 36);
            Console.WriteLine($"The index of 36 in the array is: {index}");

        }

        public static int GetIndex(int[] numArray, int num) 
        { 
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] == num) return i;
            }
            
            return -1; 
        }

    }
}
