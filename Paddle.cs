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
        protected int paddlePositionY, paddleSizeX, paddleSide;

        public Brush GetBrush => brush;

        // Class Constructor
        public Paddle(Rectangle formRectangle, Rectangle scoreBoardRectangle)
        {
            this.formRectangle = formRectangle;
            paddleSizeX = 200;
            this.scoreBoardRectangle = scoreBoardRectangle;
        }

        public Rectangle GetPaddleRectangle => new Rectangle(paddleSide, paddlePositionY, PADDLEWIDTH, paddleSizeX);

        public void PaddleYUp()
        {
            if (paddlePositionY > 0) paddlePositionY -= 10;
            if (paddlePositionY < scoreBoardRectangle.Bottom) paddlePositionY = scoreBoardRectangle.Bottom;
            //if (paddlePositionY < 0) paddlePositionY = formRectangle.Top;
        }

        public void PaddleYDown()
        {
            if (paddlePositionY < formRectangle.Bottom - paddleSizeX) paddlePositionY += 10;
            if (paddlePositionY > formRectangle.Bottom - paddleSizeX) paddlePositionY = formRectangle.Bottom - paddleSizeX;
        }
    }
}
