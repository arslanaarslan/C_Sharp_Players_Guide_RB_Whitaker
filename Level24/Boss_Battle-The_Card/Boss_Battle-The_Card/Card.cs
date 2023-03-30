using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_Battle_The_Card
{
    internal class Card
    {
        CardColors _cardColor;
        CardRanks _cardRank;

        public CardColors CardColor {
            get { return _cardColor; } 
            set { _cardColor = value; }
        }

        public CardRanks CardRank { 
            get { return _cardRank; }
            set { _cardRank = value; } 
        }

        public Card (CardColors cardColor, CardRanks cardRank)
        {
            CardColor = cardColor;
            CardRank = cardRank;
        }

        public static bool IsItNumber (CardRanks cardRank)
        {
            if (cardRank > CardRanks.Ten)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public void Print()
        {
            Console.WriteLine($"The {CardColor.ToString()} {UppercaseFirst(CardRank.ToString())}");
        }

        public static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }


}
