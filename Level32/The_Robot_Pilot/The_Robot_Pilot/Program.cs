using System;

namespace Hunting_the_Manticore
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore? ");
            int manticorePlace = random.Next(100) + 1;
            Console.WriteLine("Player 1 selected manticore place.");
            Thread.Sleep(2000);

            Console.Clear();            

            Console.WriteLine("Player 2, it is your turn.");

            int cityHealth = 15;
            int manticoreHealth = 10;
            int round = 1;
            int damagePoint = 0;
            int desiredCannonRange = 0;

            while (cityHealth > 0 && manticoreHealth > 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-----------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");

                damagePoint = calculateDamage(round);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"The cannon is expected to deal {damagePoint} damage this round.");

                Console.Write("Enter desired cannon range: ");
                desiredCannonRange = Convert.ToInt32(Console.ReadLine());

                if (desiredCannonRange > manticorePlace)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That round OVERSHOT the target.");
                } else if (desiredCannonRange < manticorePlace)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("That round FELL SHORT of the target.");
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That round was a DIRECT HIT!");
                    manticoreHealth -= damagePoint;
                }

                cityHealth -= 1;

                round += 1;
            }

            if (cityHealth == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The City has been destroyed!");
            } else if (manticoreHealth == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
            }


        }

        public static int calculateDamage (int roundNumber)
        {
            if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
            {
                return 10;
            }
            else if (roundNumber % 3 == 0 || roundNumber % 5 == 0)
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }
    }
}
