using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Reptile : Animal
    {
        public string Name { get; protected set; }
        public string Age { get; protected set; }
        public string Gender { get; protected set; }
        public int Legs { get; protected set; }
        public bool CanFly { get; protected set; }
        public Reptile(string name)
        {
            Name = name;
            CanFly = false;
            Legs = 4;
        }
        public override string  GetName()
        {
            return Name;
        }
        public override string Greet()
        {
            return "Heloooo";
        }
        public override string WantChild()
        {
            return "want a child from an egg!";
        }
    }
}
