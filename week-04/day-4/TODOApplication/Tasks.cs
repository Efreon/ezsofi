using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace TODOApplication
{
    public class Tasks
    {
        public List<string> MyTasks = new List<string>();

        // public Tasks(List<string>  myTasks)
        public Tasks()
        {
            MyTasks = new List<string>();
            string filePath = @"d:\greenfox\ezsofi\week-04\day-4\TODOApplication\todos.txt";
            if (new FileInfo(filePath).Length > 0)
            {
                var lineCount = File.ReadAllLines(filePath).Length;
                StreamReader sr = new StreamReader(filePath);
                for (int i = 0; i < lineCount; i++)
                {
                    string task = sr.ReadLine();
                    MyTasks.Add(task);
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
                    Console.WriteLine($"{i + 1} - {MyTasks[i]}");
                }
            }
        }
        public void AddNewTask(string task)
        {
            MyTasks.Add(task);
            Console.WriteLine($"You have added a new item to your todos: {MyTasks[MyTasks.Count-1]}");

            string filePath = @"d:\greenfox\ezsofi\week-04\day-4\TODOApplication\todos.txt";
            TextWriter tw = new StreamWriter(filePath);
            foreach (String s in MyTasks)
            tw.WriteLine(s);
            tw.Close();
        }
        public void RemoveTask(int number)
        {
            Console.WriteLine($"You have removed an item from your todos: {MyTasks[number-1]}");
            MyTasks.RemoveAt(number - 1);

            string filePath = @"d:\greenfox\ezsofi\week-04\day-4\TODOApplication\todos.txt";
            TextWriter tw = new StreamWriter(filePath);
            foreach (String s in MyTasks)
            tw.WriteLine(s);
            tw.Close();
        }
    }
}
