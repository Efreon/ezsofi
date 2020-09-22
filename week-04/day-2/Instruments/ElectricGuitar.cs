using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    public class ElectricGuitar :StringedInstrument
    {
        protected string name;
        protected int strings;
        protected string sounding;

        public string  Name { get; protected set; }
        public int Strings { get; protected set;}
        public  string Sounding { get; protected set; }

        public ElectricGuitar() 
        {
            Name = "Electric Guitar";
            Strings = 6;
            Sounding = "twang";
        }
        public ElectricGuitar(int strings)
        {
            Name = "Electric Guitar";
            Strings = strings;
            Sounding = "twang";
        }
        public override void Sound()
        {
            Console.WriteLine($"{Name}, a {Strings}-stringed instrument that {Sounding}s");
        }

    }
}
