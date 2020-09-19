using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    public class Pirate
    {
        // VARIABLES / PROPERTIES
        string Name;
        int ToxicLevel;
        bool IsAlive;
        bool IsPassedOut;
        int HealtLevel;
        bool HasParrot;

        // CONSTRUCTOR
        public Pirate(string name)
        {
            Name = name;
            ToxicLevel = 0;
            IsAlive = true;
            IsPassedOut = false;
            HealtLevel = 100;
            HasParrot = false;
        }

        // METHODS
        // DrinkSomeRum() - intoxicates the Pirate some
        public void DrinkSomeRum()
        {
            ToxicLevel++;
            if (ToxicLevel >15)
            {
                Die();
            }
        }

        // HowsItGoingMate() - when called, the Pirate replies
        // if DrinkSomeRun was called:-0 to 4 times, "Pour me anudder!"
        // else, "Arghh, I'ma Pirate. How d'ya d'ink its goin?", the pirate passes out and sleeps it off.
        public void HowsItGoingMate()
        {
            if (ToxicLevel <= 4)
            {
                Console.WriteLine("Pour me anudder!");
                DrinkSomeRum();
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                Sleep();
                IsPassedOut = true;
            }
            
        }

        public void Sleep()
        {
            ToxicLevel = 0;
        }

        // Die() - this kills off the pirate, in which case, DrinkSomeRum, etc. just result in he's dead.
        public void Die()
        {
            IsAlive = false;
        }

        // Brawl(x) - where pirate fights another pirate (if that other pirate is alive) and 
        // there's a 1/3 chance, 1 dies, the other dies or they both pass out.
        public void Brawl(Pirate name)
        {
            if (name.IsAlive)
            {
                var randomChance = new Random().Next(1, 4);
                if (randomChance == 1)
                {
                    Die();
                    Console.WriteLine($"{Name} has died");
                }
                else if (randomChance == 2)
                {
                    name.Die();
                    Console.WriteLine($"{name.Name} has died");
                }
                else
                {
                    IsPassedOut = true;
                    name.IsPassedOut = true;
                    Console.WriteLine($"{Name} and {name.Name}is passed out");
                }
            }
        }
    }
}
