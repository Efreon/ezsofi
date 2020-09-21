using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApplication
{
    class Tree : Plant
    {
        // CONSTRUCTORS
        public Tree(string color) :base(color)
        {
            Type = "Tree";
        }
        //METHODS
        public override bool CheckWater()
        {
            return (WaterAmount < 10);
        }
        public override void Water(double amount)
        {
            if (WaterAmount <10)
            {
                WaterAmount += 0.4 * amount;
            }
        }
    }
}
