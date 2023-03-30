using System;

namespace SomeBrokenSampleCodeForDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine()); 
            double clampedNumber = Clamp(number, 0, 10);
            Console.WriteLine($"Clamped: {clampedNumber}");

            double Clamp(double value, double min, double max) // Also see Math.Clamp.
            {
                if (value < min) return min;
                if (value > max) return max; 
                return value;
            }
        }
    }
}
