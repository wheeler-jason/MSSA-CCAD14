namespace Challenge4._2
{
    /* Write a program in C# Sharp 
     * to count the frequency of each element of an array.
     * Ask the user how many elements to store and
     * then have them input the elements for you to count.
     * Display the frequency of each unique element.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Element Frequency Counter\n");
            
            Console.Write("Enter the number of elements to be stored in the array: ");
            int numElements = Convert.ToInt32(Console.ReadLine());
            
            // Read the user's elements into an array per problem statement
            Console.WriteLine($"Input {numElements} elements in the array:");
            string[] arr = new string[numElements];
            string userInput = "";
            for (int i = 0; i < numElements; i++)
            {
                Console.Write($"element - {i}: ");
                userInput = Console.ReadLine();
                arr[i] = userInput;
            }

            // Use a dictionary to easily associate elements with their frequency
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string str in arr)
            {
                if (!dict.TryAdd(str, 1))
                {
                    dict[str]++;
                }
            }

            // Display Results
            Console.WriteLine("Frequency of all elements of the array:");
            foreach (KeyValuePair<string,int> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} occurs {kvp.Value} times");
            }
        }
    }
}
