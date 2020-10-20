using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Hero : Character
    {
        public bool canFly { get; set; }
        public Hero(string name, bool canFly) : base(name)
        {
            canFly = canFly;
        }

        public override void Shout()
        {
            Console.WriteLine("Hero is shouting!");
        }
    }
}
