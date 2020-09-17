using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherAndStudents
{
    public class Student
    {
        public Student()
        {
        }
        public void learn()
        {
            Console.WriteLine("the student is learning something new");
        }

        public void question(Teacher teacher)
        {
            teacher.answer();
        }
    }
}
