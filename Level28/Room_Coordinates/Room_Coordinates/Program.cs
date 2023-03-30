// See https://aka.ms/new-console-template for more information

using Room_Coordinates;

Coordinate coordinate1 = new Coordinate(1, 1);
Coordinate coordinate2 = new Coordinate(1, 3);
Coordinate coordinate3 = new Coordinate(1, 2);

Console.WriteLine(coordinate1.IsItAdjacentByOtherCoordinate(coordinate2));
Console.WriteLine(coordinate2.IsItAdjacentByOtherCoordinate(coordinate3));