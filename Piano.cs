using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Piano : MusicalInstrument
    {
        public int NumberOfKeys { get; set; }

        public Piano(string name, string material, int yearOfProduction, int numberOfKeys) : base(name, "Keyboard", material, yearOfProduction)
        {
            NumberOfKeys = numberOfKeys;
        }

        public override void Tune()
        {
            Console.WriteLine($"Tuning the piano: {Name}");
        }
    }
}
