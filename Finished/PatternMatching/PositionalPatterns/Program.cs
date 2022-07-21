// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"
// Using Positional and Tuple Patterns in Pattern Matching

decimal GetGroupTicketPriceDiscount(int groupSize, DateTime visitDate)
    => (groupSize, visitDate.DayOfWeek) switch
{
    // use the position of each value as an individual pattern expression
    (<= 0, _) => throw new ArgumentException("Group size must be a positive number"),
    (_, DayOfWeek.Saturday or DayOfWeek.Sunday) => 0.0m,
    (>= 5 and < 10, DayOfWeek.Monday) => 0.2m,
    (>= 10, DayOfWeek.Monday) => 0.3m,
    (>= 5 and < 10, _) => 0.12m,
    (>= 10, _) => 0.15m,
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

// Iterate over each of the test data items and evaluate the discount
foreach ((var size, var date) in TestDiscountData) {
    decimal discount = GetGroupTicketPriceDiscount(size, date);
    Console.WriteLine($"The discount for a {size}-person group on {date:ddd, MMM d} is {discount}");
}

// Use the implicit Deconstruct call to switch on the different values of a class
string Classify(Point point) => point switch
{
    (> 0, > 0) => "Upper right quadrant",
    (< 0, > 0) => "Upper left quadrant",
    (> 0, < 0) => "Lower right quadrant",
    (< 0, < 0) => "Lower left quadrant",
    _ => "Just a point",
};

// Declare some test data to use with the point example
Point[] TestPointData = new[] {
    new Point(5, 8),
    new Point(-2, 7),
    new Point(1, -1),
    new Point(-2, -2),
};

foreach (Point p in TestPointData) {
    Console.WriteLine($"Point is {Classify(p)}");
}

// Define a type that implements the Deconstruct method to return a tuple
public readonly struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y) => (X, Y) = (x, y);

    public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
}
