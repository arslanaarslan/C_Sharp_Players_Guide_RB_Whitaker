using System;

namespace TheThingNamer3000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of thing are we talking about?");
            // a is thing that we talking about.
            string a = Console.ReadLine();
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            // b is properties of thing
            string b = Console.ReadLine();
            // c is a "Doom" string
            string c = "Doom";
            // d is a "3000" string
            string d = "3000";
            Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
            Console.ReadLine();
        }
    }
}
