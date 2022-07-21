// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini
// The null coalescing operator

// A common scenario is to test a value for null and assign one if it is
void OldSchoolLogString(string theString) {
    if (theString == null) {
        Console.WriteLine("No string given!");
    }
    else {
        Console.WriteLine(theString);
    }
}

OldSchoolLogString("Test String");
OldSchoolLogString(null);

// TODO: the ?? operator returns the left-hand value if not null, or the right one if it is null


// TODO: It's also allowable to throw an exception as part of the right-hand expression


// TODO: The ??= assigns a value if the left-hand value is null
