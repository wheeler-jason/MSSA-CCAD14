namespace Assignment7._4
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            // Check the ParkingSystemTests.cs file for more comprehensive tests
            ParkingSystem obj = new ParkingSystem(1, 2, 1);
            bool param_1 = obj.AddCar(3);
            Console.WriteLine(param_1);
        }
    }
}
