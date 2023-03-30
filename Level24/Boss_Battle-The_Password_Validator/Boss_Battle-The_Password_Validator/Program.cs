using System;

namespace Boss_Battle_The_Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String password; 

            while (true)
            {
                Console.Write("Enter a password: ");
                password = Console.ReadLine();

                if (new PasswordValidator(password).IsValid())
                {
                    Console.WriteLine("Password is valid.");
                } else
                {
                    Console.WriteLine("Password is not valid.");
                }
            }
        }
    }
}
