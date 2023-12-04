using The_Fountain_of_Objects.Room;

namespace The_Fountain_of_Objects;

public class Map
{
    public Random random = new Random();
    private int _mapSize;
    public BaseRoom[,] MapArray;
    private Hero? _hero;

    private int _entranceLocationX = 0;
    private int _entranceLocationY = 0;
    
    private int _fountainLocationX = 0;
    private int _fountainLocationY = 0;
    public Map(int mapSize, Hero? hero)
    {
        _mapSize = mapSize; 
        MapArray = new BaseRoom[mapSize, mapSize];
        SetupMap();
        this._hero = hero;
    }

    private void SetupMap()
    {
        for (int i = 0; i < _mapSize; i++)
        {
            for (int j = 0; j < _mapSize; j++)
            {
                MapArray[i, j] = new EmptyRoom(i, j);
            }
        }
         
        #region Entrance
        // Locate Entrance Room
        int entranceSelection = random.Next(_mapSize) % 4;
         

        switch (entranceSelection)
        {
            case 0:
                _entranceLocationX = 0;
                _entranceLocationY = 0;
                break;
            case 1:
                _entranceLocationX = 0;
                _entranceLocationY = _mapSize - 1;
                break;
            case 2:
                _entranceLocationX = _mapSize - 1;
                _entranceLocationY = 0;
                break;
            case 3:
                _entranceLocationX = _mapSize - 1;
                _entranceLocationY = _mapSize - 1;
                break;
        }

        MapArray[_entranceLocationY, _entranceLocationX] = new EntranceRoom(_entranceLocationX, _entranceLocationY);
        #endregion

        #region Fountain
        // Locate Fountain
        bool locationDefined = false;
    

        while (!locationDefined)
        {
            _fountainLocationX = random.Next(_mapSize);
            _fountainLocationY = random.Next(_mapSize);

            if (_entranceLocationX != _fountainLocationX || _entranceLocationY != _fountainLocationY)
            {
                locationDefined = true;
            }
        }
 
        MapArray[_fountainLocationY, _fountainLocationX] = new FountainRoom(_fountainLocationX, _fountainLocationY);       
         
        #endregion Fountain
    }

    public int GetEntranceXCoordinate()
    {
        return _entranceLocationX;
    }

    public int GetEntranceYCoordinate()
    {
        return _entranceLocationY;
    }

    public int GetFountainXCoordinate()
    {
        return _fountainLocationX;
    }

    public int GetFountainYCoordinate()
    {
        return _fountainLocationY;
    }
}