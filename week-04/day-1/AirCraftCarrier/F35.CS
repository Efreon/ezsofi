using System;
using System.Collections.Generic;
using System.Text;

namespace AirCraftCarrier
{
    class F35 : Aircraft
    {
        public F35()
        {
            MaxAmmo = 12;
            BaseDamage = 50;
            AircraftType = "F35";
            IsPriorityAmmo = true;
        }
    }
}
