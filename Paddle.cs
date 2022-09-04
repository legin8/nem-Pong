﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong_NEM
{
    public class Paddle
    {
        // Class Variables
        protected const int PADDLEWIDTH = 20;
        protected Brush brush;
        protected Graphics graphics;
        protected Rectangle formRectangle;
        protected int paddlePositionY, paddleSize, paddleSide;
        // Class Constructor
        public Paddle(Graphics graphics, Rectangle formRectangle)
        {
            this.graphics = graphics;
            this.formRectangle = formRectangle;
            paddleSize = 100;
        }

        public virtual void DrawPaddle()
        {
            graphics.FillRectangle(brush, paddleSide, paddlePositionY, PADDLEWIDTH, paddleSize);
        }


        public void PaddleYUp()
        {
            if (paddlePositionY > 0) paddlePositionY -= 10;
            if (paddlePositionY < 0) paddlePositionY = formRectangle.Top;
        }

        public void PaddleYDown()
        {
            if (paddlePositionY < formRectangle.Bottom - paddleSize) paddlePositionY += 10;
            if (paddlePositionY > formRectangle.Bottom - paddleSize) paddlePositionY = formRectangle.Bottom - paddleSize;
        }
    }
}
