// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"
// Using Deconstruction on a custom defined type

public class Planet
{
    public string Name { get; set; }
    public int Radius { get; set; }
    public int MoonCount { get; set; }
    public int DistanceFromSunKm { get; set; }

    public Planet(string name, int rads, int moons, int distance ) {
        Name = name;
        Radius = rads;
        MoonCount = moons;
        DistanceFromSunKm = distance;
    }

    // Define a Deconstruct method to return the name and moon count
    public void Deconstruct(out string name, out int moons) {
        name = Name;
        moons = MoonCount;
    }

    // Define a Deconstruct method to return the name, moon count, and radius
    public void Deconstruct(out string name, out int moons, out int radius) {
        name = Name;
        moons = MoonCount;
        radius = Radius;
    }

    // Defining a Deconstruct with the name number of parameters will cause an error
    // public void Deconstruct(out string name, out int distance) {
    //     name = Name;
    //     moons = DistanceFromSunKm;
    // }
}