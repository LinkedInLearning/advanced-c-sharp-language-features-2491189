// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"
// C# Pattern Matching using enhanced switch expressions

// switch statements are very common in C#:
string NumToString(int num) {
    switch (num) {
        case 1:
            return "One";
        case 2:
            return "Two";
        case 3:
            return "Three";
        default:
            return "Unknown";
    }
}
Console.WriteLine(NumToString(2));
Console.WriteLine(NumToString(4));

// Beginning with C# 7 and enhanced in C# 8, switch statements 
// can now operate on just about any type
string ShapeToString(object shape) {
    switch (shape) {
        case Circle:
            return "Circle";
        case Rectangle:
            return "Rectangle";
        case Triangle:
            return "Triangle";
        default:
            return "Unknown";
    }
}
Console.WriteLine(ShapeToString(new Circle {Radius = 10}));
Console.WriteLine(ShapeToString(new Rectangle {Length = 5, Width = 10}));

// This can be made a little more concise with the switch expression, starting in C# 8
string ShapeToString2 (object shape) => shape switch {
    Circle {Radius: var r} when r > 10 => "Big Circle",
    Circle {Radius: var r} when r <= 10 => "Little Circle",
    Rectangle {Length: var l, Width: var w} when l == w => "Square",
    Rectangle => "Rectangle",
    Triangle => "Triangle",
    _ => "Unknown"
};
Console.WriteLine(ShapeToString2(new Circle {Radius = 20}));
Console.WriteLine(ShapeToString2(new Circle {Radius = 10}));
Console.WriteLine(ShapeToString2(new Rectangle {Length = 10, Width = 10}));
Console.WriteLine(ShapeToString2(new Rectangle {Length = 5, Width = 10}));
