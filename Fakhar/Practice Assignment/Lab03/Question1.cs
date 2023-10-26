class Program
{
    static void Main()
    {
        Point p1 = new Point(10, 20);
        p1.Display(); // Output: X: 10, Y: 20

        Point p2; // Since it's a value type, you can create it without 'new'
        p2.X = 30;
        p2.Y = 40;
        p2.Display(); // Output: X: 30, Y: 40

        // Assigning one struct to another creates a copy
        Point p3 = p2;
        p3.X = 50;
        p3.Display(); // Output: X: 50, Y: 40
        p2.Display(); // Output: X: 30, Y: 40
    }
}
