using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong_NEM
{
    public class PlayerPaddle : Paddle
    {

        
        // Class Constructor for child class
        public PlayerPaddle(Graphics graphics, Rectangle formRectangle, Rectangle scoreBoardRectangle) : base(graphics, formRectangle, scoreBoardRectangle)
        {
            paddleSide = 0;
            paddlePositionY = 400;
            brush = Brushes.Tomato;
        }

        

    }
}
