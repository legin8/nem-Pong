/* Program name: Pong NEM
Project file name: Screen.cs
Author: Nigel Maynard
Date: 24/8/22
Language: C#
Platform: Microsoft Visual Studio 2022
Purpose: Class work
Description: Assessment game: Pong.
Known Bugs:
Additional Features:
*/

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
        }

        // Calls everything to be put on Screen
        public void DisplayScreen()
        {
            ball.UpdateBall();

            graphics.Clear(Control.DefaultBackColor);

            // Ball
            graphics.FillEllipse(ball.GetBrush, ball.GetBall());
            // Score Board
            graphics.FillRectangle(scoreBoard.GetScoreBoardBrush, scoreBoard.GetScoreBoardRectangle);
            // Names and scores on Score Board
            graphics.DrawString(playerScore.GetName, playerScore.GetFont, Brushes.Black, new Point(playerScore.GetNameXPosition, playerScore.GetNameOfYPosition));
            graphics.DrawString(playerScore.CurrentScore.ToString(), playerScore.GetFont, Brushes.Black, new Point(playerScore.GetNameXPosition, playerScore.GetScoreOfYPosition));
            graphics.DrawString(cpuScore.GetName, cpuScore.GetFont, Brushes.Black, new Point(cpuScore.GetNameXPosition, cpuScore.GetNameOfYPosition));
            graphics.DrawString(cpuScore.CurrentScore.ToString(), cpuScore.GetFont, Brushes.Black, new Point(cpuScore.GetNameXPosition, cpuScore.GetScoreOfYPosition));
            // Paddles
            graphics.FillRectangle(playerPaddle.GetBrush, playerPaddle.GetPaddleRectangle); // Player Paddle
            graphics.FillRectangle(cpuPaddle.GetBrush, cpuPaddle.GetPaddleRectangle); // Cpu Paddle
        }
    }
}
