using System;

namespace Boss_Battle_The_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card[,] cards = new Card[4, 14];

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 13; j++)
                {
                    cards[i, j] = new Card((CardColors)i, (CardRanks)j);
                    cards[i, j].Print();
                }
            }
        }
    }

    enum CardColors
    {
        Red, Green, Blue, Yellow
    }

    enum CardRanks
    {
        One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand
    }
}
