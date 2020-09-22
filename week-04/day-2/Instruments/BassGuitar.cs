using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    public class BassGuitar : StringedInstrument
    {
        protected string name;
        protected int strings;
        protected string sounding;

        public string Name { get; protected set; }
        public int Strings { get; protected set; }
        public string Sounding { get; protected set; }

        public BassGuitar()
        {
            Name = "Bass Guitar";
            Strings = 4;
            Sounding = "Duum-duum-duum";
        }
        public BassGuitar(int strings )
        {
            Name = "Bass Guitar";
            Strings = strings;
            Sounding = "Duum-duum-duum";
        }
        public override void Sound()
        {
            Console.WriteLine($"{Name}, a {Strings}-stringed instrument that {Sounding}");
        }
    }
}
