using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeInheritance
{
    public class Student : Person
    {
        // FIELDS
        //string name;                     
        //int age;                         
        //string gender;                   
        string PreviousOrganization;     
        int SkippedDays;                 

        // CONSTRUCTORS
        public Student(string name, int age, string gender, string previousOrganization) 
             : base(name, age, gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
            PreviousOrganization = previousOrganization;
            SkippedDays = 0;
        }

        public Student()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
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
