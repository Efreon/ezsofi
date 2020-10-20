using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GreenFoxOrganization
{
    class Sponsor : Person
    {
        // FIELDS
        public string Company;
        public int HiredStudents;

        // CONSTRUCTORS
        public Sponsor(string name, int age, string gender, string company) :base(name, age, gender)
        {
            Company = company;
            HiredStudents = 0;
        }
        public Sponsor() :base()
        {
            Company = "Google";
            HiredStudents = 0;
        }

        //METHODS
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {Company} and hired {HiredStudents} students so far.");
        }
        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
        public void Hire()
        {
            HiredStudents += 1;
        }
    }
}
