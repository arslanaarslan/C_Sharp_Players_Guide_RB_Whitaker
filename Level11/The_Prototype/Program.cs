using System;

namespace The_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int number;

            do
            {
                Console.Write("User 1, enter a number between 0 and 100: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            while (number < 0 || number > 100);

            Console.Clear();

            Console.WriteLine("User 2, guess the number.");

            int predictedNumber;

            do
            {
                Console.Write("What is your next guess? ");
                predictedNumber = Convert.ToInt32(Console.ReadLine());
                if (predictedNumber < number)
                {
                    Console.WriteLine($"{predictedNumber} is too low.");
                }

                if (predictedNumber > number)
                {
                    Console.WriteLine($"{predictedNumber} is too high.");
                }
            }
            while (predictedNumber != number);

            Console.WriteLine("You guessed the number!");
        }
    }
}
