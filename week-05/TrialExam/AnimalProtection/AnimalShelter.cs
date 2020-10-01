using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalProtection
{
    class AnimalShelter
    {
        public int Budget { get; protected set; }
        public List<Animal> Animals { get; protected set; } // = new List<Animal>();
        public List<string> Adopters { get; protected set; }

        public AnimalShelter()
        {
            Budget = 50;
        }
        public int Rescue(Animal animal)
        {
            Animals.Add(animal);
            return Animals.Count;
        }
        public int Heal()
        {
            int healedAnimals = 0;
            int foundSick = 0;
            while (foundSick < 1)
            {
                for (int i = 0; i < Animals.Count; i++)
                {
                    if (Animals[i].IsHealthy == false)
                    {
                        foundSick++;
                        if (Animals[i].HealCost <= Budget)
                        {
                            Animals[i].IsHealthy = true;
                            healedAnimals++;
                            Budget -= Animals[i].HealCost;
                        }
                    }
                }
            } 
            return healedAnimals;
        }
        public void AddAdopter(string adopterName)
        {
            Adopters.Add(adopterName);
        }
        public void FindNewOwner()
        {
            int randAdopter = new Random().Next(0, Adopters.Count);
            int randAnimal = new Random().Next(0, Animals.Count);

            if (randAdopter < Animals.Count && randAnimal < Adopters.Count)
            {
                Animals[randAnimal].OwnerName = Adopters[randAdopter];
                Animals.RemoveAt(randAnimal);
                Adopters.RemoveAt(randAdopter);
            }
        }
        public int EarnDonation(int donation)
        {
            Budget += donation;
            return Budget;
        }
        public override string ToString()
        {
            string shelterStats = "Budget: " + Budget + "$,\n" + "There are " + Animals.Count + " animal(s) and " + Adopters.Count + " potential adopters(s)\n" ;

            for (int i=0; i < Animals.Count; i++)
            {
                shelterStats += Animals[i].ToString() + "\n";
            }

            return shelterStats;
        }
    }
}
