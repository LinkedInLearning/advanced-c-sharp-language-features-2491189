// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"
// Using Positional and Tuple Patterns in Pattern Matching

decimal GetGroupTicketPriceDiscount(int groupSize, DateTime visitDate)
    => (groupSize, visitDate.DayOfWeek) switch
{
    // TODO: use the position of each value as an individual pattern expression

    _ => 0.0m,
};

// Declare some test data to use with the example
(int, DateTime)[] TestDiscountData = new[] {
    (4, new DateTime(2022, 9, 3)),
    (7, new DateTime(2023, 2, 6)),
    (20, new DateTime(2023, 4, 17)),
    (15, new DateTime(2023, 8, 8)),
    (9, new DateTime(2023, 8, 9)),
};

// TODO: Iterate over each of the test data items and evaluate the discount


// TODO: Use the implicit Deconstruct call to switch on the different values of a class


// Declare some test data to use with the point example
Point[] TestPointData = new[] {
    new Point(5, 8),
    new Point(-2, 7),
    new Point(1, -1),
    new Point(-2, -2),
};

// foreach (Point p in TestPointData) {
//     Console.WriteLine($"Point is {Classify(p)}");
// }

// Define a type that implements the Deconstruct method to return a tuple
public readonly struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y) => (X, Y) = (x, y);

    public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
}
