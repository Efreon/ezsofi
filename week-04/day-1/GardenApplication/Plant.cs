using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace GardenApplication
{
    abstract class Plant
    {
        // FIELDS
        public string Color;
        public double WaterAmount;
        public string Type;
        // CONSTRUCTOR
        public Plant(string color)
        {
            WaterAmount = 0;
            Color = color;
            Type = "Plant";
        }
        //METHODS
        public virtual void Water(double amount)
        {
            if (WaterAmount < 5)
            {
                WaterAmount += 0.75 * amount;
                Console.WriteLine($"Watering with {amount}");
            }
        }
        public abstract bool CheckWater();
    }
}
