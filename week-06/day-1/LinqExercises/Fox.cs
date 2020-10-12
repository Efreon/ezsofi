using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExercises
{
    class Fox
    {
        // Create a Fox class with 3 properties: name, type and color.
        public string Name { get; protected set; }
        public string Type { get; protected set; }
        public string Color { get; protected set; }
        // Fill a list with at least 5 foxes, it's up to you how you name/create them.
        public Fox(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }
    }
}
