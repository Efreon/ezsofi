using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    // Create a Farm class
    class Farm
    {
        // it has list of Animals
        public List<Animal> Animals;
        // it has slots which defines the number of free places for animals
        int Slots = 0;

        public Farm(List<Animal> animals, int slots)
        {
            Animals = animals;
            Slots = slots;
        }

        // breed() -> creates a new animal if there's place for it
        public void Breed(int hunger, int thirst)
        {
            if (Slots > 0)
            {
                Animals.Add(new Animal(hunger, thirst));
                Slots--;
            }
            else
            {
                Console.WriteLine("Sorry, there is no empty slot for a new animal");
            }
        }

        // slaughter() -> removes the least hungry animal
        public void Slaughter()
        {
            int leastHungry = 0;
            int leastHungryIndex = 0;
            for (int i = 0; i < Animals.Count; i++)
            {
                if (i == 0)
                {
                    leastHungry = Animals[i].Hunger;
                    leastHungryIndex = i;
                }
                else if (Animals[i].Hunger < leastHungry)
                {
                    leastHungry = Animals[i].Hunger;
                    leastHungryIndex = i;
                }
            }
            Animals.RemoveAt(leastHungryIndex);
        }

    }
}
