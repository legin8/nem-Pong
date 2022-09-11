using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong_NEM
{
    public class Score
    {
        // Abstract Class
        // Class Variables
        private const int NAMEOFYPOSITION = 20;
        private int score = 0, nameXPosition;
        private string name;

        // Gets and sets
        public int GetScore { get => score; set => score = value; }
        public string GetName { get => name; }
        public int GetNameXPosition { get => nameXPosition; }
        public int GetNameOfYPosition { get => NAMEOFYPOSITION; }

        public Score(string name, int nameXPosition)
        {
            this.name = name;
            this.nameXPosition = nameXPosition;
        }

    }
}
