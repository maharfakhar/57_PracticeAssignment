using System;

class Person : IEquatable<Person>, IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public bool Equals(Person other)
    {
        if (other == null) return false;
        return (Name == other.Name) && (Age == other.Age);
    }

    public int CompareTo(Person other)
    {
        if (other == null) return 1;

        int nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
        if (nameComparison != 0) return nameComparison;

        return Age.CompareTo(other.Age);
    }

    public static bool operator ==(Person person1, Person person2)
    {
        if (ReferenceEquals(person1, person2))
            return true;

        if (person1 is null || person2 is null)
            return false;

        return person1.Equals(person2);
    }

    public static bool operator !=(Person person1, Person person2)
    {
        return !(person1 == person2);
    }

    public static bool operator <(Person person1, Person person2)
    {
        return person1.CompareTo(person2) < 0;
    }

    public static bool operator >(Person person1, Person person2)
    {
        return person1.CompareTo(person2) > 0;
    }

    public static bool operator <=(Person person1, Person person2)
    {
        return person1.CompareTo(person2) <= 0;
    }

    public static bool operator >=(Person person1, Person person2)
    {
        return person1.CompareTo(person2) >= 0;
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person("Alice", 30);
