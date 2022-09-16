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
            paddleWidth = 2000;
            paddlePositionY = formRectangle.Bottom / 2;
            this.scoreBoardRectangle = scoreBoardRectangle;
        }

        public Rectangle GetPaddleRectangle => new Rectangle(paddleSide, paddlePositionY, PADDLEWIDTH, paddleWidth);

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
