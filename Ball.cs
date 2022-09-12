﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_NEM
{
    public class Ball
    {
        // Class Variables
        // Constants
        private const int BALLSIZE = 20;

        // Holds References
        private Rectangle formRectangle, scoreBoardRectangle;
        private Brush brush;
        private Score playerScore, cpuScore;

        // This class variables
        private int ballSpeedX, ballSpeedY; // Ball position and speed
        private bool ballXGoUp = true, ballYGoUp = true, isReset = false;
        private int ballPositionX, ballPositionY;
        
        // Gets and Sets
        public Brush GetBrush { get => brush; }

        // Class Constructor
        public Ball(int ballPositionX, int ballPositionY, Random random, Rectangle clientRectangle, 
            Rectangle formRectangle, Rectangle scoreBoardRectangle, Score playerScore, Score cpuScore)
        {
            this.ballPositionX = ballPositionX;
            this.ballPositionY = ballPositionY;
            ballSpeedX = 20;
            ballSpeedY = 20;
            this.formRectangle = formRectangle;
            brush = Brushes.Black;
            this.scoreBoardRectangle = scoreBoardRectangle;
            this.playerScore = playerScore;
            this.cpuScore = cpuScore;
        }

        // This will Return the current Rectangle for the ball
        public Rectangle GetBall()
        {
            return new Rectangle(ballPositionX, ballPositionY, BALLSIZE, BALLSIZE);
        }

        // This will call Methods in ball Class to check and move Ball
        public void UpdateBall()
        {
            if (isReset)
            {
                ResetBall();
            } else
            {
                MoveBall();
                SideBounce();
            }
        }

        // This Moves the Ball under perfect conditions
        private void MoveBall()
        {
            // X axis
            if (ballXGoUp) ballPositionX += ballSpeedX;
            if (!ballXGoUp) ballPositionX -= ballSpeedX;

            // Y axis
            if (ballYGoUp) ballPositionY += ballSpeedY;
            if (!ballYGoUp) ballPositionY -= ballSpeedY;
        }

        // This will set the correct position of the ball for the bounce.
        private void SideBounce()
        {
            // Left and Right
            if (ballPositionX >= formRectangle.Right - (BALLSIZE + (BALLSIZE / 2)))
            {
                ballXGoUp = false;
                ballPositionX = formRectangle.Right - BALLSIZE;
                isReset = true;
                playerScore.CurrentScore++;
            }

            if (ballPositionX <= formRectangle.Left + BALLSIZE)
            {
                ballXGoUp = true;
                ballPositionX = formRectangle.Left;
                isReset = true;
                cpuScore.CurrentScore++;
            }

            // Top and Bottom
            if (ballPositionY >= formRectangle.Bottom - (BALLSIZE + (BALLSIZE / 2)))
            {
                ballYGoUp = false;
                ballPositionY = formRectangle.Bottom - BALLSIZE;
                Console.Beep();
            }

            if (ballPositionY <= scoreBoardRectangle.Bottom - BALLSIZE)
            {
                ballYGoUp = true;
                ballPositionY = scoreBoardRectangle.Bottom;
                Console.Beep();
            }
        }

       
        public void ResetBall()
        {
            ballPositionX = formRectangle.Width / 2;
            ballPositionY = formRectangle.Height /2;
            isReset = false;
            Console.Beep(2000, 200);
        }

    }
}
