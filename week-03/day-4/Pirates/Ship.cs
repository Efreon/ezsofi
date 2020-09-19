using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Pirates
{
    public class Ship
    {
        private List<Pirate> crew;
        private bool isCaptainDrunk;
        private string captainState;
        private int aliveCrew;

        public Ship()
        {
            crew = new List<Pirate>();
        }

        public List<Pirate> Crew
        {
            get { return crew; }
            set { }
        }
        public bool IsCaptainDrunk
        {
            get { return isCaptainDrunk; }
            set { }
        }
        /*public bool CaptainRum 
        {
            get { return }
            set { return }
        }*/

        public void FillShip()
        {
            var randomCrew = new Random().Next(5, 26);
            for (int i = 0; i < randomCrew; i++)
            {
                Crew.Add(new Pirate($"Pirate-{i}"));
            }
            var captain = new Pirate("Captain");
            captain.IsCaptain = true;
            Crew.Add(captain);
        }

        public void ShipInfo()
        {
            for (int i = 0; i < Crew.Count; i++)
            {
                if (Crew[i].IsCaptain)
                {
                    if (Crew[i].ToxicLevel > 0)
                    {
                        isCaptainDrunk = true;
                        Console.WriteLine("The captain has drunk rum");
                    }
                    else if (Crew[i].ToxicLevel == 0) 
                    {
                        isCaptainDrunk = false;
                        Console.WriteLine("The captain has not drunk rum");
                    }

                    if ( Crew[i].IsPassedOut)
                    {
                        captainState = "passed out";
                        Console.WriteLine("The captain is passed out");
                    }
                    if (Crew[i].IsAlive == false)
                    {
                        captainState = "dead";
                        Console.WriteLine("The captain is dead");
                    }
                }
                if (Crew[i].IsAlive)
                {
                    aliveCrew += 1;
                }
            }
            Console.WriteLine($"The captain has drunk: {isCaptainDrunk} and {captainState}.");
            Console.WriteLine($"There are {aliveCrew} alive pirates on the ship.");
        }
    }
}
