// See https://aka.ms/new-console-template for more information

using War_Preparations;

Sword basicSword = new Sword(Material.Iron, Gemstone.None, 5, 2);
Sword steelLongSword = basicSword with {Material = Material.Steel, Length = 10};
Sword steelSwordWithDiamond = steelLongSword with {Gemstone = Gemstone.Diamond};

Console.WriteLine(basicSword);
Console.WriteLine(steelLongSword);
Console.WriteLine(steelSwordWithDiamond);
