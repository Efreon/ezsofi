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
                        WeeklyTasks.AddNewTask(new Task(args[1], false));
                    }
                }
                else if (args[0] == "-r")
                {
                    int ind;
                    if (args.Length < 2)
                    {
                        Console.WriteLine("Unable to remove: no index provided");
                    }
                    else if (Int32.TryParse(args[1], out ind))
                    {
                        WeeklyTasks.RemoveTask(Int32.Parse(args[1]));
                    }
                    else
                    {
                        Console.WriteLine("Unable to remove: index is not a number");
                    }
                }
                else if (args[0] == "-c")
                {
                    int ind;
                    if (args.Length < 2)
                    {
                        Console.WriteLine("Unable to check: no index provided");
                    }
                    else if (Int32.TryParse(args[1], out ind))
                    {
                        WeeklyTasks.CheckTask(Int32.Parse(args[1]));
                    }
                    else
                    {
                        Console.WriteLine("Unable to check: index is not a number");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Unsupported argument");
                    PrintUsage();
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
