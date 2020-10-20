using System;
using System.Collections.Generic;
using System.Text;

namespace AirCraftCarrier
{
    class F16 : Aircraft
    {
        public F16()
        {
            MaxAmmo = 8;
            AmmoLevel = 0;
            BaseDamage = 30;
            AircraftType = "F16";
            IsPriorityAmmo = false;
        }
    }
}
