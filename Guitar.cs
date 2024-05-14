 class Guitar : MusicalInstrument
    {
        public Guitar(string name, string material, int yearOfProduction) : base(name, "String", material, yearOfProduction)
        {
        }

        public override void Play()
        {
            Console.WriteLine($"Playing the guitar: {Name}");
        }
    }
