using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class TwoPlayers
    {
        public static void SnakeladderGame()
        {
            Console.WriteLine("Snake and Ladder game played with single player at start position 0");
            int player1 = 0;
            int player2 = 0;
            int numberOfTimesDiceRolled = 0;

            Console.WriteLine("Welcome Player 1, Let's start the Game");
            Console.WriteLine("Player 1 is at position : " + player1);

            Console.WriteLine("Welcome Player 2, Let's start the Game");
            Console.WriteLine("Player 2 is at position : " + player2);

            Random random = new Random();

            while (player1 != 100 && player2 != 100)
            {
                int temp1 = player1;
                int temp2 = player2;

                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                numberOfTimesDiceRolled++;

                Console.WriteLine($"The Player1 rolls a dice and gets: {dice1}");
                Console.WriteLine($"The Player2 rolls a dice and gets: {dice2}");
                Console.WriteLine($"Number of Times Dice rolled is: {numberOfTimesDiceRolled}");

                int option = random.Next(0, 3);

                if (option == 0)
                {
                    Console.WriteLine("Player stays at same player");
                }
                else if (option == 1)
                {
                    Console.WriteLine("Player1 Moves Ahead by {0} from ladder", dice1);
                    Console.WriteLine("Player2 Moves Ahead by {0} from ladder", dice2);
                    player1 += dice1;
                    player2 += dice2;
                }
                else
                {
                    Console.WriteLine("Player1 Moves Behind by {0} from Snake", dice1);
                    Console.WriteLine("Player2 Moves Behind by {0} from Snake", dice2);
                    player1 -= dice1;
                    player2 -= dice2;
                }

                if (player1 < 0)
                {
                    player1 = 0;
                }
                if (player2 < 0)
                {
                    player2 = 0;
                }

                if (player1 > 100)
                {
                    player1 -= dice1;
                }
                if (player2 > 100)
                {
                    player2 -= dice2;
                }

                Console.WriteLine("Player1 Current position is at : {0}", player1);
                Console.WriteLine("Player2 Current position is at : {0}", player2);

            }
            Console.WriteLine("Player1 is at position : {0}", player1);
            Console.WriteLine("Player2 is at position : {0}", player2);


            if (player1 == 100)
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if (player2 == 100)
            {
                Console.WriteLine("Player 2 Wins");
            }
            else
            {
                Console.WriteLine("It's a tie");
            }

            Console.WriteLine($"Total Number of Times Dice rolled is: {numberOfTimesDiceRolled}");



        }
    }
}
