using System;

namespace AirCraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            var f16Aircraft = new F16();
            Console.WriteLine(f16Aircraft.GetStatus());
            Console.WriteLine(f16Aircraft.Refill(50));
            Console.WriteLine(f16Aircraft.GetStatus());
        }
    }
}
