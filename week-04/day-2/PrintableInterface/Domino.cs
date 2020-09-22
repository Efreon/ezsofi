using System;
using System.Collections.Generic;
using System.Text;

namespace PrintableInterface
{
    class Domino : IPrintable
    {
        private int sideA;
        private int sideB;

        public int SideA { get; protected set; }
        public int SideB { get; protected set; }

        public void PrintAllFields()
        {
            Console.WriteLine($"Domino A side: {sideA}, B side: {SideB}");
        }
    }
}
