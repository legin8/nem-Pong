﻿using System;
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
        private string[] highScoreList = new string[10];

        // Class Constructor
        public HighScore()
        {

        }

        public void FillArrayFromFile()
        {
            for (int i = 0; i < highScoreList.Length; i++)
            {
                // fill Array from the File here
            }
        }

        public void SaveToTXTFile()
        {
            for (int i = 0; i < highScoreList.Length; i++)
            {

            }
        }

    }
}