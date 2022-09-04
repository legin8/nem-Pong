using System;
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
        private Graphics graphics;
        private Rectangle formRectangle;
        private Paddle playerPaddle, cpuPaddle;

        // This class variables
        private int ballSpeedX, ballSpeedY; // Ball position and speed
        private bool ballXGoUp = true, ballYGoUp = true, isReset = false;
        private int ballPositionX, ballPositionY;
        
        // Gets and Sets
        public int BallSize { get => BALLSIZE; }
        public int BallPositionX { get => ballPositionX; set => ballPositionX = value; }
        public int BallPositionY { get => ballPositionY; set => ballPositionY = value; }
        


        // Class Constructor
        public Ball(int ballPositionX, int ballPositionY, Random random, Rectangle clientRectangle, Graphics graphics, 
            Rectangle formRectangle, Paddle playerPaddle, Paddle cpuPaddle)
        {
            this.graphics = graphics;

            // Ball positions and speed
            this.ballPositionX = ballPositionX;
            this.ballPositionY = ballPositionY;
            ballSpeedX = 20;
            ballSpeedY = 20;

            this.formRectangle = formRectangle;
            this.playerPaddle = playerPaddle;
            this.cpuPaddle = cpuPaddle;
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
            /*
            if (ballPositionX == cpuPaddle.PaddleSideX - cpuPaddle.PaddleWidth && ballPositionY >= cpuPaddle.PaddlePositionY
                && ballPositionY >= cpuPaddle.PaddlePositionY + cpuPaddle.PaddleSize)
            {
                ballXGoUp = !ballXGoUp;
                ballPositionX = cpuPaddle.PaddleSideX - cpuPaddle.PaddleWidth;
            }
            */
            

            // This is for if one side loses
            // Left and Right
            if (ballPositionX >= formRectangle.Right - BALLSIZE)
            {
                ballXGoUp = !ballXGoUp;
                ballPositionX = formRectangle.Right - BALLSIZE;
                isReset = !isReset;
            }

            if (ballPositionX <= formRectangle.Left)
            {
                ballXGoUp = !ballXGoUp;
                ballPositionX = formRectangle.Left;
                isReset = !isReset;
            }

            // Top and Bottom
            if (ballPositionY >= formRectangle.Bottom - BALLSIZE)
            {
                ballYGoUp = !ballYGoUp;
                ballPositionY = formRectangle.Bottom - BALLSIZE;
                Console.Beep();
            }

            if (ballPositionY <= formRectangle.Top - BALLSIZE)
            {
                ballYGoUp = !ballYGoUp;
                ballPositionY = formRectangle.Top - BALLSIZE;
                Console.Beep();
            }
        }

       
        public void ResetBall()
        {
            ballPositionX = formRectangle.Width / 2;
            ballPositionY = formRectangle.Height /2;
            isReset = !isReset;
            Console.Beep(2000, 200);
        }

    }
}
