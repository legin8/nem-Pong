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
        protected Rectangle formRectangle;
        protected int paddlePositionY, paddleSize, paddleSideX;

        public int PaddlePositionY { get => paddlePositionY; }
        public int PaddleSize { get => paddleSize; }
        public int PaddleSideX { get => paddleSideX; }
        public int PaddleWidth { get => PADDLEWIDTH; }


        // Class Constructor
        public Paddle(Graphics graphics, Rectangle formRectangle)
        {
            this.graphics = graphics;
            this.formRectangle = formRectangle;
            paddleSideX = 100;
        }

        public void MovePaddle()
        {
            graphics.FillRectangle(brush, paddleSideX, paddlePositionY, PADDLEWIDTH, paddleSize); // Testing code
        }



        public void PaddleYUp()
        {
            if (paddlePositionY > formRectangle.Top) paddlePositionY -= 10;
            if (paddlePositionY < formRectangle.Top) paddlePositionY = formRectangle.Top;
        }

        public void PaddleYDown()
        {
            if (paddlePositionY < formRectangle.Bottom - paddleSize) paddlePositionY += 10;
            if (paddlePositionY > formRectangle.Bottom - paddleSize) paddlePositionY = formRectangle.Bottom - paddleSize;
        }
    }
}
