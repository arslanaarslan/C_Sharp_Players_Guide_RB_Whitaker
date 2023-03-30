// See https://aka.ms/new-console-template for more information
using Packing_Inventory;
using Packing_Inventory.Items;

Arrow arrow = new("Arrow", 0.1, 0.05);
Console.WriteLine(arrow.Name + " " + arrow.Weight + " " + arrow.Volume);
Bow bow = new("Bow", 1, 4);
Rope rope = new("Rope", 1, 1.5);
Water water = new("Water", 2, 3);
Food food = new("Food", 1, 0.5);
Sword sword = new("Sword", 5, 3);

Pack pack = new(3, 4, 5);

pack.Add(water);
pack.Report();
pack.Add(food);
pack.Report();
pack.Add(sword);
pack.Report();

Console.ReadKey();