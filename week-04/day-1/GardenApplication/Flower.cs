using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace GardenApplication
{
    class Flower : Plant
    {
        // CONSTRUCTORS
        public Flower(string color) : base(color)
        {
            Type = "Flower";
        }
        //METHODS
        public override bool CheckWater()
        {
            return (WaterAmount < 5);
        }
        public override void Water(double amount)
        {
            if (WaterAmount < 5)
            {
                WaterAmount += 0.75 * amount;
            }
        }
    }
}
