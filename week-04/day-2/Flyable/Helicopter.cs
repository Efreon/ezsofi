using System;
using System.Collections.Generic;
using System.Text;

namespace Fly
{
    class Helicopter :Vehicle, IFlyable
    {
        public Helicopter(string type, int speed, string color) : base(type, speed, color)
        {
            Type = type;
            Speed = speed;
            Color = color;
        }

        public void Fly()
        {
            Console.WriteLine("The helicopter is flying!");
        }

        public void Land()
        {
            Console.WriteLine("The helicopter is landing!");
        }

        public void TakeOff()
        {
            Console.WriteLine("The helicopter is taking off!");
        }
    }
}
