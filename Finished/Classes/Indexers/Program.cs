// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini
// Using class indexers

// Create a new sample data set
StockRecord stock1 = new StockRecord();

// Access a couple of the properties
Console.WriteLine($"Days: {stock1.Length}");
Console.WriteLine($"Average: {stock1.Average:C}");
Console.WriteLine($"High: {stock1.High:C}");
Console.WriteLine($"Low: {stock1.Low:C}");

// Use the indexer method
for (int i=0; i < stock1.Length; i++) {
    decimal val = stock1[i];
    Console.Write($"Val: {val:C} ");
}
Console.WriteLine("");

// Index using a different value
Console.WriteLine($"Monday: {stock1["mon"]:C}");
Console.WriteLine($"Wednesday: {stock1["wed"]:C}");
Console.WriteLine($"Wednesday: {stock1["blurg"]:C}");
