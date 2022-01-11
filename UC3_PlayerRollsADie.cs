using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class UC3_PlayerRollsADie
    {
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        public int playerPosition = 0;
        Random random = new Random();
        public int DieRolling()
        {
            int roll = random.Next(1, 7);
            return roll;
        }
        public void PlayerCheck()
        {
            int die = DieRolling();
            int option = random.Next(0, 3);
            switch (option)
            {
                case NO_PLAY:
                    break;
                case LADDER:
                    playerPosition += die;
                    break;
                case SNAKE:
                    playerPosition -= die;
                    break;
            }
            Console.WriteLine(playerPosition);
        }
    }
}

