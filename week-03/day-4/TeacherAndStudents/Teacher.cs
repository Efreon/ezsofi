using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherAndStudents
{
    public class Teacher
    {
        
        public Teacher()
        {

        }
        public void teach(Student student)
        {
            student.learn();
        }

        public void answer ()
        {
            Console.WriteLine("the teacher is answering a question");
        }
    }
}
