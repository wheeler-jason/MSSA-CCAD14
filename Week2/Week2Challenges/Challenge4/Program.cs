namespace Challenge4
{
    /*
     * Write a C# Sharp program that takes a symbol 
     * and a width as input and then displays a triangle
     * consisting of those symbols using that width.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a symbol: ");
            string symbol = Console.ReadLine();
            Console.WriteLine("Enter the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            for(int i = width; i > 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
