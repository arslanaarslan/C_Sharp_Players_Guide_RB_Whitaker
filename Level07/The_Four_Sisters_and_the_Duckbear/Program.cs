using System;

namespace The_Four_Sisters_and_the_Duckbear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of eggs: ");
            int numberOfEggs = Convert.ToInt32(Console.ReadLine());
            int numberOfDuckbearsEggs = numberOfEggs % 4;
            int numberOfSistersEggs = (numberOfEggs - numberOfDuckbearsEggs) / 4;

            Console.WriteLine("Number of Sisters Eggs: " + numberOfSistersEggs);
            Console.WriteLine("Number of Duckbears Eggs: " + numberOfDuckbearsEggs);
        }
    }
}
