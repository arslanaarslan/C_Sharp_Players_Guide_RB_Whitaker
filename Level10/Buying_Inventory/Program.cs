﻿using System;

namespace Buying_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
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
                1 => "Rope cost 10 gold.",
                2 => "Torches cost 15 gold.",
                3 => "Climbing Equipment cost 25 gold.",
                4 => "Clean Water cost 1 gold.",
                5 => "Machete cost 20 gold.",
                6 => "Canoe cost 200 gold.",
                7 => "Food Supplies cost 1 gold.",
                _ => "Invalid Item Number"
            };

            Console.WriteLine(response);

        }
    }
}
