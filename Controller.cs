using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_NEM
{
    public class Controller
    {
        // Class Variables
        private Ball ball;
        private PlayerPaddle playerPaddle;
        private Screen screen;

        private Graphics graphics;

        private int ballStartX = 600, ballStartY = 300;
        // private bool ballIsInPlay = true; // Testing code

        private bool isOver;

        public bool IsOver { get => isOver; set => isOver = value; }

        // Class Constructor
        public Controller(Graphics graphics, Random random, Rectangle clientRectangle)
        {
            screen = new Screen(graphics, clientRectangle);
            this.graphics = graphics;
            ball = new Ball(ballStartX, ballStartY, random, clientRectangle);
            this.playerPaddle = new PlayerPaddle(graphics, clientRectangle);
            isOver = false;
        }

        // This will be called by the timer
        // Will move the balls
        public void RunGame()
        {
            /*
            if (!ballIsInPlay)
            {
                ball.ResetBall(ref ballIsInPlay);
            }
            */


            if (ball.IsDead)
            {
                isOver = true;
                
            }

            screen.DisplayScreen(ball, playerPaddle);
        }

        public void MovePaddleUp()
        {
            playerPaddle.PaddleYUp();
        }

        public void MovePaddleDown()
        {
            playerPaddle.PaddleYDown();
        }

    }
}
