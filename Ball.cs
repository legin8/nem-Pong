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
        private const int BALLSIZE = 20, XYORIGIN = 0;

        // Holds References
        private Graphics graphics;
        private Rectangle formRectangle;

        // This class variables
        private int ballSpeedX, ballSpeedY; // Ball position and speed
        private bool ballXGoUp = true, ballYGoUp = true;
        private int ballPositionX, ballPositionY;
        
        // Gets and Sets
        public int BallSize { get => BALLSIZE; }
        public int BallPositionX { get => ballPositionX; set => ballPositionX = value; }
        public int BallPositionY { get => ballPositionY; set => ballPositionY = value; }
        


        // Class Constructor
        public Ball(int ballPositionX, int ballPositionY, Random random, Rectangle clientRectangle, Graphics graphics, Rectangle formRectangle)
        {
            this.graphics = graphics;

            // Ball positions and speed
            BallPositionX = ballPositionX;
            BallPositionY = ballPositionY;
            ballSpeedX = 20;
            ballSpeedY = 20;
            this.formRectangle = formRectangle;
        }

        // This will call Methods in ball Class to check and move Ball
        public void UpdateBall()
        {
            MoveBall();
            SideBounce();
        }

        // This Moves the Ball under perfect conditions
        private void MoveBall()
        {
            // X axis
            if (ballXGoUp) BallPositionX += ballSpeedX;
            if (!ballXGoUp) BallPositionX -= ballSpeedX;

            // Y axis
            if (ballYGoUp) BallPositionY += ballSpeedY;
            if (!ballYGoUp) BallPositionY -= ballSpeedY;
        }

        // This will set the correct position of the ball for the bounce.
        private void SideBounce()
        {
            if (ballPositionX >= formRectangle.Width - BALLSIZE)
            {
                ballXGoUp = !ballXGoUp;
                ballPositionX = formRectangle.Width - BALLSIZE;
                Console.Beep(2000, 200);
            }

            if (ballPositionX <= XYORIGIN)
            {
                ballXGoUp = !ballXGoUp;
                ballPositionX = XYORIGIN;
                Console.Beep(2000, 200);
            }

            if (ballPositionY >= formRectangle.Height - BALLSIZE)
            {
                ballYGoUp = !ballYGoUp;
                ballPositionY = formRectangle.Height - BALLSIZE;
                Console.Beep();
            }

            if (ballPositionY <= XYORIGIN)
            {
                ballYGoUp = !ballYGoUp;
                ballPositionY = XYORIGIN;
                Console.Beep();
            }
        }

       
        public void ResetBall()
        {
            ballPositionX = 300;
            ballPositionY = 600;
            Console.WriteLine(BallPositionX);
            Console.WriteLine(BallPositionY);

        }

    }
}
