using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    class Station
    {
        // Create Station and Car classes
            // Station
            // GasAmount
        // Refill(car) -> decreases the gasAmount by the capacity of the car and increases the cars gasAmount

        public int GasAmount = 0;

        public Station(int gasAmount)
        {
            GasAmount = gasAmount;
        }

        public void Refill(Car car)
        {
            GasAmount -= car.Capacity;
            car.GasAmount += car.Capacity;
        }
    }
}
