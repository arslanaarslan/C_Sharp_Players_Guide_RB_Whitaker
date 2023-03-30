using System;

namespace Discounted_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine().ToLower();

            int discount = 0;

            if (name == "arslan")
            {
                discount = 50;
            }
            Console.WriteLine("The following items are available:");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.Write("What number do you want to see the price of? ");
            int selection = Convert.ToInt32(Console.ReadLine());

            /*
            switch (selection)
            {
                case 1:
                    Console.WriteLine("Rope cost 10 gold.");
                    break;
                case 2:
                    Console.WriteLine("Torches cost 15 gold.");
                    break;
                case 3:
                    Console.WriteLine("Climbing Equipment cost 25 gold.");
                    break;
                case 4:
                    Console.WriteLine("Clean Water cost 1 gold.");
                    break;
                case 5:
                    Console.WriteLine("Machete cost 20 gold.");
                    break;
                case 6:
                    Console.WriteLine("Canoe cost 200 gold.");
                    break;
                case 7:
                    Console.WriteLine("Food Supplies cost 1 gold.");
                    break;
                default:
                    Console.WriteLine("Invalid Item Number");
                    break;
            }
            */

            string response = selection switch
            {
                1 => $"Rope cost {(10 - (10 * (float)discount / 100)): ##.#} gold.",
                2 => $"Torches cost {(15 - (15 * (float)discount / 100)): ##.#} gold.",
                3 => $"Climbing Equipment cost {(25 - (25 * (float)discount / 100)): ##.#} gold.",
                4 => $"Clean Water cost {(1 - (1 * (float)discount / 100)): ##.#} gold.",
                5 => $"Machete cost {(20 - (float)(20 * (float)discount / 100)): ##.#} gold.",
                6 => $"Canoe cost {(200 - (200 * (float)discount / 100)): ##.#} gold.",
                7 => $"Food Supplies cost {(1 - (1 * (float)discount / 100)): #.#} gold.",
                _ => $"Invalid Item Number"
            };

            Console.WriteLine(response);

        }
    }
}
