namespace Assignment3._2._2
{
    /*
     * Write a program in C# Sharp for 
     * addition of two Matrices of same size.
     * Test Data :
     * Input the size of the square matrix (less than 5): 2
     * Input elements in the first matrix :
     * element - [0],[0] : 1
     * element - [0],[1] : 2
     * element - [1],[0] : 3
     * element - [1],[1] : 4
     * Input elements in the second matrix :
     * element - [0],[0] : 5
     * element - [0],[1] : 6
     * element - [1],[0] : 7
     * element - [1],[1] : 8
     * Expected Output:
     * The First matrix is:
     * 1 2
     * 3 4
     * The Second matrix is :
     * 5 6
     * 7 8
     * The Addition of two matrix is :
     * 6 8
     * 10 12
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the size of the square matrix (less than 5): ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[size,size];
            int[,] matrix2 = new int[size,size];
            Console.WriteLine("Input elements in the first matrix : ");
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write($"element - [{row}],[{col}] : ");
                    matrix1[row,col] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Input elements in the second matrix : ");
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write($"element - [{row}],[{col}] : ");
                    matrix2[row, col] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
            }

            Console.WriteLine("The first matrix is: ");
            PrintMatrix(matrix1);
            Console.WriteLine("The second matrix is: ");
            PrintMatrix(matrix2);
            Console.WriteLine("The addition of those matrices is: ");
            PrintMatrix(AddMatrices(matrix1, matrix2));
        }

        public static void PrintMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);

            for(int row = 0; row < size; row++)
            {
                for(int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int size = matrix1.GetLength(0);
            int[,] result = new int[size,size];
            for(int row = 0; row < size; row++)
            {
                for (int col = 0;col < size; col++)
                {
                    result[row, col] = matrix1[row, col] + matrix2[row, col];
                }
            }
            return result;
        }
    }
}
