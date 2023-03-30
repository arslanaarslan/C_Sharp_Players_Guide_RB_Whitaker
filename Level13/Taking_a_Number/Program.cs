using System;

namespace Taking_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Question 1");
            Console.WriteLine("-------------------------------------------------------------");
            int weight = AskForNumber("What is your weight?");
            Console.WriteLine($"Your weight is {weight} kg");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Question 2");
            Console.WriteLine("-------------------------------------------------------------");
            int height = AskForNumberInRange("What is your height?", 0, 300);

            Console.WriteLine($"Your height is {height} m");
            Console.WriteLine("-------------------------------------------------------------");
        }

        static int AskForNumber(string text)
        {
            Console.WriteLine(text);

            return Convert.ToInt32(Console.ReadLine());
        }

        static int AskForNumberInRange(string text, int min, int max)
        {
            int value;   

            do
            {
                Console.WriteLine(text);
                
                value = Convert.ToInt32(Console.ReadLine());
            }
            while (value < min || value > max);

            return value;
            
        }
    }
}
