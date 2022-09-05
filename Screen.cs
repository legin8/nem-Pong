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
        private Paddle playerPaddle, cpuPaddle;
        //private BufferedGraphicsContext bufferedGraphicsContext;
        

        // Class Constructor
        public Screen(Graphics graphics, Rectangle formRectangle, Ball ball, Paddle playerPaddle, Paddle cpuPaddle)
        {
            this.graphics = graphics;
            this.formRectangle = formRectangle;
            this.ball = ball;
            this.playerPaddle = playerPaddle;
            this.cpuPaddle = cpuPaddle;

            //bufferedGraphicsContext = new BufferedGraphicsContext();
            
        }

        // Calls everything to be put on Screen
        // Test
        public void DisplayScreen()
        {
            ball.UpdateBall();

            graphics.Clear(Control.DefaultBackColor);

            graphics.FillEllipse(ball.GetBrush, ball.GetBall()); // Ball
            graphics.FillRectangle(playerPaddle.GetBrush, playerPaddle.GetPaddle()); // Player Paddle
            graphics.FillRectangle(cpuPaddle.GetBrush, cpuPaddle.GetPaddle()); // Cpu Paddle
            
        }
    }
}
