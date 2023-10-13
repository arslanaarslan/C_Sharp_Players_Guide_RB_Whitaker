using System;

namespace Repairing_the_Clocktower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isEven = number % 2 == 0 ? true : false;

            string result = isEven ? "Tick" : "Tock";

            Console.WriteLine(result);
        }
    }
}
