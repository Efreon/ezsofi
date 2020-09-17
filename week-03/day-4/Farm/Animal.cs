using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Animal
    {
        // Reuse your Animal class
        public int Hunger = 50;
        public int Thirst = 50;

        public Animal(int hunger, int thirst)
        {
            Hunger = hunger;
            Thirst = thirst;
        }

        public void Eat()
        {
            Hunger++;
        }
        public void Drink()
        {
            Thirst--;
        }

        public void Play()
        {
            Thirst++;
            Hunger--;
        }
    }
}
