using System;
using System.Collections.Generic;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            var pirateZsofi = new Pirate("Zsofi");
            var pirateEnemy = new Pirate("Enemy");
            pirateZsofi.DrinkSomeRum();
            pirateZsofi.HowsItGoingMate();
            pirateZsofi.DrinkSomeRum();
            pirateZsofi.HowsItGoingMate();
            pirateZsofi.DrinkSomeRum();
            pirateZsofi.HowsItGoingMate();
            pirateZsofi.DrinkSomeRum();
            pirateZsofi.HowsItGoingMate();
            pirateZsofi.DrinkSomeRum();
            pirateZsofi.HowsItGoingMate();

            pirateZsofi.Brawl(pirateEnemy);

            var shipship = new Ship();
            shipship.FillShip();
            
            for (int i=0; i < shipship.Crew.Count; i++)
            {
                Console.WriteLine(shipship.Crew[i].Name);
            }

            shipship.ShipInfo();
        }
    }
}
