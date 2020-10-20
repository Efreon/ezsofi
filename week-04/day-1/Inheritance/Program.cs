using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Pepa", true);
            Console.WriteLine(hero);

            Character npc = new Character("Pepa");

            var npcHero = hero as Character;    // this can be casted this way, but won't work the other way around (Hero npcHer = Character(hero)

            // creating character on the spot (boolean check and casting at the same time)
            if (hero is Character character)
            {
                Console.WriteLine(character);
            }
        }
    }
}
