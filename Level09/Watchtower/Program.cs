using System;

namespace Watchtower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter enemy x coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter enemy y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool isEast = x > 0 ? true : false;
            bool isWest = x < 0 ? true : false;
            bool isXOrigin = x == 0 ? true : false;
            bool isNorth = y > 0 ? true : false;
            bool isSouth = y < 0 ? true : false;
            bool isYOrigin = y == 0 ? true : false;

            if (isXOrigin && isYOrigin)
            {
                Console.WriteLine("The enemy is here");
            }
            else if (isXOrigin && !isYOrigin)
            {
                if (isNorth)
                {
                    Console.WriteLine("The enemy is to the north");
                }
                else
                {
                    Console.WriteLine("The enemhy is to the south");
                }
            }
            else if (!isXOrigin && isYOrigin)
            {
                if (isWest)
                {
                    Console.WriteLine("The enemy is to the west");
                }
                else
                {
                    Console.WriteLine("The enemy is to the east");
                }
            }
            else if (isEast && isNorth)
            {
                Console.WriteLine("The enemy is to the northeast");
            }
            else if (isEast && isSouth)
            {
                Console.WriteLine("The enemy is to the southeash");
            }
            else if (isWest && isNorth)
            {
                Console.WriteLine("The enemy is to the northwest");
            }
            else if (isWest && isSouth)
            {
                Console.WriteLine("The enemy is to the southwest");
            }
        }
    }
}
