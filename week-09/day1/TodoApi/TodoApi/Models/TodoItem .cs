using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class ToDoItem
    {
        public long Id { get; set; }    // unique key
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
