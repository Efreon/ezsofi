using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BeforeInheritance
{
    public class Person
    {
        // FIELDS
        public string Name;    
        public int Age;        
        public string Gender;  

        // CONSTRUCTORS
        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public Person()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
        }

        // METHODS
        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender}");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
