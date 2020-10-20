using System;
using System.Collections.Generic;
using System.Text;

namespace AirCraftCarrier
{
    public class F35 : Aircraft
    {
        public F35()
        {
            MaxAmmo = 12;
            AmmoLevel = 0;
            BaseDamage = 50;
            AircraftType = "F35";
            IsPriorityAmmo = true;
        }
    }
}
