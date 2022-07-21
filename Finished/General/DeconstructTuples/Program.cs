// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"

// Tuples provide an easy, lightweight way of returning multiple values
// from a single function call without defining a complex structure
(decimal, decimal, decimal) GetStockValues(string ticker) {
    // Given a ticker symbol, return HIGH, LOW, and CLOSE values
    if (ticker == "ABCD") {
        return (22.0m, 19.0m, 20.5m);
    }
    else if (ticker == "WXYZ") {
        return (50.0m, 47.0m, 49.25m);
    }
    else {
        return (0,0,0);
    }
}

// Working directly with a tuple can be somewhat tedious, having
// to access each value individually using the ItemN syntax:
var result = GetStockValues("ABCD");
Console.WriteLine($"{result.Item1}, {result.Item2}, {result.Item3}");

// An easier way can be accomplished using named values and 
// deconstructing the tuple into variables
var (high, low, close) = GetStockValues("WXYZ");
Console.WriteLine($"{high}, {low}, {close}");

// You can also use explicit variable types, and the _ character can be
// used to ignore any values that you don't plan to use
decimal cl;
(_, _, cl) = GetStockValues("ABCD");
Console.WriteLine($"{cl}");
