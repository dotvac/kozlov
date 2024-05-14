using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
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

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is being played");
        }

        public virtual void Tune()
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
}
