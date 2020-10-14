using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public static int callCounter;
        public string Name { get; set; }

        public Greeting()
        {
        }
        public Greeting(string name)
        {
            callCounter++;
            Id = callCounter;
            Content = $"Hello, {name}!";
        }
        //public Greeting(long id, string content)
        //{
        //    Id=id;
        //    Content = $"Hello, World!";
        //}
        //public Greeting(long id, string name)
        //{
        //    Id = id;
        //    Content = $"Hello, {name}!";
        //}

    }
}
