using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class PlayerPosition

    {
        public static void Gameplayer()
        {
            Console.WriteLine("Snake and Ladder game played with single player at start position 0");
            int position = 0;
            int count = 0;
            int lastPosition = 100;
            Random random = new Random();
            Random random1 = new Random();
            for (int i = 0; i < lastPosition; i++)
            {
                while (count <= lastPosition)
                {
                    int result = random.Next(0, 3);
                    int Dice = random1.Next(1, 7);
                    if (position == 0)
                    {
                        if (result == 0)
                        {
                            Console.WriteLine("Snake");
                            Console.WriteLine(" Player moves behind by the number of position received in the dice");
                            position = position - Dice;
                            Console.WriteLine("position moves back : " + position);
                        }
                        else if (result == 1)
                        {
                            Console.WriteLine("Ladder");
                            Console.WriteLine(" Player moves ahead by the number of position received in the die");
                            position = position + Dice;
                            Console.WriteLine("position moves ahead : " + position);
                        }
                        else
                        {
                            Console.WriteLine("No Play");
                            Console.WriteLine("Player Will Stay in the same position");
                        }
                    }
                }
                count++;
            }
        }
    }
}
