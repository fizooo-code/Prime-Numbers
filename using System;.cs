using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;
        double quotient = (num2 != 0) ? (double)num1 / num2 : double.NaN;

        Console.WriteLine("\nResults:");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");

        //Console.WriteLine("\n");
for (int i = 1; i < 10; i++)
{
    Console.Write(i + " ");
}

Console.WriteLine("\n\nEven numbers from");
for (int i = 2; i < 20; i += 2)
{
    Console.Write(i + " ");
}
}