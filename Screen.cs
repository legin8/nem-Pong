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
        private Ball ball;
        private Paddle playerPaddle, cpuPaddle;
        private Score playerScore, cpuScore;
        private ScoreBoard scoreBoard;
        //private BufferedGraphicsContext bufferedGraphicsContext;
        

        // Class Constructor
        public Screen(Graphics graphics, Ball ball, Paddle playerPaddle, Paddle cpuPaddle, Score playerScore, Score cpuScore,
            ScoreBoard scoreBoard)
        {
            this.graphics = graphics;
            this.ball = ball;
            this.playerPaddle = playerPaddle;
            this.cpuPaddle = cpuPaddle;
            this.playerScore = playerScore;
            this.cpuScore = cpuScore;
            this.scoreBoard = scoreBoard;

            //bufferedGraphicsContext = new BufferedGraphicsContext();
            
        }

        // Calls everything to be put on Screen
        // Test
        public void DisplayScreen()
        {
            ball.UpdateBall();

            graphics.Clear(Control.DefaultBackColor);

            graphics.FillEllipse(ball.GetBrush, ball.GetBall()); // Ball
            graphics.FillRectangle(scoreBoard.GetScoreBoardBrush, scoreBoard.GetScoreBoardRectangle); // Testing Code for Score Board
            graphics.DrawString(playerScore.GetName, playerScore.GetFont, Brushes.Black, new Point(playerScore.GetNameXPosition, playerScore.GetNameOfYPosition)); // Testing Code for Score Name

            graphics.FillRectangle(playerPaddle.GetBrush, playerPaddle.GetPaddle()); // Player Paddle
            graphics.FillRectangle(cpuPaddle.GetBrush, cpuPaddle.GetPaddle()); // Cpu Paddle
            
        }
    }
}
