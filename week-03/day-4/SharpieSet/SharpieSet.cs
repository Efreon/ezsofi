using ObjectOrientedProgramming;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SharpieSet
{
    // Create SharpieSet class
        // it contains a list of Sharpie
        // Add method CountUsable() -> sharpie is usable if it has ink in it
        // Add method RemoveTrash() -> removes all unusable sharpies
    class SharpieSet
    {
        public List<Sharpie> Sharpies;

        public SharpieSet()
        {
           Sharpies = new List<Sharpie>();
        }

        public void Add(Sharpie sharpie)
        {
            Sharpies.Add(sharpie);
        }

        public int CountUsable()
        {
            int countSharpie = 0;
            for (int i=0; i < Sharpies.Count; i++)
            {
                if (Sharpies[i].inkAmount > 0)
                {
                    countSharpie++;
                }
            }
            return countSharpie;
        }

        public void RemoveTrash()
        {
            for (int i=0; i < Sharpies.Count; i++)
            {
                if (Sharpies[i].inkAmount ==0)
                {
                    Sharpies.RemoveAt(i);
                }
            }
        }

    }
}
