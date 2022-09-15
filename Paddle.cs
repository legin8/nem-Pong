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
        protected Graphics graphics;
        protected Rectangle formRectangle, scoreBoardRectangle, paddleRectangel;
        protected int paddlePositionY, paddleSize, paddleSide;

        public Brush GetBrush { get => brush; }
        public Rectangle GetPaddleRectangel { get => paddleRectangel; }

        // Class Constructor
        public Paddle(Graphics graphics, Rectangle formRectangle, Rectangle scoreBoardRectangle)
        {
            this.graphics = graphics;
            this.formRectangle = formRectangle;
            paddleSize = 2000;
            this.scoreBoardRectangle = scoreBoardRectangle;
            this.paddleRectangel = new Rectangle(paddleSide, paddlePositionY, PADDLEWIDTH, paddleSize);
        }

        public void PaddleYUp()
        {
            if (paddlePositionY > 0) paddlePositionY -= 10;
            if (paddlePositionY < scoreBoardRectangle.Bottom) paddlePositionY = scoreBoardRectangle.Bottom;
            //if (paddlePositionY < 0) paddlePositionY = formRectangle.Top;
            paddleRectangel = new Rectangle(paddleSide, paddlePositionY, PADDLEWIDTH, paddleSize);
        }

        public void PaddleYDown()
        {
            if (paddlePositionY < formRectangle.Bottom - paddleSize) paddlePositionY += 10;
            if (paddlePositionY > formRectangle.Bottom - paddleSize) paddlePositionY = formRectangle.Bottom - paddleSize;
            paddleRectangel = new Rectangle(paddleSide, paddlePositionY, PADDLEWIDTH, paddleSize);
        }
    }
}
