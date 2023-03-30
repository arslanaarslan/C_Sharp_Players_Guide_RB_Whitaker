using System;

namespace Simula_s_Test
{
    class Program
    {
        static ChestState chestState = ChestState.Locked;

        static void Main(string[] args)
        {
            
            while (true)
            {
                ChestStateReporter();

                ChestController();
            }
               
        }

        enum ChestState { Open, Closed, Locked }

        static void ChestStateReporter()
        {
            if (chestState == ChestState.Locked)
            {
                Console.Write("The chest is locked. What do you want to do? ");
            } 
            else if (chestState == ChestState.Closed)
            {
                Console.Write("The chest is unlocked. What do you want to do? ");
            }
            else
            {
                Console.Write("The chest is open. What do you want to do? ");
            }
        }

        static void ChestController()
        {
            string command;

            command = Console.ReadLine().ToLower();

            if (chestState == ChestState.Locked && command == "unlock")
            {
                chestState = ChestState.Closed;
            }

            if (chestState == ChestState.Closed && command == "open")
            {
                chestState = ChestState.Open;
            }

            if (chestState == ChestState.Open && command == "close")
            {
                chestState = ChestState.Closed;
            }

            if (chestState == ChestState.Closed && command == "lock")
            {
                chestState = ChestState.Locked;
            }
        }
    }
}
