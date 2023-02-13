using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class RollDice
    {
        public static void RollDiceplayer()
        {
            Random random = new Random();
            int player = random.Next(1, 7);
            Console.WriteLine("Player Roll the Dice : " + player);
        }
    }
}
