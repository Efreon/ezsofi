using ObjectOrientedProgramming;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace SharpieSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var sharpieTest = new SharpieSet();
            sharpieTest.Add(new Sharpie("yellow", 100));
            sharpieTest.Add(new Sharpie("blue", 100));
            sharpieTest.Add(new Sharpie("black", 100));
            sharpieTest.Add(new Sharpie("green", 100));

            foreach (var sharpie in sharpieTest.Sharpies)
            {
                for (int i = 0; i < 100; i++)
                {
                    sharpie.Use();
                }
            }

            Console.WriteLine(sharpieTest.CountUsable());
            sharpieTest.RemoveTrash();
            Console.WriteLine(sharpieTest.CountUsable());
        }
    }
}
