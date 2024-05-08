// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

int num1 = 123;
float num2 = 12.3F;
decimal num3 = 1234.1234M;
double num4 = 123.123D;

decimal maxNum;
decimal minNum;



maxNum = Math.Max(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
maxNum = Math.Max(maxNum, num3);
maxNum = Math.Max(maxNum, Convert.ToDecimal(num4));

minNum = Math.Min(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
minNum = Math.Min(minNum, num3);
minNum = Math.Min(minNum, Convert.ToDecimal(num4));

Console.WriteLine($"The max number is {maxNum}. The min number is {minNum}.");

decimal sum = Convert.ToDecimal(num1) + Convert.ToDecimal(num2);
Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");

decimal resultOfDivision = Convert.ToDecimal(num1) / Convert.ToDecimal(num2);
Console.WriteLine($"{num1} divided by {num2} equals {resultOfDivision}.");
