﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public class GameBoard
    {
        public PictureBox BoardImage = new PictureBox();
        public int[,] Matrix = new int[30,27];

        public void CreateBoardImage(Form formInstance, int Level)
        {
            // Create Board Image
            BoardImage.Name = "BoardImage";
            BoardImage.SizeMode = PictureBoxSizeMode.AutoSize;
            BoardImage.Location = new Point(0, 50);
            switch (Level)
            {
                case 1: BoardImage.Image = Properties.Resources.Board_1; break;
            }
            formInstance.Controls.Add(BoardImage);
        }

        public Tuple<int,int> InitialiseBoardMatrix(int Level)
        {
            // Initialise Game Board Matrix
            switch (Level)
            {
                case 1:
                    Matrix = new int[,] {
                        { 10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10 },
                        { 10,01,01,01,01,01,01,01,01,01,01,01,01,10,10,01,01,01,01,01,01,01,01,01,01,01,01,10 },
                        { 10,01,10,10,10,10,01,10,10,10,10,10,01,10,10,01,10,10,10,10,10,01,10,10,10,10,01,10 },
                        { 10,02,10,10,10,10,01,10,10,10,10,10,01,10,10,01,10,10,10,10,10,01,10,10,10,10,02,10 },
                        { 10,01,10,10,10,10,01,10,10,10,10,10,01,10,10,01,10,10,10,10,10,01,10,10,10,10,01,10 },
                        { 10,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,10 },
                        { 10,01,10,10,10,10,01,10,10,01,10,10,10,10,10,10,10,10,01,10,10,01,10,10,10,10,01,10 },
                        { 10,01,10,10,10,10,01,10,10,01,10,10,10,10,10,10,10,10,01,10,10,01,10,10,10,10,01,10 },
                        { 10,01,01,01,01,01,01,10,10,01,01,01,01,10,10,01,01,01,01,10,10,01,01,01,01,01,01,10 },
                        { 10,10,10,10,10,10,01,10,10,10,10,10,00,10,10,00,10,10,10,10,10,01,10,10,10,10,10,10 },
                        { 10,10,10,10,10,10,01,10,10,10,10,10,00,10,10,00,10,10,10,10,10,01,10,10,10,10,10,10 },
                        { 10,10,10,10,10,10,01,10,10,00,00,00,00,00,00,00,00,00,00,10,10,01,10,10,10,10,10,10 },
                        { 10,10,10,10,10,10,01,10,10,00,10,10,10,11,11,10,10,10,00,10,10,01,10,10,10,10,10,10 },
                        { 10,10,10,10,10,10,01,10,10,00,10,10,10,15,15,10,10,10,00,10,10,01,10,10,10,10,10,10 },
                        { 00,00,00,00,00,00,01,00,00,00,10,10,10,15,15,10,10,10,00,00,00,01,00,00,00,00,00,00 },
                        { 10,10,10,10,10,10,01,10,10,00,10,10,10,10,10,10,10,10,00,10,10,01,10,10,10,10,10,10 },
                        { 10,10,10,10,10,10,01,10,10,00,10,10,10,10,10,10,10,10,00,10,10,01,10,10,10,10,10,10 },
                        { 10,10,10,10,10,10,01,10,10,03,00,00,00,00,00,00,00,00,00,10,10,01,10,10,10,10,10,10 },
                        { 10,10,10,10,10,10,01,10,10,00,10,10,10,10,10,10,10,10,00,10,10,01,10,10,10,10,10,10 },
                        { 10,10,10,10,10,10,01,10,10,00,10,10,10,10,10,10,10,10,00,10,10,01,10,10,10,10,10,10 },
                        { 10,01,01,01,01,01,01,01,01,01,01,01,01,10,10,01,01,01,01,01,01,01,01,01,01,01,01,10 },
                        { 10,01,10,10,10,10,01,10,10,10,10,10,01,10,10,01,10,10,10,10,10,01,10,10,10,10,01,10 },
                        { 10,01,10,10,10,10,01,10,10,10,10,10,01,10,10,01,10,10,10,10,10,01,10,10,10,10,01,10 },
                        { 10,02,01,01,10,10,01,01,01,01,01,01,01,00,00,01,01,01,01,01,01,01,10,10,01,01,02,10 },
                        { 10,10,10,01,10,10,01,10,10,01,10,10,10,10,10,10,10,10,01,10,10,01,10,10,01,10,10,10 },
                        { 10,10,10,01,10,10,01,10,10,01,10,10,10,10,10,10,10,10,01,10,10,01,10,10,01,10,10,10 },
                        { 10,01,01,01,01,01,01,10,10,01,01,01,01,10,10,01,01,01,01,10,10,01,01,01,01,01,01,10 },
                        { 10,01,10,10,10,10,10,10,10,10,10,10,01,10,10,01,10,10,10,10,10,10,10,10,10,10,01,10 },
                        { 10,01,10,10,10,10,10,10,10,10,10,10,01,10,10,01,10,10,10,10,10,10,10,10,10,10,01,10 },
                        { 10,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,10 },
                        { 10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10 } };
                    break;
            }

            int StartX = 0;
            int StartY = 0;
            for (int y=0; y<30; y++)
            {
                for (int x=0; x<27; x++)
                {
                    if (Matrix[y, x] == 3) { StartX = x; StartY = y;}
                }
            }
            Tuple<int,int> StartLocation = new Tuple<int,int> (StartX, StartY);
            return StartLocation;
        }
    }
}
