using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong_NEM
{
    public class CpuPaddle : Paddle
    {

        // Class Constructor
        public CpuPaddle(Graphics graphics, Rectangle formRectangle, Rectangle scoreBoardRectangle) : base(graphics, formRectangle, scoreBoardRectangle)
        {
            paddleSide = 1000;
            paddlePositionY = 400;
            brush = Brushes.Tomato;
        }

        

    }
}
