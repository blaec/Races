﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LabRaces
{
    class Guy
    {
        public string Name;     // The guy's name
        public Bet MyBet;       // An instance of Bet that has his bet
        public int Cash;        // How much cahs he has

        // The last two fields are the guy's GUI controls on the form
        public RadioButton myRadioButton;       // My RadioButton
        public Label MyLabel;                   // My Label

        /// <summary>
        /// Set my label to my bet's description, and tthe label on my
        /// radio button to show my cash ("Joe has 43 bucks")
        /// </summary>
        public void UpdateLabels()
        {

        }

        /// <summary>
        /// Reset my bet so it's zero
        /// </summary>
        public void ClearBet()
        {

        }

        /// <summary>
        /// Place a new bet and store it in my bet field
        /// </summary>
        /// <param name="BetAmount"></param>
        /// <param name="DogToWin"></param>
        /// <returns>Return true if the guy had enough oney to bet</returns>
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            // MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this };
            return false;
        }

        /// <summary>
        /// Ask my bet to pay out, clear my bet, and update my labels
        /// </summary>
        /// <param name="Winner"></param>
        public void Collect(int Winner)
        {

        }
    }
}