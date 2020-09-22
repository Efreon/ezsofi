using System;
using System.Collections.Generic;
using System.Text;

namespace Fly
{
    abstract public class Vehicle
    {
        protected string type;
        protected int speed;
        protected string color;
        protected string canFly;

        public string Type { get; protected set; }
        public int Speed { get; protected set; }
        public string Color { get; protected set; }
        public string CanFly { get; protected set; }

        public Vehicle(string type, int speed, string color )
        {
            Type = type;
            Speed = speed;
            Color = color;
        }
    }
}
