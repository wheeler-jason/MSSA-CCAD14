// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter your age: ");
double age = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter your address: ");
string address = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Your name is {name}. \nYour age is {age}. \nYour address is {address}.");
