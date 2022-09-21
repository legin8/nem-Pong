/* Program name: Pong NEM
Project file name: Controller.cs
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_NEM
{
    public class Controller
    {
        // Class Variables
        private const int ENDGAMECONDITION = 1;
        private Ball ball;
        private Paddle playerPaddle, cpuPaddle;
        private Screen screen;
        private Score playerScore, cpuScore;
        private ScoreBoard scoreBoard;
        private HighScore highScore;
        private RandomColor randomColor;
        private bool gameEnded;
        private Timer timer1;



        // Class Constructor
        public Controller(Graphics graphics, Random random, Rectangle formRectangle, Timer timer1)
        {
            randomColor = new RandomColor(random);
            scoreBoard = new ScoreBoard(formRectangle);
            playerPaddle = new PlayerPaddle(formRectangle, scoreBoard.GetScoreBoardRectangle, randomColor);
            cpuPaddle = new CpuPaddle(formRectangle, scoreBoard.GetScoreBoardRectangle, randomColor);
            playerScore = new Score("Nigel", formRectangle.Left + 20);
            cpuScore = new Score("CPU", formRectangle.Right - 100);
            ball = new Ball(formRectangle, formRectangle, scoreBoard.GetScoreBoardRectangle, playerScore, cpuScore, playerPaddle, cpuPaddle, randomColor);
            screen = new Screen(graphics, ball, playerPaddle, cpuPaddle, playerScore, cpuScore, scoreBoard, formRectangle);
            highScore = new HighScore();
            gameEnded = false;
            this.timer1 = timer1;
        }

        // This will be called by the timer
        // Will move the balls
        public void RunGame(Timer timer)
        {
            if (!gameEnded) screen.DisplayScreen();
            if (gameEnded) endGame(timer);
            if (playerScore.GetScore == ENDGAMECONDITION || cpuScore.GetScore == ENDGAMECONDITION) gameEnded = true;
        }



        // Moves Player paddle up
        public void MovePaddleUp(int up)
        {
            playerPaddle.MoveCpuPaddle(up);
        }

        // Moves Player paddle down
        public void MovePaddleDown(int down)
        {
            playerPaddle.MoveCpuPaddle(down);
        }

        private void endGame(Timer timer)
        {
            if (playerScore.GetScore == ENDGAMECONDITION) MessageBox.Show($"{playerScore.GetName} Wins");
            if (cpuScore.GetScore == ENDGAMECONDITION) MessageBox.Show($"{cpuScore.GetName} Wins");
            timer.Stop();
        }

    }
}
