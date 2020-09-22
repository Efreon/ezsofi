using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Mammal : Animal
    {
        public string Name { get; protected set; }
        public string Age { get; protected set; }
        public string Gender { get; protected set; }
        public int Legs { get; protected set; }
        public bool CanFly { get; protected set; }
        public Mammal(string name)
        {
            Name = name;
            CanFly = false;
            Legs = 4;
        }
        public override string GetName()
        {
            return Name;
        }
        public override string Greet()
        {
            return "Hello";
        }
        public override string WantChild()
        {
            return "want a child from my uterus!";
        }
    }
}
