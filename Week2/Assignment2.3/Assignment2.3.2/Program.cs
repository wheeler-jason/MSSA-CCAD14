namespace Assignment2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 2.3.2 - Tip Calculator\n");
            Console.WriteLine("Enter bill total: ");
            double billTotal = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"The bill total is: ${billTotal}");
            Console.WriteLine("What percentage would you like to tip?");
            Console.WriteLine("Enter a tip percentage: ");
            double tipPercentage = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double grandTotal = billTotal * ((tipPercentage / 100.0) + 1);
            Console.WriteLine($"For a bill total of ${billTotal},");
            Console.WriteLine($"with a tip percentage of {tipPercentage},");
            Console.WriteLine($"your grand total is: {grandTotal:C2}");
        }
    }
}
