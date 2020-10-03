using System;
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
        /// Set my label to my bet's description, and the label on my
        /// radio button to show my cash ("Joe has 43 bucks")
        /// </summary>
        public void UpdateLabels()
        {
            myRadioButton.Text = $"{Name} has {Cash} bucks";
            MyLabel.Text = MyBet.Amount == 0
                ? ($"{Name} hasn't placed a bet")
                : ($"{Name} bets {MyBet.Amount} on dog #{MyBet.Dog}");
        }

        /// <summary>
        /// Reset my bet so it's zero
        /// </summary>
        public void ClearBet()
        {
            MyBet = new Bet();
        }

        /// <summary>
        /// Place a new bet and store it in my bet field
        /// </summary>
        /// <param name="BetAmount"></param>
        /// <param name="DogToWin"></param>
        /// <returns>Return true if the guy had enough oney to bet</returns>
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            bool result = false;
            int newBalance = Cash + MyBet.Amount - BetAmount;
            if (newBalance >= 0)
            {
                Cash = newBalance;
                MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin };
                UpdateLabels();
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Ask my bet to pay out, clear my bet, and update my labels
        /// </summary>
        /// <param name="PrizeAmount"></param>
        public void Collect(int PrizeAmount)
        {
            Cash += PrizeAmount;
            ClearBet();
            UpdateLabels();
        }
    }
}
