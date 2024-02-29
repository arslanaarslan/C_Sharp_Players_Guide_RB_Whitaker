using System.ComponentModel;

namespace The_Fountain_of_Objects;

public class Hero
{
    private int _x;

    public int X
    {
        get => _x; 
        set => _x = value;
    }

    private int _y;

    public int Y
    {
        get => _y; 
        set => _y = value;
    }

    private int _mapSize;


    public Hero(int x, int y, int mapSize)
    {
        X = x;
        Y = y;
        _mapSize = mapSize;
    }

    public void MoveCommand(String command)
    {
        String loweredCommand = command.ToLower();
        
        switch (loweredCommand)
        {
            case "move east":
                MoveEast();
                break;
            case "move west":
                MoveWest();
                break;
            case "move north":
                MoveNorth();
                break;
            case "move south":
                MoveSouth();
                break;
            default:
                Console.WriteLine("Invalid Command!");
                break;
        }
    }

    public void MoveEast()
    {
        if (X < _mapSize - 1)
        {
            X++;
        }
    }

    public void MoveWest()
    {
        if (X > 0)
        {
            X--;
        }
    }

    public void MoveNorth()
    {
        if (Y > 0)
        {
            Y--;
        }
    }

    public void MoveSouth()
    {
        if (Y < _mapSize - 1)
        {
            Y++;
        }
    }
}