using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_NEM
{
    public class ScoreBoard
    {
        // Class Variables
        private Rectangle scoreBoardRectangle, formRectangle;
        private int scoreBoardHeight;
        private Brush brush = Brushes.DarkBlue;

        // Gets
        public Rectangle GetScoreBoardRectangle { get => scoreBoardRectangle; }
        public Brush GetScoreBoardBrush { get => brush; }
        

        // Class constructor
        public ScoreBoard(Rectangle formRectangle)
        {
            this.formRectangle = formRectangle;
            scoreBoardHeight = formRectangle.Height / 4;
            scoreBoardRectangle = new Rectangle(formRectangle.Left, formRectangle.Top, formRectangle.Width, scoreBoardHeight);
        }

    }
}
