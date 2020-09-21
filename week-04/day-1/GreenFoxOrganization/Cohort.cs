using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Cohort
    {
        // FIELDS
        public string Name;
        public List<Student> Students;
        public List<Mentor> Mentors;

        // CONSTRUCTORS
        public Cohort(string name)
        {
            Name = name;
            Students = new List<Student>();
            Mentors = new List<Mentor>();
        }

        //  METHODS
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void AddMentor(Mentor mentor)
        {
            Mentors.Add(mentor);
        }
        public void Info()
        {
            Console.WriteLine($"The {Name} cohort has {Students.Count} students and {Mentors.Count} mentors.");
        }
    }
}
