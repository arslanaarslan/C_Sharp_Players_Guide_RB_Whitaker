using System;

namespace Boss_Battle_The_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(2, 3);
            Point point2 = new Point(-4, 0);

            Console.WriteLine($"({point1.X}, {point1.Y})");
            Console.WriteLine($"({point2.X}, {point2.Y})");
        }
    }
}
