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
        private Rectangle formRectangle, scoreBoardRectangle;
        private RandomColor randomColor;
        private Brush brush;
        private Score playerScore, cpuScore;
        private Paddle playerPaddle, cpuPaddle;

        // This class variables
        private int ballSpeedX, ballSpeedY;
        private bool ballXGoUp = true, ballYGoUp = true, isReset = false;
        private int ballPositionX, ballPositionY;
        
        // Gets and Sets
        public Brush GetBrush => brush;
        public Rectangle GetBall() => new Rectangle(ballPositionX, ballPositionY, BALLSIZE, BALLSIZE);

        // Class Constructor
        public Ball(Rectangle clientRectangle, Rectangle formRectangle, Rectangle scoreBoardRectangle,
            Score playerScore, Score cpuScore, Paddle playerPaddle, Paddle cpuPaddle, RandomColor randomColor)
        {
            this.formRectangle = formRectangle;
            this.scoreBoardRectangle = scoreBoardRectangle;
            this.playerScore = playerScore;
            this.cpuScore = cpuScore;
            this.playerPaddle = playerPaddle;
            this.cpuPaddle = cpuPaddle;
            this.randomColor = randomColor;
            ballPositionX = clientRectangle.Width / 2;
            ballPositionY = clientRectangle.Height / 2;
            ballSpeedX = 20;
            ballSpeedY = 20;
            brush = new SolidBrush(randomColor.GetColor());
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

            if (ballPositionX > formRectangle.Width / 2) {
                if (ballPositionY <= cpuPaddle.GetPaddleRectangle.Bottom)
                {
                    cpuPaddle.MoveCpuPaddle(0);
                } else
                {
                    cpuPaddle.MoveCpuPaddle(1);
                }
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
            // Right side Score and Reset
            if (ballPositionX >= formRectangle.Right - BALLSIZE)
            {
                ballXGoUp = false;
                ballPositionX = formRectangle.Right - BALLSIZE;
                isReset = true;
                playerScore.CurrentScore++;
                playerScore.HasScored = true;
                cpuScore.HasScored = false;
            }

            // Left side Score and Reset
            if (ballPositionX <= formRectangle.Left)
            {
                ballXGoUp = true;
                ballPositionX = formRectangle.Left;
                isReset = true;
                cpuScore.CurrentScore++;
                playerScore.HasScored = true;
                cpuScore.HasScored = false;
            }


            // Cpu Paddle Bounce
            if (ballPositionX >= cpuPaddle.GetPaddleRectangle.Left - BALLSIZE && ballPositionX <= cpuPaddle.GetPaddleRectangle.Right - BALLSIZE)
            {
                if (ballPositionY >= cpuPaddle.GetPaddleRectangle.Top - BALLSIZE && ballPositionY <= cpuPaddle.GetPaddleRectangle.Bottom - BALLSIZE )
                {
                    ballXGoUp = false;
                    ballPositionX = cpuPaddle.GetPaddleRectangle.Left - BALLSIZE;
                    Console.Beep(4000, 200);
                }
            }
            
            // Player Paddle Bounce
            if (ballPositionX <= playerPaddle.GetPaddleRectangle.Right && ballPositionX >= playerPaddle.GetPaddleRectangle.Left)
            {
                if (ballPositionY >= playerPaddle.GetPaddleRectangle.Top && ballPositionY <= playerPaddle.GetPaddleRectangle.Bottom)
                {
                    ballXGoUp = true;
                    ballPositionX = playerPaddle.GetPaddleRectangle.Right;
                    Console.Beep(4000, 200);
                }
            }


            // Top Bounce
            if (ballPositionY >= formRectangle.Bottom - BALLSIZE)
            {
                ballYGoUp = false;
                ballPositionY = formRectangle.Bottom - BALLSIZE;
                Console.Beep();
            }
            // Bottom Bounce
            if (ballPositionY <= scoreBoardRectangle.Bottom)
            {
                ballYGoUp = true;
                ballPositionY = scoreBoardRectangle.Bottom;
                Console.Beep();
            }
        }

       // This is called to reset the ball position
        public void ResetBall()
        {
            ballPositionX = formRectangle.Width / 2;
            ballPositionY = formRectangle.Height /2;
            isReset = false;
            Console.Beep(2000, 200);

        }
    }
}
