using System;

class MusicalInstrument
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Material { get; set; }
    public int YearOfProduction { get; set; }

    public MusicalInstrument(string name, string type, string material, int yearOfProduction)
    {
        Name = name;
        Type = type;
        Material = material;
        YearOfProduction = yearOfProduction;
    }

    public void Play()
    {
        Console.WriteLine($"{Name} is being played");
    }

    public void Tune()
    {
        Console.WriteLine($"{Name} is being tuned");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Material: {Material}");
        Console.WriteLine($"Year of Production: {YearOfProduction}");
    }
}

class Program
{
    static void Main()
    {
        MusicalInstrument guitar = new MusicalInstrument("Guitar", "String", "Wood", 2020);
        MusicalInstrument piano = new MusicalInstrument("Piano", "Keyboard", "Wood", 2015);

        guitar.DisplayInfo();
        guitar.Play();
        guitar.Tune();

        Console.WriteLine();

        piano.DisplayInfo();
        piano.Play();
        piano.Tune();
    }
}
