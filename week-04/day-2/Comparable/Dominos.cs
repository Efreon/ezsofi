using System;
using System.Collections.Generic;

namespace Domino
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

            var dominoesSorted = new List<Domino>();
            dominoesSorted.Add(dominoes[0]);
            for (int i = 1; i < dominoes.Count; i++)
            {
                if (dominoes[i].GetValues()[1] == dominoes[i-1].GetValues()[0])
                {
                    dominoesSorted.Add(dominoes[i]);
                }
            }
            // for (int i=0; dominoesSorted.Count;i++)
            //{
                Console.WriteLine($"[{dominoesSorted[1].GetValues()[0]}, {dominoesSorted[1].GetValues()[1]}]");
            // }
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}