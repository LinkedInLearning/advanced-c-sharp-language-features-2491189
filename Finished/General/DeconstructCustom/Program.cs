// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"
// Using Deconstruction on a custom defined type

// Create some classes with data
Planet Earth = new Planet("Earth", 6371, 1, 150_980_000);
Planet Venus = new Planet("Venus", 6052, 0, 108_930_000);

// Use Deconstruction to get the name and moon count
var (name, moons) = Earth;
Console.WriteLine($"{name}, {moons}");

// Use Deconstruction to get the name, moon count, and radius
(name, moons, var radius) = Venus;
Console.WriteLine($"{name}, {moons}, {radius}");
