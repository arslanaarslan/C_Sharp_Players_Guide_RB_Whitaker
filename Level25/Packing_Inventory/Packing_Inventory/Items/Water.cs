using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory.Items
{
    internal class Water : InventoryItem
    {
        public Water(string name, double weight, double volume) : base(name, weight, volume)
        {

        }
    }
}
