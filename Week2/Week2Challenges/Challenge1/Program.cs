namespace Challenge1
{
    /*
     * Write a C# Sharp program to read temperature in fahrenheit and display a suitable message according to temperature state below :
     * Temp 0< 10 then Freezing weather
     * Temp 11-20 then Very Cold weather
     * Temp 21-35 then Cold weather
     * Temp 36-50 then Normal in Weather
     * Temp 51-65 then Its Hot
     * Temp 66-80 then Its Very Hot
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature in Fahrenheit?");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.Write("The weather is: ");
            switch (temp)
            {
                case < 10:
                    Console.WriteLine("Freezing weather");
                    break;
                case < 21:
                    Console.WriteLine("Very cold weather");
                    break;
                case < 36:
                    Console.WriteLine("Cold weather");
                    break;
                case < 51:
                    Console.WriteLine("Normal weather");
                    break;
                case < 66:
                    Console.WriteLine("Hot weather");
                    break;
                case < 81:
                    Console.WriteLine("Very hot weather");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}
