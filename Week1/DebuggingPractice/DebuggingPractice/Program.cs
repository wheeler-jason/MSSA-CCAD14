namespace DebuggingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 1.3.1 - Debugging Practice");
            int result = Divide(3, 0);
            Console.WriteLine($"3 / 0 = {result}");
        }

        static int Divide(int a, int b)
        {
            // Generate a mathematical error and utilize exception handling
            try
            {
                return a / b;
            }
            catch (DivideByZeroException e) 
            {
                Console.WriteLine(e.Message);
                throw new Exception(e.StackTrace);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
                throw new Exception(e.StackTrace);
            }
        }
    }
}
