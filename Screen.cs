using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        //private BufferedGraphicsContext bufferedGraphicsContext;
        

        // Class Constructor
        public Screen(Graphics graphics, Rectangle formRectangle)
        {
            this.graphics = graphics;
            this.formRectangle = formRectangle;

            //bufferedGraphicsContext = new BufferedGraphicsContext();
            
        }

        // Clears Screen
        private void ClearScreen()
        {
            graphics.Clear(Control.DefaultBackColor);
        }

        // Calls everything to be put on Screen
        // Test
        public void DisplayScreen(Ball ball, Paddle playerPaddle)
        {
            ClearScreen();
            ball.MoveBall(graphics, formRectangle);
            playerPaddle.DrawPaddle();
        }
    }
}
