using System;

class Program
{
    static void Main()
    {
        // Example 1: Casting from int to double
        int intValue = 10;
        double doubleValue = (double)intValue;

        Console.WriteLine($"Casting int {intValue} to double: {doubleValue}");

        // Example 2: Casting from double to int
        double doubleValue2 = 20.5;
        int intValue2 = (int)doubleValue2;

        Console.WriteLine($"Casting double {doubleValue2} to int: {intValue2}");

        // Example 3: Casting from char to int
        char charValue = 'A';
        int intValue3 = (int)charValue;

        Console.WriteLine($"Casting char '{charValue}' to int: {intValue3}");
    }
}
