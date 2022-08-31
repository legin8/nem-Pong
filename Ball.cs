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
        protected const int BALLSIZE = 20, XYORIGIN = 0;
        
        protected int ballSpeedX, ballSpeedY; // Ball position and speed
        protected bool ballXGoUp = true, ballYGoUp = true;

        private bool isDead;
        private int ballPositionX;
        private int ballPositionY;

        public int BallPositionX { get => ballPositionX; set => ballPositionX = value; }
        public int BallPositionY { get => ballPositionY; set => ballPositionY = value; }
        public bool IsDead { get => isDead; set => isDead = value; }


        // Class Constructor
        public Ball(int ballPositionX, int ballPositionY, Random random, Rectangle clientRectangle)
        {
            // Ball positions and speed
            this.ballPositionX = ballPositionX;
            this.ballPositionY = ballPositionY;
            ballSpeedX = 20;
            ballSpeedY = 20;
            isDead = false;
        }

        // This will call Methods in ball Class to move Ball
        public void MoveBall(Graphics graphics, Rectangle formRectangle)
        {
            CheckBallLocation(formRectangle);
            
            MoveBall();

            

            

            graphics.FillEllipse(Brushes.Red, ballPositionX, ballPositionY, BALLSIZE, BALLSIZE); // Testing Code
        }

        // This will check to see if Ball needs to change direction
        private void CheckBallLocation(Rectangle formRectangle)
        {
            // This won't be needed, X axis
            if (ballPositionX >= formRectangle.Width - (BALLSIZE *2))
            {
                ballXGoUp = !ballXGoUp;
                Console.WriteLine(ballPositionX + " 1x" + ballPositionY);
                //isDead = true;
                ResetBall();
                //Console.WriteLine(ballPositionX + " 2" + ballPositionY);

                //ballPositionX -= BALLSIZE; Test Code for Bounce
            }


            if (ballPositionX <= XYORIGIN)
            {
                ballXGoUp = !ballXGoUp;
                Console.WriteLine(ballPositionX + " 1y" + ballPositionY);
                
                ResetBall();
                //Console.WriteLine(ballPositionX + " 2y" + ballPositionY);

                //ballPositionX = originOfScreen; Test Code for Bounce
            }


            // This above won't be needed, X axis

            if (ballPositionY >= formRectangle.Height - (BALLSIZE * 2)) ballYGoUp = !ballYGoUp;
            if (ballPositionY <= XYORIGIN) ballYGoUp = !ballYGoUp;

        }

        // This Moves the Ball under perfect conditions
        private void MoveBall()
        {
            if (ballXGoUp) ballPositionX += ballSpeedX;
            if (!ballXGoUp) ballPositionX -= ballSpeedX;

            if (ballYGoUp) ballPositionY += ballSpeedY;
            if (!ballYGoUp) ballPositionY -= ballSpeedY;
        }

       
        public void ResetBall()
        {
            ballPositionX = 300;
            ballPositionY = 600;
            Console.WriteLine(ballPositionX);
            Console.WriteLine(ballPositionY);

        }

    }
}
