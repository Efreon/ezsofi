using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Character
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int AttackDamage { get; protected set; }

        public Character(string name)
        {
            Name = name;
            Health = 100;
            AttackDamage = 50;
        }

        public virtual void Shout()
        {
            Console.WriteLine("Character is shouting!");
        }
    }
}
