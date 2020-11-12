using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorScheduler.Models.Entities
{
    public class MentorName
    {
        public MentorName(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
