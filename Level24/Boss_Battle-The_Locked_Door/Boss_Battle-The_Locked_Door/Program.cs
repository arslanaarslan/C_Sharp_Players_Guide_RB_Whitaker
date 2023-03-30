using System;

namespace Boss_Battle_The_Locked_Door
{
    internal class Program
    {
        static String[] commands = { "Open", "Close", "Lock", "Unlock", "Change Passcode", "Exit" };

        static void Main(string[] args)
        {
            Console.Write("Hello Door Creator, please enter a password for create a new door: ");
            int passcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Door door = new Door(passcode);

            String doorState;
            String command;

            

            while (true)
            {
                doorState = door.getDoorState().ToLower();

                Console.WriteLine("--------------------------");
                Console.WriteLine("Door State is: " + doorState);
                Console.WriteLine("--------------------------");

                Console.Write("What do you want to do?\n 1. Open \n 2. Close \n 3. Lock \n 4. Unlock \n 5. Change Passcode \n 6. Exit \n Please write your command: ");

                command = Console.ReadLine().ToLower();

                Console.WriteLine();

                if (command == "open" && doorState == "closed")
                {
                    Console.WriteLine("Door is openning...");
                    door.Open();
                }
                else if (command == "close" && doorState == "open")
                {
                    Console.WriteLine("Door is closing...");
                    door.Close();
                }
                else if (command == "lock" && doorState == "closed")
                {
                    Console.WriteLine("Door is locking...");
                    door.Lock();
                }
                else if (command == "unlock" && doorState == "locked")
                {
                    Console.WriteLine("Door is unlocking...");
                    door.Unlock();
                }
                else if (command == "change" || command == "change passcode")
                {
                    door.changePasscode();
                }
                else if (command == "exit")
                {
                    break;
                } else
                {
                    if (IsValidCommand(command))
                    {
                        Console.WriteLine("Please check your door state and enter new command.");
                    } else
                    {
                        Console.WriteLine("Wrong command.");
                    }
                }
            }
        }

        static bool IsValidCommand(String takenCommand)
        {
            foreach (String command in commands)
            {
                if (takenCommand == command.ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
