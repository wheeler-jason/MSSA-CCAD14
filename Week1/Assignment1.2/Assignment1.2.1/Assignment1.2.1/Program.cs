namespace Assignment1._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 1st number: ");
            int inputNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number: ");
            int inputNum2 = Convert.ToInt32(Console.ReadLine());
            bool result = testEquality(inputNum1, inputNum2);
            if (result)
            {
                Console.WriteLine($"{inputNum1} and {inputNum2} are equal.");
            }
            else
            {
                Console.WriteLine($"{inputNum1} and {inputNum2} are not equal.");
            }
        }
        static bool testEquality(int num1, int num2)
        {
            if (num1 == num2) return true;
            return false;
        }
    }
}
