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
        public CpuPaddle(Rectangle formRectangle, Rectangle scoreBoardRectangle) : base(formRectangle, scoreBoardRectangle)
        {
            paddleSide = formRectangle.Right - PADDLEWIDTH;
            paddlePositionY = 400;
            brush = Brushes.Tomato;
        }

        

    }
}
