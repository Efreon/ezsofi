using System;
using System.Collections.Generic;
using System.Text;

namespace FleetOfThings
{
    class Fleet
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }

        public void Print()
        {
            for (int i = 0; i < Things.Count; i++)
            {
                if (Things[i].getCompleted())
                {
                    Console.WriteLine($"{i + 1}. [x] {Things[i].getName()}");
                }

                else
                {
                    Console.WriteLine($"{i + 1}. [ ] {Things[i].getName()}");
                }
            }

        }
    }
}
