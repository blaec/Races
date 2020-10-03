using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LabRaces
{
    class Greyhound
    {
        public int StartingPosition;                // Where y PuctureBox starts
        public int RacetackiLength;                 // How long the racetrack is
        public PictureBox MyPictureBox = null;      // My PictureBox object
        public int Location = 0;                    // My Location on the recetrack
        public Random Randomizer;                   // And instance of Random

        /// <summary>
        /// Move either 1, 2, 3 or 4 spaces at random
        /// Update the position of my PictureBox on the form like this:
        ///   MyPictureBoxLeft = StartingPosition + Location;
        /// </summary>
        /// <returns>Return true if I won the race</returns>
        public bool Run()
        {
            return false;
        }

        /// <summary>
        /// Reset my location to 0 and my PictureBox to starting position
        /// </summary>
        public void TakeStartingPosition()
        {

        }
    }
}
