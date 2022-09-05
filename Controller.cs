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
        private Paddle playerPaddle, cpuPaddle;
        private Screen screen;

        private Graphics graphics;

        private int ballStartX, ballStartY;

        // Class Constructor
        public Controller(Graphics graphics, Random random, Rectangle formRectangle)
        {
            ballStartX = formRectangle.Width / 2;
            ballStartY = formRectangle.Height / 2;
            this.graphics = graphics;

            ball = new Ball(ballStartX, ballStartY, random, formRectangle, graphics, formRectangle);
            playerPaddle = new PlayerPaddle(graphics, formRectangle);
            cpuPaddle = new CpuPaddle(graphics, formRectangle);
            cpuPaddle = new CpuPaddle(graphics, formRectangle);
            screen = new Screen(graphics, formRectangle, ball, playerPaddle, cpuPaddle);
        }

        // This will be called by the timer
        // Will move the balls
        public void RunGame()
        {
            screen.DisplayScreen();
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
