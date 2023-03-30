using System;

namespace Arrow_Factories
{

    class Program
    {
        static void Main(string[] args)
        {
            Arrow newArrow;

            Console.WriteLine("Please Choose Predefined Arrows, If you want to design your custom arrow type 4 \n");
            Console.Write("1. The Elite Arrow\n2. The Beginner Arrow\n3. The Marksman Arrow\n4. The Custom Arrow\n>");
            int arrowTypeSelection = Convert.ToInt32(Console.ReadLine());
            if (arrowTypeSelection == 1)
            {
                newArrow = Arrow.CreateEliteArrow();
                Console.WriteLine(newArrow.Length);
                newArrow.GetCost();
            } else if (arrowTypeSelection == 2)
            {
                newArrow = Arrow.CreateBeginnerArrow();
                Console.WriteLine(newArrow.Length);
                newArrow.GetCost();
            } else if (arrowTypeSelection == 3)
            {
                newArrow = Arrow.CreateMarksmanArrow();
                Console.WriteLine(newArrow.Length);
                newArrow.GetCost();
            } else
            {
                Console.Write("Please Choose an Arrow Head Material,\n1. Steel\n2. Wood\n3. Obsidian\n>");
                int arrowHeadSelection = Convert.ToInt32(Console.ReadLine());
                Console.Write("Plese Choose a Fletching Material,\n1. Plactic\n2. Turkey Feather\n3. Goose Feather\n>");
                int fletchingSelection = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please write how long it is: ");
                float length = Convert.ToSingle(Console.ReadLine());

                newArrow = new Arrow(arrowHeadSelection, fletchingSelection, length);

                Console.WriteLine(newArrow.Length);

                newArrow.GetCost();
            }

        }
    }

    class Arrow
    {
        private ArrowHead arrowHead;

        public ArrowHead ArrowHead { get => arrowHead; set => arrowHead = value; }

        private Fletching fletching;

        public Fletching Fletching { get => fletching; set => fletching = value; }

        private float length;

        public float Length { get => length; set => length = value; }

        private float totalCost;

        public float TotalCost { get => totalCost; }
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

        public static Arrow CreateEliteArrow()
        {
            return new Arrow(1, 1, 95);
        }

        public static Arrow CreateBeginnerArrow()
        {
            return new Arrow(2, 3, 75);
        }

        public static Arrow CreateMarksmanArrow()
        {
            return new Arrow(1, 3, 65);
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
