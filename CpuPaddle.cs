﻿using System;
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
        public CpuPaddle(Graphics graphics, Rectangle formRectangle) : base(graphics, formRectangle)
        {
            paddleSide = formRectangle.Right - PADDLEWIDTH;
            paddlePositionY = 200;
            brush = Brushes.Tomato;
        }

        public override void MovePaddle()
        {
            graphics.FillRectangle(brush, paddleSide, paddlePositionY, PADDLEWIDTH, paddleSize); // Testing Code
        }

    }
}