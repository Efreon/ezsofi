using System;
using System.Collections.Generic;

namespace GreenFoxOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            var newStudent = new Student();
            var newStudentCloned = newStudent.Clone() as Student;

            Console.WriteLine(newStudent.Age);
            Console.WriteLine(newStudentCloned.Age);

            var John = new Student("John", 20, "male", "BME");
            var JohnTheClone = John.Clone() as Student;
            Console.WriteLine($"{John.Name}, a {John.Age} yers old {John.Gender} from {John.PreviousOrganization}");
            Console.WriteLine($"{JohnTheClone.Name}, a {JohnTheClone.Age} yers old {JohnTheClone.Gender} from {JohnTheClone.PreviousOrganization}");
        }
    }
}
