using System;

namespace The_Defense_of_Consolas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Target Row? ");
            int rowNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Target Column? ");
            int columnNumber = Convert.ToInt32(Console.ReadLine());
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Deploy to:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"({rowNumber}, {columnNumber - 1})");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"({rowNumber - 1}, {columnNumber})");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"({rowNumber}, {columnNumber + 1})");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"({rowNumber + 1}, {columnNumber})");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Beep();
        }
    }
}
