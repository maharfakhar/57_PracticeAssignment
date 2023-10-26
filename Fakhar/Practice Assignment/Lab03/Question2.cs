using System;

class Person
{
    public string Name;
    public int Age;

    // Default constructor (parameterless)
    public Person()
    {
        Name = "John Doe";
        Age = 30;
    }

    // Parameterized constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        // Using the default constructor
        Person person1 = new Person();
        person1.DisplayInfo(); // Output: Name: John Doe, Age: 30

        // Using the parameterized constructor
        Person person2 = new Person("Alice", 25);
        person2.DisplayInfo(); // Output: Name: Alice, Age: 25
    }
}
