using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TODOApplication
{
    public class Task
    {

        protected string taskName;
        public string TaskName = "";

        public Task(string taskName)
        {
            TaskName = taskName;
        }
        //public static void AddNewTask(string task)
        //{
        //    string filePath = @"d:\greenfox\ezsofi\week-04\day-4\TODOApplication\todos.txt";
        //    File.AppendAllText(filePath, task + Environment.NewLine);
        //}
    }
}
