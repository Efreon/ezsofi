using System;
using System.Collections;

namespace Domino
{
    public class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }
        public int CompareTo(Domino otherDomino)
        {

            return Values[0].CompareTo(otherDomino.Values[0]);
        }
    }
}