using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    public class Animal
    {
        public int hunger = 50;
        public int thirst = 50;

        public Animal(int hunger, int thirst)
        {
            this.hunger = hunger;
            this.thirst = thirst;
        }

        public void Eat()
        {
            hunger++;
        }
        public void Drink()
        {
            thirst--;
        }

        public void Play()
        {
            thirst++;
            hunger--;
        }
    }
}
