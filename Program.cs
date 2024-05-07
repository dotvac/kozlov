using System;

// Base class for musical instruments
class Instrument
{
    public string Name { get; set; }
    public string Type { get; set; }

    public void Play()
    {
        Console.WriteLine($"Playing {Name}");
    }
}

// Derived class for string instruments
class StringInstrument : Instrument
{
    public int NumStrings { get; set; }

    public StringInstrument(string name, int numStrings)
    {
        Name = name;
        NumStrings = numStrings;
        Type = "String";
    }

    public void Pluck()
    {
        Console.WriteLine($"Plucking the {Name}");
    }
}

// Derived class for wind instruments
class WindInstrument : Instrument
{
    public string Material { get; set; }

    public WindInstrument(string name, string material)
    {
        Name = name;
        Material = material;
        Type = "Wind";
    }

    public void Blow()
    {
        Console.WriteLine($"Blowing into the {Name}");
    }
}

class Program
{
    static void Main()
    {
        StringInstrument guitar = new StringInstrument("Guitar", 6);
        guitar.Play();
        guitar.Pluck();

        WindInstrument flute = new WindInstrument("Flute", "Wood");
        flute.Play();
        flute.Blow();
    }
}