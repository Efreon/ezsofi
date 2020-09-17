using System;
using System.Collections.Generic;

namespace ObjectOrientedProgramming
{
    class Program
    {

        static void Main(string[] args)
        {
            // POSTIT //
            PostIt postitOrangeBlue = new PostIt("orange", "Idea 1", "blue");
            PostIt postitPinkBlack = new PostIt("pink", "Awesome", "black");
            PostIt postitYellowGreen = new PostIt("yellow", "Superb!", "green");

            // BLOG POST //
            BlogPost blogPostJohnDoe = new BlogPost("John Doe",
                                                    "Lorem Ipsum",
                                                    "Lorem ipsum dolor sit amet.",
                                                    "2000.05.04.");
            BlogPost blogPostTimUrban = new BlogPost("Tim Urban",
                                                     "Wait but why",
                                                     "A popular long-form, stick-figure-illustrated blog about almost everything.",
                                                     "2010.10.10.");
            BlogPost blogPostWilliamTurton = new BlogPost("William Turton",
                                                          "One Engineer Is Trying to Get IBM to Reckon With Trump",
                                                          "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.",
                                                          "2017.03.28.");
            // ANIMAL // 
            var animal = new Animal(30, 70);
            Console.WriteLine($"The animal has {animal.hunger} hunger and {animal.thirst} thirst at the beginning");
            animal.Eat();
            animal.Drink();
            animal.Play();
            animal.Play();
            Console.WriteLine($"The animal has {animal.hunger} hunger and {animal.thirst} thirst at the end");

            //SHARPIE //
            var sharpie = new Sharpie("blue", 37);
            Console.WriteLine($"initial ink amount: {sharpie.inkAmount}");
            sharpie.Use();
            Console.WriteLine($"ink amount after use: {sharpie.inkAmount}");

            // COUNTER//
            var c = new Counter();
            c.Add();
            Console.WriteLine(c.initialNumber);
            c.Get();
            Console.WriteLine(c.initialNumber);
            c.Reset();
            Console.WriteLine(c.initialNumber);
         }
    }
}
