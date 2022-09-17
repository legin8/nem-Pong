/* Program name: Pong NEM
Project file name: Paddle.cs
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
    public abstract class Paddle
    {
        // Class Variables
        protected const int PADDLEWIDTH = 20;
        protected Brush brush;
        protected Rectangle formRectangle, scoreBoardRectangle;
        protected int paddlePositionY, paddleWidth, paddleSide;

        public Brush GetBrush => brush;

        // Class Constructor
        public Paddle(Rectangle formRectangle, Rectangle scoreBoardRectangle)
        {
            this.formRectangle = formRectangle;
            paddleWidth = 200;
            paddlePositionY = formRectangle.Bottom / 2;
            this.scoreBoardRectangle = scoreBoardRectangle;
        }

        public Rectangle GetPaddleRectangle => new Rectangle(paddleSide, paddlePositionY, PADDLEWIDTH, paddleWidth);

        public void MoveCpuPaddle(int upOrDown)
        {
            if (upOrDown == 0) PaddleYUp();
            if (upOrDown == 1) PaddleYDown();
        }

        public void PaddleYUp()
        {
            if (paddlePositionY > scoreBoardRectangle.Top) paddlePositionY -= 10;
            if (paddlePositionY < scoreBoardRectangle.Bottom) paddlePositionY = scoreBoardRectangle.Bottom;
        }

        public void PaddleYDown()
        {
            if (paddlePositionY < formRectangle.Bottom - paddleWidth) paddlePositionY += 10;
            if (paddlePositionY > formRectangle.Bottom - paddleWidth) paddlePositionY = formRectangle.Bottom - paddleWidth;
        }
    }
}
