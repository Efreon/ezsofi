using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    public class Ship
    {
        private List<Pirate> crew;

        public Ship()
        {
            crew = new List<Pirate>();
        }

        public List<Pirate> Crew
        {
            get { return crew; } 
            set { }
        }

        public void FillShip()
        {
            var randomCrew = new Random().Next(5, 26);
            for (int i = 0; i < randomCrew; i++)
            {
                Crew.Add(new Pirate($"Pirate{i}"));
            }
            var captain = new Pirate("Captain");
            Crew.Add(captain);
        }
    }
}
