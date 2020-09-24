using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace TODOApplication
{
    public class Tasks
    {
        public List<Task> MyTasks = new List<Task>();
        // public List<string> MyTasks = new List<string>();
        public Tasks()
        {
            // MyTasks = new List<string>();
            MyTasks = new List<Task>();
            string filePath = @"d:\greenfox\ezsofi\week-04\day-4\TODOApplication\todos.txt";
            if (new FileInfo(filePath).Length > 0)
            {
                var lineCount = File.ReadAllLines(filePath).Length;
                StreamReader sr = new StreamReader(filePath);
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    var taskItem = new Task(line.Split(';')[0], Convert.ToBoolean(line.Split(';')[1]));
                    MyTasks.Add(taskItem);
                }
                sr.Close();
            }
        }
        public void PrintToDos()
        {
            if (MyTasks.Count == 0)
            {
                Console.WriteLine($"No todos for today! :)");
            }
            else
            {
                for (int i = 0; i < MyTasks.Count; i++)
                {
                    if (MyTasks[i].IsChecked)
                    {
                        Console.WriteLine($"{i + 1} - [x] {MyTasks[i].TaskName}");
                    }
                    else
                    {
                        Console.WriteLine($"{i + 1} - [ ] {MyTasks[i].TaskName}");
                    }
                }
            }
        }
        public void AddNewTask(Task task)
        {
            MyTasks.Add(task);
            Console.WriteLine($"You have added a new item to your todos: {MyTasks[MyTasks.Count-1].TaskName}");

            string filePath = @"d:\greenfox\ezsofi\week-04\day-4\TODOApplication\todos.txt";
            TextWriter tw = new StreamWriter(filePath);
            foreach (Task s in MyTasks)
            {
                tw.WriteLine($"{s.TaskName}; {s.IsChecked}");
            } 
            tw.Close();
        }
        public void RemoveTask(int number)
        {
            if (number-1 > MyTasks.Count)
            {
                Console.WriteLine("Unable to remove: index is out of bound");
            }
            else
            {
                Console.WriteLine($"You have removed an item from your todos: {MyTasks[number - 1].TaskName}");
                MyTasks.RemoveAt(number - 1);

                string filePath = @"d:\greenfox\ezsofi\week-04\day-4\TODOApplication\todos.txt";
                TextWriter tw = new StreamWriter(filePath);
                foreach (Task s in MyTasks)
                {
                    tw.WriteLine($"{s.TaskName}; {s.IsChecked}") ;
                }
                tw.Close();
            }
        }
        public void CheckTask(int number)
        {
            if (number - 1 > MyTasks.Count)
            {
                Console.WriteLine("Unable to check: index is out of bound");
            }
            else
            {
                MyTasks[number - 1].IsChecked = true;
                string filePath = @"d:\greenfox\ezsofi\week-04\day-4\TODOApplication\todos.txt";
                TextWriter tw = new StreamWriter(filePath);
                foreach (Task s in MyTasks)
                {
                    tw.WriteLine($"{s.TaskName}; {s.IsChecked}");
                }
                tw.Close();
            }

        }
    }
}
