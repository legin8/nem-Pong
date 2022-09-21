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
        private Ball ball;
        private Paddle playerPaddle, cpuPaddle;
        private Screen screen;
        private Score playerScore, cpuScore;
        private ScoreBoard scoreBoard;
        private HighScore highScore;
        private RandomColor randomColor;

        

        // Class Constructor
        public Controller(Graphics graphics, Random random, Rectangle formRectangle)
        {
            randomColor = new RandomColor(random);
            scoreBoard = new ScoreBoard(formRectangle);
            playerPaddle = new PlayerPaddle(formRectangle, scoreBoard.GetScoreBoardRectangle);
            cpuPaddle = new CpuPaddle(formRectangle, scoreBoard.GetScoreBoardRectangle);
            playerScore = new Score("Nigel", formRectangle.Left + 20);
            cpuScore = new Score("CPU", formRectangle.Right - 100);
            ball = new Ball(formRectangle, formRectangle, scoreBoard.GetScoreBoardRectangle, playerScore, cpuScore, playerPaddle, cpuPaddle, randomColor);
            screen = new Screen(graphics, ball, playerPaddle, cpuPaddle, playerScore, cpuScore, scoreBoard);
            highScore = new HighScore();
        }

        // This will be called by the timer
        // Will move the balls
        public void RunGame()
        {
            screen.DisplayScreen();
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

    }
}
