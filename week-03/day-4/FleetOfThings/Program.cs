using System;

namespace FleetOfThings
{
    class Program
    {
        static void Main(string[] args)
        {
            // - You have the `Thing` class
            // - You have the `Fleet` class
            // - You have the `FleetOfThings` class with a `Main` method
            // - Download those, use those
            // - In the Main method create a fleet
            var fleet = new Fleet();

            // - Achieve this output:s
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also


            var getMilk = new Thing("Get milk");
            var obstacles = new Thing("Remove the obstacles");
            var standUp = new Thing("Stand up");
            var eatLunch = new Thing("Eat lunch");
            eatLunch.Complete();
            standUp.Complete();

            fleet.Add(getMilk);
            fleet.Add(obstacles);
            fleet.Add(standUp);
            fleet.Add(eatLunch);

            fleet.Print();
        }
    }
}
