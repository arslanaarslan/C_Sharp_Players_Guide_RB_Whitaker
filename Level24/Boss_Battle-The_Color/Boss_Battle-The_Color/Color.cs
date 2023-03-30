using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_Battle_The_Color
{
    internal class Color
    {
        public int _redChannelValue;
        public int RedChannelValue
        {
            get { return _redChannelValue; }

            set
            {
                if (value < 0)
                {
                    _redChannelValue = 0;
                } else if (value > 255)
                {
                    _redChannelValue = 255;
                } else
                {
                    _redChannelValue = value;
                }
            }
        }

        public int _greenChannelValue;
        public int GreenChannelValue {
            get { return _greenChannelValue; }
            set 
            {
                if (value < 0)
                {
                    _greenChannelValue = 0;
                }
                else if (value > 255)
                {
                    _greenChannelValue = 255;
                }
                else
                {
                    _greenChannelValue = value;
                }
            }
        }

        public int _blueChannelValue;
        public int BlueChannelValue
        {
            get { return _blueChannelValue; }
            set
            {
                if (value < 0)
                {
                    _blueChannelValue = 0;
                }
                else if (value > 255)
                {
                    _blueChannelValue = 255;
                }
                else
                {
                    _blueChannelValue = value;
                }
            }
        }

        public static Color White { get; } = new Color(255, 255, 255);
        public static Color Black { get; } = new Color(0, 0, 0);
        public static Color Red { get; } = new Color(255, 0, 0);
        public static Color Orange { get; } = new Color(255, 165, 0);
        public static Color Yellow { get; } = new Color(255, 255, 0);
        public static Color Green { get; } = new Color(0, 128, 0);
        public static Color Blue { get; } = new Color(0, 0, 255);
        public static Color Purple { get; } = new Color(128, 0, 128);


        public Color()
        {
            RedChannelValue = 0;
            GreenChannelValue = 0;
            BlueChannelValue = 0;
        }

        public Color(int redChannelValue, int greenChannelValue, int blueChannelValue)
        {
            RedChannelValue = redChannelValue;
            GreenChannelValue = greenChannelValue;
            BlueChannelValue = blueChannelValue;
        }
    }
}
