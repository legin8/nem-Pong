/* Program name: Pong NEM
Project file name: HighScore.cs
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong_NEM
{
    public class HighScore
    {
        // Class Variables
        private string[] highScoreArr = new string[5];
        private string newHighScore;
        private bool winnerIsPlayer;
        private Score playerScore, cpuScore;

        // Class Constructor
        public HighScore(Score playerScore, Score cpuScore)
        {
            this.playerScore = playerScore;
            this.cpuScore = cpuScore;
        }

        public void FillArrayFromFile()
        {
            StreamReader sr = new StreamReader(@"../../HighScores.txt");
            int index = 0;

            while (!sr.EndOfStream)
            {
                highScoreArr[index] = sr.ReadLine();
                index++;
            }
            sr.Close();
        }

        public void SaveToTXTFile()
        {
            
        }

        public void WhoWon(bool playerWin)
        {
            winnerIsPlayer = playerWin;
        }


        private string makeNewHighScore()
        {
            string winnerName = winnerIsPlayer ? playerScore.GetName : cpuScore.GetName;
            return $"{playerScore.GetName}: {playerScore.GetScore}|| {cpuScore.GetName}: {cpuScore.GetScore} || Winner is {winnerName}";
        }


    }
}
