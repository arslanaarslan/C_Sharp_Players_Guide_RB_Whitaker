using System;

namespace Consolas_and_Telim_Page_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is the bread for?");
            name = Console.ReadLine();
            Console.WriteLine("Noted: " + name + " got bread.");
        }
    }
}
