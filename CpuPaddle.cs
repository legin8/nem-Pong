/* Program name: Pong NEM
Project file name: CpuPaddle.cs
Author: Nigel Maynard
Date: 24/8/22
Language: C#
Platform: Microsoft Visual Studio 2022
Purpose: Class work
Description: Assessment game: Pong.
Known Bugs:
Additional Features:
*/

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
            paddlePositionY = formRectangle.Bottom / 2;
            brush = Brushes.Tomato;
        }

    }
}
