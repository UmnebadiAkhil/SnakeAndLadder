using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class UC2_PlayerRolls
    {
            public int playerPosition = 0;
            Random random = new Random();
            public int DieRoll()
            {
                int roll = random.Next(1, 7);
                return roll;
            }
    }
}