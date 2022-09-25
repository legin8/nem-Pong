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
        private const int MAXSCORELIST = 5;
        private string[] highScoreArr = new string[5];
        private bool winnerIsPlayer;
        private Score playerScore, cpuScore;

        // Class Constructor
        public HighScore(Score playerScore, Score cpuScore)
        {
            this.playerScore = playerScore;
            this.cpuScore = cpuScore;
            for (int i = 0; i < highScoreArr.Length; i++) highScoreArr[i] = "...";
        }

        public void FillArrayFromFile()
        {
            StreamReader sr = new StreamReader(@"../../HighScores.txt");
            int index = 0;
            highScoreArr[index] = makeNewHighScore();
            index++;

            while (index < MAXSCORELIST)
            {
                highScoreArr[index] = sr.ReadLine();
                index++;
            }
            sr.Close();
        }

        public void SaveToTXTFile()
        {
            using (StreamWriter sr = new StreamWriter(@"../../HighScores.txt"))
            {
                foreach (string entry in highScoreArr) sr.WriteLine(entry);
            }
        }

        public void WhoWon(bool playerWin)
        {
            winnerIsPlayer = playerWin;
            FillArrayFromFile();
            SaveToTXTFile();
        }


        private string makeNewHighScore()
        {
            string winnerName = winnerIsPlayer ? playerScore.GetName : cpuScore.GetName;
            return $"{playerScore.GetName}: {playerScore.GetScore}|| {cpuScore.GetName}: {cpuScore.GetScore} || Winner is {winnerName}";
        }


    }
}
