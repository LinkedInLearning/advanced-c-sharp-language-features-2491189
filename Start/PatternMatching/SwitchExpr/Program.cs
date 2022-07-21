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

// TODO: Beginning with C# 7 and enhanced in C# 8, switch statements 
// can now operate on just about any type


// TODO: This can be made a little more concise with the switch expression, starting in C# 8

// Console.WriteLine(ShapeToString2(new Circle {Radius = 20}));
// Console.WriteLine(ShapeToString2(new Circle {Radius = 10}));
// Console.WriteLine(ShapeToString2(new Rectangle {Length = 10, Width = 10}));
// Console.WriteLine(ShapeToString2(new Rectangle {Length = 5, Width = 10}));
