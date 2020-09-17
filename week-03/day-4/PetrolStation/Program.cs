using System;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var station = new Station(500);
            var car = new Car();

            station.Refill(car);
            Console.WriteLine($"The car has {car.GasAmount} gas after refilling, and {station.GasAmount} gas remained at the station");
        }
    }
}
