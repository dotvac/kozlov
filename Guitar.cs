using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Guitar : MusicalInstrument
    {
        public string StringType { get; set; }

        public Guitar(string name, string material, int yearOfProduction, string stringType) : base(name, "String", material, yearOfProduction)
        {
            StringType = stringType;
        }

        public override void Play()
        {
            Console.WriteLine($"Playing the guitar: {Name}");
        }
    }
}
