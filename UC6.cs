using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class UC6
    {
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING = 100, START = 0;
        public int PlayerPosition = 0, count = 0;


        Random random = new Random();
        public int DieRolling()
        {
            int roll = random.Next(1, 7);
            return roll;
        }

        public void PlayerCheck()
        {
         
                while (PlayerPosition <= WINNING)
                {
                    int dieRoll = DieRolling();
                    int option = random.Next(0, 3);
                    switch (option)
                    {
                        case NO_PLAY:
                            break;
                        case LADDER:
                            PlayerPosition += dieRoll;
                            if (PlayerPosition > WINNING)
                            {
                                PlayerPosition += dieRoll;
                            }
                            Console.WriteLine("Got Ladder");
                            break;
                        case SNAKE:
                            PlayerPosition -= dieRoll;
                            if (PlayerPosition < START)
                            {
                                PlayerPosition = START;
                            }
                            Console.WriteLine("Got Snake");
                            break;
                    }
                    count++;
                    Console.WriteLine("The Player Position is :" + PlayerPosition + " " + "with a roll of " + dieRoll);
              
                    Console.WriteLine("The number of times dice was rolled to win the Game is : " + count);
               
                }
        }
    }
}
