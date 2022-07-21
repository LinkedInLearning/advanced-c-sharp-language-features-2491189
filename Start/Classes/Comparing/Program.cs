// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini
// Comparing objects for equality

// Declare some Point2D instances
Point2D p1 = new Point2D() {X = 10, Y = 20};
Point2D p2 = new Point2D() {X = 10, Y = 20};
Point2D p3 = null, p4 = null;

// Test for equality
Console.WriteLine($"{p1.Equals(p2)}");
Console.WriteLine($"{p1 == p2}");
Console.WriteLine($"{p1 != p2}");
Console.WriteLine($"{p3 == p4}");

// TODO: The IEquatable interface gives us a type-specific Equals() method
public class Point2D {
    public int X;
    public int Y;

    // TODO: Override the methods needed to define value equality


    // TODO: Override the == and != operators as well

}
