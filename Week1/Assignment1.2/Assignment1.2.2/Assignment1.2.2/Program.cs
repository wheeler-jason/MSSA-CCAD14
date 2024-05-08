namespace Assignment1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, how many natural numbers would you like to add up?");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = sumNaturalNumbers(num);
            Console.WriteLine($"The sum of numbers 1 through {num} is {sum}.");
        }

        static int sumNaturalNumbers(int num) 
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        }

    }
}
