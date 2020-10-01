using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalProtection
{
    class Parrot : Animal
    {
        public Parrot()
        {
            AnimalName = "Parrot";
            HealCost = new Random().Next(4, 11);
        }
        public Parrot(string animalName)
        {
            AnimalName = animalName;
            HealCost = new Random().Next(4, 11);
        }
    }
}
