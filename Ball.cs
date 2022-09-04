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
        private const int BALLSIZE = 20, XYORIGIN = 0;

        private Graphics graphics;
        private Rectangle formRectangle;

        private int ballSpeedX, ballSpeedY; // Ball position and speed
        private bool ballXGoUp = true, ballYGoUp = true;

        private bool isDead;
        //private int ballPositionX, ballPositionY;


        public int BallSize { get => BALLSIZE; }
        public int BallPositionX { get; set; }
        public int BallPositionY { get; set; }
        public bool IsDead { get => isDead; set => isDead = value; }


        // Class Constructor
        public Ball(int ballPositionX, int ballPositionY, Random random, Rectangle clientRectangle, Graphics graphics, Rectangle formRectangle)
        {
            this.graphics = graphics;

            // Ball positions and speed
            BallPositionX = ballPositionX;
            BallPositionY = ballPositionY;
            ballSpeedX = 20;
            ballSpeedY = 20;
            isDead = false;
            this.formRectangle = formRectangle;
        }

        // This will call Methods in ball Class to move Ball
        public void UpdateBall()
        {
            CheckBallLocation();

            MoveBall();

            

            // graphics.FillEllipse(Brushes.Red, ballPositionX, ballPositionY, BALLSIZE, BALLSIZE); // Testing Code
        }

        // This will check to see if Ball needs to change direction
        private void CheckBallLocation()
        {
            // This won't be needed, X axis
            if (BallPositionX >= formRectangle.Width - (BALLSIZE *2))
            {
                ballXGoUp = !ballXGoUp;
                Console.WriteLine(BallPositionX + " 1x" + BallPositionY);
                //isDead = true;
                ResetBall();
                //Console.WriteLine(ballPositionX + " 2" + ballPositionY);

                //ballPositionX -= BALLSIZE; Test Code for Bounce
            }


            if (BallPositionX <= XYORIGIN)
            {
                ballXGoUp = !ballXGoUp;
                Console.WriteLine(BallPositionX + " 1y" + BallPositionY);
                
                ResetBall();
                //Console.WriteLine(ballPositionX + " 2y" + ballPositionY);

                //ballPositionX = originOfScreen; Test Code for Bounce
            }


            // This above won't be needed, X axis

            if (BallPositionY >= formRectangle.Height - (BALLSIZE * 2)) ballYGoUp = !ballYGoUp;
            if (BallPositionY <= XYORIGIN) ballYGoUp = !ballYGoUp;

        }

        // This Moves the Ball under perfect conditions
        private void MoveBall()
        {
            if (ballXGoUp) BallPositionX += ballSpeedX;
            if (!ballXGoUp) BallPositionX -= ballSpeedX;

            if (ballYGoUp) BallPositionY += ballSpeedY;
            if (!ballYGoUp) BallPositionY -= ballSpeedY;
        }

       
        public void ResetBall()
        {
            BallPositionX = 300;
            BallPositionY = 600;
            Console.WriteLine(BallPositionX);
            Console.WriteLine(BallPositionY);

        }

    }
}
