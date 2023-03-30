using System;

namespace The_Replicator_of_D_To
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i+1}. Number: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] copyOfArray = new int[5];

            for (int i = 0; i < copyOfArray.Length; i++)
            {
                copyOfArray[i] = array[i];
            }

            Console.WriteLine($"Original Array: {string.Join(",", array)}");
            Console.WriteLine($"Copy of Array: {string.Join(",", copyOfArray)}");
        }
    }
}
