namespace Assignment3._1._3
{
    /*
     * Write a program in C# Sharp to create a function 
     * to input a string and count number of spaces are in the string.
     * Test Data :
     * Please input a string : This is a test string.
     * Expected Output :
     * "This is a test string." contains 4 spaces
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            CountSpaces("Hello,  World!");
        }

        public static void CountSpaces(string str)
        {
            int numSpaces = str.Count(c => c == ' ');
            Console.WriteLine($"{str} contains {numSpaces} spaces.");
        }
    }
}
