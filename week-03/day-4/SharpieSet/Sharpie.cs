using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    // Reuse your Sharpie class
    
    class Sharpie
    {
        public string color;
        public float width;
        public float inkAmount = 100;

        public Sharpie(string color, float width)
        {
            this.color = color;
            this.width = width;
        }

        public void Use()
        {
            inkAmount--;
        }

    }
}
