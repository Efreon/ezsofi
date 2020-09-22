using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {
        protected string name;
        protected string age;
        protected string gender;
        protected int legs;
        protected bool canFly;

        public string Name { get; protected set; }
        public string Age { get; protected set; }
        public string Gender { get; protected set; }
        public int Legs { get; protected set; }
        public bool CanFly { get; protected set; }

        public abstract string Greet();
        public abstract string WantChild();
        public abstract string GetName();
    }
}
