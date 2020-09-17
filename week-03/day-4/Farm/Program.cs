using System;
using System.Collections.Generic;

namespace Farm
{
    class Program
    {
        public static void Main(string[] args)
        {
            var  animalsTest = new List<Animal>();
            animalsTest.Add(new Animal(50, 25));
            animalsTest.Add(new Animal(10, 30));
            animalsTest.Add(new Animal(15, 70));
            animalsTest.Add(new Animal(80, 100));
            animalsTest.Add(new Animal(84, 20));
            var farmTest = new Farm(animalsTest, 5);

            farmTest.Breed(14, 36);
            farmTest.Breed(20, 30);
            farmTest.Breed(30, 40);
            farmTest.Breed(40, 50);
            farmTest.Breed(50, 60);
            farmTest.Breed(60, 70);


        }
    }
}
