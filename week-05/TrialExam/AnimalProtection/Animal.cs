using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalProtection
{
    public abstract class Animal
    {
        public string AnimalName { get; protected set; }
        public string OwnerName { get; set; }
        public bool IsHealthy { get; set; }
        public int HealCost { get; protected set; }

        public Animal()
        {
        }
        public virtual void Heal()
        {
            IsHealthy = true;
        }
        public virtual bool IsAdoptable()
        {
            return IsHealthy;
        }
        public override string ToString()
        {
            return IsHealthy ? $"{AnimalName} is healthy, and adoptable" : $"{AnimalName} is not healthy ({HealCost} $), and not adoptable";
        }

    }
}
