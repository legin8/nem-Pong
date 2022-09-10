using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong_NEM
{
    public abstract class Score
    {
        // Abstract Class
        // Class Variables
        protected int score = 0;
        protected string name;

        // Gets and sets
        public int GetScore { get => score; set => score = value; }
        public string Name { get => name; }

        public Score(string name)
        {
            this.name = name;
        }

    }
}
