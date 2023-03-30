using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory
{
    internal class Pack
    {
        List<InventoryItem> items = new List<InventoryItem>();
        int _totalNumberOfItems;
        double _maximumWeigth;
        double _maximumVolume;

        public Pack(int totalNumberOfItems, double maximumWeight, double maximumVolume)
        {
            _totalNumberOfItems = totalNumberOfItems;
            _maximumWeigth = maximumWeight;
            _maximumVolume = maximumVolume;
            Console.WriteLine(_totalNumberOfItems + " " + _maximumWeigth + " " + _maximumVolume + " pack created.");
        }

        public bool Add(InventoryItem item)
        {

            // Console.WriteLine($"Items Count: {items.Count()} + allowed Items Number: {_totalNumberOfItems}");
            // Console.WriteLine($"Weight: {PackWeight() + item.Weight} + allowed Maximum Weight: {_maximumWeigth}");
            // Console.WriteLine($"Volume: {PackVolume() + item.Volume} + allowed Maximum Volume: {_maximumVolume}");
            bool addable = (items.Count() < _totalNumberOfItems) && ((PackWeight() + item.Weight) < _maximumWeigth) && ((PackVolume() + item.Volume) < _maximumVolume);

            // Console.WriteLine("This product is " + (addable ? "" : "not ") + "addable");

            if (addable)
            {
                items.Add(item);

                Console.WriteLine(item.Name + " " + item.Weight + " " + item.Volume + " added.");

                return true;
            }

            Console.WriteLine(item.Name + " " + item.Weight + " " + item.Volume + " could not add.");

            return false;
        }

        public double PackWeight()
        {
            double totalWeight = 0;

            foreach (InventoryItem item in items)
            {
                if (item == null)
                {
                    continue;
                }

                totalWeight = totalWeight + item.Weight;
            }

            return totalWeight;
        }

        public double PackVolume()
        {
            double totalVolume = 0;

            foreach (InventoryItem item in items)
            {
                if (item == null)
                {
                    continue;
                }

                totalVolume = totalVolume + item.Volume;
            }

            return totalVolume;
        }

        public void Report()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Pack details:");

            int index = 0;

            foreach (InventoryItem item in items)
            {
                index++;
                if (item == null)
                {
                    continue;
                }

                Console.WriteLine($"{index}. item is {item.Name}");
            }

            Console.WriteLine("---------------------------------------------");
        }

        public override string ToString()
        {
            string result = "";

            result += "Pack containing ";

            foreach (InventoryItem item in items)
            {
                result += item.ToString() + " ";
            }

            return result;
        }
    }
}
