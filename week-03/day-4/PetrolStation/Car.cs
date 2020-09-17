using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    // Car
        // GasAmount
        // Capacity
    // create constructor for Car where:
        // initialize gasAmount -> 0
        // initialize capacity -> 100
    public class Car
    {
        public int GasAmount;
        public int Capacity;

        public Car(int gasAmount = 0, int capacity= 100)
        {
            GasAmount = gasAmount;
            Capacity = capacity;
        }
    }
}
