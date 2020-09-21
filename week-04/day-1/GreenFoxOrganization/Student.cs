using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace GreenFoxOrganization
{
    class Student : Person
    {
        // FIELDS
        private string PreviousOrganization;
        private int SkippedDays;

        // CONSTRUCTORS
        public Student(string name, int age, string gender, string previousOrganization) :base(name, age, gender)
        {
            SkippedDays = 0;
        }
        public Student() :base()
        {
            PreviousOrganization = "The School of Life";
            SkippedDays = 0;
        }

        // METHODS
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {PreviousOrganization} who skipped {SkippedDays} days from the course already.");
        }
        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }
        public void SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays;
        }

    }
}
