using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    public class Violin : StringedInstrument
    {
        protected string name;
        protected int strings;
        protected string sounding;

        public string Name { get; protected set; }
        public int Strings { get; protected set; }
        public string Sounding { get; protected set; }

        public Violin()
        {
            Name = "Violin";
            Strings = 4;
            Sounding = "screech";
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name}, a {Strings}-stringed instrument that {Sounding}es");
        }
    }
}
