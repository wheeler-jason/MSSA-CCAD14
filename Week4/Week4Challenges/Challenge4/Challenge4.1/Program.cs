using System.ComponentModel;

namespace Challenge4._1
{
    /*  Write a program in C# Sharp to calculate and 
        print the Electricity bill of a given customer. 
        The customer id., name and unit consumed by the user should be 
        taken from the user and display the total amount to pay to 
        the customer. The charge are as follows: (you may change the charge sheet values)
        0-199:   $1.20/unit
        200-399: $1.50/unit
        400-599: $1.80/unit
        600-...: $2.00/unit
        NOTE: if the bill exceeds $400, 15% surcharge will be added
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Electric Bill Calculator!\n");
           
            // Get user input
            Console.Write("Enter your Customer ID Number: ");
            int customerID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your name: ");
            string customerName = Console.ReadLine();
            Console.Write("Enter number of units consumed: ");
            int unitsConsumed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Start printing output
            Console.WriteLine($"Customer IDNO: {customerID}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Units consumed: {unitsConsumed}");

            // Run calculations and finish output in function
            CalculateBill(unitsConsumed);
        }

        public static void CalculateBill(int units)
        {
            double pricePerUnit = 0;
            switch(units)
            {
                case < 200:
                    pricePerUnit = 1.2;
                    break;
                case < 400:
                    pricePerUnit = 1.5;
                    break;
                case < 600:
                    pricePerUnit = 1.8;
                    break;
                case >= 600:
                    pricePerUnit = 2.0;
                    break;
                default:
                    Console.WriteLine("Units cannot be a negative number.");
                    break;
            }

            double subtotal = units * pricePerUnit;
            double surcharge = 0;
            double total = 0;
            Console.WriteLine($"Subtotal @ ${pricePerUnit:F2} per unit: ${subtotal:F2}");
            if(subtotal > 400)
            {
                surcharge = subtotal * 0.15;
                Console.WriteLine($"Surcharge Amount: ${surcharge:F2}");
                total = subtotal + surcharge;
                Console.WriteLine($"Total Amount Due: ${total:F2}");
            } 
            else
            {
                Console.WriteLine($"Surcharge Amount: $0.00");
                Console.WriteLine($"Total Amount Due: ${subtotal:F2}");
            }  
        }
    }
}
