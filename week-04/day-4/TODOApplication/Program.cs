using System;
using System.Collections.Generic;
using System.IO;

namespace TODOApplication
{
    public class ToDoApplication
    {
        public static void Main(string[] args)
        {
            // var WeeklyTasks = new Tasks(new List<string>());
            var WeeklyTasks = new Tasks();
            //WeeklyTasks.GenerateTasks();
            if (args.Length == 0)
            { 
                PrintUsage();
            }
            else
            {
                if (args[0] == "-l")
                {
                    WeeklyTasks.PrintToDos();
                }
                else if (args[0] == "-a")
                {
                    if (args.Length < 2)
                    {
                        Console.WriteLine("Unable to add: no task provided");
                    }
                    else
                    {
                        WeeklyTasks.AddNewTask(args[1]);
                    }
                }
                else if (args[0] == "-r")
                {
                    WeeklyTasks.RemoveTask(Int32.Parse(args[1]));
                }
            }
        }
        static void PrintUsage()
        {
            {
                Console.WriteLine("Command Line Todo application\n" +
                              "=============================\n" +
                              "\n" +
                              "Command line arguments:\n" +
                              "     -l   Lists all the tasks\n" +
                              "     -a   Adds a new task\n" +
                              "     -r   Removes an task\n" +
                              "     -c   Completes an task");
            }
        }
    }
}
