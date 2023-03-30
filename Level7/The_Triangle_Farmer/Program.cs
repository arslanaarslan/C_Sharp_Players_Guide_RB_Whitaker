using System;

namespace The_Triangle_Farmer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length of Base: ");
            int lengthOfBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lenght of Height: ");
            int lengthOfHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result is {lengthOfHeight * lengthOfBase / 2}");
        }
    }
}
