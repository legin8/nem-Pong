/* Program name: Pong NEM
Project file name: Form1.cs
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_NEM
{
    public partial class Form1 : Form
    {
        // Class Variables
        public Controller controller;
        private Bitmap bufferImage;
        private Graphics graphics;
        private Graphics bufferGraphics;
        private Random random;


        // Class Form Constructor
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            random = new Random();
            bufferImage = new Bitmap(Width, Height);
            bufferGraphics = Graphics.FromImage(bufferImage); 
            controller = new Controller(bufferGraphics, random, ClientRectangle);

        }

        // Event handler for timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            bufferGraphics.FillRectangle(Brushes.Black, 0, 0, Width, Height);
            controller.RunGame();
            graphics.DrawImage(bufferImage, 0, 0);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) controller.MovePaddleUp(); // Testing Code
            if (e.KeyCode == Keys.Down) controller.MovePaddleDown(); // Testing Code
        }
    }
}
