using System;
using System.Collections.Generic;
using System.Text;

namespace PrintableInterface
{
    class Todo : IPrintable
    {
        private string taskName;
        private string priority;
        private bool isDone;
        
        protected string TaskName { get; set; }
        protected string Priority { get; set; }
        protected bool IsDone { get; set; }

        public void PrintAllFields()
        {
            Console.WriteLine($"Task: {TaskName} | Priority: {Priority} | Done: {IsDone}");
        }
    }
}
