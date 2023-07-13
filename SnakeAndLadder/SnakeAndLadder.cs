﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLader
{

    internal class SnakeAndLader
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100, STARTING_POSITION = 0;

        int position = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int diePosition = random.Next(1, 7);
            Console.WriteLine("Die POsition is" + diePosition);
            return diePosition;
        }
        public void Game()
        {
            int option = random.Next(0, 3);
            int dice = DieRoll();
            while (this.position < WINNING_POSITION)
            {
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.position += dice;
                        break;
                    case SNAKE:
                        if (this.position < STARTING_POSITION)
                            this.position = 0;
                        else
                            this.position -= dice;
                        break;
                }
            }
        }

    }
}