using System;

namespace Fly
{
    class Program
    {
        static void Main(string[] args)
        {
            var helicoopter = new Helicopter("helicopter02", 200, "black");
            helicoopter.Fly();
            helicoopter.Land();
            helicoopter.TakeOff();

            var birdy = new Bird("bird");
            birdy.Fly();
            birdy.Land();
            birdy.TakeOff();
        }
    }
}
