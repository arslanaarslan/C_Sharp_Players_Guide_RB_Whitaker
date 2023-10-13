using System;

namespace The_Dominion_of_Kings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of estate: ");
            int estate = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of duchy: ");
            int duchy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of province: ");
            int province = Convert.ToInt32(Console.ReadLine());

            int total = estate + duchy * 3 + province * 6;

            Console.WriteLine("Total Point: " + total);
        }
    }
}
