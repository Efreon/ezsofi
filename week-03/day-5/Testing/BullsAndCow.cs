using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BullsAndCows
{
    class BAC
    {
        // The player have to guess a 4 digit number.
        int guess = 1234;
        //The CAB object should have a random 4 digit number, which is the goal to guess.
        int goal = new Random().Next(1000, 10000);
        // The CAB object should have a state where the game state is stored (playing, finished).
        string state = "playing";
        // The CAB object should have a counter where it counts the guesses.
        int guesCounter = 0;

        public BAC(int guess)
        {
            Guess = { get guess; set; }
            Goal { get; set; }
            State = "playing";
            GuesCounter = 0;
        }

        public string BACGame(int guess)
        {
                
    
        }
    }
}
