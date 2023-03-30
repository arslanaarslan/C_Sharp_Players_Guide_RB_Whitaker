using System;

namespace Vin_s_Trouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Choose an Arrow Head Material,\n1. Steel\n2. Wood\n3. Obsidian\n>");
            int arrowHeadSelection = Convert.ToInt32(Console.ReadLine());
            Console.Write("Plese Choose a Fletching Material,\n1. Plactic\n2. Turkey Feather\n3. Goose Feather\n>");
            int fletchingSelection = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please write how long it is: ");
            float length = Convert.ToSingle(Console.ReadLine());

            Arrow newArrow = new Arrow(arrowHeadSelection, fletchingSelection, length);

            newArrow.GetCost();
        }
    }

    class Arrow
    {
        private ArrowHead arrowHead;

        public ArrowHead GetArrowHead()
        {
            return arrowHead;
        }

        private Fletching fletching;

        public Fletching GetFletching()
        {
            return fletching;
        }

        private float length;

        public float GetLength()
        {
            return length;
        }

        private float totalCost;
        
        public float GetTotalCost()
        {
            return totalCost;
        }

        public Arrow(int selectedArrowHeadNumber, int selectedFletchingNumber, float length)
        {
            if (selectedArrowHeadNumber == 1)
            {
                arrowHead = ArrowHead.Steel;
            }
            else if (selectedArrowHeadNumber == 2)
            {
                arrowHead = ArrowHead.Wood;
            }
            else if (selectedArrowHeadNumber == 3)
            {
                arrowHead = ArrowHead.Obsidian;
            }

            if (selectedFletchingNumber == 1)
            {
                fletching = Fletching.Plastic;
            }
            else if (selectedFletchingNumber == 2)
            {
                fletching = Fletching.Turkey;
            }
            else if (selectedFletchingNumber == 3)
            {
                fletching = Fletching.Goose;
            }

            this.length = length;
        }

        public void GetCost()
        {
            totalCost = ((float)arrowHead) + ((float)fletching) + (float)(length * 0.05);

            Console.WriteLine($"Arrow costed: {totalCost} gold.");
        }
    }

    enum ArrowHead { Steel = 10, Wood = 3, Obsidian = 5 }
    enum Fletching { Plastic = 10, Turkey = 5, Goose = 3 }
}
