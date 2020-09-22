using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace GreenFoxOrganization
{
    class Student : Person, ICloneable
    {
        // FIELDS
        private string previousOrganization;
        private int skippedDays;

        public string PreviousOrganization { get; protected set; }
        public int SkippedDays { get; protected set; }

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
        public object Clone()

        {
            return new Student( Name,  Age,  Gender,  PreviousOrganization);
        }

    }
}
