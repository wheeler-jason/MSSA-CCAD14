
namespace Assignment6._4
{
    // You are given an n x n 2D matrix representing an image,
    // rotate the image by 90 degrees(clockwise).
    // You have to rotate the image in-place, 
    // which means you have to modify the input 2D matrix directly.
    // DO NOT allocate another 2D matrix and do the rotation.
    // 
    // Example 1:
    // Input: matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
    // Output: [[7, 4, 1],[8, 5, 2],[9, 6, 3]]
    //
    // Example 2:
    // Input: matrix = [[5, 1, 9, 11],[2, 4, 8, 10],[13, 3, 6, 7],[15, 14, 12, 16]]
    // Output: [[15, 13, 2, 5],[14, 3, 4, 1],[12, 6, 8, 9],[16, 7, 10, 11]]

    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] test = { {1, 2, 3},
                            {4, 5, 6},
                            {7, 8, 9} };

            Console.WriteLine("Matrix Before Rotation: ");
            PrintMatrix(test);

            RotateMatrix(test);

            Console.WriteLine("Matrix After Rotation: ");
            PrintMatrix(test);
        }

        public static void RotateMatrix(int[,] matrix)
        {
            // Size of the n x n matrix
            int size = matrix.GetLength(0);
            // Loop through each layer of the matrix, starting from the outermost layer
            for (int layer = 0; layer < size / 2; layer++)
            {
                // Loop through the elements in the current layer
                for (int element = layer; element < size - layer - 1; element++)
                {
                    // Save the top-left element
                    int temp = matrix[layer, element];
                    // Move bottom-left element to top-left
                    matrix[layer, element] = matrix[size - element - 1, layer];
                    // Move bottom-right element to bottom-left
                    matrix[size - element - 1, layer] = matrix[size - layer - 1, size - element - 1];
                    // Move top-right element to bottom-right
                    matrix[size - layer - 1, size - element - 1] = matrix[element, size - layer - 1];
                    // Move top-left element (saved in temp) to top-right
                    matrix[element, size - layer - 1] = temp;
                }
            }
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
