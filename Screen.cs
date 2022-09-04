using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_NEM
{
    public class Screen
    {
        // Class Variables
        private Graphics graphics;
        private Rectangle formRectangle;
        private Ball ball;
        private Paddle playerPaddle;
        //private BufferedGraphicsContext bufferedGraphicsContext;
        

        // Class Constructor
        public Screen(Graphics graphics, Rectangle formRectangle, Ball ball, Paddle paddle)
        {
            this.graphics = graphics;
            this.formRectangle = formRectangle;
            this.ball = ball;
            this.playerPaddle = paddle;

            //bufferedGraphicsContext = new BufferedGraphicsContext();
            
        }

        // Calls everything to be put on Screen
        // Test
        public void DisplayScreen()
        {
            graphics.Clear(Control.DefaultBackColor);
            ball.UpdateBall();

            graphics.FillEllipse(Brushes.Red, ball.BallPositionX, ball.BallPositionY, ball.BallSize, ball.BallSize); // Testing Code

            playerPaddle.DrawPaddle();
        }
    }
}
