using System;
using System.Collections.Generic;
using System.Text;

namespace Fly
{
    class Bird: IFlyable
    {
        public string Name { get; protected set; }
        public string Age { get; protected set; }
        public string Gender { get; protected set; }
        public int Legs { get; protected set; }
        public bool CanFly { get; protected set; }
        public Bird(string name)
        {
            Name = name;
            CanFly = true;
            Legs = 2;
        }
        public string GetName()
        {
            return Name;
        }
        public string Greet()
        {
            return "Chirp-chirp";
        }
        public string WantChild()
        {
            return "want a child from an egg!";
        }
        public void Fly()
        {
            Console.WriteLine("The bird is flying!");
        }

        public void Land()
        {
            Console.WriteLine("The bird is landing!");
        }

        public void TakeOff()
        {
            Console.WriteLine("The bird is taking off!");
        }
    }
}
