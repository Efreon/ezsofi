using System;

namespace GardenApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var flowerAndTreeGarden = new Garden();

            var yellowFlower = new Flower("yellow");
            var blueFlower = new Flower("blue");
            var purpleTree = new Tree("purple");
            var orangeTree = new Tree("orange");

            flowerAndTreeGarden.PlantGarden(yellowFlower);
            flowerAndTreeGarden.PlantGarden(blueFlower);
            flowerAndTreeGarden.PlantGarden(purpleTree);
            flowerAndTreeGarden.PlantGarden(orangeTree);
            
            flowerAndTreeGarden.GardenInfo();
            Console.WriteLine();
            flowerAndTreeGarden.WaterGarden(40);
            Console.WriteLine();
            flowerAndTreeGarden.WaterGarden(70);

        }
    }
}
