using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GardenApplication
{
    class Garden
    {
        // FIELD
        public List<Plant> NiceGarden;

        // CONSTRUCTOR 
        public Garden()
        {
            NiceGarden = new List<Plant>();
        }

        public void PlantGarden(Plant plant)
        {
            NiceGarden.Add(plant);
        }

        public void GardenInfo()
        {
            for (int i = 0; i < NiceGarden.Count; i++)
            {
                if (NiceGarden[i].CheckWater())
                {
                    Console.WriteLine($"The {NiceGarden[i].Color} {NiceGarden[i].Type} needs water");
                }
                else
                {
                    Console.WriteLine($"The {NiceGarden[i].Color} {NiceGarden[i].Type} doesnt need water");
                }
            }
        }
        public void WaterGarden( int amount)
        {
            Console.WriteLine($"Watering with {amount}");
            int amountPerPlant = 0;
            for (int i = 0; i < NiceGarden.Count; i++)
            {
                if (NiceGarden[i].CheckWater())
                {
                    amountPerPlant += 1;
                }
            }
            for (int i =0; i < NiceGarden.Count; i++ )
            {
                NiceGarden[i].Water(amount / amountPerPlant);
            }
            GardenInfo();
        }
    }
}
