namespace Assignment3._2._1
{
    /*
     * Create a 2D array to store integers and 
     * print them in matrix format with proper formatting.
     * e. g:
     * | 2 | 3 | 4 |
     * | 1 | 4 | 6 |
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDimArray = new int[2, 3] { {2, 3, 4 }, {1, 4, 6} };
            for (int row = 0; row < 2; row++)
            {
                Console.Write("|");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(" " + twoDimArray[row, col] + " |");
                }
                Console.WriteLine();
            }
        }
    }
}
