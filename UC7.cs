using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class UC7
    {
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING = 100, START = 0;
        public int count = 0,Play = 2, i = 0, Player1 = 0, Player2 = 0;


        Random random = new Random();
        public int DieRolling()
        {
            int roll = random.Next(1, 7);
            return roll;
        }
        Random random1 = new Random();
        public int DieRolling1()
        {
            int roll = random1.Next(1, 7);
            return roll;
        }

        public void PlayerCheck()
        {
 
            while (Player1 <= WINNING && Player2 <= WINNING)
            {
                    
                int dieRoll1 = DieRolling();
                int option1 = random.Next(0, 3);
                int dieRoll2 = DieRolling();
                int option2 = random1.Next(0, 3);
                switch (option1)
                {
                   case NO_PLAY:
                   break;
                   case LADDER:
                        Player1 += dieRoll1;
                        Player2 += dieRoll2;
                        if (Player1 > WINNING && Player2 > WINNING)
                        {
                          Player1 -= dieRoll1;
                          Player2 -= dieRoll2;
                        }
                   Console.WriteLine("Got Ladder");
                   break;
                   case SNAKE:
                        Player1 -= dieRoll1;
                        Player2 -= dieRoll2;
                        if (Player1 < START && Player2 < START)
                        {
                          Player1 = START;
                          Player2 = START;
                        }
                   Console.WriteLine("Got Snake");
                   break;
                                                        
                }
                    count++;
                Console.WriteLine("The Player1 Position is :" + Player1 + " " + "with a roll of " + dieRoll1);
                Console.WriteLine("The Player2 Position is :" + Player2 + " " + "with a roll of " + dieRoll2);
            }
                Console.WriteLine("The number of times dice was rolled to win the Game is : " + count);
                Console.WriteLine("The Player wins the Game");
                        
        }
    }
}
