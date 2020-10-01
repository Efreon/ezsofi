using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalProtection
{
    public class Cat : Animal
    {
        public Cat()
        {
            AnimalName = "Cat";
            HealCost = new Random().Next(0, 7);
        }
        public Cat(string animalName)
        {
            AnimalName = animalName;
            HealCost = new Random().Next(0, 7);
        }
    }
}
