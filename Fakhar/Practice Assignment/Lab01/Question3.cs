using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        double magnitude = FindMagnitude(number);

        Console.WriteLine($"The magnitude of {number} is: {magnitude}");
    }

    static double FindMagnitude(double num)
    {
        return Math.Abs(num);
    }
}
