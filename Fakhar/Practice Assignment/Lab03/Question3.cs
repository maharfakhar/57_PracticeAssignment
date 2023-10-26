using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}

class Program
{
    static void Main()
    {
        Shape shape1 = new Shape();
        Shape shape2 = new Circle();
        Shape shape3 = new Square();

        shape1.Draw(); // Output: Drawing a shape
        shape2.Draw(); // Output: Drawing a circle
        shape3.Draw(); // Output: Drawing a square
    }
}
