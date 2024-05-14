using System;
using ConsoleApp31;

class Program
{
    static void Main()
    {
        Guitar guitar = new Guitar("Classical Guitar", "Wood", 2018);
        Piano piano = new Piano("Grand Piano", "Wood", 2016);

        guitar.DisplayInfo();
        guitar.Play();
        guitar.Tune();

        Console.WriteLine();

        piano.DisplayInfo();
        piano.Play();
        piano.Tune();
    }
