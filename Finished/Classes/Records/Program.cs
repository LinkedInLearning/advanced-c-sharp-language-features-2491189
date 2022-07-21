// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini
// Using records 

// Instantiate some records
DayTemperature temp1 = new DayTemperature(29.6m, 24.1m);
DayTemperature temp2 = new DayTemperature(30.1m, 22.7m);
DayTemperature temp3 = new DayTemperature(29.6m, 24.1m);

// Records get built-in formatting for output
Console.WriteLine($"{temp1}");

// Records have built-in value equality testing
Console.WriteLine($"{temp1 == temp2}");
Console.WriteLine($"{temp1 == temp3}");

// Like classes you can add other methods and properties
Console.WriteLine($"{temp1.Average}");

// Records are immutable by default - you can make them mutable but they are 
// really intended for immutable data types
// temp1.High = 32.0m;

// The "with" keyword can be used to make a new record
DayTemperature temp4 = temp1 with {High = 32.0m};
Console.WriteLine($"{temp4}");

// Records can be defined very simply
public record DayTemperature(decimal High, decimal Low) {
    public decimal Average {
        get => (High + Low) / 2;
    } 
}
