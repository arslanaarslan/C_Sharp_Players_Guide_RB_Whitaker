using The_Fountain_of_Objects.Room;

namespace The_Fountain_of_Objects;

public class Announcer
{
    private Hero? _hero;
    private Map _map;
    private int _heroStartXPosition;
    private int _heroStartYPosition;
    
    public Announcer(Hero? hero, Map map)
    {
        _hero = hero;
        
        if (hero != null)
        {
            _heroStartXPosition = hero.X;
            _heroStartYPosition = hero.Y;
        }

        _map = map;
    }

    public void Announce()
    {
        FountainRoom fountainRoom = (FountainRoom)_map.MapArray[_map.GetFountainXCoordinate(), _map.GetFountainYCoordinate()];
        
        Console.WriteLine("----------------------------------------------------------------------------------");

        if (_hero != null)
        {
            Console.WriteLine($"You are in the room at (Row={_hero.Y}, Column={_hero.X})");

            if (_hero.X == _heroStartXPosition && _hero.Y == _heroStartYPosition && fountainRoom.FountainStatus())
            {
                Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!");
                Console.WriteLine("You win!");
            }
            else
            {
                if (_map.MapArray[_hero.Y, _hero.X].RoomKnowledge().Length > 0)
                {
                    Console.WriteLine(_map.MapArray[_hero.Y, _hero.X].RoomKnowledge());
                }

                Console.Write("What do you want to do? ");
            }
        }
        else
        {
            Console.WriteLine("Hero is null");
        }
    }

}