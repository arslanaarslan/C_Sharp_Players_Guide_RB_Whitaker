using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory
{
    internal class InventoryItem
    {
        string _name;
        public string Name 
        { 
            get
            {
                return _name;
            } 
            
            set
            {
                _name = value;
            }
        }

        double _weight;
        public double Weight 
        { 
            get
            {
                return _weight;
            } 
            
            set
            {
                _weight = value;
            }
        }

        double _volume;

        public double Volume 
        { 
            get
            {
                return _volume;
            }

            set
            {
                _volume = value;
            }
        }

        public InventoryItem (string name, double weight, double volume)
        {
            _name = name;
            _weight = weight;
            _volume = volume;
        }

        public InventoryItem () : this("", 0, 0)
        {
        }
    }
}
