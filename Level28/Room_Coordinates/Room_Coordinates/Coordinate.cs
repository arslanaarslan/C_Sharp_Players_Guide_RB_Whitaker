namespace Room_Coordinates;

public struct Coordinate
{
    public int X { get;  }
    public int Y { get;  }

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool IsItAdjacentByOtherCoordinate(Coordinate OtherCoordinate)
    {
        if (X == OtherCoordinate.X)
        {
            if (Math.Abs(Y - OtherCoordinate.Y) == 1)
            {
                return true;
            }
        } else if (Y == OtherCoordinate.Y)
        {
            if (Math.Abs(X - OtherCoordinate.X) == 1)
            {
                return true;
            }
        }

        return false;
        
    }
}