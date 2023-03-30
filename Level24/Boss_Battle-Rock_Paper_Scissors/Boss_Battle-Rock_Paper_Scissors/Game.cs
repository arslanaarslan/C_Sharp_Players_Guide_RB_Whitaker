using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_Battle_Rock_Paper_Scissors
{
    internal class Game
    {

        Player player1;
        Player player2;

        public Game()
        {
            player1 = new Player();
            
            player2 = new Player();
            
        }
        

        public void Start()
        {
            while(true)
            {
                player1.Select();
                Console.WriteLine("Player 1 Selection: " + player1.Selection);
                player2.Select();
                Console.WriteLine("Player 2 Selection: " + player2.Selection);
                if (player1.Selection == player2.Selection)
                {
                    Console.WriteLine("Draws");
                    player1.NumberOfDraws++;
                    player2.NumberOfDraws++;
                }
                else if (player1.Selection == Selection.Rock)
                {
                    if (player2.Selection == Selection.Paper)
                    {
                        Console.WriteLine("Player 2 Wins");
                        player1.NumberOfLosts++;
                        player2.NumberOfWins++;
                    }
                    else if (player2.Selection == Selection.Scissors)
                    {
                        Console.WriteLine("Player 1 Wins");
                        player1.NumberOfWins++;
                        player2.NumberOfLosts++;
                    }
                }
                else if (player1.Selection == Selection.Paper)
                {
                    if (player2.Selection == Selection.Scissors)
                    {
                        Console.WriteLine("Player 2 Wins");
                        player1.NumberOfLosts++;
                        player2.NumberOfWins++;
                    }
                    else if (player2.Selection == Selection.Rock)
                    {
                        Console.WriteLine("Player 1 Wins");
                        player1.NumberOfWins++;
                        player2.NumberOfLosts++;
                    }
                }
                else if (player1.Selection == Selection.Scissors)
                {
                    if (player2.Selection == Selection.Rock)
                    {
                        Console.WriteLine("Player 2 Wins");
                        player1.NumberOfLosts++;
                        player2.NumberOfWins++;
                    }
                    else if (player2.Selection == Selection.Paper)
                    {
                        Console.WriteLine("Player 1 Wins");
                        player1.NumberOfWins++;
                        player2.NumberOfLosts++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("\tWins\tLosts\tDraws");
                Console.WriteLine("P1\t" + player1.NumberOfWins + "\t" + player1.NumberOfLosts + "\t" + player1.NumberOfDraws);
                Console.WriteLine("P2\t" + player2.NumberOfWins + "\t" + player2.NumberOfLosts + "\t" + player2.NumberOfDraws);
                Console.WriteLine("-------------------------------------");

                Console.ReadKey();

            }
        }
    }
}
