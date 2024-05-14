using System;
using ConsoleApp31;

class Program
{
    static void Main()
    {
        Guitar guitar = new Guitar("Classical Guitar", "Wood", 2018, "Nylon");
        Piano piano = new Piano("Grand Piano", "Wood", 2016, 88);

        guitar.DisplayInfo();
        guitar.Play();
        guitar.Tune();
        Console.WriteLine($"String Type: {guitar.StringType}");

        Console.WriteLine();

        piano.DisplayInfo();
        piano.Play();
        piano.Tune();
        Console.WriteLine($"Number of Keys: {piano.NumberOfKeys}");
    }
}
