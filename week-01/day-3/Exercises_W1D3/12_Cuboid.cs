using System;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            double a = 10;
            double b = 15;
            double c = 20;

            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            double cuboidSurfaceArea = 2 * a * b + 2 * b * c + 2 * a * c;
            Console.WriteLine(cuboidSurfaceArea);

            // Volume: 1000
            double cuboidVolume = a * b * c;
            Console.WriteLine(cuboidVolume);
        }
    }
}
