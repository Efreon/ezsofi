using System;
using System.Collections.Generic;
using System.Text;

namespace AirCraftCarrier
{
    class Carrier
    {
        public List<Aircraft> AircraftCarrier;
        public int StoreAmmo { get; set; }
        public int HealthPoint { get; set; }
        public Carrier(int ammo, int health)
        {
            AircraftCarrier = new List<Aircraft>();
            StoreAmmo = ammo;
            HealthPoint = health;
        }
        
        public void Add(Aircraft aircraft)
        {
            AircraftCarrier.Add(aircraft);
        }
        public void Fill()
        {
            if (StoreAmmo ==0)
            {
                Console.WriteLine("I can't fill any of the aircrafts! There is no ammo in the store!");
            }
            else
            {
                int ammoNeeded = 0;
                List<Aircraft> notPriorityAircrafts = new List<Aircraft>();
                List<Aircraft> sortedAircrafts = new List<Aircraft>();

                for (int i=0; i < AircraftCarrier.Count; i++)
                {
                    ammoNeeded += (AircraftCarrier[i].MaxAmmo - AircraftCarrier[i].CurrAmmo);
                    if (AircraftCarrier[i].IsPriorityAmmo)
                    {
                        sortedAircrafts.Add(AircraftCarrier[i]);
                    }
                    else
                    {
                        notPriorityAircrafts.Add(AircraftCarrier[i]);
                    }
                }
                sortedAircrafts.AddRange(notPriorityAircrafts);

                if (ammoNeeded > StoreAmmo)
                {
                    for (int i = 0; i < sortedAircrafts.Count; i++)
                    {
                        sortedAircrafts[i].Refill((sortedAircrafts[i].MaxAmmo - sortedAircrafts[i].CurrAmmo));
                        StoreAmmo -= (sortedAircrafts[i].MaxAmmo - sortedAircrafts[i].CurrAmmo);
                    }
                }
                else
                {
                    for (int i = 0; i < AircraftCarrier.Count; i++)
                    {
                        AircraftCarrier[i].Refill((AircraftCarrier[i].MaxAmmo - AircraftCarrier[i].CurrAmmo));
                        StoreAmmo -= (AircraftCarrier[i].MaxAmmo - AircraftCarrier[i].CurrAmmo);
                    }
                }
            }
        }
        public void Fight(Carrier anotherCarrier)
        {
            int availableAmmo = 0;
            for (int i=0; i < AircraftCarrier.Count; i++)
            {
                availableAmmo += AircraftCarrier[i].CurrAmmo;
                AircraftCarrier[i].CurrAmmo = 0;
            }

        }
    }
}
