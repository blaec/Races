using System;
using System.Collections.Generic;
using System.Text;

namespace LabRaces
{
    class Bet
    {
        public int Amount;          // The amount of cash that was bet
        public int Dog;             // The number of the dog the bet is on
        public Guy Bettor;          // The guy who placed the bet

        /// <summary>
        /// Return the string that says who placed the bet, how much
        /// cash was bet, and which dog he bet on ("Joe bets 8 on dog #4").
        /// If the amount is zero, not bet was palced
        /// ("Joe hasn't placed a bet").
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            string description = null;
            if (Amount == 0)
            {
                description = ($"{Bettor.Name} hasn't placed a bet");
            }
            else
            {
                description = ($"{Bettor.Name} bets {Amount} on dog #{Dog}");
            }
            return description;
        }

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
