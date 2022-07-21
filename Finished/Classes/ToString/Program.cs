// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini
// Overriding the ToString() function

// All C# objects inherit from the base "object" class, so they all have
// a base implementation of the ToString method
float x = 42.0f;
string str = x.ToString();
Console.WriteLine($"{str}");

// Implement ToString to represent a custom type
Person p = new Person() {FirstName = "John", LastName = "Doe", Age = 25};
Console.WriteLine($"{p}");

public class Person {
    public string? FirstName {get; set;}
    public string? LastName {get; set;}
    public int Age {get; set;}

    // Override ToString to provide your own string representation
    public override string ToString() => $"[Person] FirstName:{FirstName}, LastName:{LastName}, Age:{Age}";
}
