using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TODOApplication
{
    public class Task
    {
        public string TaskName { get; protected set; }
        public bool IsChecked { get; set; }

        public Task(string taskName, bool isChecked)
        {
            TaskName = taskName;
            IsChecked = isChecked;
        }
    }
}

