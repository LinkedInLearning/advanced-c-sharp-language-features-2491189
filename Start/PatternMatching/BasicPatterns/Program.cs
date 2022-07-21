// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"
// C# Pattern Matching for type testing

// a very common use for pattern matching is to compare values, such as checking for null
// The "is" expression is used for this to test the Constant pattern
string? str = "This is a string";


// The "is" expression can also be used to extract a value if one is present
// This is called the Declaration pattern
void dashedline(object o) {
    // The old way of doing this is to try determine the type of the argument
    int l = 0;
    if (o.GetType() == typeof(int)) {
        l = (int)o;
    }
    string s;
    if (o.GetType() == typeof(string)) {
        s = (string)o;
        if (!int.TryParse(s, out l)) {
            l = 0;
        }
    }
    if (l > 0) {
        string str = new string('-', l);
        Console.WriteLine(str);
    }

    // TODO: The new way is to just use the declaration pattern
}

// dashedline(25);
// dashedline("50");
// dashedline(20.5);

// Property pattern examines the properties of an object
// bool IsTheIdesOfMarch(DateTime date) {
//     // Test the month and day properties
//     return false;
// }
// Console.WriteLine(IsTheIdesOfMarch(new DateTime(DateTime.Today.Year, 1, 13)));
// Console.WriteLine(IsTheIdesOfMarch(new DateTime(DateTime.Today.Year, 3, 14)));
// Console.WriteLine(IsTheIdesOfMarch(new DateTime(DateTime.Today.Year, 3, 15)));
// Console.WriteLine(IsTheIdesOfMarch(new DateTime(DateTime.Today.Year, 3, 16)));
