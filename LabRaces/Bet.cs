using System;
using System.Collections.Generic;
using System.Text;

namespace LabRaces
{
    class Bet
    {
        public int Amount;          // The amount of cash that was bet
        public int Dog;             // The number of the dog the bet is on

        /// <summary>
        /// If the dog won, return the amount bet.
        /// Otherwise, return the negative of the amount bet.
        /// </summary>
        /// <param name="Winner">The paramenter is the winner of the race.</param>
        /// <returns></returns>
        public int PayOut(int Winner)
        {
            return Amount * (Dog == Winner ? 2 : 0);
        }
    }
}
