using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeInheritance
{
    public class Mentor
    {
        // FIELDS
        string Name;   
        int Age;        
        string Gender;  
        string Level;

        // CONTRUCTORS
        public Mentor(string name, int age, string gender, string level)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Level = level;
        }

        public Mentor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            Level = "intermediate";
        }

        // METHODS
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} {Level} mentor.");
        }

        public void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
    }
}
