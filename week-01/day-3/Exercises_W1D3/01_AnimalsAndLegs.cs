using System;

namespace _01_AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            int numChickens;
            int legsChicken = 2;
            // The second represents the number of pigs owned by the farmer
            int numberPigs;
            int legsPigs = 4;

            // It should print how many legs all the animals have
            

            Console.WriteLine("Please write a number!");
            if (!int.TryParse(Console.ReadLine(), out numChickens));
            {
                Console.WriteLine("Please write another number!");
                if (!int.TryParse(Console.ReadLine(), out numberPigs));
                {
                    int totalLegs = numChickens * legsChicken + numberPigs * legsPigs;
                    Console.WriteLine($"Total number of animal legs: {totalLegs}");
                }
            }

            

            
        }
    }
}
