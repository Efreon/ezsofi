using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalProtection
{
    class Dog : Animal
    {
        public Dog()
        {
            AnimalName = "Dog";
            HealCost = new Random().Next(1, 9);
        }
        public Dog(string animalName)
        {
            AnimalName = animalName;
            HealCost = new Random().Next(1, 9);
        }
    }
}
