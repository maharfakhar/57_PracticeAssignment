using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int smallestFactor = FindSmallestSingleDigitFactor(number);

        if (smallestFactor != -1)
        {
            Console.WriteLine($"The smallest single-digit factor of {number} is: {smallestFactor}");
        }
        else
        {
            Console.WriteLine($"There is no single-digit factor for {number}.");
        }
    }

    static int FindSmallestSingleDigitFactor(int num)
    {
        for (int i = 2; i <= 9; i++)
        {
            if (num % i == 0)
            {
                return i;
            }
        }
        return -1;
    }
}
