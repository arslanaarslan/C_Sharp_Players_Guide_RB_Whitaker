using System;

namespace Boss_Battle_The_Color
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------");
            Color myColor = new Color(275, -1, 147);
            Console.WriteLine("My Color Values:");
            Console.WriteLine(myColor.RedChannelValue);
            Console.WriteLine(myColor.GreenChannelValue);
            Console.WriteLine(myColor.BlueChannelValue);
            Console.WriteLine("----------------------------------------------");
            Color purpleColor = Color.Purple;
            Console.WriteLine("Purple Color Values:");
            Console.WriteLine(purpleColor.RedChannelValue);
            Console.WriteLine(purpleColor.GreenChannelValue);
            Console.WriteLine(purpleColor.BlueChannelValue);
            Console.WriteLine("----------------------------------------------");
        }
    }
}
