using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LabRaces
{
    public partial class Form1 : Form
    {
        private readonly Guy[] guys;
        private readonly Greyhound[] dogs;
        private readonly Random random = new Random();
        private Guy selectedBettor = null;

        public Form1()
        {
            InitializeComponent();

            // init guys
            guys = new Guy[3];
            guys[0] = new Guy() { Name = "Joe", Cash = 50, MyBet = new Bet(), MyLabel = joeBetLabel, myRadioButton = joeRadioButton };
            guys[1] = new Guy() { Name = "Bob", Cash = 75, MyBet = new Bet(), MyLabel = bobBetLabel, myRadioButton = bobRadioButton };
            guys[2] = new Guy() { Name = "Al", Cash = 45, MyBet = new Bet(), MyLabel = alBetLabel, myRadioButton = alRadioButton };
            for (int i = 0; i < guys.Length; i++)
            {
                guys[i].UpdateLabels();
            }

            // init dogs
            dogs = new Greyhound[4];
            dogs[0] = new Greyhound() { Randomizer = random, MyPictureBox = dog1, StartingPosition = dog1.Left, RacetackiLength = racetrack.Width - dog1.Width };
            dogs[1] = new Greyhound() { Randomizer = random, MyPictureBox = dog2, StartingPosition = dog2.Left, RacetackiLength = racetrack.Width - dog2.Width };
            dogs[2] = new Greyhound() { Randomizer = random, MyPictureBox = dog3, StartingPosition = dog3.Left, RacetackiLength = racetrack.Width - dog3.Width };
            dogs[3] = new Greyhound() { Randomizer = random, MyPictureBox = dog4, StartingPosition = dog4.Left, RacetackiLength = racetrack.Width - dog4.Width };

            // init form
            bettingParlor.Enabled = true;
            minimumBetLabel.Text = $"Minimum bet: {betAmount.Minimum} bucks";
            selectedBettor = guys[0];
            activeBettor.Text = selectedBettor.Name;
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedBettor = guys[0];
            activeBettor.Text = selectedBettor.Name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedBettor = guys[1];
            activeBettor.Text = selectedBettor.Name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedBettor = guys[2];
            activeBettor.Text = selectedBettor.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bettingParlor.Enabled = false;
            Thread.Sleep(1000);
            int winner = random.Next(1, 4);
            Utils.showMessage($"Won dog #{winner}");
            for (int i = 0; i < guys.Length; i++)
            {
                guys[i].Collect(guys[i].MyBet.PayOut(winner));
            }
            bettingParlor.Enabled = true;
        }

        private void placeBet_Click(object sender, EventArgs e)
        {
            if (!selectedBettor.PlaceBet((int)betAmount.Value, (int)dogToWin.Value))
            {
                Utils.showMessage($"{selectedBettor.Name} has not enough money!");
            }
        }
    }
}
