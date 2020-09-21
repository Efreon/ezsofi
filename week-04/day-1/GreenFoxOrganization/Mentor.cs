using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace GreenFoxOrganization
{
    class Mentor : Person
    {
        // FIELDS
        public string Level;

        // CONSTRUCTORS
        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            Level = level;
        }
        public Mentor() :base()
        {
            Level = "intermediate";
        }

        //METHODS
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} {Level} mentor.");
        }
        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
    }
}
