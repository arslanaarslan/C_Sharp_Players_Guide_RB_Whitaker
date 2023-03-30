using System;

namespace The_Laws_of_Freach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentMinimum = int.MaxValue; // Start higher than anything in the array. 
 /*           for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < currentMinimum)
                    currentMinimum = array[index];
            }*/
            foreach (int value in array)
            {
                if (value < currentMinimum)
                    currentMinimum = value;
            }
            Console.WriteLine(currentMinimum);

            int[] array2 = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int total = 0;
            /*            for (int index = 0; index < array2.Length; index++)
                            total += array2[index];*/
            foreach (int value in array2)
                total += value;
            float average = (float)total / array2.Length;
            Console.WriteLine(average);
        }
    }
}
