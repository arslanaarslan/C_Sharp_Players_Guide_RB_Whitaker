using System;

namespace Countdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown(10);
        }

        static void Countdown(int number)
        {
            Console.WriteLine(number);

            if (number > 1)
                Countdown(number - 1);
        }
    }
}
