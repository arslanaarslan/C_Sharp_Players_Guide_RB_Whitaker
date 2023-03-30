using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_Battle_Rock_Paper_Scissors
{
    internal class Player
    {
        Random random = new Random();

        int _randomNumber;

        int _numberOfWins;

        public int NumberOfWins 
        {
            get { return _numberOfWins; }
            set { _numberOfWins = value; } 
        }

        int _numberOfLosts;

        public int NumberOfLosts
        {
            get { return _numberOfLosts; }
            set { _numberOfLosts = value; }
        }

        int _numberOfDraw;

        public int NumberOfDraws
        {
            get { return _numberOfDraw; }
            set { _numberOfDraw = value; }
        }

        Selection _selection;

        public Selection Selection 
        { 
            get { return _selection;  }
            set { _selection = value; } 
        }

        public Player()
        {

            _randomNumber = 0;

        }

        public void Select()
        {
            _randomNumber = random.Next(3);

            _selection = (Selection)_randomNumber;

        }


    }

    enum Selection
    {
        Rock, Paper, Scissors
    }
}
